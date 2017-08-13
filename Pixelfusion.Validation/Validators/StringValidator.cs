using System;
using SimpleValidation.Criterias;

namespace SimpleValidation.Validators
{
    public sealed class StringValidator
    {
        private readonly string _target;

        public StringValidator(string inputValue)
        {
            _target = inputValue;
        }

        public AndCriteria<StringValidator> NotEmpty()
        {
            if(string.IsNullOrWhiteSpace(_target)|| string.IsNullOrEmpty(_target))
                throw new ArgumentNullException($"String argument should not be empty");

            return new AndCriteria<StringValidator>(this);
        }

        public AndCriteria<StringValidator> MinimumLength(int minLengthValue)
        {
            NotEmpty();

            if(_target.Length < minLengthValue)
                throw new ArgumentOutOfRangeException(
                    $"Input string should be at least {minLengthValue} length but found {_target.Length}");

            return new AndCriteria<StringValidator>(this);
        }

        public AndCriteria<StringValidator> MaximumLength(int maxLengthValue)
        {
            NotEmpty();

            if (_target.Length > maxLengthValue)
                throw new ArgumentOutOfRangeException(
                    $"Input string should be a maximum length of {maxLengthValue} but found {_target.Length}");

            return new AndCriteria<StringValidator>(this);
        }

        public AndCriteria<StringValidator> LengthBetween(int minLengthValue, int maxLengthValue)
        {
            NotEmpty();

            if (!(_target.Length >= minLengthValue && _target.Length <= maxLengthValue))
                throw new ArgumentOutOfRangeException(
                    $"Input string length should be between {minLengthValue} and {maxLengthValue} but found {_target.Length}");

            return new AndCriteria<StringValidator>(this);
        }
    }
}
