﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;
using System.Linq;
using csharp_interviews.exos;

namespace csharp_interviews
{
    class Program
    {
        static void Main(string[] args)
        {
            //var fruit = new XElement("fruit", "orange");
            //var panier1 = new XElement("panier", fruit);
            //var panier2 = new XElement("panier", fruit);
            //fruit.SetValue("pomme");
            //Console.WriteLine(panier2.Element("fruit").Value);
            ////outputs orange, because when XEelment does not save "fruit"'s reference

            //int i = 0;
            //Console.WriteLine(++i); //outputs 1
            //Console.WriteLine(i++); //outputs 0

            //var sd = new SortedDictionary<int, int>();
            //sd[3] = 3;
            //sd[2] = 1;
            //sd[1] = 2;
            //foreach (var item in sd)
            //{
            //    Console.WriteLine(item);
            //}
            //result is 2, 1, 3, as the order is applied to the keys and not to the values

            //double total = 0;
            //var numbers = new string[] { "-1.001", "1.01" };
            //foreach (string number in numbers)
            //{
            //    //problem : return value is not always the same
            //    //total = total + double.Parse(number);
            //    //solution
            //    total = total + double.Parse(number, CultureInfo.InvariantCulture);
            //}
            //Console.WriteLine(total.ToString());

            //var hashset = new HashSet<int>();
            //hashset.Add(1);
            //hashset.Add(1);
            //hashset.Add(2);
            //Console.WriteLine(hashset.Count); //outputs 2 and not 3

            //var d = new DateTime(0);
            //d.AddHours(2);
            //Console.WriteLine(d.Hour); //outputs 0 because AddHours is not void

            //string s; //string value is null

            //Struct struct1;
            //struct1.foo = 5;
            //Struct struct2 = struct1;
            //struct2.foo = 10;
            //Console.WriteLine(struct1.foo); //outputs 5 as structs are not objects but values only

            //var list = new List<int>(2);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //Console.WriteLine(list.Count);
            ////outputs 3 and not 2 ! 2 means the capacity, and that's only the allocation unit, default is 4 if i remember

            //A a = new A();
            //A b = new B();
            ////B must inherit from A so this code compiles

            //outputs an empty string
            //ClassLevel3 classLevel3 = new ClassLevel3();
            //Console.WriteLine($"Value : {classLevel3?.PropLevel2?.PropLevel1}");

            //Console.WriteLine(2 << 1); //outputs 4, we should know why...

            //Console.WriteLine(new[] { "aaaa", "bbb" }.Max(x => x.Length));

            //Console.WriteLine(new String("abcdefgh".Reverse().ToArray())); //this is how you get a reversed string !

            ////SelectMany Example, Distinct is not applied by default as we excpected
            //ClassRoom cr = new ClassRoom()
            //{
            //    Students = new List<Student>()
            //    {
            //        new Student() { Homeworks = new List<string>() { "Homework_1", "Homework_2", "Homework_3", "Homework_4", }},
            //        new Student() { Homeworks = new List<string>() { "Homework_5", "Homework_6", "Homework_7" }},
            //        new Student() { Homeworks = new List<string>() { "Homework_8", "Homework_9", "Homework_7" }},
            //    }
            //};
            //cr.Students.SelectMany(x => x.Homeworks).Distinct().ToList().ForEach(x => Console.WriteLine(x));

            //Dictionary<object, string> dict = new Dictionary<object, string>();
            //object o1 = 2;
            //object o2 = 5;
            //o1 = o2;
            //dict[o1] = "two";
            //dict[o2] = "five";
            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item.Value);
            //}
            ////outputs "five" as o1 and o2 reference each other 

            ////outputs "csharp_interviews.Program+Vehicule`1[csharp_interviews.Program+Bicycle]"
            //Console.WriteLine(new Vehicule<Bicycle>().GetType());

            //exos
            //reshaper
            Console.WriteLine(new Reshaper().Reshape("142 5 54 963 212 225 190", 2));

            //isReadOnly
            //Dynamic polymorphism ?
            //what is a unicode character
            //User-defined exception classes are derived from the ApplicationException class in C# -> true
            //reshape (n, str)

            Console.WriteLine("\n\nEOP");
            Console.ReadLine();
        }

        struct Struct { public int foo; }
        public class A { }
        public class B : A { }

        public class ClassLevel1 { }
        public class ClassLevel2 { public decimal PropLevel1 { get; set; } }
        public class ClassLevel3 { public ClassLevel2 PropLevel2 { get; set; } }

        public class Student { public List<string> Homeworks { get; set; } }
        public class ClassRoom { public List<Student> Students { get; set; } }

        public class Vehicule<T>{};
        public class Bicycle { }
    }
}