using System;
using System.Collections.Generic;
using System.Linq;
using SimpleValidation.Criterias;

namespace SimpleValidation.Validators
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
            NotEmpty();

            if (!(_target.Keys.Count >= minKeysCountValue && _target.Keys.Count <= maxKeysCountValue))
                throw new ArgumentOutOfRangeException(
                    $"Input dictionary keys count should be between {minKeysCountValue} and {maxKeysCountValue} but found {_target.Keys.Count}");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> MaximumKeysCount(int maxKeysCountValue)
        {
            NotEmpty();

            if (_target.Keys.Count >= maxKeysCountValue)
                throw new ArgumentOutOfRangeException(
                    $"Input dictionary keys count should not exceed {maxKeysCountValue} but found {_target.Keys.Count}");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> MinimumKeysCount(int minKeysCountValue)
        {
            NotEmpty();

            if (_target.Keys.Count <= minKeysCountValue)
                throw new ArgumentOutOfRangeException(
                    $"Input dictionary keys count should be at least {minKeysCountValue} but found {_target.Keys.Count}");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> NotEmpty()
        {
            NotNull();
            if (!_target.Any())
                throw new ArgumentOutOfRangeException($"Input dictionary should not be empty");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> NotNull()
        {
            if (_target == null)
                throw new ArgumentOutOfRangeException($"Input dictionary should not be null");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> NotNullOrEmpty()
        {
            NotEmpty();

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }
    }
}
