using System;

namespace FluentValidation.Tests.Validators.Factory;

internal static class TypeFactory
{
    public static bool CreateBooleanTrue()
    {
        return true;
    }
    
    public static bool CreateBooleanFalse()
    {
        return false;
    }
    
    public static Guid CreateEmptyGuid()
    {
        return Guid.Empty;
    }

    public static Guid CreateGuid()
    {
        return Guid.NewGuid();
    }
}