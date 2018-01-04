using Framework.CromeDriver;
using Framework.Pages;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Framework.Tests
{
    /// <summary>
    /// Сводное описание для Test
    /// </summary>
    [TestClass]
    public class Test
    {
        public Test()
        {
            //
            // TODO: добавьте здесь логику конструктора
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
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

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            var driver = DriverInstance.GetInstance();
            MainPage page = new MainPage(driver);
            page.OpenPage();
            page.Test1("Berlin", "Paris", new DateTime(2018, 01, 04), new DateTime(2018, 01, 07));

            Assert.IsTrue(page.IsTicketsListExist());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var driver = DriverInstance.GetInstance();
            MainPage page = new MainPage(driver);
            page.OpenPage();
            page.Test2("Berlin", "Paris", new DateTime(2018, 01, 04), new DateTime(2018, 01, 07));

            Assert.IsTrue(page.IsTicketsListExist());

        }

        [TestMethod]
        public void TestMethod3()
        {
            var driver = DriverInstance.GetInstance();
            MainPage page = new MainPage(driver);
            page.OpenPage();
            page.Test1("Berlin", "Paris", new DateTime(2018, 01, 04), new DateTime(2018, 01, 04));

            Assert.IsTrue(page.IsErrorExist());

        }

        [TestMethod]
        public void TestMethod4()
        {
            var driver = DriverInstance.GetInstance();
            MainPage page = new MainPage(driver);
            page.OpenPage();
            page.Test3("Berlin", new DateTime(2018, 01, 04), new DateTime(2018, 01, 07));

            Assert.IsTrue(page.IsErrorDestination());

        }

        [TestMethod]
        public void TestMethod5()
        {
            var driver = DriverInstance.GetInstance();
            MainPage page = new MainPage(driver);
            page.OpenPage();
            page.Test4("Berlin", "Paris", new DateTime(2018, 01, 04), new DateTime(2018, 01, 07), new DateTime(2018, 01, 02));

            Assert.IsTrue(page.IsErrorData());
        }

        [TestMethod]
        public void TestMethod6()
        {
            var driver = DriverInstance.GetInstance();
            MainPage page = new MainPage(driver);
            page.OpenPage();
            page.Test1("Berlin", "Berlin", new DateTime(2018, 01, 04), new DateTime(2018, 01, 07));

            Assert.IsTrue(page.IsErrorDestination());
        }

        [TestMethod]
        public void TestMethod7()
        {
            var driver = DriverInstance.GetInstance();
            MainPage page = new MainPage(driver);
            page.OpenPage();
            page.Test5("Berlin", new DateTime(2018, 01, 04),  new DateTime(2018, 01, 12));

            Assert.IsTrue(page.IsErrorOrigin());

        }

        
    }
}
