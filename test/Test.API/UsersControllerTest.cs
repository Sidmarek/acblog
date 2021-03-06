using AcBlog.Data.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Test.API
{
    [TestClass]
    public class UsersControllerTest
    {
        const string PREP = "/Users";

        WebApplicationFactory<AcBlog.Server.API.Program> Factory { get; set; }

        [TestInitialize]
        public void Setup()
        {
            Factory = new WebApplicationFactory<AcBlog.Server.API.Program>();
        }

        [TestCleanup]
        public void Clean()
        {
            Factory.Dispose();
        }
    }
}
