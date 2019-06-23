using System;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for DateTime
    /// </summary>
    public sealed class DateTimeValidator
    {
        private readonly DateTime _target;
        private readonly string _parameterName = "INPUT_DATETIME";

        internal DateTimeValidator(DateTime inputDateTime, string parameterName="")
        {
            _target = inputDateTime;
            if (!string.IsNullOrEmpty(parameterName))
                _parameterName = parameterName;
        }

        /// <summary>
        /// Check if the DateTime value is a valid DateTime. It should not be MinValue, MaxValue or default(DateTime)
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<DateTimeValidator> IsValid()
        {
            if (_target == DateTime.MinValue || _target == DateTime.MaxValue || _target == default(DateTime))
                throw new ArgumentOutOfRangeException(_parameterName, $"Input DateTime argument should be valid but found {_target}");

            return new AndCriteria<DateTimeValidator>(this);
        }

        /// <summary>
        /// Check if the DateTime value is greater than an input min DateTime
        /// </summary>
        /// <param name="minValue">The input min value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<DateTimeValidator> IsGreaterThan(DateTime minValue)
        {
            IsValid();

            if (_target < minValue)
                throw new ArgumentOutOfRangeException(
                    _parameterName, $"Input DateTime argument should be greater than {minValue} but found {_target}");

            return new AndCriteria<DateTimeValidator>(this);
        }

        /// <summary>
        /// Check if the DateTime value is less than an input max DateTime
        /// </summary>
        /// <param name="maxValue">The input max value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<DateTimeValidator> IsLessThan(DateTime maxValue)
        {
            IsValid();

            if (_target > maxValue)
                throw new ArgumentOutOfRangeException(
                    _parameterName, $"Input DateTime argument should be less then {maxValue} but found {_target}");

            return new AndCriteria<DateTimeValidator>(this);
        }

        /// <summary>
        /// Check if the DateTime value is between an input min value and max value
        /// </summary>
        /// <param name="minValue">The input min value</param>
        /// <param name="maxValue">The input max value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<DateTimeValidator> IsBetween(DateTime minValue, DateTime maxValue)
        {
            IsValid();

            if (!(_target >= minValue && _target <= maxValue))
                throw new ArgumentOutOfRangeException(
                    _parameterName, $"Input DateTime argument should be between {minValue} and {maxValue} but found {_target}");

            return new AndCriteria<DateTimeValidator>(this);
        }
    }
}
