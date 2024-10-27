using System;
using FluentAssertions;
using FluentValidation.Tests.Validators.NullableGuid.Factory;
using NUnit.Framework;

namespace FluentValidation.Tests.Validators.NullableGuid;

[TestFixture]
[Parallelizable(ParallelScope.All)]
public class NullableGuidValidationTests
{
    [Test]
    public void Given_NullableGuid_ThatIsNull_WhenCheck_IsNull_ThenItDoesNotThrow()
    {
        //Arrange
        var action = () => { NullableGuidFactory.CreateNullGuid().Check().IsNull(); };

        //Act

        //Assert
        action.Should().NotThrow();
    }
    
    [Test]
    public void Given_NullableGuid_ThatIsNull_WhenCheck_HasValue_ThenItThrowsCorrectException()
    {
        //Arrange
        var action = () => { NullableGuidFactory.CreateNullGuid().Check().HasValue(); };

        //Act

        //Assert
        action.Should().Throw<ArgumentNullException>();
    }
    
    [Test]
    public void Given_NullableGuid_ThatIsEmpty_WhenCheck_ValueIsNotEmpty_ThenItThrowsCorrectException()
    {
        //Arrange
        var action = () => { NullableGuidFactory.CreateEmptyGuid().Check().ValueIsNotEmpty(); };

        //Act

        //Assert
        action.Should().Throw<ArgumentOutOfRangeException>();
    }
    
    [Test]
    public void Given_NullableGuid_ThatIsNotEmpty_WhenCheck_ValueIsEmpty_ThenItThrowsCorrectException()
    {
        //Arrange
        var action = () => { NullableGuidFactory.CreateGuid().Check().ValueIsEmpty(); };

        //Act

        //Assert
        action.Should().Throw<ArgumentOutOfRangeException>();
    }
    
    [Test]
    public void Given_NullableGuid_ThatIsNotEmpty_WhenCheck_ValueIsNotEmpty_ThenItDoesNotThrow()
    {
        //Arrange
        var action = () => { NullableGuidFactory.CreateGuid().Check().ValueIsNotEmpty(); };

        //Act

        //Assert
        action.Should().NotThrow();
    }
}
