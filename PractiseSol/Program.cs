using System;
using System.Text;


namespace PractiseSol
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ************* INTERFACE EXP *************
            //  *****************************************
            //  interface can have static field - if static is given then it throws compile error
            // Test T = new();
            // T.getMethod();



            //  ************* ABSTRACT EXP **************
            //  *****************************************
            // abstract can have paramterless constructor
            // A s = new Sample();
            // s.TestMethod(2, 3);
            // Sample s = new Sample();
            // 
            #region TRY-CATCH EXAMPLE
            
                try
                {
                    //code that may raise an exception
                    string str = "";
                    str = null;
                    Console.WriteLine("String=> " + str);
                }            
                catch (NullReferenceException nullEx)
                {
                    Console.WriteLine(nullEx.Message);
                }
                catch (InvalidCastException inEx)
                {
                    Console.WriteLine(inEx.Message);
                }
                catch
                {
                    // General Catch block 
                    // this catch block must be last block
                }
                finally
                {
                    //FINALLY block must be below Catch block either gives compile error               
                    //FINALLY block does not have return, break, continue keyword , either gives compile time error
                    // Multiple finaalt blocks not allowed
                    Console.WriteLine("in finally block ");
                }
            #endregion

            Console.ReadKey();
        }

        #region ABSTRACT EXP

        abstract class A
        {
            public A()
            {
                Console.WriteLine("Abstract class parameterless constructor");
            }

            public A(string str = "test")
            {
                Console.WriteLine("Abstract class parameter constructor STRING => " + str);
            }

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
            public Sample(): base("test ctor")
            {

            }
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
