using System;

namespace FluentValidation.Validators
{
    /// <summary>
    /// Validation class for a generic object
    /// </summary>
    public sealed class ObjectValidator
    {
        private readonly object _target;

        internal ObjectValidator(object inputObject)
        {
            _target = inputObject;
        }

        /// <summary>
        /// Check if the object is not null
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AndCriteria<ObjectValidator> IsNotNull()
        {
            if (_target == null)
                throw new ArgumentNullException($"Input object argument should be not null but found null");

            return new AndCriteria<ObjectValidator>(this);
        }

        /// <summary>
        /// Check if the object is of type T
        /// </summary>
        /// <typeparam name="T">The expected type</typeparam>
        /// <param name="ofType">The expected type</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AndCriteria<ObjectValidator> IsOfType<T>(T ofType)
        {
            if (_target.GetType() != typeof(T))
                throw new ArgumentException(
                    $"Input object argument should be of type {typeof(T)} but found {_target.GetType()}");

            return new AndCriteria<ObjectValidator>(this);
        }

        /// <summary>
        /// Check if the object is a reference type (not value type)
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AndCriteria<ObjectValidator> IsReferenceType()
        {
            if (_target.GetType().IsValueType)
                throw new ArgumentException(
                    $"Input object argument should be a reference type but found value type");

            return new AndCriteria<ObjectValidator>(this);
        }

        /// <summary>
        /// Check if the object is a value type (not reference type)
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AndCriteria<ObjectValidator> IsValueType()
        {
            if (!_target.GetType().IsValueType)
                throw new ArgumentException(
                    $"Input object argument should be a value type but found reference type");

            return new AndCriteria<ObjectValidator>(this);
        }
    }
}
