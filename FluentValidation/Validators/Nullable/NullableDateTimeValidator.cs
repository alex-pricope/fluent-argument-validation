using System;
using FluentValidation.Criterias;

namespace FluentValidation.Validators.Nullable
{
    public sealed class NullableDateTimeValidator
    {
        private readonly DateTime? _target;

        public NullableDateTimeValidator(DateTime? inputDateTime)
        {
            _target = inputDateTime;
        }

        public AndCriteria<NullableDateTimeValidator> HasValue()
        {
            if (!_target.HasValue)
                throw new ArgumentOutOfRangeException($"Input nullable datetime argument should have a value but found null");

            return new AndCriteria<NullableDateTimeValidator>(this);
        }

        public void IsNull()
        {
            if (_target.HasValue)
                throw new ArgumentNullException(
                    $"Input nullable datetime argument should be null but found {_target.Value}");
        }

        public AndCriteria<NullableDateTimeValidator> IsValid()
        {
            HasValue();

            if (_target == DateTime.MinValue || _target == DateTime.MaxValue || _target == default(DateTime))
                throw new ArgumentOutOfRangeException($"Input nullable datetime argument should be valid but found {_target}");

            return new AndCriteria<NullableDateTimeValidator>(this);
        }
    }
}
