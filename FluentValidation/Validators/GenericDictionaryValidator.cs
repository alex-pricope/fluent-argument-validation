using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Criterias;

namespace FluentValidation.Validators
{
    public sealed class GenericDictionaryValidator<TKey,TValue>
    {
        private readonly IDictionary<TKey, TValue> _target;

        public GenericDictionaryValidator(IDictionary<TKey, TValue> inputCollection)
        {
            _target = inputCollection;
        }

        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> KeysCountBetween(int minKeysCountValue,
            int maxKeysCountValue)
        {
            IsNotEmpty();

            if (!(_target.Keys.Count >= minKeysCountValue && _target.Keys.Count <= maxKeysCountValue))
                throw new ArgumentOutOfRangeException(
                    $"Input dictionary argument keys count should be between {minKeysCountValue} and {maxKeysCountValue} but found {_target.Keys.Count}");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> MaximumKeysCount(int maxKeysCountValue)
        {
            IsNotEmpty();

            if (_target.Keys.Count >= maxKeysCountValue)
                throw new ArgumentOutOfRangeException(
                    $"Input dictionary argument keys count should not exceed {maxKeysCountValue} but found {_target.Keys.Count}");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> MinimumKeysCount(int minKeysCountValue)
        {
            IsNotEmpty();

            if (_target.Keys.Count <= minKeysCountValue)
                throw new ArgumentOutOfRangeException(
                    $"Input dictionary argument keys count should be at least {minKeysCountValue} but found {_target.Keys.Count}");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> IsNotEmpty()
        {
            IsNotNull();
            if (!_target.Any())
                throw new ArgumentOutOfRangeException($"Input dictionary argument should not be empty");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> IsNotNull()
        {
            if (_target == null)
                throw new ArgumentNullException($"Input dictionary argument should not be null");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> IsNotNullOrEmpty()
        {
            IsNotEmpty();

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }
    }
}
