using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomTracking
{
    public class Log
    {
        private readonly ObservableListSource<Boom> _boom =
            new ObservableListSource<Boom>();
        public int Id { get; set; }
        public string Species { get; set; }
        public double Volume { get; set; }
        public bool Consumed { get; set; }
        public Boom Boom { get; set; }

        public virtual ObservableListSource<Boom> Booms { get { return _boom; } }
    }
}
