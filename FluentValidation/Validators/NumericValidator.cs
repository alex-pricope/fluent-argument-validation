using System;
using FluentValidation.Criterias;

namespace FluentValidation.Validators
{
    public sealed class NumericValidator<T> where T : struct, IComparable
    {
        private readonly IComparable<T> _target;

        public NumericValidator(T inputValue)
        {
            _target = (IComparable<T>) inputValue;
        }

        public AndCriteria<NumericValidator<T>> IsPositive()
        {
            if (_target.CompareTo(default(T)) < 0)
                throw new ArgumentOutOfRangeException(
                    $"Input number argument should be positive but found {_target}");

            return new AndCriteria<NumericValidator<T>>(this);
        }

        public AndCriteria<NumericValidator<T>> IsNegative()
        {
            if (_target.CompareTo(default(T)) > 0)
                throw new ArgumentOutOfRangeException(
                    $"Input number argument should be negative but found {_target}");

            return new AndCriteria<NumericValidator<T>>(this);
        }

        public AndCriteria<NumericValidator<T>> IsLessThen(T maxValue)
        {
            if (_target.CompareTo(maxValue) > 0)
                throw new ArgumentOutOfRangeException(
                    $"Input number argument should not be less then {maxValue} but found {_target}");

            return new AndCriteria<NumericValidator<T>>(this);
        }

        public AndCriteria<NumericValidator<T>> IsGreaterThen(T minValue)
        {
            if (_target.CompareTo(minValue) < 0)
                throw new ArgumentOutOfRangeException(
                    $"Input number argument should be greater then {minValue} but found {_target}");

            return new AndCriteria<NumericValidator<T>>(this);
        }

        public AndCriteria<NumericValidator<T>> IsBetween(T minValue, T maxValue)
        {
            if (!(_target.CompareTo(minValue) > 0 && _target.CompareTo(maxValue) < 0))
                throw new ArgumentOutOfRangeException(
                    $"Input number argument should be between {minValue} and {maxValue} but found {_target}");

            return new AndCriteria<NumericValidator<T>>(this);
        }
    }
}
