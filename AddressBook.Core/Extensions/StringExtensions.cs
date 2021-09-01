using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBook.Core.Extensions
{
    public static class StringExtensions
    {
        public static bool TryParseEnum<T>(this string source, out T result) where T : struct
        {
            if (Enum.TryParse<T>(source, true, out result))
            {
                return true;
            }

            foreach (var field in typeof(T).GetFields())
            {
                 if (Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                 {
                    if (attribute.Description.EqualsIgnoreCase(source))
                    {
                        result = (T)field.GetValue(null);
                        return true;
                    }
                 }
            }

            result = default;
            return false;
        }

        public static bool EqualsIgnoreCase(this string source, string compare)
        {
            return source.Equals(compare, StringComparison.OrdinalIgnoreCase);
        }
    }


}