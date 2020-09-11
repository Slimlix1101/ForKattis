using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForKattis
{
    class AlphabetSpam
    {
        static void Main(string[] args)
        {
            String input;
            Double total, counter;
            while ((input = Console.ReadLine()) != null)
            {
                total = input.Length;
                for (int time = 0; time < 4; time++)
                {
                    counter = 0;
                    switch (time)
                    {
                        case 0: // whitespace 
                            for (int i = 0; i < input.Length; i++)
                            {
                                if (input[i] == '_') counter++; 
                            }
                                break;
                        case 1: // lowercase
                            for (int i = 0; i < input.Length; i++)
                            {
                                if (input[i] >= 'a' && input[i]<='z') counter++;
                            }
                            break;
                        case 2: // uppercase
                            for (int i = 0; i < input.Length; i++)
                            {
                                if (input[i] >= 'A' && input[i] <= 'Z') counter++;
                            }
                            break;
                        case 3: // symbols
                            for (int i = 0; i < input.Length; i++)
                            {
                                if (input[i] == '_') continue;
                                if ((input[i] >= 'A' && input[i] <= 'Z') || (input[i] >= 'a' && input[i] <= 'z')) continue;
                                counter++;
                                
                            }
                            break;
                    }
                    Console.WriteLine("{0:0.0000000000}", counter / total);

                    
                }
                
            }
        }
    }
}
