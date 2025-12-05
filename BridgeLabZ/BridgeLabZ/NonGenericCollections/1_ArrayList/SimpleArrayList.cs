using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.NonGenericCollections._1_ArrayList
{
    public class SimpleArrayList
    {
        public static void Main(String[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Dilshad");
            list.Add(15.5);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

       
    }
}
