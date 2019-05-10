using System;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for numbers
    /// </summary>
    /// <typeparam name="T">The type of the number</typeparam>
    public sealed class NumericValidator<T> where T : struct, IComparable
    {
        private readonly IComparable<T> _target;

        internal NumericValidator(T inputValue)
        {
            _target = (IComparable<T>) inputValue;
        }

        /// <summary>
        /// Check if the number is positive
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NumericValidator<T>> IsPositive()
        {
            if (_target.CompareTo(default(T)) < 0)
                throw new ArgumentOutOfRangeException(nameof(_target),
                    $"Input number argument should be positive but found {_target}");

            return new AndCriteria<NumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the number is negative
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NumericValidator<T>> IsNegative()
        {
            if (_target.CompareTo(default(T)) > 0)
                throw new ArgumentOutOfRangeException(nameof(_target),
                    $"Input number argument should be negative but found {_target}");

            return new AndCriteria<NumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the number is less then an input max value
        /// </summary>
        /// <param name="maxValue">The input max value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NumericValidator<T>> IsLessThen(T maxValue)
        {
            if (_target.CompareTo(maxValue) > 0)
                throw new ArgumentOutOfRangeException(nameof(_target),
                    $"Input number argument should not be less then {maxValue} but found {_target}");

            return new AndCriteria<NumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the number is greater then an input min value
        /// </summary>
        /// <param name="minValue">The input min value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NumericValidator<T>> IsGreaterThen(T minValue)
        {
            if (_target.CompareTo(minValue) < 0)
                throw new ArgumentOutOfRangeException(nameof(_target),
                    $"Input number argument should be greater then {minValue} but found {_target}");

            return new AndCriteria<NumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the number is between an input min value and max value
        /// </summary>
        /// <param name="minValue">The input min value</param>
        /// <param name="maxValue">The input max value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NumericValidator<T>> IsBetween(T minValue, T maxValue)
        {
            if (!(_target.CompareTo(minValue) > 0 && _target.CompareTo(maxValue) < 0))
                throw new ArgumentOutOfRangeException(nameof(_target),
                    $"Input number argument should be between {minValue} and {maxValue} but found {_target}");

            return new AndCriteria<NumericValidator<T>>(this);
        }
    }
}
