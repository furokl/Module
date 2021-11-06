using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainModule.Tests
{
    [TestClass]
    public class StringUtilTests
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "C:\\repos\\MainModule\\MainModule_Test\\data.xml",
            "info",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void GetSumNumberTest()
        {
            string text = Convert.ToString(TestContext.DataRow["data"]);
            int expected = int.Parse(Convert.ToString(TestContext.DataRow["expected"]));

            int actual = StringUtil.GetSumNumber(text);

            Assert.AreEqual(expected, actual);
        }
    }
}