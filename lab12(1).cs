using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rabotnik");
            Rabotnik r1 = new Rabotnik();
            r1.Zarplata();
           Console.WriteLine(r1.GetInfo());
            Console.WriteLine(r1.Zvilnenya());
            Console.WriteLine(r1.GetInfo());
            Console.WriteLine(r1.ToString());
            Rabotnik r2;
            r2 = r1;
            if(r1.Equals(r2))
            {
                Console.WriteLine("Ravni");
                
            }
            else
            {
                Console.WriteLine("Ne Ravni");
            }
            Rabotnik r3 = new Rabotnik("Alex","Dadov",34,22);
            if (r1.Equals(r3))
            {
                Console.WriteLine("Ravni");

            }
            else
            {
                Console.WriteLine("Ne Ravni");
            }
            if(r1.GetHashCode()==r2.GetHashCode())
            {
                Console.WriteLine("Same hash codes");
            }
            else
            {
                Console.WriteLine("Not Same hash codes");
            }
            if (r1.GetHashCode() == r3.GetHashCode())
            {
                Console.WriteLine("Same hash codes");
            }
            else
            {
                Console.WriteLine("Not Same hash codes");
            }
            Console.WriteLine("Stager");
            Stager s1 = new Stager();         
            s1.Zarplata();
            Console.WriteLine(s1.Info());
            Console.WriteLine(s1.Zvilnenya());
            Console.WriteLine(s1.Info());
            Console.WriteLine(s1.ToString());
            Stager s3;
            s3 = s1;
            if (s1.Equals(s3))
            {
                Console.WriteLine("Ravni");

            }
            else
            {
                Console.WriteLine("Ne Ravni");
            }
            Stager s2 = new Stager("Vasya","Petrov",7000,20,"Finance");
            if (s1.Equals(s2))
            {
                Console.WriteLine("Ravni");

            }
            else
            {
                Console.WriteLine("Ne Ravni");
            }
            if (s1.GetHashCode() == s2.GetHashCode())
            {
                Console.WriteLine("Same hash codes");
            }
            else
            {
                Console.WriteLine("Not Same hash codes");
            }
            if (s1.GetHashCode() == s3.GetHashCode())
            {
                Console.WriteLine("Same hash codes");
            }
            else
            {
                Console.WriteLine("Not Same hash codes");
            }
            s2.Zarplata();
            Console.WriteLine(s2.Info());
            Console.WriteLine("Ingener");
            Ingener i1 = new Ingener();
            i1.Zarplata();
            Console.WriteLine(i1.Info());
            Console.WriteLine(i1.Zvilnenya());
            Console.WriteLine(i1.Info());
            Console.WriteLine(i1.ToString());
            Ingener i3;
            i3 = i1;
            if (i1.Equals(i3))
            {
                Console.WriteLine("Ravni");

            }
            else
            {
                Console.WriteLine("Ne Ravni");
            }
            Ingener i2 = new Ingener("Viktor", "Oleynik", 400, 10, 2);
            if (i1.Equals(i2))
            {
                Console.WriteLine("Ravni");

            }
            else
            {
                Console.WriteLine("Ne Ravni");
            }
            if (i1.GetHashCode() == i3.GetHashCode())
            {
                Console.WriteLine("Same hash codes");
            }
            else
            {
                Console.WriteLine("Not Same hash codes");
            }
            if (i1.GetHashCode() == i2.GetHashCode())
            {
                Console.WriteLine("Same hash codes");
            }
            else
            {
                Console.WriteLine("Not Same hash codes");
            }
            Console.WriteLine(i2.Info());
            i2.Zarplata();
            Console.WriteLine(i2.Info());
            Console.WriteLine("Manager");
            Manager m1 = new Manager();
            m1.Zarplata();
            Console.WriteLine(m1.GetInfo());
            Console.WriteLine(m1.Zvilnenya());
            Console.WriteLine(m1.Info());
            Console.WriteLine(m1.ToString());
            Manager m3;
            m3 = m1;
            if (m1.Equals(m3))
            {
                Console.WriteLine("Ravni");

            }
            else
            {
                Console.WriteLine("Ne Ravni");
            }           
            Manager m2= new Manager("Dmitriy","Ivanov",300,18,"Semi-rpo");
            if (m1.Equals(m2))
            {
                Console.WriteLine("Ravni");

            }
            else
            {
                Console.WriteLine("Ne Ravni");
            }
            if (m1.GetHashCode() == r3.GetHashCode())
            {
                Console.WriteLine("Same hash codes");
            }
            else
            {
                Console.WriteLine("Not Same hash codes");
            }
            if (m1.GetHashCode() == m2.GetHashCode())
            {
                Console.WriteLine("Same hash codes");
            }
            else
            {
                Console.WriteLine("Not Same hash codes");
            }
            m2.Zarplata();
            Console.WriteLine(m2.GetInfo());
            Console.WriteLine(m2.Zvilnenya());
            Console.WriteLine(m2.Info());
           





            Console.ReadKey();
        }
    }
}
