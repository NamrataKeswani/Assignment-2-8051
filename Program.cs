using System;

class VirtualPet
{
    // Pet attributes
    private int hunger;
    private int happiness;
    private int energy;

    // Constructor
    public VirtualPet()
    {

        hunger = 50;
        happiness = 50;
        energy = 50;
    }

    // Method to display pet's status
    public void DisplayStatus()
    {
        Console.WriteLine($"Hunger: {hunger}\nHappiness: {happiness}\nEnergy: {energy}\n");
    }

    // Method to feed the pet
    public void Feed()
    {
        Console.WriteLine("You feed the pet.");
        hunger -= 10;
        happiness += 5;
        energy += 10;
    }

    // Method to play with the pet
    public void Play()
    {

        Console.WriteLine("Its Pet Playing Time.");
        hunger += 5;
        happiness += 15;
        energy -= 10;
    }

    // Method to put the pet to sleep
    public void Sleep()
    {
        Console.WriteLine("The pet must be sleeping.");
        hunger += 5;
        happiness += 10;
        energy += 20;
    }

    // Method to update the pet's status over time
    public void UpdateStatus()
    {
        // Simulate the passage of time
        hunger += 5;
        happiness -= 5;
        energy -= 5;
    }
}

class Program
{
    static void Main()
    {
        VirtualPet myPet = new VirtualPet();

        Console.WriteLine("Welcome to Virtual Pet Simulator!");

        while (true)
        {
            myPet.DisplayStatus();

            Console.WriteLine("Action needs to be selected:");
            Console.WriteLine("1. Feed the pet");
            Console.WriteLine("2. Play with the pet");
            Console.WriteLine("3. keep the pet to sleep");
            Console.WriteLine("4. Quit");

            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            switch (choice)
            {
                case '1':
                    myPet.Feed();
                    break;
                case '2':
                    myPet.Play();
                    break;
                case '3':
                    myPet.Sleep();
                    break;
                case '4':
                    Console.WriteLine("Thanks for playing! Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice.Please choose a valid option.");
                    break;
            }

            myPet.UpdateStatus(); 
        }
    }
}
