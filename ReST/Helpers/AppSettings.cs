using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReST.Helpers
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public int MyProperty { get; set; }
        public InnerSetting Inner { get; set; }
    }
    public class InnerSetting
    {
        public string key1 { get; set; }
    }
}
