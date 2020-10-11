using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    /////////////1////////////////
    class Water
    {
        public string Name { get; set; }
        public Water(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
        public override string ToString()
        {
            return base.ToString() + ": " + Name.ToString();
        }
    }
    class Sea : Water
    {
        public string Sea_ { get; set; }
        public Sea(string name, string Sea_1)
            : base(name)
        {
            Sea_ = Sea_1;
        }

        public override void Display()
        {
            Console.WriteLine($"Water is {Name}, {Sea_} Sea");
        }
        public override string ToString()
        {
            return base.ToString() + ": " + Sea_.ToString();
        }
    }

    //class Land
    //{
    //    public string str;
    //}
    //class Continent : Land
    //{
    //    public string str_;
    //    public Continent(string str_,string str)
    //    {
    //        this.str = str;
    //        this.str_ = str_;
    //    }
    //    public virtual void ReWrite()
    //    {
    //        Console.WriteLine("Value Land: " + str_);
    //    }
    //}
    //class iIsland : Continent
    //{
    //    public string str_1;
    //    public iIsland(string str_1) : base("America", "Africa")
    //    {
    //        this.str_1 = str_1;
    //    }
    //    public override void ReWrite() {
    //        base.ReWrite();
    //        Console.WriteLine("Contenent: " + str_1);
    //    }
    //}
    //class Country : iIsland
    //{
    //    public string str_2;
    //    public Country(string str_2): base("New Land")
    //    {
    //        this.str_2 = str_2;
    //    }
    //    public override void ReWrite()
    //    {
    //        Console.WriteLine("Country: " + str_2);
    //    }
    //}

    class Land
    {
        public string str = "Earth";
    }
    class Continent : Land
    {
        public string str_="America";
        public virtual void ReWrite()
        {
            Console.WriteLine("Land: " + str);
            Console.WriteLine("Continent: " + str_);
        }
       
    }
    class iIsland : Continent
    {
        public string isla { get; set; }
        public iIsland(string isla_1)
        {
            isla = isla_1;
        }
        public override void ReWrite()
        {
            base.ReWrite();
            Console.WriteLine("Island: " + isla);
        }
    }
    class Country : iIsland
    {
        public string count { get; set; }
        public Country(string isla_, string count_):base(isla_)
        {
            count = count_;
        }
        public override void ReWrite()
        {
            base.ReWrite();
            Console.WriteLine("Country: " + count);
        }
        public override string ToString()
        {
            return base.ToString() + ": " + str_.ToString();
        }
    }
    /////////////1////////////////
    /////////////2////////////////
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
    }
    /////////////2////////////////
    /////////////3////////////////
    sealed class SealedClass
    {
        public int x;
        public int y;
    }
    /////////////3////////////////
    /////////////4////////////////
    public abstract class Vehicle
    {
        public abstract void Move();
    }
    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }
    //////////////////inteface//////////////////
    public interface IMovable
    {
        void Move();
    }
    public abstract class AVehicle1
    { }
    public class Car1 : AVehicle1, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }
    /////////////4////////////////

    /////////////7////////////////
    class Printer
    {
        public void IAmPrinting(RunThing rn)
        {
            rn.Run();
            Console.WriteLine("ToString() 7 exersize" + rn.ToString());
        }
    }
    public interface Running
    {
        void Run();
    }
    public class RunThing : Running
    {
        public void Run()
        {
            Console.WriteLine("Work");
        }
    }
    /////////////7////////////////
    class Class1
    {
        static void Main(string[] args)
        {
            /////////////1////////////////
            Sea s = new Sea("Clear" , "Black");
            s.Display();
            Country coun = new Country("New Land", "Russia");
            coun.ReWrite();
            /////////////6////////////////
            Console.WriteLine(coun.ToString());
            /////////////6////////////////
            /////////////1////////////////

            /////////////2////////////////
            Person p1 = new Person("Bill");
            p1.Display(); // вызов метода Display из класса Person

            Employee p2 = new Employee("Tom", "Microsoft");
            p2.Display(); // вызов метода Display из класса Person
            /////////////2////////////////
            /////////////3////////////////
            var sc = new SealedClass();
            sc.x = 110;
            sc.y = 150;
            Console.WriteLine($"x = {sc.x}, y = {sc.y}");
            /////////////3////////////////
            /////////////4////////////////
            Car1 c = new Car1();
            c.Move();
            /////////////4////////////////
            /////////////5////////////////
            if(p1 is Employee)
            {
                Employee emp1 = (Employee)p1;
                Console.WriteLine(emp1.Company);
                Employee emp = p1 as Employee;
                if (emp == null)
                {
                    Console.WriteLine("Преобразование прошло неудачно");
                }
                else
                {
                    Console.WriteLine(emp.Company);
                }
            }
            else
            {
                Console.WriteLine("Преобразование не допустимо");
            }

            /////////////5////////////////
            /////////////7////////////////
            Printer pr = new Printer();
            var rn = new RunThing();
            pr.IAmPrinting(rn);
            object[] arr = new object[2];
            arr[0] = pr;
            arr[1] = sc;
            /////////////7////////////////

            Console.ReadKey();
        
        }
    }
}
