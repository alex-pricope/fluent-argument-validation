using System;
using FluentValidation.Criterias;

namespace FluentValidation.Validators
{
    public sealed class DateTimeValidator
    {
        private readonly DateTime _target;

        public DateTimeValidator(DateTime inputDateTime)
        {
            _target = inputDateTime;
        }

        public AndCriteria<DateTimeValidator> IsValid()
        {
            if (_target == DateTime.MinValue || _target == DateTime.MaxValue || _target == default(DateTime))
                throw new ArgumentOutOfRangeException($"Input datetime argument should be valid but found {_target}");

            return new AndCriteria<DateTimeValidator>(this);
        }
    }
}
