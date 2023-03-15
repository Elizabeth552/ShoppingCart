namespace ShoppingCart.UnitTests
{
    using System.Globalization;
    using FluentAssertions;
    using NUnit.Framework;
    using ShoppingCart.Domain.Users;

    public class UserUnitTests
    {
        [Test]
        public void User_CreateShoppingCart_ShoppingCartAdded()
        {
            //Arrange
            var user = new User("Peter", "Ivanov", "peter@abv.bg", "0885578780");

            //Act
            user.CreateShoppingCart();

            //Assert
            user.ShoppingCart.Should().NotBeNull();
        }

        [Test]

        public void DateTime_FormatDate_DateOnly()
        {
            //Arrange
            var user = new User("Peter", "Ivanov", "peter@abv.bg", "0885578780");

            //Act
            user.PopulateCreatedAtDate();

            //Assert
            user.CreatedAt.Should().Be(DateTime.Now.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
        }
    }
}