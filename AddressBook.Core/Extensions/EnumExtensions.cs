using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Core.Extensions
{
    public static class EnumExtensions
    {
        public static T ParseEnum<T>(string source) where T : struct
        {
            if (Enum.TryParse<T>(source, true, out var result))
            {
                return result;
            }

            foreach (var field in typeof(T).GetFields())
            {
                if (Attribute.GetCustomAttribute(field,
                   typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description.EqualsIgnoreCase(source))
                    {
                        return (T)field.GetValue(null);
                    }
                }
            }

            throw new Exception("Unable to parse enum");
        }
    }
}
