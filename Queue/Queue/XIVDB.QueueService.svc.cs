using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class QueueService : IQueueService
    {
        private Queue thisQueue = Queue.Instance;
        public string Dequeue()
        {
            return thisQueue.Dequeue();
        }

        public bool Enqueue(string item)
        {
            return thisQueue.Enqueue(item);
        }

        public IEnumerable<string> ViewQueue()
        {
            return thisQueue.ViewQueue();
        }
    }
}
