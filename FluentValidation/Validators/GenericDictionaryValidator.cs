using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for a generic dictionary
    /// </summary>
    /// <typeparam name="TKey">The TKey type</typeparam>
    /// <typeparam name="TValue">The TValue type </typeparam>
    public sealed class GenericDictionaryValidator<TKey,TValue>
    {
        private readonly IDictionary<TKey, TValue> _target;
        private readonly string _parameterName = "INPUT_DICTIONARY";

        internal GenericDictionaryValidator(IDictionary<TKey, TValue> inputCollection, string parameterName)
        {
            _target = inputCollection;
            if (!string.IsNullOrEmpty(parameterName))
                _parameterName = parameterName;
        }

        /// <summary>
        /// Check if the dictionary has a key count between an input min and max keys count
        /// </summary>
        /// <param name="minKeysCountValue">The input min keys count</param>
        /// <param name="maxKeysCountValue">The input max keys count</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> KeysCountBetween(int minKeysCountValue,
            int maxKeysCountValue)
        {
            IsNotEmpty();

            if (!(_target.Keys.Count >= minKeysCountValue && _target.Keys.Count <= maxKeysCountValue))
                throw new ArgumentOutOfRangeException(_parameterName,
                    $"Input dictionary argument keys count should be between {minKeysCountValue} and {maxKeysCountValue} but found {_target.Keys.Count}");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        /// <summary>
        /// Check if the dictionary has a key count less then an input max keys count
        /// </summary>
        /// <param name="maxKeysCountValue">The input max keys count</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> MaximumKeysCount(int maxKeysCountValue)
        {
            IsNotEmpty();

            if (_target.Keys.Count >= maxKeysCountValue)
                throw new ArgumentOutOfRangeException(_parameterName,
                    $"Input dictionary argument keys count should not exceed {maxKeysCountValue} but found {_target.Keys.Count}");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        /// <summary>
        /// Check if the dictionary has a key count greater then an input min keys count
        /// </summary>
        /// <param name="minKeysCountValue">The input min keys count</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> MinimumKeysCount(int minKeysCountValue)
        {
            IsNotEmpty();

            if (_target.Keys.Count <= minKeysCountValue)
                throw new ArgumentOutOfRangeException(_parameterName,
                    $"Input dictionary argument keys count should be at least {minKeysCountValue} but found {_target.Keys.Count}");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        /// <summary>
        /// Check if the dictionary is not empty
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> IsNotEmpty()
        {
            IsNotNull();
            if (!_target.Any())
                throw new ArgumentOutOfRangeException(_parameterName, $"Input dictionary argument should not be empty");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        /// <summary>
        /// Check if the dictionary is not null
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> IsNotNull()
        {
            if (_target == null)
                throw new ArgumentNullException(_parameterName, $"Input dictionary argument should not be null");

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        /// <summary>
        /// Check if the dictionary is not null and not empty
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> IsNotNullOrEmpty()
        {
            IsNotEmpty();

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }

        /// <summary>
        /// Check if the dictionary is not null and not empty (has values). The same as IsNotNullOrEmpty
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<GenericDictionaryValidator<TKey, TValue>> HasValue()
        {
            IsNotEmpty();

            return new AndCriteria<GenericDictionaryValidator<TKey, TValue>>(this);
        }
    }
}
