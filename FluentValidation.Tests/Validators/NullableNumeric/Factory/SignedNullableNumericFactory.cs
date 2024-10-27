namespace FluentValidation.Tests.Validators.NullableNumeric.Factory;

internal static class SignedNullableNumericFactory
{
    public static int? CreateIntWithNull()
    {
        return null;
    }

    public static int? CreateIntWithPositiveValue()
    {
        return 123456;
    }

    public static int? CreateIntWithNegativeValue()
    {
        return -123456;
    }

    public static long? CreateLongWithNull()
    {
        return null;
    }

    public static long? CreateLongWithPositiveValue()
    {
        return 4294967296;
    }

    public static long? CreateLongWithNegativeValue()
    {
        return -4294967296;
    }

    public static decimal? CreateDecimalWithNull()
    {
        return null;
    }

    public static decimal? CreateDecimalWithPositiveValue()
    {
        return 300.5m;
    }

    public static decimal? CreateDecimalWithNegativeValue()
    {
        return -300.5m;
    }

    public static float? CreateFloatWithNull()
    {
        return null;
    }

    public static float? CreateFloatWithPositiveValue()
    {
        return 345.55F;
    }

    public static float? CreateFloatWithNegativeValue()
    {
        return -345.55F;
    }

    public static short? CreateShortWithNull()
    {
        return null;
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
        return null;
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