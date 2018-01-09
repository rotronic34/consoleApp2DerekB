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
        }

        public Animal(double height, double weight, string sound, string name){
            this.height = height;
            this.weight = weight;
            this.sound = sound;
            this.name = name;
        }

        static int numOfAnimals = 0;
        //to get access to this static field need to create static method
        public static int getNumOfAnimals() {
            return numOfAnimals;
        }

        public static void Main(string[] args)
        {

        }
    }
}
