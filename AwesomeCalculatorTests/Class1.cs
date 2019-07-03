using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace CalcAppTest

{
    [TestFixture]
    class CalcTests
    {
        [Test]
        public void GetAddition_Input4and6_Returns10()
        {
            //Arrange

            int number1 = 4; int number2 = 6;
            int expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);

            //Act

            double actualResult = testCalc.GetAddition();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Input3and5_Returns8()
        {
            //Arrange

            int number1 = 3; int number2 = 5;
            int expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);

            //Act

            double actualResult = testCalc.GetAddition();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Input3and6_Returns7()
        {
            //Arrange

            int number1 = 1; int number2 = 6;
            int expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);

            //Act

            double actualResult = testCalc.GetAddition();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input4and2_Returns2()
        {
            //Arrange

            int number1 = 4; int number2 = 2;
            int expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);

            //Act

            double actualResult = testCalc.GetSubtraction();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input8and6_Returns2()
        {
            //Arrange

            int number1 = 8; int number2 = 6;
            int expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);

            //Act

            double actualResult = testCalc.GetSubtraction();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input5and1_Returns4()
        {
            //Arrange

            int number1 = 5; int number2 = 1;
            int expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);

            //Act

            double actualResult = testCalc.GetSubtraction();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input3and2_Returns6()
        {
            //Arrange

            int number1 = 3; int number2 = 2;
            int expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);

            //Act

            double actualResult = testCalc.GetMultiplication();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input1and2_Returns2()
        {
            //Arrange

            int number1 = 1; int number2 = 2;
            int expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);

            //Act

            double actualResult = testCalc.GetMultiplication();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input4and2_Returns8()
        {
            //Arrange

            int number1 = 4; int number2 = 2;
            int expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);

            //Act

            double actualResult = testCalc.GetMultiplication();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input10and5_Returns2()
        {
            //Arrange

            int number1 = 10; int number2 = 5;
            int expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);

            //Act

            double actualResult = testCalc.GetDivision();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input8and2_Returns4()
        {
            //Arrange

            int number1 = 8; int number2 = 2;
            int expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);

            //Act

            double actualResult = testCalc.GetDivision();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input4and2_Returns2()
        {
            //Arrange

            int number1 = 4; int number2 = 2;
            int expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);

            //Act

            double actualResult = testCalc.GetDivision();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}  
    

