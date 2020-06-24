using System;

namespace IterationExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  TODO:
            Constraints:
Use as many descriptive names as possible. I do not want to see myInt1 - 100!
For training purposes, most if not all the data for these methods can come from user input.
Each one of these methods should be called from Main() and exist in the Program class. 
Be as creative as you want, the goal is to have working methods but if you want to make them look nice, go for it. As in Num 6 w/ age and voting method, you can say “You may vote” or “Looks like your too young this time!” based on their age.
This project should work in a manner where if someone forks/clones this from GitHub, they can just press the play button and have every method run in sequence, so all interface dialogue should be in place already. When finished, push this to GitHub!

Luke Warm:
Write a method that will print to the console all numbers 1000 through -1000.
Write a method that will print to the console numbers 3 through 999 by 3 each time.
Write a method to accept two integers as parameters and check whether they are equal or not.
Write a method to check whether a given number is even or odd.
Write a method to check whether a given number is positive or negative.
Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!

Heatin Up:
Write a method to check if an integer (from the user) is in the range -10 to 10.
Write a method to display the multiplication table(from 1 to 12) of a given integer.
Write a method that takes a number from the user and returns an array with that many indexes. The indexes shall be random numbers.
Write a method to compute the sum of all the elements in an array of integers.
Write a method to display the cube of the number up to given an integer.    (If a user inputs the number 3 the method should print to the console: Number is: 1 and the cube of 1 is:1, Number is: 2 and the cube of 2 is: 8, Number is: 3 and the cube of 3 is:27)
*/
            //Luke Warm 1
            Console.WriteLine("Hello, Let me count to 1000 to make sure you're ready!");
            Console.ReadLine();
            CountToOneGrand();

            //Luke Warm 2
            Console.WriteLine("Check it out I'll count from 0 to 999 by three! ");
            Console.ReadLine();
            int byThree = 3;
            CountByThree(byThree);

            //Luke Warm 3
            Console.WriteLine("Enter two numbers!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            AreEqual(a, b);

            //Luke Warm 4
            Console.WriteLine("Pick any number and I'll tell you if it's even or odd");
            int checkEvenOdd = int.Parse(Console.ReadLine());
            EvenorOdd(checkEvenOdd);

            //Luke Warm 5
            Console.WriteLine("Pick any number and let me tell you if it's positive or negative!");
            int checkPosNeg = int.Parse(Console.ReadLine());
            PosOrNeg(checkPosNeg);

            //Luke Warm 6
            Console.WriteLine("Enter your age to find out if you can vote!");
            int voterAge = int.Parse(Console.ReadLine());
            VoteAge(voterAge);

            //Heating up 1
            Console.WriteLine("Enter a number from -10 to 10!");
            int scopeNum = int.Parse(Console.ReadLine());
            CorrectEntry(scopeNum);

            //Heating up 2
            Console.WriteLine("Lets pick a number and see a multiplication table 1-12!");
            int multBy = int.Parse(Console.ReadLine());
            MultiplyTable(multBy);

            //Heating up 3
            Console.WriteLine("Please enter the number of indexes you would like to add to the array!");
            int indexCount = int.Parse(Console.ReadLine());
            int[] UserArray = UserSetIndex(indexCount);
            foreach(int answer in UserArray)
            {
                Console.WriteLine(answer);
            }

          
            //Heating up 4
            Console.WriteLine("Lets add all of out indexes together!");
            
            int sumation = SumOfIndexed();
            Console.WriteLine($"{sumation} this is the sum of the array indexes!");
            //Heating up 5
            Console.WriteLine("Please enter a number to find the cube!");
            int userCube = int.Parse(Console.ReadLine());
            CubePowers(userCube);
            

        }
        //Luke warm 1:write all numbers -1000 to 1000
                public static int CountToOneGrand()
        {
            int numberToAdd = -1001;
            do
            {
                numberToAdd ++;
                Console.WriteLine(numberToAdd);
            } while (numberToAdd < 1001);
            return numberToAdd;

            
        }
        //Luke Warm 2 write all numbers counting from 3 - 999 by three
        public static int CountByThree(int byThree)
        {
            int plusThree = 0;
            do
            {
                plusThree += 3;
                Console.WriteLine(plusThree);
            } while (plusThree < 999  );
            return plusThree;
     
        }
        //Luke Warm 3 accept two user input integer parameters and determine if they are equal
        public static void AreEqual(int userParam1 ,int userParam2)
        {
           if(userParam1 == userParam2)
            {
                Console.WriteLine("They are equal");
            }
            else 
            {
                Console.WriteLine("They aren't equal");
            }
            
        }
        //Luke Warm 4 accept user input and determine whether the input is an even or odd number
        public static void EvenorOdd(int userEvenOdd)
        {
            if(userEvenOdd %2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
        }
        //Luke Warm 5 accept user input and determine whether the input is a positive or negative number
        public static void PosOrNeg(int RedOrBlack)
        {
            if(RedOrBlack >= 0)
            {
                Console.WriteLine("this number is positive");
            }
            else
            {
                Console.WriteLine("this number is negative");
            }
                
        }
        //Luke Warm 6 determine eligability to vote with user input age
        public static void VoteAge(int userAge)
        {
            if (userAge >= 18)
            {
                Console.WriteLine("Welcome you may vote!");
            }
            else
            {
                Console.WriteLine("Try again when you are 18+.");
            }
        }
        //Heating up 1 accept user input within a range of -10 to 10
        public static void CorrectEntry(int userRange)
        {
            if(userRange >= -10 && userRange <= 10)
            {
                Console.WriteLine("You have followed the instructions, that number is within range!");
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }
        //Heating up 2 accept user input for first interger in a multiplication table 1 - 12
        public static void MultiplyTable(int userTable)
        {
            
            for(int j = 1; j < 13; j++)
            {
                Console.WriteLine($"{userTable} x {j} = {userTable*j}");
            }
        }
        // Heating up 3 allow the user to set a number of indexes in an array
        public static int[] UserSetIndex(int setme)
        {
            //create array
            int[] creatorsArray = new int[setme];
            //random object
            Random rng = new Random();
            //llop through array
            for(int i = 0; i < creatorsArray.Length; i++)
            {//Assign random number 
                creatorsArray[i] = rng.Next(20);
            }
            return creatorsArray;
           

        }
        //Heating up 4 add all numbers in an array --hardcoded
        public static int SumOfIndexed()
        {

            int[] sumOfArray = { 1, 2, 3, 4, 5 };
            var sum = 0;
            for (int i = 0; i < sumOfArray.Length; i++)
            {
                sum += sumOfArray[i];
            }
            return sum;
        }
        //Heating up 5 accept user input in the form of a number and write the value and the cubed value
        public static void CubePowers(double userCube)
        {
            double cubed =  Math.Pow(userCube, 3);
            Console.WriteLine($"Number entered : {userCube}, and the cube is : {cubed}");
        }

    }
}
