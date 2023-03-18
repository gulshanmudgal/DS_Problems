using Heap;

int[] input = new int[6] { 7, 10, 4, 3, 20, 15 };
int resultPB01 = PB_01_Kth_Smallest.GetKthSmallestNumber(input, 3);
Console.WriteLine(resultPB01);

int resultPB02 = PB_02_Kth_Largest.FindKthLargest(input, 3);
Console.WriteLine(resultPB02);

int[] resultPB03 = PB_03_K_Largest.GetKLargest(input, 3);
Console.WriteLine(String.Join(',', resultPB03));