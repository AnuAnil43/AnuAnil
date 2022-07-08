using NUnit.Framework;
using TestNinja.Fundamentals;
using Xunit;


namespace TestNinja.UTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();


            //Act 
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });


            //Assert
            NUnit.Framework.Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation
            {
                MadeBy = user
            };

            //Act
            var result = reservation.CanBeCancelledBy(user);


            //Assert
            NUnit.Framework.Assert.True(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            //Arrange 
            var anotheruser = new User();
            var reservation = new Reservation();

            //Act 
            var result = reservation.CanBeCancelledBy(anotheruser);


            //Assert
            NUnit.Framework.Assert.False(result);
        }
    }
}