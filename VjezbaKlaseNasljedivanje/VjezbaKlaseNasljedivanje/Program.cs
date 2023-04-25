using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaKlaseNasljedivanje
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.SqlTypes;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

        public class Vehicle
        {
            private string regNo, model;
            private int year;
            private double price;

            public Vehicle(string regNo, string model, int year, double price)
            {
                this.RegNo = regNo;
                this.Model = model;
                this.Year = year;
                this.price = price;
            }

            public Vehicle()
            {

            }

            public string RegNo { get => regNo; set => regNo = value; }
            public string Model { get => model; set => model = value; }
            public int Year { get => year; set => year = value; }
            public double Price { get => price; set => price = value; }

            public override string ToString()
            {
                string ispis;
                ispis = ("Registracija: " + this.regNo + "\nModel: " + this.model + "\nGodina: " + this.year + "\nCijena: " + this.price);
                return ispis;
            }

            public virtual double getPricePerDay()
            {
                double price = this.price * 24;
                return price;
            }

            public double getPricePerMonth()
            {
                double price = this.getPricePerDay() * 30;
                return price;
            }



        }

        public class Car : Vehicle
        {
            string carType;

            public string CarType { get => carType; set => carType = value; }
            public double CargoSpace { get => cargoSpace; set => cargoSpace = value; }

            double cargoSpace;
        }

        public class Van : Vehicle
        {
            double height;
            int noOfSeats;

            public double Height { get => height; set => height = value; }
            public int NoOfSeats { get => noOfSeats; set => noOfSeats = value; }
        }

        public class Limo : Vehicle
        {
            double lenght;
            bool miniBar, sunRoof;

            public double Lenght { get => lenght; set => lenght = value; }
            public bool MiniBar { get => miniBar; set => miniBar = value; }
            public bool SunRoof { get => sunRoof; set => sunRoof = value; }

            public override double getPricePerDay()
            {
                double price = this.Price * 1.5 * 24;
                return price;
            }
        }

        public class PassengerVan : Van
        {
            int noOfPassengers;

            public int NoOfPassengers { get => noOfPassengers; set => noOfPassengers = value; }

            public override double getPricePerDay()
            {
                double price = this.Price * 0.8 * 24;
                return price;
            }
        }

        public class CargoVan : Van
        {
            double maxLoad;

            public double MaxLoad { get => maxLoad; set => maxLoad = value; }

            public override double getPricePerDay()
            {
                double price = this.Price * 1.1 * 24;
                return price;
            }
        }
  


    class Dessert
    {
        private string name;
        private double weight;
        private int calories;

        public Dessert(string name, double weight, int calories)
        {
            this.name = name;
            this.weight = weight;
            this.calories = calories;
        }

        public Dessert()
        {
        }

        public string GetDessertType()
        {
            return ("dessert");
        }

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Calories { get => calories; set => calories = value; }

        public override string ToString()
        {
            string ispis = ("Ime deserta: " + this.name + "\ntežina: " + this.weight + "\nkalorije: " + this.calories);
            return ispis;
        }
    }

    class Cake : Dessert
    {
        Boolean containsGluten;
        string cakeType;

        public Cake(bool containtsGluten, string cakeType, string name, double weight, int calories) : base(name, weight, calories)
        {
            this.containsGluten = containtsGluten;
            this.cakeType = cakeType;
        }

        public bool ContainsGluten { get => containsGluten; set => containsGluten = value; }
        public string CakeType { get => cakeType; set => cakeType = value; }

        public string getDessertType()
        {
            return ("cake");
        }
        public override string ToString()
        {
            return (base.ToString() + "\nsadrži gluten: " + this.containsGluten + "\nvrsta torte: " + this.cakeType);
        }

    }

    class IceCream : Dessert
    {
        string flavour, color;

        public IceCream(string flavour, string color, string name, double weight, int calories) : base(name, weight, calories)
        {
            this.flavour = flavour;
            this.color = color;
        }

        public string Flavour { get => flavour; set => flavour = value; }
        public string Color { get => color; set => color = value; }

        public override string ToString()
        {
            return (base.ToString() + "\nokus: " + this.flavour + "\nboja: " + this.color);
        }
        public string getDessertType()
        {
            return ("ice cream");
        }
    }

    class Person
    {
        string name, surname;
        int age;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return ("Ime: " + this.name + "\nprezime: " + this.surname + "\ngodine: " + this.age);
        }

        public bool Equals(int age1, int age2, string name1, string name2, string surname1, string surname2)
        {
            if (age1 == age2 && name1 == name2 && surname1 == surname2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Student : Person
    {
        string studentID;
        short academicYear;

        public Student(string studentID, short academicYear, string name, string surname, int age) : base(name, surname, age)
        {
            this.studentID = studentID;
            this.academicYear = academicYear;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public short AcademicYear { get => academicYear; set => academicYear = value; }

        public override string ToString()
        {
            return (base.ToString() + "\nstudent ID: " + this.studentID + "\nakademska godina: " + this.academicYear);
        }

        public bool Equals(string studentID1, string studentID2)
        {
            if (studentID1 == studentID2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Teacher : Person
    {
        string email, subject;
        double salary;

        public Teacher(string email, string subject, double salary, string name, string surname, int age) : base(name, surname, age)
        {
            this.email = email;
            this.subject = subject;
            this.salary = salary;
        }

        public string Email { get => email; set => email = value; }
        public string Subject { get => subject; set => subject = value; }
        public double Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return (base.ToString() + "\nemail: " + this.email + "\npredmet: " + this.subject + "\nplaća: " + this.salary);
        }

        public bool Equals(string email1, string email2)
        {
            if (email1 == email2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void increaseSalary(int postotak)
        {
            this.salary += (this.salary * (postotak / 100));
        }

        static void increaseSalary(int postotak, Teacher ucitelj)
        {
            ucitelj.salary += (ucitelj.salary * (postotak / 100));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dessert desert = new Dessert("tiramisu", 88.4, 2);
            Console.WriteLine(desert.ToString());
            IceCream sladoled = new IceCream("vanilija", "bijeli", "sladoled", 92.2, 4);
            Console.WriteLine(sladoled.ToString());
            Cake torta = new Cake(false, "torta", "mađarice", 132.3, 52);
            Console.WriteLine(torta.ToString());



            Console.ReadKey();
        }
    }
}
