using System;
using FluentValidation.Criterias;

namespace FluentValidation.Validators
{
    public sealed class StringValidator
    {
        private readonly string _target;

        public StringValidator(string inputValue)
        {
            _target = inputValue;
        }

        public void IsEmpty()
        {
            if (!string.IsNullOrWhiteSpace(_target) || !string.IsNullOrEmpty(_target))
                throw new ArgumentNullException($"Input string argument should empty but found {_target}");
        }

        public AndCriteria<StringValidator> NotEmpty()
        {
            if(string.IsNullOrWhiteSpace(_target)|| string.IsNullOrEmpty(_target))
                throw new ArgumentNullException($"Input string argument should not be empty");

            return new AndCriteria<StringValidator>(this);
        }

        public AndCriteria<StringValidator> MinimumLength(int minLengthValue)
        {
            NotEmpty();

            if(_target.Length < minLengthValue)
                throw new ArgumentOutOfRangeException(
                    $"Input string argument should be at least {minLengthValue} length but found {_target.Length}");

            return new AndCriteria<StringValidator>(this);
        }

        public AndCriteria<StringValidator> MaximumLength(int maxLengthValue)
        {
            NotEmpty();

            if (_target.Length > maxLengthValue)
                throw new ArgumentOutOfRangeException(
                    $"Input string argument should be a maximum length of {maxLengthValue} but found {_target.Length}");

            return new AndCriteria<StringValidator>(this);
        }

        public AndCriteria<StringValidator> LengthBetween(int minLengthValue, int maxLengthValue)
        {
            NotEmpty();

            if (!(_target.Length >= minLengthValue && _target.Length <= maxLengthValue))
                throw new ArgumentOutOfRangeException(
                    $"Input string argument length should be between {minLengthValue} and {maxLengthValue} but found {_target.Length}");

            return new AndCriteria<StringValidator>(this);
        }
    }
}
