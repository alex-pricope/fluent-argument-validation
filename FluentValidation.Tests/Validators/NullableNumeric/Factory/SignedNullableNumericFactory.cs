namespace FluentValidation.Tests.Validators.NullableNumeric.Factory
{
    internal static class SignedNullableNumericFactory
    {
        public static int? CreateIntWithNull()
        {
            return (int?) null;
        }

        public static int? CreateIntWithPositiveValue()
        {
            return (int?) 123456;
        }

        public static int? CreateIntWithNegativeValue()
        {
            return (int?) -123456;
        }

        public static long? CreateLongWithNull()
        {
            return (long?) null;
        }

        public static long? CreateLongWithPositiveValue()
        {
            return (long?) 4294967296;
        }

        public static long? CreateLongWithNegativeValue()
        {
            return (long?) -4294967296;
        }

        public static decimal? CreateDecimalWithNull()
        {
            return (decimal?) null;
        }

        public static decimal? CreateDecimalWithPositiveValue()
        {
            return (decimal?) 300.5m;
        }

        public static decimal? CreateDecimalWithNegativeValue()
        {
            return (decimal?) -300.5m;
        }

        public static float? CreateFloatWithNull()
        {
            return (float?) null;
        }

        public static float? CreateFloatWithPositiveValue()
        {
            return (float?) 345.55F;
        }

        public static float? CreateFloatWithNegativeValue()
        {
            return (float?) -345.55F;
        }

        public static short? CreateShortWithNull()
        {
            return (short?) null;
        }

        public static short? CreateShortWithPositiveValue()
        {
            return (short?) 31_000;
        }

        public static short? CreateShortWithNegativeValue()
        {
            return (short?) -31_000;
        }

        public static sbyte? CreateSbyteWithNull()
        {
            return (sbyte?) null;
        }

        public static sbyte? CreateSbyteWithPositiveValue()
        {
            return (sbyte?) 102;
        }

        public static sbyte? CreateSbyteWithNegativeValue()
        {
            return (sbyte?) -102;
        }
    }
}