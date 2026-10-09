using System;

namespace ClassConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------
            // 1. Static Members vs Instance Members
            // 'static' means the member belongs to the class itself, not individual instances.
            // All objects share the same single static 'counter' variable.
            // -------------------------------------------------------------
            Car car1 = new Car("Toyota", "Red", "2020");
            Car car2 = new Car("Honda", "Blue", "2021");
            Car car3 = new Car("Ford", "Black", "2019");

            // Note: Accessing static members through an instance (e.g., car1.counter)
            // is not permitted in C# and causes compile-time error CS0176.
            // We access it directly via the class name:
            Console.WriteLine("Total cars created: " + Car.counter);

            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 2. Constructor Overloading
            // Multiple constructors allow creating objects with varying amounts of data.
            // -------------------------------------------------------------
            Student student1 = new Student("John");
            Console.WriteLine("Student 1: " + student1.name);

            Student student2 = new Student("Jane", 20);
            Console.WriteLine("Student 2: " + student2.name + ", Age: " + student2.age);

            Student student3 = new Student("Bob", 22, "123 Main St");
            Console.WriteLine("Student 3: " + student3.name + ", Age: " + student3.age + ", Address: " + student3.address);

            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 3. Inheritance & Abstract Base Classes
            // Subclasses inherit properties and methods from their base class.
            // -------------------------------------------------------------
            Male male = new Male();
            Female female = new Female();
            Trans trans = new Trans();

            male.name = "Henry";
            female.age = 22;

            Console.WriteLine(male.name);
            Console.WriteLine(female.age);
            trans.specie();

            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 4. Arrays of Objects (Indexed Assignment)
            // -------------------------------------------------------------
            Car[] garage = new Car[3];
            garage[0] = new Car("BMW", "White", "2022");
            garage[1] = new Car("Audi", "Black", "2021");
            garage[2] = new Car("Mercedes", "Silver", "2020");

            Console.WriteLine("Garage 1 : " + garage[0].name);
            Console.WriteLine("Garage 1 : " + garage[0].color);
            Console.WriteLine("Garage 1 : " + garage[0].model);

            Console.WriteLine();

            Console.WriteLine("Garage 2 : " + garage[1].name);
            Console.WriteLine("Garage 2 : " + garage[1].color);
            Console.WriteLine("Garage 2 : " + garage[1].model);

            Console.WriteLine();

            Console.WriteLine("Garage 3 : " + garage[2].name);
            Console.WriteLine("Garage 3 : " + garage[2].color);
            Console.WriteLine("Garage 3 : " + garage[2].model);

            Console.WriteLine();
            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 5. Arrays of Objects (Initializer & Foreach Iteration)
            // -------------------------------------------------------------
            Car[] garage2 =
            {
                new Car("BMW", "White", "2022"),
                new Car("Audi", "Black", "2021"),
                new Car("Mercedes", "Silver", "2020")
            };

            int carIndex = 1;
            foreach (Car car in garage2)
            {
                Console.WriteLine($"Garage {carIndex} : {car.name}");
                Console.WriteLine($"Garage {carIndex} : {car.color}");
                Console.WriteLine($"Garage {carIndex} : {car.model}");
                carIndex++;
                Console.WriteLine();
            }

            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 6. Passing Objects to Methods (Copying and Modifying)
            // -------------------------------------------------------------
            Car car4 = new Car("Toyota", "Red", "2020");
            Car car5 = Car.CopyCar(car4);
            Console.WriteLine("Car 4: " + car4.name + ", Color: " + car4.color + ", Model: " + car4.model);
            Console.WriteLine("Car 5: " + car5.name + ", Color: " + car5.color + ", Model: " + car5.model);

            Console.WriteLine("===========================================");

            Car car6 = new Car("Honda", "Blue", "2021");
            Console.WriteLine("Car 6 before: " + car6.name + ", Color: " + car6.color + ", Model: " + car6.model);
            Car.ChangeColor(car6, "Green");
            Console.WriteLine("Car 6 after : " + car6.name + ", Color: " + car6.color + ", Model: " + car6.model);

            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 7. Polymorphism: Virtual and Override Methods
            // -------------------------------------------------------------
            Dog dog = new Dog();
            Cat cat = new Cat();
            dog.Sound();
            cat.Sound();

            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 8. Overriding ToString() Method
            // -------------------------------------------------------------
            Car car7 = new Car("Nissan", "Yellow", "2023");
            Console.WriteLine(car7.ToString());

            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 9. Polymorphic Array (Processing Subclasses Through Base Type)
            // -------------------------------------------------------------
            Dog dog2 = new Dog();
            Cat cat2 = new Cat();
            Horse horse2 = new Horse();
            Animal[] animals = { dog2, cat2, horse2 };

            foreach (Animal animal in animals)
            {
                animal.Sound();
            }

            Console.WriteLine("===========================================");
        }
    }

    // Base Animal class with virtual method for polymorphism
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("The Animal makes a generic sound");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("The Dog goes *woof woof*");
        }
    }

    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("The Cat goes *meow meow*");
        }
    }

    class Horse : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("The Horse goes *neigh neigh*");
        }
    }

    // Car class demonstrating fields, constructors, static members, and ToString override
    class Car
    {
        public static int counter = 0; // Shared across all instances
        public string name;
        public string color;
        public string model;

        public Car(string name, string color, string model)
        {
            this.name = name;
            this.color = color;
            this.model = model;
            counter++;
        }

        // Creates a new Car copy from an existing one
        public static Car CopyCar(Car car)
        {
            return new Car(car.name, car.color, car.model);
        }

        // Modifies the color of an existing Car instance
        public static void ChangeColor(Car car, string newColor)
        {
            car.color = newColor;
        }

        // Custom string representation of a Car
        public override string ToString()
        {
            return $"This is a {model} Model {color} {name}";
        }
    }

    // Student class demonstrating constructor overloading
    class Student
    {
        public string name;
        public int age;
        public string? address;

        public Student(string name)
        {
            this.name = name;
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Student(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
    }

    // Abstract base class: cannot be directly instantiated
    abstract class Humans
    {
        public string? name;

        public void specie()
        {
            Console.WriteLine("We are Homo Sapiens.");
        }
    }

    class Male : Humans
    {
        public int age = 20;
    }

    class Female : Humans
    {
        public int age = 18;
    }

    class Trans : Humans
    {
        public int age = 25;
    }
}