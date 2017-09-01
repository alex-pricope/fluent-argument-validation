using System;

namespace FluentValidation.Validators
{
   /// <summary>
   /// Validation class for signed nullable numbers
   /// </summary>
   /// <typeparam name="T">The type of the nullable number</typeparam>
    public sealed class SignedNullableNumericValidator<T> where T : struct ,IComparable
    {
        private readonly T? _target;

        internal SignedNullableNumericValidator(T? inputValue)
        {
            _target = inputValue;
        }

        /// <summary>
        /// Check if the signed nullable number has any value (is not null)
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<SignedNullableNumericValidator<T>> HasValue()
        {
            if (!_target.HasValue)
                throw new ArgumentOutOfRangeException($"Input nullable number argument should have a value but found null");

            return new AndCriteria<SignedNullableNumericValidator<T>>(this);
        }

        //TODO: Does this really makes any sense?! - Leave it here for now
        /// <summary>
        /// Check if the signed nullable number is null. If it's anything then null, throws
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void IsNull()
        {
            if (_target.HasValue)
                throw new ArgumentOutOfRangeException(
                    $"Input nullable number argument should be null but found {_target.Value}");
        }

        /// <summary>
        /// Check if the signed nullable number is positive
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<SignedNullableNumericValidator<T>> ValueIsPositive()
        {
            HasValue();

            if (_target.Value.CompareTo(default(T)) < 0)
                throw new ArgumentOutOfRangeException(
                    $"Input nullable number argument should be positive but found {_target}");

            return new AndCriteria<SignedNullableNumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the signed nullable number is negative
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<SignedNullableNumericValidator<T>> ValueIsNegative()
        {
            HasValue();

            if (_target.Value.CompareTo(default(T)) > 0)
                throw new ArgumentOutOfRangeException(
                    $"Input nullable number argument should be negative but found {_target}");

            return new AndCriteria<SignedNullableNumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the signed nullable number value is less then an input max value
        /// </summary>
        /// <param name="maxValue">The input max value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<SignedNullableNumericValidator<T>> ValueIsLessThen(T maxValue)
        {
            HasValue();

            if (_target.Value.CompareTo(maxValue) > 0)
                throw new ArgumentOutOfRangeException(
                    $"Input nullable number argument should not be less then {maxValue} but found {_target}");

            return new AndCriteria<SignedNullableNumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the signed nullable number value is greater then an input min value
        /// </summary>
        /// <param name="minValue">The input min value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<SignedNullableNumericValidator<T>> ValueIsGreaterThen(T minValue)
        {
            HasValue();

            if (_target.Value.CompareTo(minValue) < 0)
                throw new ArgumentOutOfRangeException(
                    $"Input nullable number argument should be greater then {minValue} but found {_target}");

            return new AndCriteria<SignedNullableNumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the signed nullable number value is between an input min value and max value
        /// </summary>
        /// <param name="minValue">The input min value</param>
        /// <param name="maxValue">The input max value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<SignedNullableNumericValidator<T>> ValueIsBetween(T minValue, T maxValue)
        {
            HasValue();

            if (!(_target.Value.CompareTo(minValue) > 0 && _target.Value.CompareTo(maxValue) < 0))
                throw new ArgumentOutOfRangeException(
                    $"Input nullable number argument should be between {minValue} and {maxValue} but found {_target}");

            return new AndCriteria<SignedNullableNumericValidator<T>>(this);
        }
    }
}
