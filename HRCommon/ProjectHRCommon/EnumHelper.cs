using system = System;
using System.Reflection;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon
{
    [ExcludeFromCodeCoverage]
    public static class EnumHelper
    {
        public static string GetEnumDescription(system.Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
            (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}
