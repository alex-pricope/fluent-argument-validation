namespace FluentValidation.Tests.Validators.NullableBoolean.Factory;

internal static class NullableBooleanFactory
{
    public static bool? CreateNullBoolean()
    {
        return null;
    }
    
    public static bool? CreateTrueBoolean()
    {
        return true;
    }
    
    public static bool? CreateFalseBoolean()
    {
        return false;
    }
}