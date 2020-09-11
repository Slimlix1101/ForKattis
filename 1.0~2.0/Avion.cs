using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForKattis
{
    class Avion
    {
        static void Main(string[] args)
        {
            bool exist;
            List<String> input = new List<string>();
            List<Int32> record = new List<Int32>();
            String get;
            while ((get = Console.ReadLine()) != null)
            {
                
                exist = false;
                input.Add(get);
                for (int i = 1; i <5; i++)
                {
                    get = Console.ReadLine();
                    input.Add(get);
                }
                for (int i = 0; i<5; i++)
                {
                    for (int k = 0; k<input[i].Length-2; k++)
                    {
                        if (input[i][k] == 'F')
                        {
                            if (input[i][k+1] == 'B')
                            {
                                if (input[i][k+2] == 'I') exist = true;
                                record.Add(i+1);
                            }
                        }
                            
                    }
                }
                if (!exist) Console.WriteLine("HE GOT AWAY!");
                else
                {
                    for (int i = 0; i<record.Count; i++)
                    {
                        Console.Write("{0} ", record[i]);
                    }
                    Console.Write('\n');
                }
                record.Clear();
                input.Clear();
            }

        }
    }
}
