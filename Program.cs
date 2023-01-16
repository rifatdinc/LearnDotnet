
// See https://aka.ms/new-console-template for more information

namespace ConsoleApp
{
    class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public string Description { get; set; }
    }

    class ClassImplements
    {
        static void Mains(string[] args)
        {
            System.Console.WriteLine("adet : ");
            int adet = int.Parse(Console.ReadLine());
            Product[] products = new Product[adet];

            int i = 0;
            Product prd;
            do
            {
                prd = new Product();

                System.Console.WriteLine("Urun Adi");
                prd.Name = Console.ReadLine();

                System.Console.WriteLine("Urun Fiyati");
                prd.Price = Console.ReadLine();


                System.Console.WriteLine("Urun Aciklamasi");
                prd.Description = Console.ReadLine();

                products[i] = prd;
                i++;

            } while (adet > i);

            foreach (var item in products)
            {
                Console.WriteLine($"Guzel Telefon {item.Name}");
                Console.WriteLine($"Guzel Telefon {item.Price}");
                Console.WriteLine($"Guzel Telefon {item.Description}");

            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public void Intro()
        {
            System.Console.WriteLine("Hello my name is " + this.Name + " " + this.Surname + " and I am " + this.Age + " years old.");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person() { Name = "Ali", Surname = "Yilmaz", Age = 25 };
            var p2 = new Person() { Name = "Veli", Surname = "Yilmaz", Age = 25 };
            var p3 = new Person() { Name = "Ayse", Surname = "Yilmaz", Age = 25 };
            p1.Intro();
            p2.Intro();
            p3.Intro();
        }
    }

}

