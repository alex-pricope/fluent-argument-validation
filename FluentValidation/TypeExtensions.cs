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
        public static ObjectValidator Check(this object inputObject, string parameterName = "")
        {
            return new ObjectValidator(inputObject, parameterName);
        }

        //DATE_TIME
        [Pure]
        public static DateTimeValidator Check(this DateTime inputDateTime, string parameterName = "")
        {
            return new DateTimeValidator(inputDateTime, parameterName);
        }

        //STRING
        [Pure]
        public static StringValidator Check(this string inputValue, string parameterName = "")
        {
            return new StringValidator(inputValue, parameterName);
        }

        //IENUMERABLE
        [Pure]
        public static GenericCollectionValidator<T> Check<T>(this IEnumerable<T> inputCollection, string parameterName = "")
        {
            return new GenericCollectionValidator<T>(inputCollection, parameterName);
        }

        //IDICTIONARY
        [Pure]
        public static GenericDictionaryValidator<TKey, TValue> Check<TKey, TValue>(this IDictionary<TKey, TValue> inputDictionary, string parameterName = "")
        {
            return new GenericDictionaryValidator<TKey, TValue>(inputDictionary, parameterName);
        }

        //NUMERIC
        [Pure]
        public static NumericValidator<int> Check(this int inputValue, string parameterName = "")
        {
            return new NumericValidator<int>(inputValue, parameterName);
        }

        [Pure]
        public static NumericValidator<uint> Check(this uint inputValue, string parameterName = "")
        {
            return new NumericValidator<uint>(inputValue, parameterName);
        }

        [Pure]
        public static NumericValidator<long> Check(this long inputValue, string parameterName = "")
        {
            return new NumericValidator<long>(inputValue, parameterName);
        }

        [Pure]
        public static NumericValidator<ulong> Check(this ulong inputValue, string parameterName = "")
        {
            return new NumericValidator<ulong>(inputValue, parameterName);
        }

        [Pure]
        public static NumericValidator<decimal> Check(this decimal inputValue, string parameterName = "")
        {
            return new NumericValidator<decimal>(inputValue, parameterName);
        }

        [Pure]
        public static NumericValidator<float> Check(this float inputValue, string parameterName = "")
        {
            return new NumericValidator<float>(inputValue, parameterName);
        }

        [Pure]
        public static NumericValidator<short> Check(this short inputValue, string parameterName = "")
        {
            return new NumericValidator<short>(inputValue, parameterName);
        }

        [Pure]
        public static NumericValidator<ushort> Check(this ushort inputValue, string parameterName = "")
        {
            return new NumericValidator<ushort>(inputValue, parameterName);
        }

        [Pure]
        public static NumericValidator<byte> Check(this byte inputValue, string parameterName = "")
        {
            return new NumericValidator<byte>(inputValue, parameterName);
        }

        [Pure]
        public static NumericValidator<sbyte> Check(this sbyte inputValue, string parameterName = "")
        {
            return new NumericValidator<sbyte>(inputValue, parameterName);
        }

        [Pure]
        public static NumericValidator<double> Check(this double inputValue, string parameterName = "")
        {
            return new NumericValidator<double>(inputValue, parameterName);
        }
    }
}
