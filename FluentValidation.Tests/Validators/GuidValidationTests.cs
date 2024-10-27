using System;
using FluentAssertions;
using FluentValidation.Tests.Validators.Factory;
using NUnit.Framework;

namespace FluentValidation.Tests.Validators;

[TestFixture]
[Parallelizable(ParallelScope.All)]
public class GuidValidationTests
{
    [Test]
    public void Given_Guid_ThatIsEmpty_WhenCheck_IsEmpty_ThenItDoesNotThrow()
    {
        //Arrange
        var action = () => { TypeFactory.CreateEmptyGuid().Check().IsEmpty(); };

        //Act

        //Assert
        action.Should().NotThrow();
    }
    
    [Test]
    public void Given_Guid_ThatIsEmpty_WhenCheck_IsNotEmpty_ThenItThrowsCorrectException()
    {
        //Arrange
        var action = () => { TypeFactory.CreateEmptyGuid().Check().IsNotEmpty(); };

        //Act

        //Assert
        action.Should().Throw<ArgumentNullException>();
    }
    
    [Test]
    public void Given_Guid_ThatIsNotEmpty_WhenCheck_IsEmpty_ThenItThrowsCorrectException()
    {
        //Arrange
        var action = () => { TypeFactory.CreateGuid().Check().IsEmpty(); };

        //Act

        //Assert
        action.Should().Throw<ArgumentOutOfRangeException>();
    }
    
    [Test]
    public void Given_Guid_ThatIsNotEmpty_WhenCheck_IsNotEmpty_ThenItDoesNotThrow()
    {
        //Arrange
        var action = () => { TypeFactory.CreateGuid().Check().IsNotEmpty(); };

        //Act

        //Assert
        action.Should().NotThrow();
    }
}