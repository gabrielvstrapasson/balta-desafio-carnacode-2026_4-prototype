using Project.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ConcretePrototype
{

    public class Margins : IPrototype
    {
        public int Top { get; set; }
        public int Bottom { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }

        public IPrototype Clone()
        {
            return (Margins)this.MemberwiseClone();
        }
    }
}
