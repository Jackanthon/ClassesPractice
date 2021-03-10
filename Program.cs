using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Twilight", "Samantha Celite", 440, "R");

            Book book2 = new Book("Harry Potter", "JK Rowling", 334, "G");
            Book book3 = new Book();

            book2.Rating = "PG";
            book3.Rating = "NR";
            Console.WriteLine(book2.Rating);
            Console.WriteLine(book3.Rating);
            

            book1.author = "Samantha White";
            Console.WriteLine(book1.author);

            Car car1 = new Car("Volkswagon", "Passat", 2017, 98000);
            Car car2 = new Car("Honda", "Accord", 2014, 104135);
            Car car3 = new Car("Chevy", "Tahoe", 2020, 146570);
            Console.WriteLine(Car.carCount);
            Car car4 = new Car("Audi", "A6", 2022, 3019);
            Car car5 = new Car("Lamborghini", "Lavender", 2021, 1028);
            Car car6 = new Car("Hyundai", "Elentra", 2022, 372);

            car3.year = 2010;
            Console.WriteLine(car3.year);
            Console.WriteLine(car1.make);

            Console.WriteLine(car1.New());
            Console.WriteLine(car2.New());
            Console.WriteLine(car3.New());
            Console.WriteLine(car4.New());
            Console.WriteLine(car5.New());
            Console.WriteLine(car6.New());

        }
    }
}
