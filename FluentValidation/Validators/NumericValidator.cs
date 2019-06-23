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
        private readonly string _parameterName = "INPUT_NUMERIC";

        internal NumericValidator(T inputValue, string parameterName = "")
        {
            _target = (IComparable<T>) inputValue;
            if (!string.IsNullOrEmpty(parameterName))
                _parameterName = parameterName;
        }

        /// <summary>
        /// Check if the number is positive
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NumericValidator<T>> IsPositive()
        {
            if (_target.CompareTo(default(T)) < 0)
                throw new ArgumentOutOfRangeException(_parameterName,
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
                throw new ArgumentOutOfRangeException(_parameterName,
                    $"Input number argument should be negative but found {_target}");

            return new AndCriteria<NumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the number is less than an input max value
        /// </summary>
        /// <param name="maxValue">The input max value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NumericValidator<T>> IsLessThan(T maxValue)
        {
            if (_target.CompareTo(maxValue) > 0)
                throw new ArgumentOutOfRangeException(_parameterName,
                    $"Input number argument should not be less then {maxValue} but found {_target}");

            return new AndCriteria<NumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the number is greater than an input min value
        /// </summary>
        /// <param name="minValue">The input min value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NumericValidator<T>> IsGreaterThan(T minValue)
        {
            if (_target.CompareTo(minValue) < 0)
                throw new ArgumentOutOfRangeException(_parameterName,
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
                throw new ArgumentOutOfRangeException(_parameterName,
                    $"Input number argument should be between {minValue} and {maxValue} but found {_target}");

            return new AndCriteria<NumericValidator<T>>(this);
        }
    }
}
