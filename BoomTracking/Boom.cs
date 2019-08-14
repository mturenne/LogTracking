using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomTracking
{
    public class Boom
    {
        public int Id { get; set; }
        public Location Location { get; set; }
        public IList<Log> Logs { get; set; }
        public IList<BoomGear> BoomGear { get; set; }
        public IList<BoomStick> BoomSticks { get; set; }
    }
}
