using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            B1 b11 = new B1();
            Console.Write(b11.Sum(30));
            Console.ReadKey();
            //B b = new B();
            //b.PF();
            // B b = new B();
            // b.f(new A() {void getval(int n){ print(n * n); }})//匿名类创建的对象作为参数，将该对象的引用船队给方法f的参数a。
            // b.f(new A1() { void getval(int n){Console.WriteLine() } })
        }

        class A1
        {
            public void getval(int n) { Console.WriteLine("0"); }
        }
        class B1
        {
            public double Sum(int a)
            {
                double b = 0;
                for (int i = 0; i < a; i++)
                {
                    b += Math.Pow(2, i);
                }
                return b;
            }
            public void f(A1 a) { a.getval(3); }
        }


        public class A
        {
            public A() { PF(); }
            public virtual void PF() { }
        }
        public class B : A
        {
            int x = 1;
            int y;
            public B() { y = -1; }
            public override void PF() { Console.WriteLine("x = {0},y = {1}", x, y); Console.ReadKey(); }

        }



    }
}