using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjKolekcje
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("A");
            arr.Add("B");
            arr.Add("C");
            arr.Add("D");
            arr.Add("E");
            
            Dictionary<int, string> dic = new Dictionary<int, string>();

            for (int i = arr.Count; i > 0; i--)
            {
                int index = arr.Count - i;
                dic.Add(index, arr[i-1].ToString());
            }

            dic.Remove(3);           
        }
    }
}
