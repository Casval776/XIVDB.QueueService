using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Queue
{
    public class Queue
    {
        private Queue<string> ItemQueue;
        private static Queue instance;

        private Queue()
        {
            
            ItemQueue = new Queue<string>();
        }

        static Queue()
        {

        }

        public static Queue Instance
        {
            get
            {
                if (instance == null) instance = new Queue();
                return instance;
            }
        }
        public string Dequeue()
        {
            try
            {
                return Instance.ItemQueue.Dequeue();
            }
            catch(Exception e)
            {
                return string.Empty;
            }
        }

        public bool Enqueue(string item)
        {
            bool Success = false;
            try
            {
                Instance.ItemQueue.Enqueue(item);
                Success = true;
            }
            catch (Exception ex)
            {
                //@TODO: Add Logging here
                return Success;
            }
            return Success;
        }

        public IEnumerable<string> ViewQueue()
        {
            List<string> itemList = new List<string>();
            Parallel.ForEach(ItemQueue, (item) =>
            {
                itemList.Add(item);
            });
            //foreach (var item in ItemQueue)
            //{
            //    itemList.Add(item);
            //}
            return itemList;
        }
    }
}