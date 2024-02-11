using Heap;

int[] input = new int[6] { 7, 10, 4, 3, 20, 15 };
int resultPB01 = PB_01_Kth_Smallest.GetKthSmallestNumber(input, 3);
Console.WriteLine(resultPB01);

int resultPB02 = PB_02_Kth_Largest.FindKthLargest(input, 3);
Console.WriteLine(resultPB02);

int[] resultPB03 = PB_03_K_Largest.GetKLargest(input, 3);
Console.WriteLine(String.Join(',', resultPB03));

int[] nearlySortedInput = new int[] { 6, 5, 3, 2, 8, 10, 9 };
int[] resultPB04 = PB_04_Sort_K_Sorted.GetNearlySorted(nearlySortedInput, 3);
Console.WriteLine(String.Join(',', resultPB04));

int[] inputPB05 = new int[5] { 1, 2, 3, 4, 5 };
IList<int> resultPB05 = PB_05_K_Closest.FindClosestElements(inputPB05, 4, 3);
Console.WriteLine(String.Join(',', resultPB05));


int[][] inputPB08 = new int[3][];
inputPB08[0] = new int[2];
inputPB08[1] = new int[2];
inputPB08[2] = new int[2];
inputPB08[0][0] = 3;
inputPB08[0][1] = 3;
inputPB08[1][0] = 5;
inputPB08[1][1] = -1;
inputPB08[2][0] = -2;
inputPB08[2][1] = 4;
int[][] resultPB08 = PB_08_Closeset_Points.KClosest(inputPB08, 2);
Console.WriteLine("PB08 Reslts");
foreach (var item in resultPB08)
{
    Console.WriteLine(String.Join(',', item));
}
Console.WriteLine();

long[] inputPB09 = new long[4] { 4, 3, 2, 6 };
long resultPB09 = PB_09_Minimum_Cost.MinCost(inputPB09);
Console.WriteLine(resultPB09);
