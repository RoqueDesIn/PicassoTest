using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PicassoTest.Tests
{
    class DemeritPointsCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateDemeritPoints_minusThan0_ArgumentOutOfRangeException()
        {
            //Arrange
            var speed = -5;
            DemeritPointsCalculator calculator = new DemeritPointsCalculator();
            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }

        [Test]
        public void CalculateDemeritPoints_greaterThanMaxSpeed_ArgumentOutOfRangeException()
        {
            //Arrange
            var speed = 303;
            DemeritPointsCalculator calculator = new DemeritPointsCalculator();
            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }

        [Test]
        public void CalculateDemeritPoints_equals0_ArgumentOutOfRangeException()
        {
            //Arrange
            var speed = 0;
            DemeritPointsCalculator calculator = new DemeritPointsCalculator();
            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }
        [Test]
        public void CalculateDemeritPoints_equalsMaxSpeed_ArgumentOutOfRangeException()
        {
            //Arrange
            var speed = 300;
            DemeritPointsCalculator calculator = new DemeritPointsCalculator();
            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }

        [Test]
        public void CalculateDemeritPoints_minusSpeedLimit_Zero()
        {
            //Arrange
            var speed = 60;
            DemeritPointsCalculator calculator = new DemeritPointsCalculator();
            // Act

            //Assert
            Assert.That(calculator.CalculateDemeritPoints(speed), Is.AnyOf(0));
        }

        [Test]
        public void CalculateDemeritPoints_greaterSpeedLimit_formula()
        {
            //Arrange
            var speed = 75;
            int SpeedLimit = 65;
            const int kmPerDemeritPoint = 5;
            DemeritPointsCalculator calculator = new DemeritPointsCalculator();
            // Act
            var result = (speed - SpeedLimit) / kmPerDemeritPoint;
            //Assert
            Assert.That(calculator.CalculateDemeritPoints(speed), Is.AnyOf(result));
        }
    }
}
