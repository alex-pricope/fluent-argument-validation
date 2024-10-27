using System;

namespace FluentValidation.Tests.Validators.NullableGuid.Factory;

public static class NullableGuidFactory
{
    public static Guid? CreateNullGuid()
    {
        return null;
    }
    
    public static Guid? CreateEmptyGuid()
    {
        return Guid.Empty;
    }
    
    public static Guid? CreateGuid()
    {
        return Guid.NewGuid();
    }
}