using System;
using System.Collections.Generic;
using FluentAssertions;
using FluentValidation.Tests.Validators.NullableNumeric.Factory;
using NUnit.Framework;

namespace FluentValidation.Tests.Validators.NullableNumeric
{
    //There must be a way to dynamically do these tests in 1 go for all the types

    [TestFixture]
    internal class SignedNullableValidatorTests
    {
        [Test]
        public void Given_NullableSignedNumericValue_ThatIsNull_WhenCheck_HasValue_ThenItThrowsCorrectException()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () => { SignedNullableNumericFactory.CreateIntWithNull().Check().HasValue(); },
                () => { SignedNullableNumericFactory.CreateLongWithNull().Check().HasValue(); },
                () => { SignedNullableNumericFactory.CreateDecimalWithNull().Check().HasValue(); },
                () => { SignedNullableNumericFactory.CreateFloatWithNull().Check().HasValue(); },
                () => { SignedNullableNumericFactory.CreateShortWithNull().Check().HasValue(); },
                () => { SignedNullableNumericFactory.CreateSbyteWithNull().Check().HasValue(); },
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
                () => { SignedNullableNumericFactory.CreateIntWithPositiveValue().Check().HasValue(); },
                () => { SignedNullableNumericFactory.CreateLongWithNegativeValue().Check().HasValue(); },
                () => { SignedNullableNumericFactory.CreateDecimalWithPositiveValue().Check().HasValue(); },
                () => { SignedNullableNumericFactory.CreateFloatWithPositiveValue().Check().HasValue(); },
                () => { SignedNullableNumericFactory.CreateSbyteWithPositiveValue().Check().HasValue(); },
                () => { SignedNullableNumericFactory.CreateShortWithPositiveValue().Check().HasValue(); },
            };

            //Act

            //Assert
            foreach (var action in actionsList)
            {
                action.ShouldNotThrow();
            }
        }

        [Test]
        public void Given_NullableSignedNumericValue_ThatIsNegative_WhenCheck_ValueIsPositive_ThenItThrowsCorrectException()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () => { SignedNullableNumericFactory.CreateIntWithNegativeValue().Check().ValueIsPositive(); },
                () => { SignedNullableNumericFactory.CreateLongWithNegativeValue().Check().ValueIsPositive(); },
                () => { SignedNullableNumericFactory.CreateDecimalWithNegativeValue().Check().ValueIsPositive(); },
                () => { SignedNullableNumericFactory.CreateFloatWithNegativeValue().Check().ValueIsPositive(); },
                () => { SignedNullableNumericFactory.CreateSbyteWithNegativeValue().Check().ValueIsPositive(); },
                () => { SignedNullableNumericFactory.CreateShortWithNegativeValue().Check().ValueIsPositive(); },
            };

            //Act

            //Assert
            foreach (var action in actionsList)
            {
                action.ShouldThrow<ArgumentOutOfRangeException>();
            }
        }

        [Test]
        public void Given_NullableSignedNumericValue_ThatIsPositive_WhenCheck_ValueIsPositive_ThenItDoesNotThrow()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () => { SignedNullableNumericFactory.CreateIntWithPositiveValue().Check().ValueIsPositive(); },
                () => { SignedNullableNumericFactory.CreateLongWithPositiveValue().Check().ValueIsPositive(); },
                () => { SignedNullableNumericFactory.CreateDecimalWithPositiveValue().Check().ValueIsPositive(); },
                () => { SignedNullableNumericFactory.CreateFloatWithPositiveValue().Check().ValueIsPositive(); },
                () => { SignedNullableNumericFactory.CreateSbyteWithPositiveValue().Check().ValueIsPositive(); },
                () => { SignedNullableNumericFactory.CreateShortWithPositiveValue().Check().ValueIsPositive(); },
            };

            //Act

            //Assert
            foreach (var action in actionsList)
            {
                action.ShouldNotThrow();
            }
        }

        [Test]
        public void Given_NullableSignedNumericValue_ThatIsPositive_WhenCheck_ValueIsNegative_ThenItThrowsCorrectException()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () => { SignedNullableNumericFactory.CreateIntWithPositiveValue().Check().ValueIsNegative(); },
                () => { SignedNullableNumericFactory.CreateLongWithPositiveValue().Check().ValueIsNegative(); },
                () => { SignedNullableNumericFactory.CreateDecimalWithPositiveValue().Check().ValueIsNegative(); },
                () => { SignedNullableNumericFactory.CreateFloatWithPositiveValue().Check().ValueIsNegative(); },
                () => { SignedNullableNumericFactory.CreateSbyteWithPositiveValue().Check().ValueIsNegative(); },
                () => { SignedNullableNumericFactory.CreateShortWithPositiveValue().Check().ValueIsNegative(); },
            };

            //Act

            //Assert
            foreach (var action in actionsList)
            {
                action.ShouldThrow<ArgumentOutOfRangeException>();
            }
        }

        [Test]
        public void Given_NullableSignedNumericValue_ThatIsNegative_WhenCheck_ValueIsNegative_ThenItDoesNotThrow()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () => { SignedNullableNumericFactory.CreateIntWithNegativeValue().Check().ValueIsNegative(); },
                () => { SignedNullableNumericFactory.CreateLongWithNegativeValue().Check().ValueIsNegative(); },
                () => { SignedNullableNumericFactory.CreateDecimalWithNegativeValue().Check().ValueIsNegative(); },
                () => { SignedNullableNumericFactory.CreateFloatWithNegativeValue().Check().ValueIsNegative(); },
                () => { SignedNullableNumericFactory.CreateSbyteWithNegativeValue().Check().ValueIsNegative(); },
                () => { SignedNullableNumericFactory.CreateShortWithNegativeValue().Check().ValueIsNegative(); },
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
                    var numericValue = SignedNullableNumericFactory.CreateIntWithPositiveValue();
                    var maxNumericValue = numericValue.Value - 31;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateLongWithPositiveValue();
                    var maxNumericValue = numericValue.Value - 31;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateDecimalWithPositiveValue();
                    var maxNumericValue = numericValue.Value - 5.5m;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateFloatWithPositiveValue();
                    var maxNumericValue = numericValue.Value - 5F;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateSbyteWithPositiveValue();
                    var maxNumericValue = (sbyte) (numericValue.Value - 10);

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateShortWithPositiveValue();
                    var maxNumericValue = (short) (numericValue.Value - 10);

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
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
                    var numericValue = SignedNullableNumericFactory.CreateIntWithPositiveValue();
                    var maxNumericValue = numericValue.Value + 31;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateLongWithPositiveValue();
                    var maxNumericValue = numericValue.Value + 31;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateDecimalWithPositiveValue();
                    var maxNumericValue = numericValue.Value + 5.5m;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateFloatWithPositiveValue();
                    var maxNumericValue = numericValue.Value + 5F;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateSbyteWithPositiveValue();
                    var maxNumericValue = (sbyte) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateShortWithPositiveValue();
                    var maxNumericValue = (short) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },
            };

            //Act

            //Assert
            foreach (var action in actionsList)
            {
                action.ShouldNotThrow();
            }
        }

        [Test]
        public void Given_NullableSignedNumericValue_ThatIsNotLessThenAMax_AndNegative_WhenCheck_ValueIsLessThen_ThenItThrowsCorrectException()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateIntWithNegativeValue();
                    var maxNumericValue = numericValue.Value - 31;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateLongWithNegativeValue();
                    var maxNumericValue = numericValue.Value - 31;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateDecimalWithNegativeValue();
                    var maxNumericValue = numericValue.Value - 5.5m;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateFloatWithNegativeValue();
                    var maxNumericValue = numericValue.Value - 5F;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateSbyteWithNegativeValue();
                    var maxNumericValue = (sbyte) (numericValue.Value - 10);

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateShortWithNegativeValue();
                    var maxNumericValue = (short) (numericValue.Value - 10);

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
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
        public void Given_NullableSignedNumericValue_ThatIsLessThenAMax_AndNegative_WhenCheck_ValueIsLessThen_ThenItThrowsCorrectException()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateIntWithNegativeValue();
                    var maxNumericValue = numericValue.Value + 31;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateLongWithNegativeValue();
                    var maxNumericValue = numericValue.Value + 31;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateDecimalWithNegativeValue();
                    var maxNumericValue = numericValue.Value + 5.5m;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateFloatWithNegativeValue();
                    var maxNumericValue = numericValue.Value + 5F;

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateSbyteWithNegativeValue();
                    var maxNumericValue = (sbyte) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateShortWithNegativeValue();
                    var maxNumericValue = (short) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsLessThen(maxNumericValue);
                },
            };

            //Act

            //Assert
            foreach (var action in actionsList)
            {
                action.ShouldNotThrow();
            }
        }

        [Test]
        public void Given_NullableSignedNumericValue_ThatIsNotGreaterThenAMin_AndPositive_WhenCheck_ValueIsGreaterThen_ThenItThrowsCorrectException()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateIntWithPositiveValue();
                    var minNumericValue = numericValue.Value + 31;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateLongWithPositiveValue();
                    var minNumericValue = numericValue.Value + 31;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateDecimalWithPositiveValue();
                    var minNumericValue = numericValue.Value + 5.5m;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateFloatWithPositiveValue();
                    var minNumericValue = numericValue.Value + 5F;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateSbyteWithPositiveValue();
                    var minNumericValue = (sbyte) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateShortWithPositiveValue();
                    var minNumericValue = (short) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
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
        public void Given_NullableSignedNumericValue_ThatIsGreaterThenAMin_AndPositive_WhenCheck_ValueIsGreaterThen_ThenItDoesNotThrow()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateIntWithPositiveValue();
                    var minNumericValue = numericValue.Value - 31;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateLongWithPositiveValue();
                    var minNumericValue = numericValue.Value - 31;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateDecimalWithPositiveValue();
                    var minNumericValue = numericValue.Value - 5.5m;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateFloatWithPositiveValue();
                    var minNumericValue = numericValue.Value - 5F;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateSbyteWithPositiveValue();
                    var minNumericValue = (sbyte) (numericValue.Value - 10);

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateShortWithPositiveValue();
                    var minNumericValue = (short) (numericValue.Value - 10);

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },
            };

            //Act

            //Assert
            foreach (var action in actionsList)
            {
                action.ShouldNotThrow();
            }
        }

        [Test]
        public void Given_NullableSignedNumericValue_ThatIsNotGreaterThenAMin_AndNegative_WhenCheck_ValueIsGreaterThen_ThenItThrowsCorrectException()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateIntWithNegativeValue();
                    var minNumericValue = numericValue.Value + 31;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateLongWithNegativeValue();
                    var minNumericValue = numericValue.Value + 31;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateDecimalWithNegativeValue();
                    var minNumericValue = numericValue.Value + 5.5m;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateFloatWithNegativeValue();
                    var minNumericValue = numericValue.Value + 5F;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateSbyteWithNegativeValue();
                    var minNumericValue = (sbyte) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateShortWithNegativeValue();
                    var minNumericValue = (short) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
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
        public void Given_NullableSignedNumericValue_ThatIsGreaterThenAMin_AndNegative_WhenCheck_ValueIsGreaterThen_ThenItDoesNotThrow()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateIntWithNegativeValue();
                    var minNumericValue = numericValue.Value - 31;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateLongWithNegativeValue();
                    var minNumericValue = numericValue.Value - 31;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateDecimalWithNegativeValue();
                    var minNumericValue = numericValue.Value - 5.5m;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateFloatWithNegativeValue();
                    var minNumericValue = numericValue.Value - 5F;

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateSbyteWithNegativeValue();
                    var minNumericValue = (sbyte) (numericValue.Value - 10);

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateShortWithNegativeValue();
                    var minNumericValue = (short) (numericValue.Value - 10);

                    numericValue
                        .Check()
                        .ValueIsGreaterThen(minNumericValue);
                },
            };

            //Act

            //Assert
            foreach (var action in actionsList)
            {
                action.ShouldNotThrow();
            }

        }

        [Test]
        public void Given_NullableSignedNumericValue_ThatIsNotBetweenAMinAndMax_AndPositive_WhenCheck_ValueIsBetween_ThenItThrowsCorrectException()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateIntWithPositiveValue();
                    var minNumericValue = numericValue.Value + 1;
                    var maxNumericValue = numericValue.Value + 10;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateLongWithPositiveValue();
                    var minNumericValue = numericValue.Value + 1;
                    var maxNumericValue = numericValue.Value + 10;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateDecimalWithPositiveValue();
                    var minNumericValue = numericValue.Value + 5.5m;
                    var maxNumericValue = numericValue.Value + 10m;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateFloatWithNegativeValue();
                    var minNumericValue = numericValue.Value + 3F;
                    var maxNumericValue = numericValue.Value + 10F;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateSbyteWithPositiveValue();
                    var minNumericValue = (sbyte) (numericValue.Value + 5);
                    var maxNumericValue = (sbyte) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateShortWithPositiveValue();
                    var minNumericValue = (short) (numericValue.Value + 5);
                    var maxNumericValue = (short) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
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
        public void Given_NullableSignedNumericValue_ThatIsBetweenAMinAndMax_AndPositive_WhenCheck_ValueIsBetween_ThenItDoesNotThrow()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateIntWithPositiveValue();
                    var minNumericValue = numericValue.Value - 1;
                    var maxNumericValue = numericValue.Value + 10;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateLongWithPositiveValue();
                    var minNumericValue = numericValue.Value - 1;
                    var maxNumericValue = numericValue.Value + 10;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateDecimalWithPositiveValue();
                    var minNumericValue = numericValue.Value - 5.5m;
                    var maxNumericValue = numericValue.Value + 10m;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateFloatWithNegativeValue();
                    var minNumericValue = numericValue.Value - 3F;
                    var maxNumericValue = numericValue.Value + 10F;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateSbyteWithPositiveValue();
                    var minNumericValue = (sbyte) (numericValue.Value - 5);
                    var maxNumericValue = (sbyte) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateShortWithPositiveValue();
                    var minNumericValue = (short) (numericValue.Value - 5);
                    var maxNumericValue = (short) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },
            };

            //Act

            //Assert
            foreach (var action in actionsList)
            {
                action.ShouldNotThrow();
            }

        }

        [Test]
        public void Given_NullableSignedNumericValue_ThatIsNotBetweenAMinAndMax_AndNegative_WhenCheck_ValueIsBetween_ThenItThrowsCorrectException()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateIntWithNegativeValue();
                    var minNumericValue = numericValue.Value + 1;
                    var maxNumericValue = numericValue.Value + 10;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateLongWithNegativeValue();
                    var minNumericValue = numericValue.Value + 1;
                    var maxNumericValue = numericValue.Value + 10;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateDecimalWithNegativeValue();
                    var minNumericValue = numericValue.Value + 5.5m;
                    var maxNumericValue = numericValue.Value + 10m;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateFloatWithNegativeValue();
                    var minNumericValue = numericValue.Value + 3F;
                    var maxNumericValue = numericValue.Value + 10F;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateSbyteWithNegativeValue();
                    var minNumericValue = (sbyte) (numericValue.Value + 5);
                    var maxNumericValue = (sbyte) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateShortWithNegativeValue();
                    var minNumericValue = (short) (numericValue.Value + 5);
                    var maxNumericValue = (short) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
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
        public void Given_NullableSignedNumericValue_ThatIsBetweenAMinAndMax_AndNegative_WhenCheck_ValueIsBetween_ThenItThrowsCorrectException()
        {
            //Arrange
            var actionsList = new List<Action>()
            {
                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateIntWithNegativeValue();
                    var minNumericValue = numericValue.Value - 1;
                    var maxNumericValue = numericValue.Value + 10;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateLongWithNegativeValue();
                    var minNumericValue = numericValue.Value - 1;
                    var maxNumericValue = numericValue.Value + 10;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateDecimalWithNegativeValue();
                    var minNumericValue = numericValue.Value - 5.5m;
                    var maxNumericValue = numericValue.Value + 10m;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateFloatWithNegativeValue();
                    var minNumericValue = numericValue.Value - 3F;
                    var maxNumericValue = numericValue.Value + 10F;

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateSbyteWithNegativeValue();
                    var minNumericValue = (sbyte) (numericValue.Value - 5);
                    var maxNumericValue = (sbyte) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
                },

                () =>
                {
                    var numericValue = SignedNullableNumericFactory.CreateShortWithNegativeValue();
                    var minNumericValue = (short) (numericValue.Value - 5);
                    var maxNumericValue = (short) (numericValue.Value + 10);

                    numericValue
                        .Check()
                        .ValueIsBetween(minNumericValue, maxNumericValue);
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
