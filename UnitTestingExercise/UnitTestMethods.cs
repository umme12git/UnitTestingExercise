﻿using System;
using System.Collections.Generic;

    
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add (int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minued, int subtrahend)
        {
            return minued - subtrahend;
        }

        // Create a Multiply method that passes 2 integers
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // Create a Divide method that passes 2 integers
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote
        public double CanFindMax(int num1, int num2)
        {

            if (num1 > num2)
                return num1;
            else 
                return num2;
           
        }
        public int CanFindAreaSquare(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
