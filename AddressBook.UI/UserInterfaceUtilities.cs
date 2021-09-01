using AddressBook.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.UI
{
    public static class UserInterfaceUtilities
    {
        public static T PromptUserValidateResponse<T>(string message, string errorMessage = default, Func<string, T> parseFunction = default)
        {
            T result;

            while (!TryPromptUser<T>(message, out result, parseFunction))
                Logger.LogError(errorMessage);

            return result;
        }

        public static int PromptUserForMenuOption(params string[] menuOptions)
        {
            return PromptUserValidateResponse<int>(CreateMenu(menuOptions), StringResources.InvalidMenuChoice, int.Parse);
        }

        private static string CreateMenu(string[] menuOptions)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = default; i < menuOptions.Length; i++)
            {
                builder.AppendLine($"{i + 1}. {menuOptions[i]}");
            }

            return builder.ToString();
        }

        private static bool TryPromptUser<T>(string message, out T result, Func<string, T> parseFunction = default)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (typeof(T) == typeof(string) && parseFunction == default)
            {
                result = (T)Convert.ChangeType(input, typeof(T));
                return true;
            }

            try
            {
                result = parseFunction(input);
            }
            catch
            {
                result = default;
                return false;
            }

            return true;
        }
    }
}
