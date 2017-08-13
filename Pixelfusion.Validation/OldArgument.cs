using System;

namespace SimpleValidation
{
    //TODO: Exception factory helper
    /// <summary>
    /// This class does OldArgument Validation
    /// </summary>
    public static class OldArgument
    {
        /// <summary>
        /// Validates a bool condition
        /// </summary>
        /// <param name="condition">Condition</param>
        /// <param name="exceptionMessage">The exception message</param>
        public static void ValidateCondition(bool condition, string exceptionMessage)
        {
            if (!condition) throw new ArgumentException(exceptionMessage);
        }

        /// <summary>
        /// Validates an input object
        /// </summary>
        /// <param name="input">Input object</param>
        public static void ValidateObject(object input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
        }

        #region STRING_VALIDATION

        /// <summary>
        /// Validates an input string
        /// </summary>
        /// <param name="inputString">The input string</param>
        public static void ValidateString(string inputString)
        {
            ValidateObject(inputString);
            if (string.IsNullOrWhiteSpace(inputString)) throw new ArgumentNullException(nameof(inputString));
        }

        /// <summary>
        /// Validates an input string that matches a given length
        /// </summary>
        /// <param name="inputString">The input string</param>
        /// <param name="minLength">The minimum length</param>
        public static void ValidateStringLength(string inputString, int minLength)
        {
            ValidateString(inputString);
            if (inputString.Length < minLength)
                throw new ArgumentOutOfRangeException(
                    $"Input string should be at least {minLength} length but found {inputString.Length}");
        }

        /// <summary>
        /// Validates an input string that is between a minimum and a maximum length
        /// </summary>
        /// <param name="inputString">The input string</param>
        /// <param name="minLength">The minimum length</param>
        /// <param name="maxLength">The maximum length</param>
        public static void ValidateStringLength(string inputString, int minLength, int maxLength)
        {
            ValidateStringLength(inputString, minLength);
            if (inputString.Length > maxLength)
                throw new ArgumentOutOfRangeException(
                    $"Input string should be of maximum {maxLength} length but found {inputString.Length}");
        }

        #endregion

        #region NUMBER_VALIDATION

        /// <summary>
        /// Validates an input integer
        /// </summary>
        /// <param name="inputInteger">The input integer</param>
        public static void ValidateInteger(long inputInteger)
        {
            if(inputInteger < 0)
                throw new ArgumentException(nameof(inputInteger));
        }

        /// <summary>
        /// Validates an input number against a minimum value
        /// </summary>
        /// <param name="inputInteger">The input number</param>
        /// <param name="minValue">The minimum value</param>
        public static void ValidateInteger(long inputInteger, long minValue)
        {
            ValidateInteger(inputInteger);
            if(inputInteger < minValue)
                throw new ArgumentOutOfRangeException(
                    $"Input number integer should be at least {minValue} but found {inputInteger}");
        }

        /// <summary>
        /// Validates an input integer is between a minimum and a maximum
        /// </summary>
        /// <param name="inputInteger">The input integer</param>
        /// <param name="minValue">The minimum value</param>
        /// <param name="maxValue">The maximum value</param>
        public static void ValidateInteger(long inputInteger, long minValue, long maxValue)
        {
            ValidateInteger(inputInteger, minValue);
            if (inputInteger > maxValue)
                throw new ArgumentOutOfRangeException(
                    $"Input integer should be of maximum {maxValue} but found {inputInteger}");
        }

        #endregion

        #region DATE_VALIDATION

        public static void ValidateDateTime(DateTime inputDateTime)
        {
            if (inputDateTime == DateTime.MinValue || inputDateTime == DateTime.MaxValue)
                throw new ArgumentOutOfRangeException(
                    $"Input DateTime should not be DateTime.MinValue or  DateTime.MaxValue but found {inputDateTime}");
        }

        #endregion
    }
}
