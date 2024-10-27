namespace FluentValidation.Tests.Validators.NullableNumeric.Factory;

internal static class UnsignedNullableNumericFactory
{
    public static uint? CreateUIntWithNull()
    {
        return null;
    }

    public static uint? CreateUIntWithValue()
    {
        return (uint?) 123456;
    }

    public static ulong? CreateULongWithNull()
    {
        return null;
    }

    public static ulong? CreateULongWithValue()
    {
        return (ulong?) 4294967296;
    }

    public static byte? CreateByteWithNull()
    {
        return null;
    }

    public static byte? CreateByteWithValue()
    {
        return (byte?) 233;
    }

    public static ushort? CreateUShortWithNull()
    {
        return null;
    }

    public static ushort? CreateUShortWithValue()
    {
        return (ushort?) 15_500;
    }
}