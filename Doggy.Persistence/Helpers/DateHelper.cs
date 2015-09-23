using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doggy.Persistence.Helpers
{
    using Chronic;

    internal static class DateHelper
    {
        public static DateTime Parse(string dateValue)
        {
            var parser = new Parser();
            var span = parser.Parse(dateValue);

            return span.ToTime();
        }
    }
}
