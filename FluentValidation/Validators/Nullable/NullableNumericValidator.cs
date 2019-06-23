using System;

namespace FluentValidation.Validators
{
    public sealed class NullableNumericValidator<T> where T : struct ,IComparable
    {
        private readonly T? _target;
        private readonly string _parameterName = "INPUT_NULLABLE_NUMERIC";

        public NullableNumericValidator(T? inputValue, string parameterName = "")
        {
            _target = inputValue;
            if (!string.IsNullOrEmpty(parameterName))
                _parameterName = parameterName;
        }

        /// <summary>
        /// Check if the nullable number has any value (is not null)
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NullableNumericValidator<T>> HasValue()
        {
            if (!_target.HasValue)
                throw new ArgumentOutOfRangeException(_parameterName, $"Input nullable number argument should have a value but found null");

            return new AndCriteria<NullableNumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the nullable number is null. If it's anything then null, throws
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public void IsNull()
        {
            if (_target.HasValue)
                throw new ArgumentNullException(_parameterName,
                    $"Input nullable number argument should be null but found {_target.Value}");
        }

        /// <summary>
        /// Check if the nullable number is positive
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NullableNumericValidator<T>> ValueIsPositive()
        {
            HasValue();

            if (_target.Value.CompareTo(default(T)) < 0)
                throw new ArgumentOutOfRangeException(_parameterName,
                    $"Input nullable number argument should be positive but found {_target}");

            return new AndCriteria<NullableNumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the nullable number is negative
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NullableNumericValidator<T>> ValueIsNegative()
        {
            HasValue();

            if (_target.Value.CompareTo(default(T)) > 0)
                throw new ArgumentOutOfRangeException(_parameterName,
                    $"Input nullable number argument should be negative but found {_target}");

            return new AndCriteria<NullableNumericValidator<T>>(this);
        }

        ///<summary>
        /// Check if the nullable number value is less than an input max value
        /// </summary>
        /// <param name="maxValue">The input max value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NullableNumericValidator<T>> ValueIsLessThan(T maxValue)
        {
            HasValue();

            if (_target.Value.CompareTo(maxValue) > 0)
                throw new ArgumentOutOfRangeException(_parameterName, 
                    $"Input nullable number argument should not be less than {maxValue} but found {_target}");

            return new AndCriteria<NullableNumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the nullable number value is greater than an input min value
        /// </summary>
        /// <param name="minValue">The input min value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NullableNumericValidator<T>> ValueIsGreaterThan(T minValue)
        {
            HasValue();

            if (_target.Value.CompareTo(minValue) < 0)
                throw new ArgumentOutOfRangeException(_parameterName, 
                    $"Input nullable number argument should be greater than {minValue} but found {_target}");

            return new AndCriteria<NullableNumericValidator<T>>(this);
        }

        /// <summary>
        /// Check if the nullable number value is between an input min value and max value
        /// </summary>
        /// <param name="minValue">The input min value</param>
        /// <param name="maxValue">The input max value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<NullableNumericValidator<T>> ValueIsBetween(T minValue, T maxValue)
        {
            HasValue();

            if (!(_target.Value.CompareTo(minValue) > 0 && _target.Value.CompareTo(maxValue) < 0))
                throw new ArgumentOutOfRangeException(_parameterName, 
                    $"Input nullable number argument should be between {minValue} and {maxValue} but found {_target}");

            return new AndCriteria<NullableNumericValidator<T>>(this);
        }
    }
}
