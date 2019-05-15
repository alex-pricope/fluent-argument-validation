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
        public static NullableDateTimeValidator Check(this DateTime? inputDateTime, string parameterName = "")
        {
            return new NullableDateTimeValidator(inputDateTime, parameterName);
        }

        //NUMERIC
        [Pure]
        public static SignedNullableNumericValidator<int> Check(this int? inputValue, string parameterName = "")
        {
            return new SignedNullableNumericValidator<int>(inputValue, parameterName);
        }

        [Pure]
        public static UnsignedNullableNumericValidator<uint> Check(this uint? inputValue, string parameterName = "")
        {
            return new UnsignedNullableNumericValidator<uint>(inputValue, parameterName);
        }

        [Pure]
        public static SignedNullableNumericValidator<long> Check(this long? inputValue, string parameterName = "")
        {
            return new SignedNullableNumericValidator<long>(inputValue, parameterName);
        }

        [Pure]
        public static UnsignedNullableNumericValidator<ulong> Check(this ulong? inputValue, string parameterName = "")
        {
            return new UnsignedNullableNumericValidator<ulong>(inputValue, parameterName);
        }

        [Pure]
        public static SignedNullableNumericValidator<decimal> Check(this decimal? inputValue, string parameterName = "")
        {
            return new SignedNullableNumericValidator<decimal>(inputValue, parameterName);
        }

        [Pure]
        public static SignedNullableNumericValidator<float> Check(this float? inputValue, string parameterName = "")
        {
            return new SignedNullableNumericValidator<float>(inputValue, parameterName);
        }

        [Pure]
        public static SignedNullableNumericValidator<short> Check(this short? inputValue, string parameterName = "")
        {
            return new SignedNullableNumericValidator<short>(inputValue, parameterName);
        }

        [Pure]
        public static UnsignedNullableNumericValidator<ushort> Check(this ushort? inputValue, string parameterName = "")
        {
            return new UnsignedNullableNumericValidator<ushort>(inputValue, parameterName);
        }

        [Pure]
        public static UnsignedNullableNumericValidator<byte> Check(this byte? inputValue, string parameterName = "")
        {
            return new UnsignedNullableNumericValidator<byte>(inputValue, parameterName);
        }

        [Pure]
        public static SignedNullableNumericValidator<sbyte> Check(this sbyte? inputValue, string parameterName = "")
        {
            return new SignedNullableNumericValidator<sbyte>(inputValue, parameterName);
        }

        [Pure]
        public static SignedNullableNumericValidator<double> Check(this double? inputValue, string parameterName = "")
        {
            return new SignedNullableNumericValidator<double>(inputValue, parameterName);
        }
    }
}
