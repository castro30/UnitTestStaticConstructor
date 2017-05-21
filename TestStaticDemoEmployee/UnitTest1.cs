using System;
using StaticDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestStaticDemoEmployee
{
    [TestClass]
    public class EmployeeTest
    {
        int expected;
        Employee target;

        [TestInitialize()]
        public void EmployeeInitialize()
        {
            expected = Employee.countOfEmployee + 1;
            target = new Employee();
            Assert.AreEqual(expected,Employee.countOfEmployee);
        }

        [TestMethod]
        public void EmployeeConstructorTest() { }

       

    }
}
