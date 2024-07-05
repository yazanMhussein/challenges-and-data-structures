using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    // this is array variable  the size of it is 5 it's a list of number they're 1 to 5 
            //    int[] Array = new int[5] { 1, 2, 3, 4, 5 };
            //    // this is variable  called arraybackward we are using it to save the methods ArrayReversal that has parameter with the array it type. we are going to used the variable to called it latter on.   
            //    int[] arraybackwards = ArrayReversal(Array);
            //    // we are using the Console.Write methods to show it on window prompt with the string ( Reversed Array:. with the string.Join to join the , and the arraybackwards variable) .  
            //    Console.WriteLine("Reversed Array: " + string.Join(", ", arraybackwards));


            //    // this is array variable  the size of it is 17 it's a list of random numbers
            //    int[] ArrayOfnumbers = new int[17] { 62791, 2,3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            //    // this is variable  called MostFrequentNumber we are using it to save the methods MostFrequent that has parameter with the array int type. we are going to used the variable to called it latter on.
            //    int mostFrequentNumber = MostFrequent(ArrayOfnumbers);
            //    // we are using the Console.Write methods to show it on window prompt with the string Most Frequent Number: and add to it the variable called MostFrequentNumber.
            //    Console.WriteLine("Most Frequent Number: " + mostFrequentNumber);
            // Insert middle value example
            
            int[] arraymiddle = new int[5] { 1, 2, 3, 4,5 };
            int middleValue = 5;
            int[] resultsz = MiddleValue(arraymiddle, middleValue);
            Console.WriteLine($"Insert Middle Value: \nMiddle Value: {middleValue} Array: {string.Join(",", arraymiddle)} \nOutput: {string.Join(",", resultsz)}");
        }
    }

    public static int[] MiddleValue(int[] arraymiddle, int middleValue)
    {
        int middleIndex = arraymiddle.Length / 2;
        int[] saveArray = new int[arraymiddle.Length + 1];

        for (int i = 0; i < middleIndex; i++)
        {
            saveArray[i] = arraymiddle[i];
        }

        saveArray[middleIndex] = middleValue;

        for (int i = middleIndex; i < arraymiddle.Length; i++)
        {
            saveArray[i + 1] = arraymiddle[i];
        }
        return saveArray;
    }

    // this is a pubile static int of array methods called ArrayReversal that has parameter with the array int type and latter on i will return it to the main methods.
    //public static int[] ArrayReversal(int[] Array)
    //    {
    //        // this is a int variable array type called reverseArr we are using it to get the array length size so we can loop through it latter on.
    //        int[] reverseArr = new int[Array.Length];
    //        // this is a int variable type called value it right now holds the value of 0 but latter on we are going to use it by put it inside of my variable called reverseArr.
    //        int value = 0;
    //        // this is a for loop that im using to loop through the array length start with the last number.
    //        for (int i = Array.Length-1; i >=0; i--)
    //        {
    //            // this is where meet my variables again, here im using the reverseArr to put inside the value of the number that add each time and im taking the variable
    //            // Array from the loop to get each the numbers.  
    //            reverseArr[value] = Array[i];
    //            // here is where im using th value to update the number by one each time for example  we star at 5 the we go to 4,3,2,1
    //            ++value;
    //        }
    //        // at end im returning all of my work to the main method
    //        return reverseArr;
    //    }


    //    // this is a pubile static int of array methods called mostFrequent that has parameter with the array int type and latter on i will return it to the main methods.
    //    public static int MostFrequent(int[] ArrayOfnumbers)
    //    {
    //        // this is a int variable called mostFrequent that holding my array of random number and im start at the first number. 
    //        int mostFrequent = ArrayOfnumbers[0];
    //        // this is a int variable called maxCount it his the value of 1 im going to use to keep track of the highest frequency of number in my list of array.
    //        int maxCount = 1;
    //        //this is my outer for loop here im looping through the array the first time to see all of the numbers so i can start to count them the secound time in my inner loop. 
    //        for (int i = 0; i < ArrayOfnumbers.Length; i++)
    //        {
    //            // this is int variable called count it his thee value of 1 we are going use it so i can update ArrayOfnumbers[i] from my first outer loop. 
    //            int count = 1;
    //            //this is my inner loop im loop through it by use the i value from my outter loop to agian to so we can check of the numbers that reply with using the if latter on.  
    //            for (int j = i + 1; j < ArrayOfnumbers.Length; j++)
    //            {
    //                //here we are using the if to see if any number his a duplicate numbers 
    //                if (ArrayOfnumbers[j] == ArrayOfnumbers[i])
    //                {
    //                    // here we are increment count
    //                    count++;
    //                }
    //            }
    //            // if the count of the current number is greater than maxCount,
    //            // update maxCount and set mostFrequent to the current number
    //            if (count > maxCount)
    //            {
    //                maxCount = count;
    //                mostFrequent = ArrayOfnumbers[i];
    //            }
    //        }
    //        // at end im returning all of my work to the main method
    //        return mostFrequent;
    //    }
    //}


            //// this is array variable  the size of it is 5 it's a list of number they're 1 to 5 
            //int[] Array = new int[5] { 1, 2, 3, 4, 5 };
            //// this is variable  called arraybackward we are using it to save the methods ArrayReversal that has parameter with the array it type. we are going to used the variable to called it latter on.   
            //int[] arraybackwards = ArrayReversal(Array);
            //// we are using the Console.Write methods to show it on window prompt with the string ( Reversed Array:. with the string.Join to join the , and the arraybackwards variable) .  
            //Console.WriteLine("Reversed Array: " + string.Join(", ", arraybackwards));


            //this is array variable  the size of it is 5 it's a list of number they're 1 to 5
            int[] Array = new int[5] { 1, 2, 3, 4, 5 };
            // this is variable  called arraybackward we are using it to save the methods ArrayReversal that has parameter with the array it type. we are going to used the variable to called it latter on.   
            int[] arraybackwards = ArrayReversal(Array);
            // we are using the Console.Write methods to show it on window prompt with the string ( Reversed Array:. with the string.Join to join the , and the arraybackwards variable) .  
            Console.WriteLine("Reversed Array: " + string.Join(", ", arraybackwards));


            //// this is array variable  the size of it is 17 it's a list of random numbers
            //int[] ArrayOfnumbers = new int[17] { 62791, 2,3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            //// this is variable  called MostFrequentNumber we are using it to save the methods MostFrequent that has parameter with the array int type. we are going to used the variable to called it latter on.
            //int mostFrequentNumber = MostFrequent(ArrayOfnumbers);
            //// we are using the Console.Write methods to show it on window prompt with the string Most Frequent Number: and add to it the variable called MostFrequentNumber.
            //Console.WriteLine("Most Frequent Number: " + mostFrequentNumber);


            int[] midArray = new int[5] { 1, 2, 3, 4, 5 };
            int[] removedMidArray = RemoveMiddleValue(midArray);
            
            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(" ", midArray));
            Console.WriteLine("Array after removing middle value:");
            Console.WriteLine(string.Join(" ", removedMidArray));
        }

        public static int[] RemoveMiddleValue(int[] array)

            // this is array variable  the size of it is 17 it's a list of random numbers
            int[] ArrayOfnumbers = new int[17] { 62791, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            // this is variable  called MostFrequentNumber we are using it to save the methods MostFrequent that has parameter with the array int type. we are going to used the variable to called it latter on.
            int mostFrequentNumber = MostFrequent(ArrayOfnumbers);
            // we are using the Console.Write methods to show it on window prompt with the string Most Frequent Number: and add to it the variable called MostFrequentNumber.
            Console.WriteLine("Most Frequent Number: " + mostFrequentNumber);

            //here is where im defending the values that im going to pass to the parameter MaximumArrayOfNumber
            int[] MaximumArrayOfNumber = new int[5] { 7, 9, 13, 25, 5 };
            // here is where im calling the method
            int maximumValue = MaximumValue(MaximumArrayOfNumber);
            //here im print out to the console the maximum value in the array
            Console.WriteLine("The maximum value in the array is: " + maximumValue);
        }

        // this is a pubile static int of array methods called MaximumValue that has parameter with the array int type and latter on i will return it to the main methods.
        public static int MaximumValue(int[] MaximumArrayOfNumber)
        {
            //here is im using a veriable called maximumValue to hold the value of MaximumArrayOfNumber and latter on im going to return it to the main  
            int maximumValue = MaximumArrayOfNumber[0];
            // here where im looping thourgth the array of numbers
            for (int i = 0; i < MaximumArrayOfNumber.Length; i++)
            {
                // here im using the loop value to test to see if i got the maximum number
                if (MaximumArrayOfNumber[i] > maximumValue)
                {
                    // here is where im storing im maximum number inside my verible called maximumValue
                    maximumValue = MaximumArrayOfNumber[i];
                }
            }
            //last here is where im return the value to the main
            return maximumValue;
        }



        // this is a pubile static int of array methods called ArrayReversal that has parameter with the array int type and latter on i will return it to the main methods.
        public static int[] ArrayReversal(int[] Array)
        {
            // this is a int variable array type called reverseArr we are using it to get the array length size so we can loop through it latter on.
            int[] reverseArr = new int[Array.Length];
            // this is a int variable type called value it right now holds the value of 0 but latter on we are going to use it by put it inside of my variable called reverseArr.
            int value = 0;
            // this is a for loop that im using to loop through the array length start with the last number.
            for (int i = Array.Length - 1; i >= 0; i--)
            {
                // this is where meet my variables again, here im using the reverseArr to put inside the value of the number that add each time and im taking the variable
                // Array from the loop to get each the numbers.  
                reverseArr[value] = Array[i];
                // here is where im using th value to update the number by one each time for example  we star at 5 the we go to 4,3,2,1
                ++value;
            }
            // at end im returning all of my work to the main method
            return reverseArr;
        }


        // this is a pubile static int of array methods called mostFrequent that has parameter with the array int type and latter on i will return it to the main methods.
        public static int MostFrequent(int[] ArrayOfnumbers)

        {
            int middleIndex = array.Length / 2;

            int[] modifiedArray = new int[array.Length - 1]; 

            for (int i = 0, j = 0; i < array.Length; i++) 
            {
                if (i != middleIndex)
                {
                    modifiedArray[j++] = array[i];
                }
            }
            return modifiedArray;
        }

        //// this is a pubile static int of array methods called ArrayReversal that has parameter with the array int type and latter on i will return it to the main methods.
        //public static int[] ArrayReversal(int[] Array)
        //{
        //    // this is a int variable array type called reverseArr we are using it to get the array length size so we can loop through it latter on.
        //    int[] reverseArr = new int[Array.Length];
        //    // this is a int variable type called value it right now holds the value of 0 but latter on we are going to use it by put it inside of my variable called reverseArr.
        //    int value = 0;
        //    // this is a for loop that im using to loop through the array length start with the last number.
        //    for (int i = Array.Length-1; i >=0; i--)
        //    {
        //        // this is where meet my variables again, here im using the reverseArr to put inside the value of the number that add each time and im taking the variable
        //        // Array from the loop to get each the numbers.  
        //        reverseArr[value] = Array[i];
        //        // here is where im using th value to update the number by one each time for example  we star at 5 the we go to 4,3,2,1
        //        ++value;
        //    }
        //    // at end im returning all of my work to the main method
        //    return reverseArr;
        //}


        //// this is a pubile static int of array methods called mostFrequent that has parameter with the array int type and latter on i will return it to the main methods.
        //public static int MostFrequent(int[] ArrayOfnumbers)
        //{
        //    // this is a int variable called mostFrequent that holding my array of random number and im start at the first number. 
        //    int mostFrequent = ArrayOfnumbers[0];
        //    // this is a int variable called maxCount it his the value of 1 im going to use to keep track of the highest frequency of number in my list of array.
        //    int maxCount = 1;
        //    //this is my outer for loop here im looping through the array the first time to see all of the numbers so i can start to count them the secound time in my inner loop. 
        //    for (int i = 0; i < ArrayOfnumbers.Length; i++)
        //    {
        //        // this is int variable called count it his thee value of 1 we are going use it so i can update ArrayOfnumbers[i] from my first outer loop. 
        //        int count = 1;
        //        //this is my inner loop im loop through it by use the i value from my outter loop to agian to so we can check of the numbers that reply with using the if latter on.  
        //        for (int j = i + 1; j < ArrayOfnumbers.Length; j++)
        //        {
        //            //here we are using the if to see if any number his a duplicate numbers 
        //            if (ArrayOfnumbers[j] == ArrayOfnumbers[i])
        //            {
        //                // here we are increment count
        //                count++;
        //            }
        //        }
        //        // if the count of the current number is greater than maxCount,
        //        // update maxCount and set mostFrequent to the current number
        //        if (count > maxCount)
        //        {
        //            maxCount = count;
        //            mostFrequent = ArrayOfnumbers[i];
        //        }
        //    }
        //    // at end im returning all of my work to the main method
        //    return mostFrequent;
        //}

    }


}