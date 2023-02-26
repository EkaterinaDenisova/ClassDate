using System;
using WindowsFormsAppDate;
namespace TestProjectDate
{
    [TestClass]
    public class UnitTestDate
    {
        [TestMethod]
        public void TestConstructor()
        {
            Date d = new Date(1, 2, 5);
            Assert.AreEqual(1, d.GetDay());  // Проверка на равенство двух параметров
            Assert.AreEqual(2, d.GetMonth());
            Assert.AreEqual(5, d.GetYear());
        }

        [TestMethod]
        public void TestSets()
        {
            Date d = new Date();
            d.SetDay(14);
            d.SetMonth(8);
            d.SetYear(3);
            Assert.AreEqual(14, d.GetDay());
            Assert.AreEqual(8, d.GetMonth());
            Assert.AreEqual(3, d.GetYear());
            
            d.SetDate(8,11,2);
            Assert.AreEqual(8, d.GetDay());
            Assert.AreEqual(11, d.GetMonth());
            Assert.AreEqual(2, d.GetYear());
        }

        [TestMethod]
        public void TestConvertDateToDays()
        {
            Date d = new Date(5,1,2);
            Assert.AreEqual(766, d.ConvertDateToDays());

            d.SetDate(27, 3, 1);
            Assert.AreEqual(482, d.ConvertDateToDays());
        }

        [TestMethod]
        public void TestConvertDaysToDate()
        {
            Date d = new Date();
            d.ConvertDaysToDate(398);
            Assert.AreEqual(2, d.GetDay());
            Assert.AreEqual(1, d.GetMonth());
            Assert.AreEqual(1, d.GetYear());

            d.ConvertDaysToDate(589);
            Assert.AreEqual(12, d.GetDay());
            Assert.AreEqual(7, d.GetMonth());
            Assert.AreEqual(1, d.GetYear());
        }

        [TestMethod]
        public void TestAddDate()
        {
            Date d = new Date(25,3,2);
            d.AddDate(new Date(8, 2, 1));

            Assert.AreEqual(1, d.GetDay());
            Assert.AreEqual(6, d.GetMonth());
            Assert.AreEqual(3, d.GetYear());

            d.AddDate(new Date(2, 5, 2));
            Assert.AreEqual(1, d.GetDay());
            Assert.AreEqual(11, d.GetMonth());
            Assert.AreEqual(5, d.GetYear());
        }

        [TestMethod]
        public void TestSubDate()
        {
            Date d = new Date(25, 3, 2);
            d.SubDate(new Date(8, 2, 1));

            Assert.AreEqual(17, d.GetDay());
            Assert.AreEqual(1, d.GetMonth());
            Assert.AreEqual(1, d.GetYear());

            d.SubDate(new Date(8, 2, 0));
            Assert.AreEqual(12, d.GetDay());
            Assert.AreEqual(11, d.GetMonth());
            Assert.AreEqual(0, d.GetYear());
        }

        [TestMethod]
        public void TestAddDay()
        {
            Date d = new Date(25, 3, 2);
            d.AddDay(20);

            Assert.AreEqual(15, d.GetDay());
            Assert.AreEqual(4, d.GetMonth());
            Assert.AreEqual(2, d.GetYear());
        }

        [TestMethod]
        public void TestSubDay()
        {
            Date d = new Date(25, 3, 2);
            d.SubDay(28);

            Assert.AreEqual(28, d.GetDay());
            Assert.AreEqual(2, d.GetMonth());
            Assert.AreEqual(2, d.GetYear());
        }

        [TestMethod]
        public void TestAddMonth()
        {
            Date d = new Date(25, 3, 2);
            d.AddMonth(9);

            Assert.AreEqual(25, d.GetDay());
            Assert.AreEqual(0, d.GetMonth());
            Assert.AreEqual(3, d.GetYear());
        }

        [TestMethod]
        public void TestSubMonth()
        {
            Date d = new Date(25, 3, 2);
            d.SubMonth(9);

            Assert.AreEqual(25, d.GetDay());
            Assert.AreEqual(6, d.GetMonth());
            Assert.AreEqual(1, d.GetYear());
        }

        [TestMethod]
        public void TestAddYear()
        {
            Date d = new Date(25, 3, 2);
            d.AddYear(2);

            Assert.AreEqual(25, d.GetDay());
            Assert.AreEqual(3, d.GetMonth());
            Assert.AreEqual(4, d.GetYear());
        }

        [TestMethod]
        public void TestSubYear()
        {
            Date d = new Date(25, 3, 2);
            d.SubYear(1);

            Assert.AreEqual(25, d.GetDay());
            Assert.AreEqual(3, d.GetMonth());
            Assert.AreEqual(1, d.GetYear());
        }

        [TestMethod]
        public void TestToString()
        {
            Date d = new Date(9,7,0);
            Assert.AreEqual("9 days 7 months 0 years", d.ToString());
        }



    }
}