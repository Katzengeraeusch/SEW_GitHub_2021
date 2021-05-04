using System;

namespace HÜ09
{
    class Program
    {
        static void Main(string[] args)
        {
            A myA = new A();
            A myAB = new B();
            A myAC = new C();
            //
            //B myBA = new A();
            B myB = new B();
            B myBC = new C();
            //C myCA = new A();
            //C myBC = new B();
            C myC = new C();

            myA.DoA();
            myA.DoA1();
            myA.DoA2();
            //myA.DoB();
            //myA.DoB1();
            //myA.DoB1();
            myAB.DoA();
            myAB.DoA1();
            myAB.DoA2();
            //myAB.DoB1();
            //myAB.DoB1();
            myAC.DoA();
            myAC.DoA1();
            myAC.DoA2();
            //myAC.DoB();
            //myAC.DoB1();
            //myAC.DoB1();
            myB.DoA();
            myB.DoA1();
            myB.DoA2();
            myB.DoB();
            myB.DoB1();
            myB.DoB1();
            myBC.DoA();
            myBC.DoA1();
            myBC.DoA2();
            myBC.DoB();
            myBC.DoB1();
            myBC.DoB1();
            myC.DoA();
            myC.DoA1();
            myC.DoA2();
            myC.DoB();
            myC.DoB1();
            myC.DoC();


        }
    }
}
