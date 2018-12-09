using System.Collections.Generic;

namespace web.Store
{
    public class SmsNotification
        : INotification
    {
        public IList<string> ToAddresses { get; set; }
        public string MessageBody { get; set; }
        public string Subject { get; set; }
        public IList<string> BccAddresses { get; set; }

        public void Send()
        {

        }

    }
}