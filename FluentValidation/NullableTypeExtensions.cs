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
        public static NullableDateTimeValidator Check(this DateTime? input, string argName = "")
        {
            return new NullableDateTimeValidator(input, argName);
        }
        
        //BOOLEAN
        [Pure]
        public static NullableBooleanValidator Check(this bool? input, string argName = "")
        {
            return new NullableBooleanValidator(input, argName);
        }
        
        //GUID
        [Pure]
        public static NullableGuidValidator Check(this Guid? input, string argName = "")
        {
            return new NullableGuidValidator(input, argName);
        }
        
        //NUMERIC
        [Pure]
        public static SignedNullableNumericValidator<int> Check(this int? input, string argName = "")
        {
            return new SignedNullableNumericValidator<int>(input, argName);
        }

        [Pure]
        public static UnsignedNullableNumericValidator<uint> Check(this uint? input, string argName = "")
        {
            return new UnsignedNullableNumericValidator<uint>(input, argName);
        }

        [Pure]
        public static SignedNullableNumericValidator<long> Check(this long? input, string argName = "")
        {
            return new SignedNullableNumericValidator<long>(input, argName);
        }

        [Pure]
        public static UnsignedNullableNumericValidator<ulong> Check(this ulong? input, string argName = "")
        {
            return new UnsignedNullableNumericValidator<ulong>(input, argName);
        }

        [Pure]
        public static SignedNullableNumericValidator<decimal> Check(this decimal? input, string argName = "")
        {
            return new SignedNullableNumericValidator<decimal>(input, argName);
        }

        [Pure]
        public static SignedNullableNumericValidator<float> Check(this float? input, string argName = "")
        {
            return new SignedNullableNumericValidator<float>(input, argName);
        }

        [Pure]
        public static SignedNullableNumericValidator<short> Check(this short? input, string argName = "")
        {
            return new SignedNullableNumericValidator<short>(input, argName);
        }

        [Pure]
        public static UnsignedNullableNumericValidator<ushort> Check(this ushort? input, string argName = "")
        {
            return new UnsignedNullableNumericValidator<ushort>(input, argName);
        }

        [Pure]
        public static UnsignedNullableNumericValidator<byte> Check(this byte? input, string argName = "")
        {
            return new UnsignedNullableNumericValidator<byte>(input, argName);
        }

        [Pure]
        public static SignedNullableNumericValidator<sbyte> Check(this sbyte? input, string argName = "")
        {
            return new SignedNullableNumericValidator<sbyte>(input, argName);
        }

        [Pure]
        public static SignedNullableNumericValidator<double> Check(this double? input, string argName = "")
        {
            return new SignedNullableNumericValidator<double>(input, argName);
        }
    }
}
