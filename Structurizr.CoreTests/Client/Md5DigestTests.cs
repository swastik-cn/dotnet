﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Structurizr.Client;

namespace Structurizr.CoreTests.Client
{
    [TestClass]
    public class Md5DigestTests
    {

        private Md5Digest md5 = new Md5Digest();

        public void Test_Generate_TreatsNullAsEmptyContent()
        {
            Assert.AreEqual(md5.Generate(""), md5.Generate(null));
        }

        [TestMethod]
        public void Test_Generate()
        {
            Assert.AreEqual("ed076287532e86365e841e92bfc50d8c", md5.Generate("Hello World!"));
            Assert.AreEqual("d41d8cd98f00b204e9800998ecf8427e", md5.Generate(""));
        }
    }
}
