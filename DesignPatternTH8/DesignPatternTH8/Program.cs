using DesignPatternTH8.Observer;
using DesignPatternTH8.VisitorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bai1();
            Bai2();
            Bai3();
        }
        public static void EndExercise()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        public static void Bai1()
        {
            Console.WriteLine("Bài 1:");
            Console.WriteLine("***Observer Pattern Demo***\n");
            IObserver myObserver1 = new ObserverTypeOne("Roy");
            IObserver myObserver2 = new ObserverTypeOne("Kevin");
            IObserver myObserver3 = new ObserverTypeTwo("Bose");
            Subject subject = new Subject();
            subject.Register(myObserver1);
            subject.Register(myObserver2);
            subject.Register(myObserver3);

            Console.WriteLine("Setting Flag = 5");
            subject.Flag = 5;
            subject.Unregister(myObserver1);

            Console.WriteLine("\nSetting Flag = 50");
            subject.Flag = 50;
            subject.Register(myObserver1);

            Console.WriteLine("\nSetting Flag = 100");
            subject.Flag = 100;
            EndExercise();
        }
        public static void Bai2()
        {
            Console.WriteLine("\nBài 2:");
            User user = new User("H");
            IObserverCompany companyA = new CompanyA("FPT", "222 Nguyen Hue");
            IObserverCompany companyB = new CompanyB("VNG", "111 Cong Quynh");
            ISubjectCompany subjectCompany = new CompanySubject(user);

            subjectCompany.Subscribe(companyA);
            subjectCompany.Subscribe(companyB);

            Console.Out.WriteLine("Posting Topic:");
            subjectCompany.Post("Chicken hihi ^_^");

            Console.WriteLine("Test Unsubscribe Company B");
            subjectCompany.Unsubscribe(companyB);
            subjectCompany.Post("GOOD BYE COMPANY B");
            EndExercise();
        }
        public static void Bai3()
        {
            Console.WriteLine("\nBài 3:");
            Console.WriteLine("***Visitor Pattern Demo***");
            IVisitor visitor = new Visitor();
            MyClass myClass = new MyClass();
            myClass.Accept(visitor);
            Console.ReadLine();
        }
    }
}
