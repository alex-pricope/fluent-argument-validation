using System;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for nullable Boolean
    /// </summary>
    public sealed class NullableBooleanValidator
    {
        private readonly bool? _target;
        private readonly string _parameterName = "INPUT_NULLABLE_BOOLEAN";
        
        internal NullableBooleanValidator(bool? input, string parameterName = "")
        {
            _target = input;
            if (!string.IsNullOrWhiteSpace(parameterName))
                _parameterName = parameterName;
        }
        
        /// <summary>
        /// Check if the nullable boolean has any value (is not null)
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AndCriteria<NullableBooleanValidator> HasValue()
        {
            if (!_target.HasValue)
                throw new ArgumentNullException(_parameterName, "Input nullable boolean argument should have a value but found null");

            return new AndCriteria<NullableBooleanValidator>(this);
        }
        
        /// <summary>
        /// Check if the nullable boolean is null. If it's anything then null, throws
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public void IsNull()
        {
            if (_target.HasValue)
                throw new ArgumentException(
                    _parameterName, $"Input nullable boolean argument should be null but found {_target.Value}");
        }
        
        /// <summary>
        /// Check if the nullable boolean has value and it's TRUE. If it's null or FALSE, throws
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void ValueIsTrue()
        {
            HasValue();

            if (_target.Value != true)
            {
                throw new ArgumentOutOfRangeException(
                    _parameterName, $"Input nullable boolean argument should have value TRUE but found {_target.Value}");
            }
        }
        
        /// <summary>
        /// Check if the nullable boolean has value and it's FALSE. If it's null or TRUE, throws
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void ValueIsFalse()
        {
            HasValue();

            if (_target.Value)
            {
                throw new ArgumentOutOfRangeException(
                    _parameterName, $"Input nullable boolean argument should have value FALSE but found {_target.Value}");
            }
        }
    }
}