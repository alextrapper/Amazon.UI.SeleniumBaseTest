using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.UI.SeleniumBaseTests.Helpers.Config
{
    public class AppConfig
    {
        public string BaseURL { get; set; }
        public DriverToUse DriverToUse { get; set; }
    }

    public class DriverToUse
    {
        public Browser Type { get; set; }
        public List<string> Arguments { get; set; }
        public TimeOuts TimeOuts { get; set; }
    }

    public class TimeOuts
    {
        public double ImplicitWait { get; set; }
        public double ExplicitWait { get; set; }
    }
}
