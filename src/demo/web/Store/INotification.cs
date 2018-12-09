using System.Collections.Generic;

namespace web.Store
{
    public interface INotification
    {
        IList<string> ToAddresses { get; set; }
        IList<string> BccAddresses { get; set; }
        string MessageBody { get; set; }
        string Subject { get; set; }

        void Send();
    }
}