//Copyright (c) 2011-2014 Effort Team
//https://effort.codeplex.com/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessCardHolder.UnitTests
{
    [TestClass]
    public class TestsInitialize
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Effort.Provider.EffortProviderConfiguration.RegisterProvider();
        }
    }
}


