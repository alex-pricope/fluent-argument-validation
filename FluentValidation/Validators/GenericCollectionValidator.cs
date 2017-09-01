using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for a generic collection
    /// </summary>
    /// <typeparam name="T">The collection types</typeparam>
    public sealed class GenericCollectionValidator<T>
    {
        private readonly IEnumerable<T> _target;

        internal GenericCollectionValidator(IEnumerable<T> inputValue)
        {
            _target = inputValue;
        }

        /// <summary>
        /// Check if the collection is not empty
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericCollectionValidator<T>> IsNotEmpty()
        {
            IsNotNull();
            if (!_target.Any())
                throw new ArgumentOutOfRangeException($"Input collection argument should not be empty");

            return new AndCriteria<GenericCollectionValidator<T>>(this);
        }

        /// <summary>
        /// Check if the collection is not null
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericCollectionValidator<T>> IsNotNull()
        {
            if(_target == null)
                throw new ArgumentNullException($"Input collection argument should not be null");

            return new AndCriteria<GenericCollectionValidator<T>>(this);
        }

        /// <summary>
        /// Check if the collection is not null and not empty
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericCollectionValidator<T>> IsNotNullOrEmpty()
        {
            IsNotEmpty();

            return new AndCriteria<GenericCollectionValidator<T>>(this);
        }

        /// <summary>
        /// Check if the collection is not null and not empty (has values). The same as IsNotNullOrEmpty
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericCollectionValidator<T>> HasValues()
        {
            IsNotEmpty();

            return new AndCriteria<GenericCollectionValidator<T>>(this);
        }

        /// <summary>
        /// Check if the collection has a minimum length (or count)
        /// </summary>
        /// <param name="minLengthValue">The input min length</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericCollectionValidator<T>> MinimumLength(int minLengthValue)
        {
            IsNotEmpty();

            if (_target.Count() <= minLengthValue)
                throw new ArgumentOutOfRangeException(
                    $"Input collection argument should be at least {minLengthValue} but found {_target.Count()}");

            return new AndCriteria<GenericCollectionValidator<T>>(this);
        }

        /// <summary>
        /// Check if the collection has a maximum length (or count)
        /// </summary>
        /// <param name="maxLengthValue">The input max length</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericCollectionValidator<T>> MaximumLength(int maxLengthValue)
        {
            IsNotEmpty();

            if (_target.Count() >= maxLengthValue)
                throw new ArgumentOutOfRangeException(
                    $"Input collection argument size should not exceed {maxLengthValue} but found {_target.Count()}");

            return new AndCriteria<GenericCollectionValidator<T>>(this);
        }

        /// <summary>
        /// Check if the collection has a length (or count) between an input min and max length
        /// </summary>
        /// <param name="minLengthValue">The input min length</param>
        /// <param name="maxLengthValue">The input max length</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericCollectionValidator<T>> LengthBetween(int minLengthValue, int maxLengthValue)
        {
            IsNotEmpty();

            var collectionSize = _target.Count();
            if (!(collectionSize >= minLengthValue && collectionSize <= maxLengthValue))
                throw new ArgumentOutOfRangeException(
                    $"Input collection argument size should be between {minLengthValue} and {maxLengthValue} but found {_target.Count()}");

            return new AndCriteria<GenericCollectionValidator<T>>(this);
        }
    }
}
