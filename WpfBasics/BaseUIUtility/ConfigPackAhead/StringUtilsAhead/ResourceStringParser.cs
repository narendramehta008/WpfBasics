using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseUIUtility.ConfigPackAhead.StringUtilsAhead
{
    public static partial class ResourceStringParser
    {
        public static string GetResourceString(this string ResourceKey)
            => App.Current.FindResource(ResourceKey).ToString();
    }
}
