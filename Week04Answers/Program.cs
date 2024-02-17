using System;

namespace Week04Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            ////Create a car with zero gasoline
            //Car new_car = new Car(0);
            //Console.Write("Initial gasoline amount: ");
            //string input = Console.ReadLine();
            ////Check whether input is valid
            //if (int.TryParse(input, out int init_gasoline))
            //    new_car = new Car(init_gasoline);
            //else
            //    Console.WriteLine("Invalid input!!!");
            ////Ask to refuel
            //Console.Write("How many litres do you want: ");
            //int refuel_amount = Convert.ToInt32(Console.ReadLine());
            ////Check if refuel
            //if (new_car.Refuel(refuel_amount))
            //{
            //    new_car.Drive();
            //}

            //Note: I think that my code is more logical than the original answer at
            //https://www.exercisescsharp.com/oop/interfaces/
            #endregion
            #region Task2
            ////Get teacher
            //Console.Write("1. ");
            //Teacher teacher = new Teacher(Console.ReadLine());
            ////Get sttudents
            //Console.Write("2. ");
            //Student student1 = new Student(Console.ReadLine());
            //Console.Write("3. ");
            //Student student2 = new Student(Console.ReadLine());
            ////Read people
            //Console.Write(teacher.ToString());
            //teacher.Explain();
            //Console.Write(student1.ToString());
            //student1.Study();
            //Console.Write(student2.ToString());
            //student2.Study();


            //Resources:
            //https://www.daveoncsharp.com/2009/08/overriding-the-tostring-method-in-csharp/
            //https://stackoverflow.com/questions/12051/calling-the-base-constructor-in-c-sharp
            #endregion
            #region Task3
            ////Create the dog
            //Dog dog = new Dog();
            ////Ask for name
            //dog.GetName();
            ////Output
            //dog.Eat();


            //Resources
            //https://www.c-sharpcorner.com/UploadFile/93126e/importance-and-use-of-versioning-in-C-Sharp/
            #endregion
            #region Task4
            ////Create the array of objects
            //Task4_Person[] people = new Task4_Person[3];
            ////Ask for people
            //for(int i = 0; i < people.Length; i++)
            //{
            //    Console.Write($"{i + 1}. ");
            //    people[i] = new Task4_Person(Console.ReadLine());
            //}
            ////Read people
            //for(int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine(people[i].ToString());
            //}


            //Resources
            //https://www.geeksforgeeks.org/destructors-in-c-sharp/
            #endregion
        }
    }
    //interface IVehicle
    //{
    //    //Create methods
    //    void Drive();
    //    bool Refuel(int refuel_amount);
    //}

    //class Car: IVehicle
    //{
    //    private int gasoline_amount; 
    //    //Initialize the constructor
    //    internal Car(int gasoline)
    //    {
    //        gasoline_amount = gasoline;
    //    }
    //    public void Drive()
    //    {
    //        if(gasoline_amount > 0)
    //            Console.WriteLine("The car is driving.");
    //        else
    //            Console.WriteLine("not enough fuel");
    //    }
    //    public bool Refuel(int refuel_amount)
    //    {
    //        gasoline_amount += refuel_amount;
    //        return true;
    //    }
    //}
    //class Person
    //{
    //    public string Name { get; set; }
    //    public Person(string name)
    //    {
    //        Name = name;
    //    }
    //    public override string ToString()
    //    {
    //        return "My name is " + Name + ".";
    //    }
    //}
    //class Student: Person
    //{
    //    public Student(string name): base(name){}
    //    public void Study()
    //    {
    //        Console.WriteLine(" I'm studying");
    //    }
    //}
    //class Teacher: Person
    //{
    //    public Teacher(string name): base(name){}
    //    public void Explain()
    //    {
    //        Console.WriteLine(" I'm explaining");
    //    }
    //}
    //abstract class Animal
    //{
    //    public string Name;
    //    public void SetName(string name)
    //    {
    //        Name = name;
    //    }
    //    public void GetName()
    //    {
    //        Console.Write("Call your dog: ");
    //        SetName(Console.ReadLine());
    //    }
    //    public abstract void Eat();
    //}
    //class Dog: Animal
    //{
    //    public override void Eat()
    //    {
    //        Console.WriteLine($"{Name} is eating.");
    //    }
    //}
    //class Task4_Person
    //{
    //    public string Name { get; set; }
    //    internal Task4_Person(string name)
    //    {
    //        Name = name;
    //    }
    //    public override string ToString()
    //    {
    //        return "Hello! My name is " + Name + ".";
    //    }
    //    ~Task4_Person()
    //    {
    //        Name = string.Empty;
    //    }
    //}
}

