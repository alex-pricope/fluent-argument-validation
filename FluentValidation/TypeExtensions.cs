using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using FluentValidation.Validators;

namespace FluentValidation
{
    /// <summary>
    /// Extension methods
    /// </summary>
    [DebuggerNonUserCode]
    public static class TypeExtensions
    {
        //OBJECT
        [Pure]
        public static ObjectValidator Check(this object input, string argName = "")
        {
            return new ObjectValidator(input, argName);
        }

        //DATE_TIME
        [Pure]
        public static DateTimeValidator Check(this DateTime input, string argName = "")
        {
            return new DateTimeValidator(input, argName);
        }

        //STRING
        [Pure]
        public static StringValidator Check(this string input, string argName = "")
        {
            return new StringValidator(input, argName);
        }

        //IENUMERABLE
        [Pure]
        public static GenericCollectionValidator<T> Check<T>(this IEnumerable<T> input, string argName = "")
        {
            return new GenericCollectionValidator<T>(input, argName);
        }

        //IDICTIONARY
        [Pure]
        public static GenericDictionaryValidator<TKey, TValue> Check<TKey, TValue>(this IDictionary<TKey, TValue> input, string argName = "")
        {
            return new GenericDictionaryValidator<TKey, TValue>(input, argName);
        }
        
        //BOOLEAN
        [Pure]
        public static BooleanValidator Check(this bool input, string argName = "")
        {
            return new BooleanValidator(input, argName);
        }
        
        //GUID
        [Pure]
        public static GuidValidator Check(this Guid input, string argName = "")
        {
            return new GuidValidator(input, argName);
        }

        //NUMERIC
        [Pure]
        public static NumericValidator<int> Check(this int input, string argName = "")
        {
            return new NumericValidator<int>(input, argName);
        }

        [Pure]
        public static NumericValidator<uint> Check(this uint input, string argName = "")
        {
            return new NumericValidator<uint>(input, argName);
        }

        [Pure]
        public static NumericValidator<long> Check(this long input, string argName = "")
        {
            return new NumericValidator<long>(input, argName);
        }

        [Pure]
        public static NumericValidator<ulong> Check(this ulong input, string argName = "")
        {
            return new NumericValidator<ulong>(input, argName);
        }

        [Pure]
        public static NumericValidator<decimal> Check(this decimal input, string argName = "")
        {
            return new NumericValidator<decimal>(input, argName);
        }

        [Pure]
        public static NumericValidator<float> Check(this float input, string argName = "")
        {
            return new NumericValidator<float>(input, argName);
        }

        [Pure]
        public static NumericValidator<short> Check(this short input, string argName = "")
        {
            return new NumericValidator<short>(input, argName);
        }

        [Pure]
        public static NumericValidator<ushort> Check(this ushort input, string argName = "")
        {
            return new NumericValidator<ushort>(input, argName);
        }

        [Pure]
        public static NumericValidator<byte> Check(this byte input, string argName = "")
        {
            return new NumericValidator<byte>(input, argName);
        }

        [Pure]
        public static NumericValidator<sbyte> Check(this sbyte input, string argName = "")
        {
            return new NumericValidator<sbyte>(input, argName);
        }

        [Pure]
        public static NumericValidator<double> Check(this double input, string argName = "")
        {
            return new NumericValidator<double>(input, argName);
        }
    }
}
