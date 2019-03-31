namespace ChainOf
{
    using System.Collections.Generic;

    public class ApproverManager : IApproverManager
    {
        private readonly IEnumerable<IApprover> approvers;

        public ApproverManager(IEnumerable<IApprover> approvers)
        {
            this.approvers = approvers;
        }

        public void ProcessRequest(Purchase purchase)
        {
            foreach (var approver in approvers)
            {
                approver.ProcessRequest(purchase);
            }
        }
    }
}
