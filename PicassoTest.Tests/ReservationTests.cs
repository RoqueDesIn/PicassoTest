using NUnit.Framework;

namespace PicassoTest.Tests
{
    public class ReservationTests   
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User()
            {
                IsAdmin = true
            });

            //Assert
            Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelledBy_UserIsNotAdmin_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User()
            {
                IsAdmin = false
            }); ;

            //Assert
            Assert.That(result, Is.False);
        }
        [Test]
        public void CanBeCancelledBy_MadeByIsUserReservation_ReturnsTrue()
        {
            //Arrange
            var userReservation = new User();
            userReservation.IsAdmin = false;
            var reservation = new Reservation { MadeBy = userReservation };
        
            //Act
            var result = reservation.CanBeCancelledBy(userReservation);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_MadeByIsNotUserReservation_ReturnsFalse()
        {
            //Arrange
            var userReservation = new User();
            userReservation.IsAdmin = false;
            var otherUser = new User();
            otherUser.IsAdmin = false;
            var reservation = new Reservation { MadeBy = userReservation };

            //Act
            var result = reservation.CanBeCancelledBy(otherUser);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanBeCancelledBy_UserIsNull_ReturnsFalse()
        {
            //Arrange
            var userReservation = new User();
            userReservation.IsAdmin = false;
            var reservation = new Reservation ();

            //Act
            var result = reservation.CanBeCancelledBy(null);

            //Assert
            Assert.That(result, Is.False);
        }
    }
}