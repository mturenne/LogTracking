using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomUI
{
    public class BoomStick
    {
        public int Id { get; set; }
        public bool Consumed { get; set; }
        public string Species { get; set; }
        public Boom Boom { get; set; }
    }
}
