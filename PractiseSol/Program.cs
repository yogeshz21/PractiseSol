using System;
using System.Text;

namespace PractiseSol
{
    class Program
    {
        static void Main(string[] args)
        {

            Test T = new();
            T.getMethod();
            //  ************* ABSTRACT EXP **************
            //  *****************************************
            //A s = new Sample();
            //s.TestMethod(2, 3);
            
            Console.ReadKey();
        }

        #region ABSTRACT EXP

        abstract class A
        {
            public virtual void TestMethod(int i, int j)
            {
                Console.WriteLine("class A => TestMethod()");
            }

            public virtual void TestMethod(int i, int j, int k)
            {
                Console.WriteLine("class A => overload TestMethod()");
            }
            public abstract void TestMethodB();


        }

        abstract class B
        {
            public void TestMethod(int i, int j)
            {
                Console.WriteLine("class B => TestMethod()");
            }
        }

        class Sample : A
        {
            public override void TestMethod(int a, int b)
            {
                Console.WriteLine("class SAMPLE => TestMethod()");
            }

            public override void TestMethodB()
            {
                Console.WriteLine("class SAMPLE => TestMethodB()");
            }
        }
        #endregion

        #region INTERFACE EXP

        interface ITestInterface
        {
            static int a;

            void getMethod();
            string getName();
        }

        class Test : ITestInterface
        {

            public void getMethod()
            {
                ITestInterface.a = 10;
                Console.WriteLine("ITestInterface.a => " + ITestInterface.a);
            }

            public string getName()
            {
                throw new NotImplementedException();
            }
        }
        #endregion
    }
}
