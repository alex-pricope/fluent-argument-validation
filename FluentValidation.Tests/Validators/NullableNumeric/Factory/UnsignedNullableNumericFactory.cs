namespace FluentValidation.Tests.Validators.NullableNumeric.Factory
{
    internal static class UnsignedNullableNumericFactory
    {
        public static uint? CreateUIntWithNull()
        {
            return (uint?) null;
        }

        public static uint? CreateUIntWithValue()
        {
            return (uint?) 123456;
        }

        public static ulong? CreateULongWithNull()
        {
            return (ulong?) null;
        }

        public static ulong? CreateULongWithValue()
        {
            return (ulong?) 4294967296;
        }

        public static byte? CreateByteWithNull()
        {
            return (byte?) null;
        }

        public static byte? CreateByteWithValue()
        {
            return (byte?) 233;
        }

        public static ushort? CreateUShortWithNull()
        {
            return (ushort?) null;
        }

        public static ushort? CreateUShortWithValue()
        {
            return (ushort?) 15_500;
        }
    }
}