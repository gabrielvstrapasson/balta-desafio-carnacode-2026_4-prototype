using Project.Prototype;
using System.Collections.Generic;
using System.Linq;

namespace Project.ConcretePrototype
{
    public class DocumentTemplate : IPrototype
    {

        public string Title { get; set; }
        public string Category { get; set; }
        public List<Section> Sections { get; set; }
        public DocumentStyle Style { get; set; }
        public List<string> RequiredFields { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public ApprovalWorkflow Workflow { get; set; }
        public List<string> Tags { get; set; }

        public DocumentTemplate()
        {
            Sections = new List<Section>();
            RequiredFields = new List<string>();
            Metadata = new Dictionary<string, string>();
            Tags = new List<string>();
        }

        public IPrototype Clone()
        {
            DocumentTemplate document = (DocumentTemplate)this.MemberwiseClone();
            document.Sections = this.Sections
                .Select(section => (Section)section.Clone())
                .ToList();

            document.Style = (DocumentStyle)this.Style.Clone();
            document.Workflow = (ApprovalWorkflow)this.Workflow.Clone();
            document.RequiredFields = new List<string>(this.RequiredFields);
            document.Tags = new List<string>(this.Tags);
            document.Metadata = new Dictionary<string, string>(this.Metadata);
            return document;
        }
    }
}
