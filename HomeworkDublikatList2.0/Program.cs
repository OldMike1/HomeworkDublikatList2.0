using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDublikat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listarray = new List<int>()
            {
                1,2,3,3,7,12,3,3,7,12,3,3,7,12,3,3,7,12,3,3,7,12,3,3,7,1
            };
            List<int> listarrayNew = new List<int>();


            for (int i = 0; i < listarray.Count; i++)
            {
                bool b = false;
                for (int j = 0; j < listarrayNew.Count; j++)
                {
                    if (listarray[i] == listarrayNew[j])
                    {
                        b = true;
                        break;
                    }
                }
                if (b == false)
                    listarrayNew.Add(listarray[i]);
            }


            for (int y = 0; y < listarrayNew.Count; y++)
            {
                Console.WriteLine(listarrayNew[y]);
            }

        }
    }
}