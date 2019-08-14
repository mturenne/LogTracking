using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomTracking
{
    public class Log
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public double Volume { get; set; }
        public bool Consumed { get; set; }
        public Boom Boom { get; set; }
    }
}
