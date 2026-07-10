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

#region Lower Bound Tests
void AssertLB(int[] nums, int target, int expected, string label)
{
    int result = LowerBound.FindLowerBound(nums, target);
    bool ok = result == expected;
    if (ok) passed++; else failed++;
    Console.WriteLine($"{(ok ? "PASS" : "FAIL")} | {label,-42} | x={target,-4} -> got={result}, expected={expected}");
}

Console.WriteLine();
Console.WriteLine("=== Lower bound tests ===");
AssertLB(new[] { 1, 3, 3, 4, 5 }, 3, 1, "First of duplicates");
AssertLB(new[] { 1, 5, 5, 5 }, 4, 1, "x between elements");
AssertLB(new[] { 1, 2, 3, 5, 8 }, 6, 4, "x in gap (first > x)");
AssertLB(new[] { 1, 2, 3, 5, 8 }, 11, 5, "x greater than all -> size");
AssertLB(new[] { 1, 2, 3, 5, 8 }, 0, 0, "x less than all -> 0");
AssertLB(new int[] { }, 5, 0, "Empty array");

Console.WriteLine();
Console.WriteLine($"Total: {passed + failed} | Passed: {passed} | Failed: {failed}");
if (failed > 0)
{
    Console.WriteLine("⚠ Some cases failed.");
}
#endregion
