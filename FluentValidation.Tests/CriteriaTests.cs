using FluentAssertions;
using FluentValidation.Criterias;
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
            var refClass = new AReferenceClass {StringField = "SOME_STRING_VALUE"};

            //Act
            var andCriteria = new AndCriteria<AReferenceClass>(refClass);

            //Assert
            andCriteria.And.Should().Be(refClass);
            andCriteria.And.StringField.Should().Be(refClass.StringField);
            andCriteria.And.Should().BeOfType<AReferenceClass>();
        }

        [Test]
        public void GivenOrCriteria_WhenCallingCtor_ThenTheInstanceShouldContainCorrectReference()
        {
            //Arrange
            var refClass = new AReferenceClass { StringField = "SOME_STRING_VALUE" };

            //Act
            var andCriteria = new OrCriteria<AReferenceClass>(refClass);

            //Assert
            andCriteria.Or.Should().Be(refClass);
            andCriteria.Or.StringField.Should().Be(refClass.StringField);
            andCriteria.Or.Should().BeOfType<AReferenceClass>();
        }

        [Test]
        public void GivenHavingCriteria_WhenCallingCtor_ThenTheInstanceShouldContainCorrectReference()
        {
            //Arrange
            var refClass = new AReferenceClass { StringField = "SOME_STRING_VALUE" };

            //Act
            var andCriteria = new HavingCriteria<AReferenceClass>(refClass);

            //Assert
            andCriteria.Having.Should().Be(refClass);
            andCriteria.Having.StringField.Should().Be(refClass.StringField);
            andCriteria.Having.Should().BeOfType<AReferenceClass>();
        }

        private class AReferenceClass
        {
            internal string StringField { get; set; }
        }
    }
}
