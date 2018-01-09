using System;


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
        public string Name {
            get { return name; }
            set { name = value; } // is very important, needs to be used for setting different items;
        }
        //once we have some attributes, we will need a way to initial thise animal object
        //CONSTRUCTOR

        public Animal(){
            this.height = 0;
            this.weight = 0;
            this.sound = "no sound";
            this.name = "no name";
            numOfAnimals++;
        }

        public Animal(double height, double weight, string sound, string name){
            this.height = height;
            this.weight = weight;
            this.sound = sound;
            this.name = name;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;                
        //to get access to this static field need to create static method
        public static int getNumOfAnimals() {
            return numOfAnimals;
        }

        //creating a couple other methods for animals to operate with

        public string toString(){
            return String.Format("{0} is {1} inches tall, weighs{2} lbs and likes to say {3}",name, height, weight, sound);
        }

        public int getSum(int num1 = 1, int num2 = 1){
            return num1 + num2;
            
        }

        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;

        }

        public static void Main(string[] args)
        {
            Animal Spot = new Animal(15, 10, "wolfy", "Spot");
            Console.WriteLine("{0} says {1}", Spot.name, Spot.sound);
            Console.WriteLine(Spot.toString());
            Console.WriteLine("Num of animals: " + Animal.getNumOfAnimals());
            Console.WriteLine(Spot.getSum(2, 3));
            Console.WriteLine(Spot.getSum(2.4));
        }
    }
}
