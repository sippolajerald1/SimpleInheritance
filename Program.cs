
using System;

namespace Inheritance
{

    // base class
    using System;

    namespace Inheritance
    {

        // base class
        class Animal
        {
            public string name;

            // constructor
            public Animal()
            {
                name = "";

            }
            //parameterized constructor
            public Animal(string name)
            {
                this.name = name;
            }

            public void display()
            {

                Console.WriteLine($"I am an animal, my name is {name}");
            }

        }

        // derived class of Animal 
        class Eagle : Animal
        {

            public string food;
            public double age;
            public double weight;


            public Eagle()
            {
                name = string.Empty;
                food = string.Empty;
                age = 0;
                weight = 0;

            }

            public Eagle(string name, string food, double age, double weight)

            {
                this.name = name;
                this.food = food;
                this.age = age;
                this.weight = weight;
            }

            public void display()
            {
                Console.WriteLine("Eagle information...");
                Console.WriteLine($"Name={name} \nFood{food} \nAge{age} \nWeight={weight}");
            }

        }


         class Lion : Animal
         {
             public string mobility;
             public double age;
             public double weight;


             public Lion() 
             {
                name = string.Empty;
                 mobility = "";
                 age = 0;
                 weight = 0;
             }

             public Lion(string name, string mobility, double age, double weight)
                
             {
                 this.name = name;
                 this.mobility = mobility;
                 this.age = age;
                 this.weight = weight;
             }

            public void display()
            {
                Console.WriteLine("Lion information...");
                Console.WriteLine($"Name={name} \nMobility={mobility} \nAge{age} \nWeight={weight}");
            }


        }

    
        class Program
        {
            static void Main(string[] args)
            {

                // object of base class
                Eagle eaglet = new Eagle();
                eaglet.age = 3.0;
                eaglet.weight = 45;
                eaglet.name = "Reggie";
                eaglet.food = "Carnivore";
                eaglet.display();



                Eagle theodore = new Eagle("Theodore", "Rodents", 7, 40);
                Console.WriteLine();
                theodore.display();




                Lion leo = new Lion();


                leo.age = 10;
                leo.weight = 150;
                leo.name = "Christal";
                leo.mobility = "Quad";
                leo.display();



                Lion Toni = new Lion("Toni", "Quad", 6, 200);

                Console.WriteLine();
                Toni.display();


                Console.ReadLine();



            }
        }

    }
}




