using System;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for nullable DateTime
    /// </summary>
    public sealed class NullableDateTimeValidator
    {
        private readonly DateTime? _target;
        private readonly string _parameterName = "INPUT_NULLABLE_DATETIME";

        internal NullableDateTimeValidator(DateTime? inputDateTime, string parameterName = "")
        {
            _target = inputDateTime;
            if (!string.IsNullOrEmpty(parameterName))
                _parameterName = parameterName;
        }

        /// <summary>
        /// Check if the nullable DateTime has any value (is not null)
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NullableDateTimeValidator> HasValue()
        {
            if (!_target.HasValue)
                throw new ArgumentOutOfRangeException(_parameterName, $"Input nullable DateTime argument should have a value but found null");

            return new AndCriteria<NullableDateTimeValidator>(this);
        }

        /// <summary>
        /// Check if the nullable DateTime is null. If it's anything then null, throws
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void IsNull()
        {
            if (_target.HasValue)
                throw new ArgumentOutOfRangeException(
                    _parameterName, $"Input nullable DateTime argument should be null but found {_target.Value}");
        }

        /// <summary>
        /// Check if the nullable DateTime value is a valid DateTime. It should not be MinValue, MaxValue or default(DateTime)
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NullableDateTimeValidator> IsValid()
        {
            HasValue();

            if (_target == DateTime.MinValue || _target == DateTime.MaxValue || _target == default(DateTime))
                throw new ArgumentOutOfRangeException(_parameterName, $"Input nullable DateTime argument should have a valid DateTime value but found {_target}");

            return new AndCriteria<NullableDateTimeValidator>(this);
        }
    }
}
