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

namespace UnitTests
{
	using Clide;
	using Microsoft.VisualStudio.Shell;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System;

	[TestClass]
    public class ProvidedComponentsSpec
    {
		static readonly IAssertion Assert = new Assertion();

        [TestMethod]
        public void when_provided_components_assembly_does_not_exist_then_throws()
        {
			Assert.Throws<InvalidOperationException>(() => Host.Initialize(new PackageProvidesNonExistent()));
        }

        [HostType("VS IDE")]
        [TestMethod]
        public void when_additional_components_installed_then_registers_on_composition_container()
        {
			var devEnv = DevEnv.Get(new PackageProvidesComponents());

			var component = devEnv.ServiceLocator.GetInstance<ProvidedComponent>();

			Assert.NotNull(component);
        }

		[ProvideComponents("Foo.dll")]
		public class PackageProvidesNonExistent : IServiceProvider
		{
			public object GetService(Type serviceType)
			{
				return null;
			}
		}

		[ProvideComponents("TestComponents.dll")]
		public class PackageProvidesComponents : IServiceProvider
		{
			public object GetService(Type serviceType)
			{
				return Package.GetGlobalService(serviceType);
			}
		}
    }
}
