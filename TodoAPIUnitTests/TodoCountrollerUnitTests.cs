using System;
using TODOlistAPI.Controllers;
using TODOlistAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace TodoAPIUnitTests {
    public class TodoCountrollerUnitTests {
        [TestClass]
        public TodoCountrollerUnitTests
            {
            public static readonly DbContextOptions<TODOlistContext> options = new DbContextOptionsBuilder<TODOlistContext>()
            .UseInMemoryDatabase(databaseName: "testDatabase")
            .Options;
    }
    }
    }
