using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomUI
{
    public class Boom
    {

        public int Id { get; set; }
        public virtual Location Location { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public IList<Log> Logs { get; set; }
        public IList<BoomGear> BoomGear { get; set; }
        public IList<BoomStick> BoomSticks { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
