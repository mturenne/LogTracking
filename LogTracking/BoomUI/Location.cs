using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomUI
{
    public class Location
    {
        private readonly ObservableListSource<Boom> _booms =
            new ObservableListSource<Boom>();

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ObservableListSource<Boom> Booms { get { return _booms; } }

        public override string ToString()
        {
            return Name;
        }
    }
}
