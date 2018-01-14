using System;
using static ConsoleApp2DerekB.Shape;

namespace ConsoleApp2DerekB
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        //To set your own setters and getters
        //getters to limit access or setters to set certain values 
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; } // is very important, needs to be used for setting different items;
        }
        //once we have some attributes, we will need a way to initial thise animal object
        //CONSTRUCTOR

        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.sound = "no sound";
            this.name = "no name";
            numOfAnimals++;
        }

        public Animal(double height, double weight, string sound, string name)
        {
            this.height = height;
            this.weight = weight;
            this.sound = sound;
            this.name = name;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;
        //to get access to this static field need to create static method
        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        //creating a couple other methods for animals to operate with

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs{2} lbs and likes to say {3}", name, height, weight, sound);
        }

        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;

        }

        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;

        }

        public static void Main(string[] args)
        {
            Shape rect = new Rectangle(5, 5);
            Shape tri = new Triangle(5, 5);

            Console.WriteLine("Rect area "+ rect.area());
            Console.WriteLine("Tri area "+ tri.area());

            Rectangle combRect = new Rectangle(5, 5) + new Rectangle(5, 5);

            Console.WriteLine("combRect area " + combRect.area());

        }
    }

    class Dog : Animal
    {
        public String favFood { get; set; }

        public Dog() : base()
        {     //Constructor same name as class
            this.favFood = "No favorite food";
        }

        public Dog(double height, double weight, string name, string sound, string favFood) : base(height, weight, sound, name)
        {
            /* this.height = height;
             this.weight = weight;
             this.sound = sound;
             this.name = name; */
            this.favFood = favFood;
        }

        new public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs{2} lbs and likes to say {3} and eats and {4} is it's favorite food",
                                 name, height, weight, sound, favFood);
        }
    }

    //Abstract Class
    abstract class Shape
    {
        public abstract double area();

        public void sayHi()
        {
            Console.WriteLine("hEllo you!"); //only abstract methods in interfaces, but abstract classes can do real methods
        }

        public interface ShapeItem
        {
            double area();
        }

        internal class Rectangle : Shape
        {
            private double length;
            private double width;

            public Rectangle(double num1, double num2)
            {
                length = num1;
                width = num2;   
            }

            public override double area()
            {
            return length * width;

            }

            public static Rectangle operator+ (Rectangle rect1, Rectangle rect2)
            {
                double rectLength = rect1.length + rect2.length;
                double rectWidth = rect1.width + rect2.width;
                 
                return new Rectangle(rectLength, rectWidth);
            }


        }

        internal class Triangle : Shape
        {
            private double theBase;
            private double height;

            public Triangle(double num1, double num2)
            {
                theBase = num1;
                height = num2;
            }

            public override double area()
            {
                return .5 *(theBase * height);

            }
        }

















    }
}