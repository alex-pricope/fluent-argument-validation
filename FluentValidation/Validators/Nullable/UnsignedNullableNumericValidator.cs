using System;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for unsigned nullable numbers
    /// </summary>
    /// <typeparam name="T">The type of the nullable number</typeparam>
    public sealed class UnsignedNullableNumericValidator<T> where T : struct ,IComparable
    {
        private readonly T? _target;
        private readonly string _parameterName = "INPUT_UNSIGNED_NULLABLE_NUMERIC";

        internal UnsignedNullableNumericValidator(T? inputValue, string parameterName = "")
        {
            _target = inputValue;
            if (!string.IsNullOrEmpty(parameterName))
                _parameterName = parameterName;
        }

        /// <summary>
        /// Check if the unsigned nullable number has any value (is not null)
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<UnsignedNullableNumericValidator<T>> HasValue()
        {
            if (!_target.HasValue)
                throw new ArgumentOutOfRangeException(_parameterName, $"Input nullable number argument should have a value but found null");

            return new AndCriteria<UnsignedNullableNumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the unsigned nullable number value is less than an input max value
        /// </summary>
        /// <param name="maxValue">The input max value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<UnsignedNullableNumericValidator<T>> ValueIsLessThan(T maxValue)
        {
            HasValue();

            if (_target.Value.CompareTo(maxValue) > 0)
                throw new ArgumentOutOfRangeException(
                    _parameterName, $"Input nullable number argument should not be less than {maxValue} but found {_target}");

            return new AndCriteria<UnsignedNullableNumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the unsigned nullable number value is greater than an input min value
        /// </summary>
        /// <param name="minValue">The input min value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<UnsignedNullableNumericValidator<T>> ValueIsGreaterThan(T minValue)
        {
            HasValue();

            if (_target.Value.CompareTo(minValue) < 0)
                throw new ArgumentOutOfRangeException(
                    _parameterName, $"Input nullable number argument should be greater than {minValue} but found {_target}");

            return new AndCriteria<UnsignedNullableNumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the unsigned nullable number value is between an input min value and max value
        /// </summary>
        /// <param name="minValue">The input min value</param>
        /// <param name="maxValue">The input max value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<UnsignedNullableNumericValidator<T>> ValueIsBetween(T minValue, T maxValue)
        {
            HasValue();

            if (!(_target.Value.CompareTo(minValue) > 0 && _target.Value.CompareTo(maxValue) < 0))
                throw new ArgumentOutOfRangeException(
                    _parameterName, $"Input nullable number argument should be between {minValue} and {maxValue} but found {_target}");

            return new AndCriteria<UnsignedNullableNumericValidator<T>>(this);
        }
    }
}
