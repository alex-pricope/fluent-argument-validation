using FluentAssertions;
using NUnit.Framework;

namespace FluentValidation.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    internal class CriteriaTests
    {
        [Test]
        public void GivenAndCriteria_WhenCallingCtor_ThenTheInstanceShouldContainCorrectReference()
        {
            //Arrange
            var refClass = new SomeClass {StringField = "SOME_STRING_VALUE"};

            //Act
            var andCriteria = new AndCriteria<SomeClass>(refClass);

            //Assert
            andCriteria.And.Should().Be(refClass);
            andCriteria.And.StringField.Should().Be(refClass.StringField);
            andCriteria.And.Should().BeOfType<SomeClass>();
        }

        [Test]
        public void GivenOrCriteria_WhenCallingCtor_ThenTheInstanceShouldContainCorrectReference()
        {
            //Arrange
            var refClass = new SomeClass { StringField = "SOME_STRING_VALUE" };

            //Act
            var andCriteria = new OrCriteria<SomeClass>(refClass);

            //Assert
            andCriteria.Or.Should().Be(refClass);
            andCriteria.Or.StringField.Should().Be(refClass.StringField);
            andCriteria.Or.Should().BeOfType<SomeClass>();
        }

        [Test]
        public void GivenHavingCriteria_WhenCallingCtor_ThenTheInstanceShouldContainCorrectReference()
        {
            //Arrange
            var refClass = new SomeClass { StringField = "SOME_STRING_VALUE" };

            //Act
            var andCriteria = new HavingCriteria<SomeClass>(refClass);

            //Assert
            andCriteria.Having.Should().Be(refClass);
            andCriteria.Having.StringField.Should().Be(refClass.StringField);
            andCriteria.Having.Should().BeOfType<SomeClass>();
        }

        private class SomeClass
        {
            internal string StringField { get; set; }
        }
    }
}
