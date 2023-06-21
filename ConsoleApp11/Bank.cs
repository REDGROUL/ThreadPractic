using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Bank
    {
        private int money;
        public int Money
        {
            get
            {
                return money;
            }
            set
            {

                if (money != value)
                {
                    money = value;

                    new Thread(() => {

                        if (File.Exists("hehe.txt"))
                        {
                            using (StreamWriter sr = new StreamWriter("hehe.txt"))
                            {
                                sr.WriteLine(money);
                                Console.WriteLine(money);

                            }
                        }
                    }).Start();
                }
            }
        }


        public int percent;

        public string name;
        public Bank(int mon, int per, string n)
        {
            money = mon;
            percent = per;
            name = n;
        }



    }
}
