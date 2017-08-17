using System;
using FluentValidation.Criterias;

namespace FluentValidation.Validators
{
    public sealed class ObjectValidator
    {
        private readonly object _target;

        public ObjectValidator(object inputObject)
        {
            _target = inputObject;
        }

        public AndCriteria<ObjectValidator> IsNotNull()
        {
            if (_target == null)
                throw new ArgumentNullException($"Input object argument should be not null but found null");

            return new AndCriteria<ObjectValidator>(this);
        }

        public AndCriteria<ObjectValidator> IsOfType<T>(T ofType)
        {
            if (_target.GetType() != typeof(T))
                throw new ArgumentException(
                    $"Input object argument should be of type {typeof(T)} but found {_target.GetType()}");

            return new AndCriteria<ObjectValidator>(this);
        }

        public AndCriteria<ObjectValidator> IsReferenceType()
        {
            if (_target.GetType().IsValueType)
                throw new ArgumentException(
                    $"Input object argument should be a reference type but found value type");

            return new AndCriteria<ObjectValidator>(this);
        }
        public AndCriteria<ObjectValidator> IsValueType()
        {
            if (!_target.GetType().IsValueType)
                throw new ArgumentException(
                    $"Input object argument should be a value type but found reference type");

            return new AndCriteria<ObjectValidator>(this);
        }
    }
}
