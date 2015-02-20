using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using flexischool3;
//https://msdn.microsoft.com/en-us/library/ms182532.aspx#PrepareWalkthrough


namespace FlexiSchoolNumberTest
{
    [TestClass]
    public class NumberStringUnitTest
    {
        [TestMethod]

        public void NumberStringFizzBuzz()
        {
            // arrange
            int mybeginningnumber = 1;
            string myprintstr = "what";

            StringAndNumber ba = new StringAndNumber(myprintstr, mybeginningnumber); 

            // act
            mybeginningnumber = 30;
            ba.workout(mybeginningnumber);
             
            // assert
           string actual = ba.printStr;
           Assert.AreEqual("FizzBuzz", actual, "Number can be divided by both 3 and 5");
        }

        [TestMethod]

        public void NumberStringFizz()
        {
            // arrange
            int mybeginningnumber = 1;
            string myprintstr = "what";

            StringAndNumber ba = new StringAndNumber(myprintstr, mybeginningnumber);

            // act
            mybeginningnumber = 3;
            ba.workout(mybeginningnumber);

            // assert
            string actual = ba.printStr;
            Assert.AreEqual("Fizz", actual, "Number can be divided by both 3");
        }

        [TestMethod]

        public void NumberStringBuzz()
        {
            // arrange
            int mybeginningnumber = 1;
            string myprintstr = "what";

            StringAndNumber ba = new StringAndNumber(myprintstr, mybeginningnumber);

            // act
            mybeginningnumber = 10;
            ba.workout(mybeginningnumber);

            // assert
            string actual = ba.printStr;
            Assert.AreEqual("Buzz", actual, "Number can be divided by both  5");
        }
        [TestMethod]

        public void NumberStringBeMyself()
        {
            // arrange
            int mybeginningnumber = 1;
            string myprintstr = "what";

            StringAndNumber ba = new StringAndNumber(myprintstr, mybeginningnumber);

            // act
            mybeginningnumber = 11;
            ba.workout(mybeginningnumber);

            // assert
            string actual = ba.printStr; 
            Assert.AreEqual(mybeginningnumber.ToString(), actual, "Number can not be divided by 3 and  5");
        }
    }
}
