using GitHub;
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
            SecondClass sec = new SecondClass();
            sec.Second_Method1();
            sec.Second_Method2();
        }
        public void Method1()
        {
            Console.WriteLine("First method in main class");
            //Console.ReadLine();
        }
        public void Method2()
        {
            Console.WriteLine("Second method in main class");
            
        }
    }
}
