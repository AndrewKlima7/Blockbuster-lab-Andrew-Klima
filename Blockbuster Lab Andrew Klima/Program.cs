using System;
using System.Collections.Generic;

namespace Blockbuster_Lab_Andrew_Klima
{
    class Program
    {
        static void Main(string[] args)
        {
            //Been working on this for hours and just cant seem to get it right below are some question i have, along with other questions marked throughout the other classes. 

            Blockbuster one = new Blockbuster();
            Test(one);
        }

        public static void Test(Blockbuster b)
        {
            b.CheckOut();
        }
    }

    //do i need the constructor now that the movie class is abstract? like for both dvd and vhs
    //is blockbuster suppose to be a child of movie? 
    //why wont it let me put blockbuster one in test()? -> ans: have to remember to put public static!
    //is everything else okay?
    
    //since the movie list is under blockbuster then i dont need any of the movies listed under main
    //right? its beacuse with checkout() i am pulling it from blockbuster thus pulling the list as well
}
