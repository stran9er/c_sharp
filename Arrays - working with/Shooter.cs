using System;

namespace Shooters
{
    public class SectOne
    {
        public static string numBallons(int N, int Y, int[] H)
        // public static int numBallons(int N, int Y, int[] H)
        {
            int burst = 0;
            int released = 0;
            int unaffected = 0;
            var BulletLocation = Y;
            int HalfCount = H.Length / 2;
            int[] FirstPart = new int[H.Length / 2];
            Array.Copy(H, FirstPart, H.Length / 2);

            // See if the first part of the array is hit. 
            for (int i = 0; i < FirstPart.Length; i++)
            {
                if (H[i] == BulletLocation)
                {
                    burst = burst + 1;
                }
                if (H[i] > BulletLocation)
                {
                    released = released + 1;
                }
                if (H[i] < BulletLocation)
                {
                    unaffected = unaffected + 1;
                }
                BulletLocation = BulletLocation - 1; 
            }
            // Work with the second part of the array to see if they are hit.
            BulletLocation = 0;

            for (int i = HalfCount; i < (H.Length); i++ )
            {
                if (H[i] == BulletLocation )
                {
                    burst = burst + 1;
                }
                if (H[i] > BulletLocation)
                {
                    released = released + 1;
                }
                if (H[i] < BulletLocation)
                {
                    unaffected = unaffected + 1;
                }
                BulletLocation = BulletLocation + 1;
            }

            // Return as string, instead of int.

            return "Burst: " + burst +"\tReleased: " + released + "\tUnaffected: "+ unaffected;
        }


        public static void Main()
        {
            //INPUT [uncomment and mod if req]
            int N = 0, Y = 0;
            string[] tokens = Console.ReadLine().Split();
            N = Convert.ToInt32(tokens[0]);
            Y = Convert.ToInt32(tokens[1]);

            string[] temp = Console.ReadLine().Split();
            int[] H = new int[N];

            for (int i = 0; i < N; i++)
            {
                H[i] = Convert.ToInt32(temp[i]);
            }

            //OUTPUT [uncomment & mod if req]
            Console.WriteLine(numBallons(N, Y, H));
        }
    }
}


