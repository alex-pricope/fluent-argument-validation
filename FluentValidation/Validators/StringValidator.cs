using System;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for a string
    /// </summary>
    public sealed class StringValidator
    {
        private readonly string _target;

        internal StringValidator(string inputValue)
        {
            _target = inputValue;
        }

        //TODO: This is from a merge conflicyt
        public void IsEmpty()
        {
            if (!string.IsNullOrWhiteSpace(_target) || !string.IsNullOrEmpty(_target))
                throw new ArgumentNullException($"Input string argument should empty but found {_target}");
        }

         /// <summary>
        /// Check if the string is not empty
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AndCriteria<StringValidator> IsNotEmpty()
        {
            if (string.IsNullOrWhiteSpace(_target)|| string.IsNullOrEmpty(_target))
                throw new ArgumentNullException($"Input string argument should not be empty");

            return new AndCriteria<StringValidator>(this);
        }

        /// <summary>
        /// Check if the string length is greater then an input min length
        /// </summary>
        /// <param name="minLengthValue">The input min length</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<StringValidator> MinimumLength(int minLengthValue)
        {
            IsNotEmpty();

            if(_target.Length < minLengthValue)
                throw new ArgumentOutOfRangeException(
                    $"Input string argument should be at least {minLengthValue} length but found {_target.Length}");

            return new AndCriteria<StringValidator>(this);
        }

        /// <summary>
        /// Check if the string length is less then an max input length
        /// </summary>
        /// <param name="maxLengthValue">The input max length</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<StringValidator> MaximumLength(int maxLengthValue)
        {
            IsNotEmpty();

            if (_target.Length > maxLengthValue)
                throw new ArgumentOutOfRangeException(
                    $"Input string argument should be a maximum length of {maxLengthValue} but found {_target.Length}");

            return new AndCriteria<StringValidator>(this);
        }

        /// <summary>
        /// Check if the string length is between an input min and max length
        /// </summary>
        /// <param name="minLengthValue">The input min length</param>
        /// <param name="maxLengthValue">The input max length</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns></returns>
        public AndCriteria<StringValidator> LengthBetween(int minLengthValue, int maxLengthValue)
        {
            IsNotEmpty();

            if (!(_target.Length >= minLengthValue && _target.Length <= maxLengthValue))
                throw new ArgumentOutOfRangeException(
                    $"Input string argument length should be between {minLengthValue} and {maxLengthValue} but found {_target.Length}");

            return new AndCriteria<StringValidator>(this);
        }
    }
}
