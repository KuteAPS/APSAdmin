using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ManagementMsmq
{
    public class MessageQueueHelper
    {
        public void AddMessageQueue(string path, string label, string body)
        {
            try
            {
                var mq = MessageQueue.Exists(path) ? new MessageQueue(path) : MessageQueue.Create(path);
                Message message = new Message();
                message.Label = label;
                message.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                message.Body = body;
                mq.Send(message);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
