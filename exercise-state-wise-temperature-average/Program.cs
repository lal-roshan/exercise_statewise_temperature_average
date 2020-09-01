using System;

namespace exercise_state_wise_temperature_average
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*declare array for collecting temperature of cities of 3 states
             *
             *first state provides temperature of 3 cities
             *second state provides temperature of 7 cities
             *third state provides temperature of 4 cities
            */
            int[][] states = new int[3][];
            states[0] = new int[3] {4,6,8};
            states[1] = new int[7] {5,7,8,1,2,9,6};
            states[2] = new int[4] {5,8,3,4};
            /*
             * Call GetStateWiseAverage() with state position and temperature data
             */
            int state1Avg = GetStateWiseAverage(0,states);
            int state2Avg = GetStateWiseAverage(1,states);
            int state3Avg = GetStateWiseAverage(2,states);
            /*
             * Display Average
             */
             Console.WriteLine("State 1 Average: " + state1Avg);
             Console.WriteLine("State 2 Average: " + state2Avg);
             Console.WriteLine("State 3 Average: " + state3Avg);
        }

        /* 
         * Method calculates average of temperature for the state whose position is provided
         */

        public static int GetStateWiseAverage(int index, int[][] states)
        {
            // put here logic to calculate average
            int total = 0;
            foreach(int temp in states[index]){
                total += temp;
            }
            return total/states[index].Length;
        }
    }
}
