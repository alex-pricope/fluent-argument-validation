﻿using System;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for DateTime
    /// </summary>
    public sealed class DateTimeValidator
    {
        private readonly DateTime _target;

        internal DateTimeValidator(DateTime inputDateTime)
        {
            _target = inputDateTime;
        }

        /// <summary>
        /// Check if the DateTime value is a valid DateTime. It should not be MinValue, MaxValue or default(DateTime)
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<DateTimeValidator> IsValid()
        {
            if (_target == DateTime.MinValue || _target == DateTime.MaxValue || _target == default(DateTime))
                throw new ArgumentOutOfRangeException($"Input DateTime argument should be valid but found {_target}");

            return new AndCriteria<DateTimeValidator>(this);
        }

        /// <summary>
        /// Check if the DateTime value is greater then an input min DateTime
        /// </summary>
        /// <param name="minValue">The input min value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<DateTimeValidator> IsGreaterThen(DateTime minValue)
        {
            IsValid();

            if (_target < minValue)
                throw new ArgumentOutOfRangeException(
                    $"Input DateTime argument should be greater then {minValue} but found {_target}");

            return new AndCriteria<DateTimeValidator>(this);
        }

        /// <summary>
        /// Check if the DateTime value is less then an input max DateTime
        /// </summary>
        /// <param name="maxValue">The input max value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<DateTimeValidator> IsLessThen(DateTime maxValue)
        {
            IsValid();

            if (_target > maxValue)
                throw new ArgumentOutOfRangeException(
                    $"Input DateTime argument should be less then {maxValue} but found {_target}");

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
                    $"Input DateTime argument should be between {minValue} and {maxValue} but found {_target}");

            return new AndCriteria<DateTimeValidator>(this);
        }
    }
}