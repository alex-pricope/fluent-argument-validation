using System;
using FluentAssertions;
using FluentValidation.Tests.Validators.NullableBoolean.Factory;
using NUnit.Framework;

namespace FluentValidation.Tests.Validators.NullableBoolean;

[TestFixture]
[Parallelizable(ParallelScope.All)]
public class NullableBooleanValidationTests
{
    [Test]
    public void Given_NullableBoolean_ThatIsNull_WhenCheck_HasValue_ThenItThrowsCorrectException()
    {
        //Arrange
        var action = () => { NullableBooleanFactory.CreateNullBoolean().Check().HasValue(); };

        //Act

        //Assert
        action.Should().Throw<ArgumentNullException>();
    }
    
    [Test]
    public void Given_NullableBoolean_ThatIsNull_WhenCheck_IsTrue_ThenItThrowsCorrectException()
    {
        //Arrange
        var action = () => { NullableBooleanFactory.CreateNullBoolean().Check().ValueIsTrue(); };

        //Act

        //Assert
        action.Should().Throw<ArgumentNullException>();
    }
    
    [Test]
    public void Given_NullableBoolean_ThatIsNull_WhenCheck_IsFalse_ThenItThrowsCorrectException()
    {
        //Arrange
        var action = () => { NullableBooleanFactory.CreateNullBoolean().Check().ValueIsFalse(); };

        //Act

        //Assert
        action.Should().Throw<ArgumentNullException>();
    }
    
    [Test]
    public void Given_NullableBoolean_ThatIsTrue_WhenCheck_HasValue_ThenItDoesNotThrow()
    {
        //Arrange
        var action = () => { NullableBooleanFactory.CreateTrueBoolean().Check().HasValue(); };

        //Act

        //Assert
        action.Should().NotThrow();
    }
    
    [Test]
    public void Given_NullableBoolean_ThatIsFalse_WhenCheck_HasValue_ThenItDoesNotThrow()
    {
        //Arrange
        var action = () => { NullableBooleanFactory.CreateFalseBoolean().Check().HasValue(); };

        //Act

        //Assert
        action.Should().NotThrow();
    }
    
    [Test]
    public void Given_NullableBoolean_ThatIsFalse_WhenCheck_IsFalse_ThenItDoesNotThrow()
    {
        //Arrange
        var action = () => { NullableBooleanFactory.CreateFalseBoolean().Check().ValueIsFalse(); };

        //Act

        //Assert
        action.Should().NotThrow();
    }
    
    [Test]
    public void Given_NullableBoolean_ThatIsFalse_WhenCheck_IsTrue_ThenItThrowsCorrectException()
    {
        //Arrange
        var action = () => { NullableBooleanFactory.CreateFalseBoolean().Check().ValueIsTrue(); };

        //Act

        //Assert
        action.Should().Throw<ArgumentException>();
    }
    
    [Test]
    public void Given_NullableBoolean_ThatIsTrue_WhenCheck_IsTrue_ThenItDoesNotThrow()
    {
        //Arrange
        var action = () => { NullableBooleanFactory.CreateTrueBoolean().Check().ValueIsTrue(); };

        //Act

        //Assert
        action.Should().NotThrow();
    }
    
    [Test]
    public void Given_NullableBoolean_ThatIsTrue_WhenCheck_IsFalse_ThenItThrowsCorrectException()
    {
        //Arrange
        var action = () => { NullableBooleanFactory.CreateTrueBoolean().Check().ValueIsFalse(); };

        //Act

        //Assert
        action.Should().Throw<ArgumentException>();
    }
}