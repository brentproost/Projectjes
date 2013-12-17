using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PanoramaApp3.Classes
{
    public static class InputDatabase
    {
        public static TimeSpan FromHour { get; set; }
        public static TimeSpan ToHour { get; set; }
        public static string Date { get; set; }
        public static int WeersomstandighedenIDs { get; set; }
        public static int NachtrustIDs { get; set; }
        public static int UrenSlaap { get; set; }
        public static float Vermoeidheid { get; set; }
        public static float Belangrijk { get; set; }
        public static float Tevredenheid { get; set; }
        public static int ActivityID { get; set; }
    }
}
