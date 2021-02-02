using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PicassoTest.Tests
{
    class FizzBuzzTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetOutput_divisible5_Buzz()
        {
            //Arrange
            var number = -25;
            //Act

            //Assert
            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_divisible3_Fizz()
        {
            //Arrange
            var number = 63;
            FizzBuzz fizzbuzz = new FizzBuzz();
            //Act

            //Assert
            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_divisible3y5_FizzBuzz()
        {
            //Arrange
            var number = 135;
            FizzBuzz fizzbuzz = new FizzBuzz();
            //Act

            //Assert
            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_Nodivisible3Ni5_StringNumber()
        {
            //Arrange
            var number = 134;
            FizzBuzz fizzbuzz = new FizzBuzz();
            //Act
            var result = "134";
            //Assert
            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo(result));
        }

        [Test]
        public void GetOutput_infinityPositive_Infinity()
        {
            //Arrange
            var number = Int32.MaxValue;
            FizzBuzz fizzbuzz = new FizzBuzz();
            //Act
            var result = "Infinity";
            //Assert
            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo(result));
        }

        [Test]
        public void GetOutput_infinityNegative_Infinity()
        {
            //Arrange
            var number = Int32.MinValue;
            FizzBuzz fizzbuzz = new FizzBuzz();
            //Act
            var result = "Infinity";
            //Assert
            Assert.That(FizzBuzz.GetOutput(number), Is.EqualTo(result));
        }
    }
}
