using Project.Prototype;
using System.Collections.Generic;

namespace Project.ConcretePrototype
{
    public class Section : IPrototype
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public bool IsEditable { get; set; }
        public List<string> Placeholders { get; set; }

        public Section()
        {
            Placeholders = new List<string>();
        }

        public IPrototype Clone()
        {
            Section section = (Section)this.MemberwiseClone();
            section.Placeholders = new List<string>(this.Placeholders);
            return section;
        }
    }
}
