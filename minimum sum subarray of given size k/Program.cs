// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

int[] arr = { 10, 4, 2, 5, 6, 3, 8, 1 };
int k = 3;

findSubarray(arr, k);

static void findSubarray(int[] arr, int k)
{
    int sum = 0;
    int MinToHere = int.MaxValue;
    int SoFar = 0;
    int count = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
        if (count < k)
        {
            count++;
        }
        else
        {
            if (MinToHere > sum)
            {
                MinToHere = sum;
                SoFar = i; 
            }
            sum -= arr[i - k + 1];
        }
    }

    Console.WriteLine(MinToHere);
    Console.WriteLine(SoFar-k+1 + ","+ SoFar);
}