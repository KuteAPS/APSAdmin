using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ManagementMsmq
{
    public class MsmqBeginReceive
    {

        private static MessageQueue msmqQueue;

        public static void GetmsmqQueueMessageQueues()
        {
            try
            {
                var path = ".\\private$\\msmqQueue"; //操作队列的名字
                msmqQueue = MessageQueue.Exists(path) ? new MessageQueue(path) : MessageQueue.Create(path);
                msmqQueue.Formatter = new XmlMessageFormatter(new[] { typeof(string) });
                msmqQueue.ReceiveCompleted += mq_ReceiveCompletedmsmqQueue;
                msmqQueue.BeginReceive();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void mq_ReceiveCompletedmsmqQueue(object sender, ReceiveCompletedEventArgs e)
        {
            try
            {
                var mq = (MessageQueue)sender;
                var m = mq.EndReceive(e.AsyncResult);

                //根据消息标签执行相应的命令
                if (m.Label.ToLower() == "CADAPSDATA".ToLower())
                {
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                //继续下一条消息
                msmqQueue.BeginReceive();
            }
        }

    }
}
