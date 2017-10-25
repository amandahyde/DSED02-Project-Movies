using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSED02_Project_Movies;
namespace UnitTestProject1




{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void FeeCalculator()
        {
            Database myDatabase = new Database();

            string actual = myDatabase.CaluclateFee(1984, 2).ToString();
            Assert.AreEqual('2'.ToString(), actual);


        }


        [TestMethod]

        public void DataConnection()
        {
            Database myDatabase = new Database();

            string result = myDatabase.IssueMovie(1.ToString(), 2.ToString());
            Assert.AreEqual(" is Successful".ToString(), result);


        }

   


    }
}
