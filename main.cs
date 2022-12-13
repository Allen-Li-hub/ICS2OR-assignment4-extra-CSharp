// Created by: Allen Li
// Created on: Oct 2022
//
// This program displays assignment 2

using System;
class Program
{
    public static void Main(string[] args)
    {
        System.Random random = new System.Random();
        string userSize;
        string userTopings;

        Console.Write("Chose the pizza size that you want!:");
        Console.WriteLine("");

        Console.WriteLine("We have Small, Medium, Large and the Extra-Large size, which one would you like?");
        userSize = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("What toppings you want? Caramel, Rich-Chocolate-Sauce or Ice-Cream-Scoop?");
        userTopings = Console.ReadLine();
        Console.WriteLine("");

        double sizePrice = 0.00;
        double topingPrice = 0.00;

        if (userSize == "Small")
        {
            sizePrice = 1.00;
        }
        else if (userSize == "Medium")
        {
            sizePrice = 1.50;
        }
        else if (userSize == "Large")
        {
            sizePrice = 2.00;
        }
        else if (userSize == "Extra-Large")
        {
            sizePrice = 2.50;
        }
        else
        {
            Console.WriteLine("Error");
        }
        if (userTopings == "Caramel")
        {
            topingPrice = 3.00;
        }
        else if (userTopings == "Rich-Chocolate-Sauce")
        {
            topingPrice = 10.00;
        }
        else if (userTopings == "Ice-Cream-Scoop")
        {
            topingPrice = 5.00;
        }
        else
        {
            Console.WriteLine("Error");
        }
        double totalPrice = sizePrice + topingPrice;
        Console.WriteLine("Your total will be " + totalPrice.ToString("C")");
        Console.WriteLine("\nDone.");
    }
}