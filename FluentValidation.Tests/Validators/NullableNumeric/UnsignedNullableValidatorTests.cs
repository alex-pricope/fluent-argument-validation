using System;
using System.Collections.Generic;
using FluentAssertions;
using FluentValidation.Tests.Validators.NullableNumeric.Factory;
using NUnit.Framework;

namespace FluentValidation.Tests.Validators.NullableNumeric
{
    //There must be a way to dynamically do these tests in 1 go for all the types

    [TestFixture]
    internal class UnsignedNullableValidatorTests
    {
        [Test]
        public void Given_NullableSignedNumericValue_ThatIsNull_WhenCheck_HasValue_ThenItThrowsCorrectException()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () => { UnsignedNullableNumericFactory.CreateUIntWithNull().Check().HasValue(); },
                () => { UnsignedNullableNumericFactory.CreateULongWithNull().Check().HasValue(); },
                () => { UnsignedNullableNumericFactory.CreateByteWithNull().Check().HasValue(); },
                () => { UnsignedNullableNumericFactory.CreateUShortWithNull().Check().HasValue(); },
            };

            //Act

            //Assert
            foreach (var action in actionsList)
            {
                action.ShouldThrow<ArgumentOutOfRangeException>();
            }
        }

        [Test]
        public void Given_NullableSignedNumericValue_ThatHasValue_WhenCheck_HasValue_ThenItDoesNotThrow()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () => { UnsignedNullableNumericFactory.CreateUIntWithValue().Check().HasValue(); },
                () => { UnsignedNullableNumericFactory.CreateULongWithValue().Check().HasValue(); },
                () => { UnsignedNullableNumericFactory.CreateByteWithValue().Check().HasValue(); },
                () => { UnsignedNullableNumericFactory.CreateUShortWithValue().Check().HasValue(); },
            };

            //Act

            //Assert
            foreach (var action in actionsList)
            {
                action.ShouldNotThrow();
            }
        }

        [Test]
        public void Given_NullableSignedNumericValue_ThatIsNotLessThenAMax_AndPositive_WhenCheck_ValueIsLessThen_ThenItThrowsCorrectException()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () =>
                {
                    var numericValue = UnsignedNullableNumericFactory.CreateUIntWithValue();
                    var maxNumericValue = numericValue.Value - 31;

                    numericValue
                        .Check()
                        .ValueIsLessThan(maxNumericValue);
                },

                () =>
                {
                    var numericValue = UnsignedNullableNumericFactory.CreateULongWithValue();
                    var maxNumericValue = numericValue.Value - 31;

                    numericValue
                        .Check()
                        .ValueIsLessThan(maxNumericValue);
                },

                () =>
                {
                    var numericValue = UnsignedNullableNumericFactory.CreateByteWithValue();
                    var maxNumericValue = (byte) (numericValue.Value - 10);

                    numericValue
                        .Check()
                        .ValueIsLessThan(maxNumericValue);
                },

                () =>
                {
                    var numericValue = UnsignedNullableNumericFactory.CreateUShortWithValue();
                    var maxNumericValue = (ushort) (numericValue.Value - 233);

                    numericValue
                        .Check()
                        .ValueIsLessThan(maxNumericValue);
                },
            };

            //Act

            //Assert
            foreach (var action in actionsList)
            {
                action.ShouldThrow<ArgumentOutOfRangeException>();
            }
        }

        [Test]
        public void Given_NullableSignedNumericValue_ThatIsLessThenAMax_AndPositive_WhenCheck_ValueIsLessThen_ThenItDoesNotThrow()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () =>
                {
                    var numericValue = UnsignedNullableNumericFactory.CreateUIntWithValue();
                    var maxNumericValue = numericValue.Value + 31;

                    numericValue
                        .Check()
                        .ValueIsLessThan(maxNumericValue);
                },

                () =>
                {
                    var numericValue = UnsignedNullableNumericFactory.CreateULongWithValue();
                    var maxNumericValue = numericValue.Value + 31;

                    numericValue
                        .Check()
                        .ValueIsLessThan(maxNumericValue);
                },

                () =>
                {
                    var numericValue = UnsignedNullableNumericFactory.CreateByteWithValue();
                    var maxNumericValue = (byte) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsLessThan(maxNumericValue);
                },

                () =>
                {
                    var numericValue = UnsignedNullableNumericFactory.CreateUShortWithValue();
                    var maxNumericValue = (ushort) (numericValue.Value + 233);

                    numericValue
                        .Check()
                        .ValueIsLessThan(maxNumericValue);
                },
            };

            //Act

            //Assert
            foreach (var action in actionsList)
            {
                action.ShouldNotThrow();
            }
        }
    }
}
