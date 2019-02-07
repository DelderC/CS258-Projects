/*
 Programmer: Devin Elder
 Date: 1/25/2019
 Description: This program calculates the user's BMI (Body Mass Index) from their weight (lbs) and height (in).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmiCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double dWeight, dHeight, BMI;

            name = InputName();
            dWeight = GetWeight();
            dHeight = GetHeight();
            BMI = CalcBMI(dWeight, dHeight);
            DisplayResults(name, dWeight, dHeight, BMI);

        }
        // Input Method for Name
        static string InputName()
        {
            string name;

            Console.Write("Name: ");
            name = Console.ReadLine();
            return name;
        }
        // Input Method for Weight
        static double GetWeight()
        {
            string sWeight;
            double dWeight;

            Console.Write("Weight (lbs): ");
            sWeight = Console.ReadLine();
            dWeight = double.Parse(sWeight);
            return dWeight;

        }
        // Input Method for Height
        static double GetHeight()
        {
            string sHeight;
            double dHeight;

            Console.Write("Height (in): ");
            sHeight = Console.ReadLine();
            dHeight = double.Parse(sHeight);
            return dHeight;
        }
        // Method for calculating BMI
        static double CalcBMI(double dWeight, double dHeight)
        {
            double BMI = (dWeight / (Math.Pow(dHeight, 2)) * 703);
            return BMI;
        }
        // Method to display results of input methods and calculation
        static void DisplayResults(string name, double dWeight, double dHeight, double BMI)
        {
            Console.Clear();

            Console.WriteLine("Name: " + name + "\n" +
                              "Weight (lbs): " + dWeight.ToString("N2") + "\n" +
                              "Height (in): " + dHeight.ToString("N2") + "\n" +
                              "----------\n" +
                              "BMI: " + BMI.ToString("N2"));