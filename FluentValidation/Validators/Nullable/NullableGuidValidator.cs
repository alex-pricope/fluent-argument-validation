using System;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for nullable GUID
    /// </summary>
    public sealed class NullableGuidValidator
    {
        private readonly Guid? _target;
        private readonly string _parameterName = "INPUT_NULLABLE_GUID";
        
        internal NullableGuidValidator(Guid? input, string argName = "")
        {
            _target = input;
            if (!string.IsNullOrWhiteSpace(argName))
                _parameterName = argName;
        }
        
        /// <summary>
        /// Check if the nullable GUID has any value (is not null)
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AndCriteria<NullableGuidValidator> HasValue()
        {
            if (!_target.HasValue)
                throw new ArgumentNullException(_parameterName, "Input nullable GUID argument should have a value but found null");

            return new AndCriteria<NullableGuidValidator>(this);
        }
        
        /// <summary>
        /// Check if the nullable GUID is null. If it's anything then null, throws
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public void IsNull()
        {
            if (_target.HasValue)
                throw new ArgumentException(
                    _parameterName, $"Input nullable GUID argument should be null but found {_target.Value}");
        }
        
        /// <summary>
        /// Check if the nullable GUID has value (not Guid.Empty)
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void ValueIsNotEmpty()
        {
            HasValue();

            if (_target.Value == Guid.Empty)
            {
                throw new ArgumentOutOfRangeException(
                    _parameterName, "Input nullable GUID argument should have a value but found empty GUID");
            }
        }
        
        /// <summary>
        /// Check if the nullable GUID is empty (Guid.Empty)
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void ValueIsEmpty()
        {
            HasValue();

            if (_target.Value != Guid.Empty)
            {
                throw new ArgumentOutOfRangeException(
                    _parameterName, $"Input nullable GUID argument should be emtpy but found {_target.Value}");
            }
        }
    }
}