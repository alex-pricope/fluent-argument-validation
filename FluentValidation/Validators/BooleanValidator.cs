using System;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for Boolean
    /// </summary>
    public sealed class BooleanValidator
    {
        private readonly bool _target;
        private readonly string _parameterName = "INPUT_BOOLEAN";
        
        internal BooleanValidator(bool input, string parameterName = "")
        {
            _target = input;
            if (!string.IsNullOrWhiteSpace(parameterName))
                _parameterName = parameterName;
        }
        
        /// <summary>
        /// Check if the boolean is TRUE
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void IsTrue()
        {
            if (_target != true)
            {
                throw new ArgumentOutOfRangeException(
                    _parameterName, $"Input boolean argument should have value TRUE but found {_target}");
            }
        }
        
        /// <summary>
        /// Check if the boolean is FALSE
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void IsFalse()
        {
            if (_target)
            {
                throw new ArgumentOutOfRangeException(
                    _parameterName, $"Input boolean argument should have value FALSE but found {_target}");
            }
        }
    }
}