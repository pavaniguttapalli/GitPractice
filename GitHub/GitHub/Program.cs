using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubPractice
{
    public class Git
    {
        public static void Main(String[] args)
        
        {
            Console.WriteLine("Main method");
            Git ins = new Git();
            ins.Method1();
            ins.Method2();
        }
        public void Method1()
        {
            Console.WriteLine("First method");
            //Console.ReadLine();
        }
        public void Method2()
        {
            Console.WriteLine("Second method");
            Console.ReadLine();
        }
    }
}
