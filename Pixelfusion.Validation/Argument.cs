using System;

namespace Pixelfusion.Validation
{
    /// <summary>
    /// This class does Argument Validation
    /// </summary>
    public static class Argument
    {
        public static void ValidateObject(object input)
        {
            if (input is null) throw new ArgumentNullException(nameof(input));
        }
    }
}
