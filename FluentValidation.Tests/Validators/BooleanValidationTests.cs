using System;
using FluentAssertions;
using FluentValidation.Tests.Validators.Factory;
using NUnit.Framework;

namespace FluentValidation.Tests.Validators;

[TestFixture]
[Parallelizable(ParallelScope.All)]
public class BooleanValidationTests
{
    [Test]
    public void Given_Boolean_ThatIsTrue_WhenCheck_IsTrue_ThenItDoesNotThrow()
    {
        //Arrange
        var action = () => { TypeFactory.CreateBooleanTrue().Check().IsTrue(); };

        //Act

        //Assert
        action.Should().NotThrow();
    }
    
    [Test]
    public void Given_Boolean_ThatIsFalse_WhenCheck_IsFalse_ThenItDoesNotThrow()
    {
        //Arrange
        var action = () => { TypeFactory.CreateBooleanFalse().Check().IsFalse(); };

        //Act
        
        //Assert
        action.Should().NotThrow();
    }
    
    [Test]
    public void Given_Boolean_ThatIsTrue_WhenCheck_IsFalse_ThenItThrowsCorrectException()
    {
        //Arrange
        var action = () => { TypeFactory.CreateBooleanTrue().Check().IsFalse(); };

        //Act

        //Assert
        action.Should().Throw<ArgumentOutOfRangeException>();
    }
    
    [Test]
    public void Given_Boolean_ThatIsFalse_WhenCheck_IsTrue_ThenItThrowsCorrectException()
    {
        //Arrange
        var action = () => { TypeFactory.CreateBooleanFalse().Check().IsTrue(); };

        //Act

        //Assert
        action.Should().Throw<ArgumentOutOfRangeException>();
    }
}