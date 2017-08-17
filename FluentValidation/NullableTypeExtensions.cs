using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using FluentValidation.Validators.Nullable;

namespace FluentValidation
{
    [DebuggerNonUserCode]
    public static class NullableTypeExtensions
    {
        //DATE_TIME
        [Pure]
        public static NullableDateTimeValidator Check(this DateTime? inputDateTime)
        {
            return new NullableDateTimeValidator(inputDateTime);
        }

        //NUMERIC
        [Pure]
        public static NullableNumericValidator<int> Check(this int? inputValue)
        {
            return new NullableNumericValidator<int>(inputValue);
        }

        [Pure]
        public static NullableNumericValidator<uint> Check(this uint? inputValue)
        {
            return new NullableNumericValidator<uint>(inputValue);
        }

        [Pure]
        public static NullableNumericValidator<long> Check(this long? inputValue)
        {
            return new NullableNumericValidator<long>(inputValue);
        }

        [Pure]
        public static NullableNumericValidator<ulong> Check(this ulong? inputValue)
        {
            return new NullableNumericValidator<ulong>(inputValue);
        }

        [Pure]
        public static NullableNumericValidator<decimal> Check(this decimal? inputValue)
        {
            return new NullableNumericValidator<decimal>(inputValue);
        }

        [Pure]
        public static NullableNumericValidator<float> Check(this float? inputValue)
        {
            return new NullableNumericValidator<float>(inputValue);
        }

        [Pure]
        public static NullableNumericValidator<short> Check(this short? inputValue)
        {
            return new NullableNumericValidator<short>(inputValue);
        }

        [Pure]
        public static NullableNumericValidator<ushort> Check(this ushort? inputValue)
        {
            return new NullableNumericValidator<ushort>(inputValue);
        }

        [Pure]
        public static NullableNumericValidator<byte> Check(this byte? inputValue)
        {
            return new NullableNumericValidator<byte>(inputValue);
        }

        [Pure]
        public static NullableNumericValidator<sbyte> Check(this sbyte? inputValue)
        {
            return new NullableNumericValidator<sbyte>(inputValue);
        }

        [Pure]
        public static NullableNumericValidator<double> Check(this double? inputValue)
        {
            return new NullableNumericValidator<double>(inputValue);
        }
    }
}
