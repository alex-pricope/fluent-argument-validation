using System;
using System.Collections.Generic;
using System.Linq;
using SimpleValidation.Criterias;

namespace SimpleValidation.Validators
{
    public sealed class GenericCollectionValidator<T>
    {
        private readonly IEnumerable<T> _target;

        public GenericCollectionValidator(IEnumerable<T> inputValue)
        {
            _target = inputValue;
        }

        public AndCriteria<GenericCollectionValidator<T>> NotEmpty()
        {
            NotNull();
            if (!_target.Any())
                throw new ArgumentOutOfRangeException($"Input collection should not be empty");

            return new AndCriteria<GenericCollectionValidator<T>>(this);
        }

        public AndCriteria<GenericCollectionValidator<T>> NotNull()
        {
            if(_target == null)
                throw new ArgumentOutOfRangeException($"Input collection should not be null");

            return new AndCriteria<GenericCollectionValidator<T>>(this);
        }

        public AndCriteria<GenericCollectionValidator<T>> NotNullOrEmpty()
        {
            NotEmpty();

            return new AndCriteria<GenericCollectionValidator<T>>(this);
        }

        public AndCriteria<GenericCollectionValidator<T>> MinimumLength(int minLengthValue)
        {
            NotEmpty();

            if (_target.Count() <= minLengthValue)
                throw new ArgumentOutOfRangeException(
                    $"Input collection should be at least {minLengthValue} but found {_target.Count()}");

            return new AndCriteria<GenericCollectionValidator<T>>(this);
        }

        public AndCriteria<GenericCollectionValidator<T>> MaximumLength(int maxLengthValue)
        {
            NotEmpty();

            if (_target.Count() >= maxLengthValue)
                throw new ArgumentOutOfRangeException(
                    $"Input collection size should not exceed {maxLengthValue} but found {_target.Count()}");

            return new AndCriteria<GenericCollectionValidator<T>>(this);
        }

        public AndCriteria<GenericCollectionValidator<T>> LengthBetween(int minLengthValue, int maxLengthValue)
        {
            NotEmpty();

            var collectionSize = _target.Count();

            if (!(collectionSize >= minLengthValue && collectionSize <= maxLengthValue))
                throw new ArgumentOutOfRangeException(
                    $"Input collection size should be between {minLengthValue} and {maxLengthValue} but found {_target.Count()}");

            return new AndCriteria<GenericCollectionValidator<T>>(this);
        }
    }
}
