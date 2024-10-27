using System;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for a GUID
    /// </summary>
    public sealed class GuidValidator
    {
        private readonly Guid _target;
        private readonly string _parameterName = "INPUT_GUID";
        
        internal GuidValidator(Guid input, string parameterName = "")
        {
            _target = input;
            if (!string.IsNullOrWhiteSpace(parameterName))
                _parameterName = parameterName;
        }
        
        /// <summary>
        /// Check if a GUID is empty
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void IsEmpty()
        {
            if (_target != Guid.Empty)
                throw new ArgumentOutOfRangeException(_parameterName,$"Input GUID argument should empty but found {_target}");
        }
        
        /// <summary>
        /// Check if a GUID has a value
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public void IsNotEmpty()
        {
            if (_target == Guid.Empty)
                throw new ArgumentNullException(_parameterName,"Input GUID argument should not be empty");
        }
    }
}