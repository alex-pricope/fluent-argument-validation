using System;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for nullable DateTime
    /// </summary>
    public sealed class NullableDateTimeValidator
    {
        private readonly DateTime? _target;

        internal NullableDateTimeValidator(DateTime? inputDateTime)
        {
            _target = inputDateTime;
        }

        /// <summary>
        /// Check if the nullable DateTime has any value (is not null)
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NullableDateTimeValidator> HasValue()
        {
            if (!_target.HasValue)
                throw new ArgumentOutOfRangeException(nameof(_target), $"Input nullable DateTime argument should have a value but found null");

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
                    nameof(_target), $"Input nullable DateTime argument should be null but found {_target.Value}");
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
                throw new ArgumentOutOfRangeException(nameof(_target), $"Input nullable DateTime argument should have a valid DateTime value but found {_target}");

            return new AndCriteria<NullableDateTimeValidator>(this);
        }
    }
}
