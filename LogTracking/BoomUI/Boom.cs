using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomUI
{
    public class Boom
    {
        private readonly ObservableListSource<Log> _logs = new ObservableListSource<Log>();
        private readonly ObservableListSource<BoomGear> _boomgear = new ObservableListSource<BoomGear>();
        private readonly ObservableListSource<BoomStick> _boomsticks = new ObservableListSource<BoomStick>();

        public int Id { get; set; }
        public virtual Location Location { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public virtual ObservableListSource<Log> Logs { get { return _logs; } }
        public virtual ObservableListSource<BoomGear> Boomgear { get { return _boomgear; } }
        public virtual ObservableListSource<BoomStick> Boomsticks { get { return _boomsticks; } }
        //public ICollection<Log> Logs { get; set; }
        //public IList<BoomGear> BoomGear { get; set; }
        //public IList<BoomStick> BoomSticks { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
