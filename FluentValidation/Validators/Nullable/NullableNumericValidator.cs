using System;
using FluentValidation.Criterias;

namespace FluentValidation.Validators.Nullable
{
    public sealed class NullableNumericValidator<T> where T : struct ,IComparable
    {
        private readonly T? _target;

        public NullableNumericValidator(T? inputValue)
        {
            _target = inputValue;
        }

        public AndCriteria<NullableNumericValidator<T>> HasValue()
        {
            if (!_target.HasValue)
                throw new ArgumentOutOfRangeException($"Input nullable number argument should have a value but found null");

            return new AndCriteria<NullableNumericValidator<T>>(this);
        }

        public void IsNull()
        {
            if (_target.HasValue)
                throw new ArgumentNullException(
                    $"Input nullable number argument should be null but found {_target.Value}");
        }

        public AndCriteria<NullableNumericValidator<T>> ValueIsPositive()
        {
            HasValue();

            if (_target.Value.CompareTo(default(T)) < 0)
                throw new ArgumentOutOfRangeException(
                    $"Input nullable number argument should be positive but found {_target}");

            return new AndCriteria<NullableNumericValidator<T>>(this);
        }

        public AndCriteria<NullableNumericValidator<T>> ValueIsNegative()
        {
            HasValue();

            if (_target.Value.CompareTo(default(T)) > 0)
                throw new ArgumentOutOfRangeException(
                    $"Input nullable number argument should be negative but found {_target}");

            return new AndCriteria<NullableNumericValidator<T>>(this);
        }

        public AndCriteria<NullableNumericValidator<T>> ValueIsLessThen(T maxValue)
        {
            HasValue();

            if (_target.Value.CompareTo(maxValue) > 0)
                throw new ArgumentOutOfRangeException(
                    $"Input nullable number argument should not be less then {maxValue} but found {_target}");

            return new AndCriteria<NullableNumericValidator<T>>(this);
        }

        public AndCriteria<NullableNumericValidator<T>> ValueIsGreaterThen(T minValue)
        {
            HasValue();

            if (_target.Value.CompareTo(minValue) < 0)
                throw new ArgumentOutOfRangeException(
                    $"Input nullable number argument should be greater then {minValue} but found {_target}");

            return new AndCriteria<NullableNumericValidator<T>>(this);
        }

        public AndCriteria<NullableNumericValidator<T>> ValueIsBetween(T minValue, T maxValue)
        {
            HasValue();

            if (!(_target.Value.CompareTo(minValue) > 0 && _target.Value.CompareTo(maxValue) < 0))
                throw new ArgumentOutOfRangeException(
                    $"Input nullable number argument should be between {minValue} and {maxValue} but found {_target}");

            return new AndCriteria<NullableNumericValidator<T>>(this);
        }
    }
}
