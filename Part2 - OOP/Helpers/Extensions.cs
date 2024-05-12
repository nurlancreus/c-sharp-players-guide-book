using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2___OOP.Helpers
{
    public static class Extensions
    {
        public static string EnumFirstCharToUpper(this Enum input) =>
      input switch
      {
          null => throw new ArgumentNullException(nameof(input)),
          _ => string.Concat(input.ToString()[0].ToString().ToUpper(), input.ToString().AsSpan(1))
      };
    }
}
