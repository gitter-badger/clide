﻿#region BSD License
/* 
Copyright (c) 2012, Clarius Consulting
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
* Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
#endregion

namespace Clide.Solution.Adapters
{
    using System;
    using Clide.Patterns.Adapter;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.Shell.Interop;
    using Microsoft.VisualStudio;
    using Ole = Microsoft.VisualStudio.OLE.Interop;

    [Adapter]
    internal class IServiceProviderAdapter : 
        IAdapter<ISolutionNode, IServiceProvider>, 
        IAdapter<IProjectNode, IServiceProvider>, 
        IAdapter<ProjectItemNode, IServiceProvider>
    {
        public IServiceProvider Adapt(ISolutionNode from)
        {
            return ServiceProvider.GlobalProvider;
        }

        public IServiceProvider Adapt(IProjectNode from)
        {
            var vsProject = from.As<IVsProject>();
            Ole.IServiceProvider oleSp;

            // local service provider for the project
            if (vsProject != null && vsProject.GetItemContext(VSConstants.VSITEMID_ROOT, out oleSp) == VSConstants.S_OK)
                return new ServiceProvider(oleSp);

            return ServiceProvider.GlobalProvider;
        }

        public IServiceProvider Adapt(ProjectItemNode from)
        {
            return Adapt(from.OwningProject);
        }
    }
}