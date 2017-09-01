using System;
using FluentAssertions;
using NUnit.Framework;

namespace FluentValidation.Tests.Validators
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    internal class NullableDateTimeValidationTests
    {
        [Test]
        public void Given_NullableDateTime_ThatIsNull_WhenCheck_HasValue_ThenItThrowsCorrectException()
        {
            //Arrange
            DateTime? nullDateTime = null;

            //Act
            Action act = () =>
            {
                nullDateTime.Check().HasValue();
            };

            //Assert
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Given_NullableDateTime_ThatHasValue_WhenCheck_HasValue_ThenItDoesNotThrowException()
        {
            //Arrange
            DateTime? nullDateTime = DateTime.UtcNow;

            //Act
            Action act = () =>
            {
                nullDateTime.Check().HasValue();
            };

            //Assert
            act.ShouldNotThrow();
        }

        [Test]
        public void Given_NullableDateTime_ThatIsNotNull_WhenCheck_IsNull_ThenItThrowsCorrectException()
        {
            //Arrange
            DateTime? nullDateTime = DateTime.UtcNow;

            //Act
            Action act = () =>
            {
                nullDateTime.Check().IsNull();
            };

            //Assert
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Given_NullableDateTime_ThatIsNull_WhenCheck_IsNull_ThenItDoesNotThrowException()
        {
            //Arrange
            DateTime? nullDateTime = null;

            //Act
            Action act = () =>
            {
                nullDateTime.Check().IsNull();
            };

            //Assert
            act.ShouldNotThrow();
        }

        [Test]
        public void Given_NullableDateTime_ThatIsMinValue_WhenCheck_IsValid_ThenItThrowsCorrectException()
        {
            //Arrange
            DateTime? nullDateTime = DateTime.MinValue;

            //Act
            Action act = () =>
            {
                nullDateTime.Check().IsValid();
            };

            //Assert
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Given_NullableDateTime_ThatIsMaxValue_WhenCheck_IsValid_ThenItThrowsCorrectException()
        {
            //Arrange
            DateTime? nullDateTime = DateTime.MaxValue;

            //Act
            Action act = () =>
            {
                nullDateTime.Check().IsValid();
            };

            //Assert
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Given_NullableDateTime_ThatHasAGoodValue_WhenCheck_IsValid_ThenItDoesNotThrow()
        {
            //Arrange
            DateTime? nullDateTime = DateTime.UtcNow;

            //Act
            Action act = () =>
            {
                nullDateTime.Check().IsValid();
            };

            //Assert
            act.ShouldNotThrow();
        }
    }
}
