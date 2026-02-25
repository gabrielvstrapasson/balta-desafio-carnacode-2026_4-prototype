using Project.Prototype;

namespace Project.ConcretePrototype
{
    public class DocumentStyle : IPrototype
    {
        public string FontFamily { get; set; }
        public int FontSize { get; set; }
        public string HeaderColor { get; set; }
        public string LogoUrl { get; set; }
        public Margins PageMargins { get; set; }

        public IPrototype Clone()
        {
            DocumentStyle style = (DocumentStyle)this.MemberwiseClone();
            style.PageMargins = (Margins)this.PageMargins.Clone();
            return style;
        }
    }

}
