using Project.Prototype;
using System.Collections.Generic;

namespace Project.ConcretePrototype
{
    public class ApprovalWorkflow : IPrototype
    {
        public List<string> Approvers { get; set; }
        public int RequiredApprovals { get; set; }
        public int TimeoutDays { get; set; }

        public ApprovalWorkflow()
        {
            Approvers = new List<string>();
        }

        public IPrototype Clone()
        {
            ApprovalWorkflow workFlow = (ApprovalWorkflow)this.MemberwiseClone();
            workFlow.Approvers = new List<string>(this.Approvers);
            return workFlow;
        }
    }

}
