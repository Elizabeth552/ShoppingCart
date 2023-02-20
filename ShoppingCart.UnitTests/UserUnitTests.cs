﻿namespace ShoppingCart.UnitTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using ShoppingCart.Domain.BoundedContext.Users;

    public class UserUnitTests
    {
        [Test]
        public void User_CreateShoppingCart_ShoppingCartAdded()
        {
            //Arrange
            var user = new User("Peter", "Ivanov", "Pehso123", "Babydoll90", "peter@abv.bg", "0885578780");

            //Act
            user.CreateShoppingCart();

            //Assert
            user.ShoppingCart.Should().NotBeNull();
        }
    }
}