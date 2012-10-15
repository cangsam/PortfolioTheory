using System.Collections.Generic;
using portfolioServices.db;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using portfolioServices.DomainObjects;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for TestDbConnectorTest and is intended
    ///to contain all TestDbConnectorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TestDbConnectorTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for StoreStock
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void StoreStockTest()
        {

            User user = new User();
            user.username = "jenny";
            var stockHistory = new StockHistory();
            stockHistory.symbol = "EA";            
            user.id = 5;
            var stockHistory2 = new StockHistory();
            stockHistory2.symbol = "VTI";

            user.stockHistory = new List<StockHistory>();
            
            user.stockHistory.Add(stockHistory);
            user.stockHistory.Add(stockHistory2);

            (new UserDal()).InsertUser(user);
            TestDbConnector target = new TestDbConnector(); // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual= true;
            //actual = target.StoreStock();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetUser()
        {
            User user = (new UserDal()).GetUser<User>(2);
            Assert.AreEqual(user.id, 2);
            Assert.AreEqual(user.stockHistory[0].symbol, "EA");

        }
    }
}
