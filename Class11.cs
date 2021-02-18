////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace OopsConsoleApp
////{
////    class Class11
////    {
////        public SortedList<char,int> CharacterOccurances(string name)//eye
////        {
////            name = name.ToUpper();
////            SortedList<char, int> charoc = new SortedList<char, int>();
////            foreach(char ch in name)//eye
////            {
////                if (charoc.ContainsKey(ch))
////                {
////                    int val = charoc[ch];
////                    charoc.Remove(ch);
////                    charoc.Add(ch, val + 1);
////                }
////                else
////                {
////                    charoc.Add(ch, 1);
////                }
////            }
////            return charoc;
////        }
////        static void Main(string[] args)
////        {
////            Console.Write("Enater a Name : ");
////            string name = Console.ReadLine();
////            foreach(KeyValuePair<char,int> keyValuePair in new Class11().CharacterOccurances(name))
////            {
////                Console.WriteLine(keyValuePair);
////            }
////        }
////    }
////}
