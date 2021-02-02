using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PicassoTest.Tests
{
    class ReservationComplexTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PayReservation_UserThereIsMoney_Returns0()
        {
            //Arrange
            var userReservationComplex = new UserComplex();
            userReservationComplex.Money = 300;

            var reservationComplex = new ReservationComplex();
            reservationComplex.Price = 200;

            //Act
            var result = reservationComplex.PayReservation(userReservationComplex);

            //Assert
            Assert.That(result, Is.Zero);
        }

        [Test]
        public void PayReservation_UserThereIsNoMoney_ReturnsDifferenceMoney()
        {
            //Arrange
            var userReservationComplex = new UserComplex();
            userReservationComplex.Money = 100;

            var reservationComplex = new ReservationComplex();
            reservationComplex.Price = 200;

            //Act
            var result = reservationComplex.PayReservation(userReservationComplex);

            //Assert
            Assert.That(result, Is.GreaterThan(0));
        }
        public void PayReservation_UserThereIsEqualMoney_Returns0()
        {
            //Arrange
            var userReservationComplex = new UserComplex();
            userReservationComplex.Money = 200;

            var reservationComplex = new ReservationComplex();
            reservationComplex.Price = 200;

            //Act
            var result = reservationComplex.PayReservation(userReservationComplex);

            //Assert
            Assert.That(result, Is.GreaterThanOrEqualTo(0));
        }
        [Test]
        public void PayReservation_userIsNull_null()
        {
            //Arrange
            var userReservationComplex = new UserComplex();

            var reservationComplex = new ReservationComplex();

            //Act
            var result = reservationComplex.PayReservation(userReservationComplex);
            //Assert
            Assert.That(result,Is.Null);
        }
    }
}
