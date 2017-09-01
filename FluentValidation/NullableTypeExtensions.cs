using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using FluentValidation.Validators;

namespace FluentValidation
{
    /// <summary>
    /// Nullable types extension methods
    /// </summary>
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
        public static SignedNullableNumericValidator<int> Check(this int? inputValue)
        {
            return new SignedNullableNumericValidator<int>(inputValue);
        }

        [Pure]
        public static UnsignedNullableNumericValidator<uint> Check(this uint? inputValue)
        {
            return new UnsignedNullableNumericValidator<uint>(inputValue);
        }

        [Pure]
        public static SignedNullableNumericValidator<long> Check(this long? inputValue)
        {
            return new SignedNullableNumericValidator<long>(inputValue);
        }

        [Pure]
        public static UnsignedNullableNumericValidator<ulong> Check(this ulong? inputValue)
        {
            return new UnsignedNullableNumericValidator<ulong>(inputValue);
        }

        [Pure]
        public static SignedNullableNumericValidator<decimal> Check(this decimal? inputValue)
        {
            return new SignedNullableNumericValidator<decimal>(inputValue);
        }

        [Pure]
        public static SignedNullableNumericValidator<float> Check(this float? inputValue)
        {
            return new SignedNullableNumericValidator<float>(inputValue);
        }

        [Pure]
        public static SignedNullableNumericValidator<short> Check(this short? inputValue)
        {
            return new SignedNullableNumericValidator<short>(inputValue);
        }

        [Pure]
        public static UnsignedNullableNumericValidator<ushort> Check(this ushort? inputValue)
        {
            return new UnsignedNullableNumericValidator<ushort>(inputValue);
        }

        [Pure]
        public static UnsignedNullableNumericValidator<byte> Check(this byte? inputValue)
        {
            return new UnsignedNullableNumericValidator<byte>(inputValue);
        }

        [Pure]
        public static SignedNullableNumericValidator<sbyte> Check(this sbyte? inputValue)
        {
            return new SignedNullableNumericValidator<sbyte>(inputValue);
        }

        [Pure]
        public static SignedNullableNumericValidator<double> Check(this double? inputValue)
        {
            return new SignedNullableNumericValidator<double>(inputValue);
        }
    }
}
