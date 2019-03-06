using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = solution(new int[] { 1, 2,3}, 4);

            for (int index = 0; index < A.Length; index++)
            {
                Console.WriteLine(A[index]);
            }
            Console.ReadLine();
        }

        static int[] solution(int[] A, int K)
        {
            int ALen = A.Length;
            int[] NewA = new int[ALen];

            if (ALen > K)
                for (int index = 0; index < A.Length; index++)
                {
                    if ((index + K) >= ALen)
                        NewA[((index + K) - ALen)] = A[index];
                    else
                        NewA[(index + K)] = A[index];
                }
            if (ALen == K)
                NewA = A;
            if (ALen < K)
            {
                int Column = 0;
                for (int index = 0; index < ALen; index++)
                {
                    Column = index;
                    for (int index2 = 1; index2 <= K; index2++)
                    {
                        if (Column < (ALen-1))
                            Column++;
                        else
                            Column = 0;
                    }
                    NewA[Column] = A[index];
                }
            }
            return NewA;
        }


    }
}
