using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using FluentValidation.Validators;

namespace FluentValidation
{
    [DebuggerNonUserCode]
    public static class TypeExtensions
    {
        //OBJECT
        [Pure]
        public static ObjectValidator Check(this object inputObject)
        {
            return new ObjectValidator(inputObject);
        }

        //DATE_TIME
        [Pure]
        public static DateTimeValidator Check(this DateTime inputDateTime)
        {
            return new DateTimeValidator(inputDateTime);
        }

        //STRING
        [Pure]
        public static StringValidator Check(this string inputValue)
        {
            return new StringValidator(inputValue);
        }

        //IENUMERABLE
        [Pure]
        public static GenericCollectionValidator<T> Check<T>(this IEnumerable<T> inputCollection)
        {
            return new GenericCollectionValidator<T>(inputCollection);
        }

        //IDICTIONARY
        [Pure]
        public static GenericDictionaryValidator<TKey, TValue> Check<TKey, TValue>(this IDictionary<TKey, TValue> inputDictionary)
        {
            return new GenericDictionaryValidator<TKey, TValue>(inputDictionary);
        }

        //NUMERIC
        [Pure]
        public static NumericValidator<int> Check(this int inputValue)
        {
            return new NumericValidator<int>(inputValue);
        }

        [Pure]
        public static NumericValidator<uint> Check(this uint inputValue)
        {
            return new NumericValidator<uint>(inputValue);
        }

        [Pure]
        public static NumericValidator<long> Check(this long inputValue)
        {
            return new NumericValidator<long>(inputValue);
        }

        [Pure]
        public static NumericValidator<ulong> Check(this ulong inputValue)
        {
            return new NumericValidator<ulong>(inputValue);
        }

        [Pure]
        public static NumericValidator<decimal> Check(this decimal inputValue)
        {
            return new NumericValidator<decimal>(inputValue);
        }

        [Pure]
        public static NumericValidator<float> Check(this float inputValue)
        {
            return new NumericValidator<float>(inputValue);
        }

        [Pure]
        public static NumericValidator<short> Check(this short inputValue)
        {
            return new NumericValidator<short>(inputValue);
        }

        [Pure]
        public static NumericValidator<ushort> Check(this ushort inputValue)
        {
            return new NumericValidator<ushort>(inputValue);
        }

        [Pure]
        public static NumericValidator<byte> Check(this byte inputValue)
        {
            return new NumericValidator<byte>(inputValue);
        }

        [Pure]
        public static NumericValidator<sbyte> Check(this sbyte inputValue)
        {
            return new NumericValidator<sbyte>(inputValue);
        }

        [Pure]
        public static NumericValidator<double> Check(this double inputValue)
        {
            return new NumericValidator<double>(inputValue);
        }
    }
}
