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
