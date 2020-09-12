using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ForKattis
{
    class AnagramCounting
    {
        static List<char> fac_multiply(int input, List<char> number) 
        {
            Int32 temp;
            if (input == 1) return number;
            else if (input > 1 && input < 10) {
                for (int k = 2; k <= input; k++)
                    for (int i = 0; i<number.Count; i++)
                    {
                        temp = (number[i]-'0') * k;
                        if (temp < 10) number[i] = (char)temp;
                        else
                        {
                            if (i == number.Count-1)
                            {
                                number.Add((char)(temp / 10));
                                number[i] = (char)(temp % 10);
                                break;
                            }
                            number[i + 1] = (char)(temp/10);
                            number[i] = (char)(temp % 10);
                        }
                    }
            }
            else
            {
                for (int k = 2; k <= input; k++)
                {
                    if (k < 10)
                    {
                        for (int i = 0; i < number.Count; i++)
                        {
                            temp = (number[i] - '0') * k;
                            if (temp < 10) number[i] = (char)temp;
                            else
                            {
                                if (i == number.Count - 1)
                                {
                                  number.Add((char)(temp / 10));
                                  number[i] = (char)(temp % 10);
                                  break;
                                }
                                 number[i + 1] = (char)(temp / 10);
                                 number[i] = (char)(temp % 10);
                            }
                        }
                    } else
                    {

                    }
                    
                }
                    

            }
                
            return number;
        }
        static List<char> fac_divide(int input, List<char> number)
        {
            Int32 temp, left;
            char divide; // 被除數
            if (input == 1) return number;
            for (int k = 2; k <= input; k++)
            {
                divide = number[0];
                temp = 0; //
                left = 0; // 餘數
                for (int i = number.Count-1; i >= 0; i--)
                {
                    temp = (divide - '0') / k;
                    left += (divide - '0') % k;
                    if (temp > 0) // can be divided
                    {
                        number[i] = (char)temp; // change number
                        divide = left*10

                    }
                }
            }
               
        }


        static void Main(string[] args)
        {
            String input;
            Byte counter; // 0 < counter <= 100
            List<Int32> record = new List<int>(); // A list to record total appearance for each character
            while ((input = Console.ReadLine()) != null)
            {
                char[] process = new char[input.Length]; 
                List<char> ans = new List<char>(); // ans is too big, thus using a char list
                for (int i = 0; i < input.Length; i++)
                    process[i] = input[i]; // transfering string to char array
                Array.Sort(process);
                counter = 1;
                for (int i = 0; i < input.Length-1; i++)
                {
                    if (process[i] == process[i + 1]) counter++;
                    else
                    {
                        record.Add(counter);
                        counter = 1; 
                    }
                }
                record.Add(counter);
                /*for (int i = 0; i < record.Count; i++)
                    Console.Write("{0} ", record[i]);*/
                ans.Add('1');
                ans = fac_multiply(input.Length, ans); 
                for (int i=0; i<record.Count; i++)
                {
                    if (record[i] == 1) continue;
                    ans = fac_divide(record[i], ans);
                }
                Console.WriteLine("{0}", ans);
                record.Clear();

            }
        }
    }
}
