// See https://aka.ms/new-console-template for more information
using BinarySearch;

int passed = 0, failed = 0;

#region Binary Search Tests
void Assert(int[] nums, int target, int expected, string label)
{
    int result = SearchSortedArray.Search(nums, target);
    bool ok = result == expected;
    if (ok) passed++; else failed++;
    Console.WriteLine($"{(ok ? "PASS" : "FAIL")} | {label,-42} | target={target,-4} -> got={result}, expected={expected}");
}

Console.WriteLine("=== Binary search tests ===");
Assert(new[] { 2, 5, 8, 12, 16 }, 8, 2, "Target found in middle");
Assert(new[] { 2, 5, 8, 12, 16 }, 16, 4, "Target found at last index (edge)");
Assert(new[] { 2, 5, 8, 12, 16 }, 9, -1, "Target not found");

Console.WriteLine();
Console.WriteLine($"Total: {passed + failed} | Passed: {passed} | Failed: {failed}");
if (failed > 0)
{
    Console.WriteLine("⚠ Some cases failed.");
}
#endregion
