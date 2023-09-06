using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PasswCheck.Tests
{
    [TestClass]
    public class PasswCheckerTests
    {
        [TestMethod]
        public void PasswordCheck_Nothing_0points()
        {
            //act
            PasswChecker checker = new PasswChecker();
            int passw = checker.PasswordCheck("");
            //assert
            Assert.AreEqual(0, passw);

        }
        [TestMethod]
        public void PasswordCheck_LowerC_1points()
        {
            //act

            PasswChecker checker = new PasswChecker();
            int passw = checker.PasswordCheck("asd");
            //assert
            Assert.AreEqual(1, passw);

        }
        [TestMethod]
        public void PasswordCheck_LowAndUpC_2points()
        {
            //act

            PasswChecker checker = new PasswChecker();
            int passw = checker.PasswordCheck("asD");
            //assert
            Assert.AreEqual(2, passw);

        }
        
        [TestMethod]
        public void PasswordCheck_LowUpNum_3points()
        {
            //act

            PasswChecker checker = new PasswChecker();
            int passw = checker.PasswordCheck("Asd1");
            //assert
            Assert.AreEqual(3, passw);
            

        }
        [TestMethod]
        public void PasswordCheck_LowUpNumSpecial_4points()
        {
            //act

            PasswChecker checker = new PasswChecker();
            int passw = checker.PasswordCheck("ASd1!");
            //assert
            Assert.AreEqual(4, passw);

        }
        [TestMethod]
        public void PasswordCheck_CorrecrPassw_5points()
        {
            //act

            PasswChecker checker = new PasswChecker();
            int passw = checker.PasswordCheck("ASDasd1!");
            //assert
            Assert.AreEqual(5, passw);

        }
    }
}
