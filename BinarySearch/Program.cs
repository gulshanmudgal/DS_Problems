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

#region Upper Bound Tests
void AssertUB(int[] nums, int target, int expected, string label)
{
    int result = UpperBound.FindUpperBound(nums, target);
    bool ok = result == expected;
    if (ok) passed++; else failed++;
    Console.WriteLine($"{(ok ? "PASS" : "FAIL")} | {label,-42} | x={target,-4} -> got={result}, expected={expected}");
}

Console.WriteLine();
Console.WriteLine("=== Upper bound tests ===");
AssertUB(new[] { 1, 3, 3, 4, 5 }, 3, 3, "First index after duplicates");
AssertUB(new[] { 1, 5, 5, 5 }, 5, 4, "x present, last occurrence edge");
AssertUB(new[] { 1, 2, 3, 5, 8 }, 6, 4, "x in gap (first > x)");
AssertUB(new[] { 1, 2, 3, 5, 8 }, 11, 5, "x greater than all -> size");
AssertUB(new[] { 1, 2, 3, 5, 8 }, 0, 0, "x less than all -> 0");
AssertUB(new int[] { }, 5, 0, "Empty array");

Console.WriteLine();
Console.WriteLine($"Total: {passed + failed} | Passed: {passed} | Failed: {failed}");
if (failed > 0)
{
    Console.WriteLine("⚠ Some cases failed.");
}
#endregion

#region Insert Position Tests
void AssertIP(int[] nums, int target, int expected, string label)
{
    int result = InsertPosition.Solution(nums, target);
    bool ok = result == expected;
    if (ok) passed++; else failed++;
    Console.WriteLine($"{(ok ? "PASS" : "FAIL")} | {label,-42} | target={target,-4} -> got={result}, expected={expected}");
}

Console.WriteLine();
Console.WriteLine("=== Insert position tests ===");
AssertIP(new[] { 2, 5, 8, 12, 16 }, 8, 2, "Target found exactly (middle)");
AssertIP(new[] { 2, 5, 8, 12, 16 }, 2, 0, "Target found exactly (first index)");
AssertIP(new[] { 2, 5, 8, 12, 16 }, 16, 4, "Target found exactly (last index)");
AssertIP(new[] { 2, 5, 8, 12, 16 }, 1, 0, "Target lower than all elements");
AssertIP(new[] { 2, 5, 8, 12, 16 }, 20, 5, "Target greater than all elements");
AssertIP(new[] { 2, 5, 8, 12, 16 }, 6, 2, "Target in gap between elements");
AssertIP(new[] { 2, 5, 8, 12, 16 }, 14, 4, "Target in gap near end");
AssertIP(new[] { 1, 3, 5, 7, 9 }, 4, 2, "Target in gap in middle");

Console.WriteLine();
Console.WriteLine($"Total: {passed + failed} | Passed: {passed} | Failed: {failed}");
if (failed > 0)
{
    Console.WriteLine("⚠ Some cases failed.");
}
#endregion

#region Floor and Ceil Tests
void AssertFC(int[] nums, int x, int expectedFloor, int expectedCeil, string label)
{
    int[] result = new FloorAndCeil().Solution(nums, x);
    bool ok = result[0] == expectedFloor && result[1] == expectedCeil;
    if (ok) passed++; else failed++;
    Console.WriteLine($"{(ok ? "PASS" : "FAIL")} | {label,-42} | x={x,-4} -> got=[{result[0]},{result[1]}], expected=[{expectedFloor},{expectedCeil}]");
}

Console.WriteLine();
Console.WriteLine("=== Floor and Ceil tests ===");
AssertFC(new[] { 2, 5, 8, 12, 16 }, 8, 8, 8, "Target found exactly");
AssertFC(new[] { 2, 5, 8, 12, 16 }, 16, 16, 16, "Target less than all -> no floor");
AssertFC(new[] { 2, 5, 8, 12, 16 }, 20, 16, -1, "Target greater than all -> no ceil");
AssertFC(new[] { 2, 5, 8, 12, 16 }, 6, 5, 8, "Target in gap between elements");
AssertFC(new[] { 2, 3, 3, 3, 5 }, 3, 3, 3, "Duplicates: target equals repeated");
AssertFC(new[] { 1, 1, 3, 3, 5, 5 }, 4, 3, 5, "Duplicates: target in gap between pairs");
AssertFC(new[] { 2, 2, 2, 2, 2 }, 2, 2, 2, "Duplicates: all elements equal");

Console.WriteLine();
Console.WriteLine($"Total: {passed + failed} | Passed: {passed} | Failed: {failed}");
if (failed > 0)
{
    Console.WriteLine("⚠ Some cases failed.");
}
#endregion

#region Search Range Tests
void AssertSR(int[] nums, int target, int expectedLeft, int expectedRight, string label)
{
    int[] result = SearchRange.Solution(nums, target);
    bool ok = result[0] == expectedLeft && result[1] == expectedRight;
    if (ok) passed++; else failed++;
    Console.WriteLine($"{(ok ? "PASS" : "FAIL")} | {label,-42} | target={target,-4} -> got=[{result[0]},{result[1]}], expected=[{expectedLeft},{expectedRight}]");
}

Console.WriteLine();
Console.WriteLine("=== Search range tests ===");
AssertSR(new[] { 5, 7, 7, 8, 8, 10 }, 8, 3, 4, "Duplicates in middle");
AssertSR(new[] { 5, 7, 7, 8, 8, 10 }, 6, -1, -1, "Target not present");
AssertSR(new[] { 5, 7, 7, 8, 8, 10 }, 5, 0, 0, "Single occurrence at start");
AssertSR(new[] { 5, 7, 7, 8, 8, 10 }, 10, 5, 5, "Single occurrence at end");
AssertSR(new[] { 2, 2, 2, 2, 2 }, 2, 0, 4, "All elements equal");
AssertSR(new int[] { }, 0, -1, -1, "Empty array");
AssertSR(new[] { 1 }, 1, 0, 0, "Single element present");
AssertSR(new[] { 1 }, 0, -1, -1, "Single element absent");

Console.WriteLine();
Console.WriteLine($"Total: {passed + failed} | Passed: {passed} | Failed: {failed}");
if (failed > 0)
{
    Console.WriteLine("⚠ Some cases failed.");
}
#endregion

#region Search in a sorted but rotated array
void AssertSRA(int[] nums, int k, int expected, string label)
{
    int result = SearchSortedRotatedArray.Search(nums, k);
    bool ok = result == expected;
    if (ok) passed++; else failed++;
    Console.WriteLine($"{(ok ? "PASS" : "FAIL")} | {label,-42} | k={k,-4} -> got={result}, expected={expected}");
}

Console.WriteLine();
Console.WriteLine("=== Search in rotated sorted array tests ===");
AssertSRA(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4, "Target in right half");
AssertSRA(new[] { 4, 5, 6, 7, 0, 1, 2 }, 5, 1, "Target in left half");
AssertSRA(new[] { 4, 5, 6, 7, 0, 1, 2 }, 4, 0, "Target is first element");
AssertSRA(new[] { 4, 5, 6, 7, 0, 1, 2 }, 2, 6, "Target is last element");
AssertSRA(new[] { 4, 5, 6, 7, 0, 1, 2 }, 7, 3, "Target at pivot");
AssertSRA(new[] { 4, 5, 6, 7, 0, 1, 2 }, 9, -1, "Target absent (greater than all)");
AssertSRA(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1, "Target absent (in gap)");
AssertSRA(new[] { 1, 3 }, 3, 1, "Two elements, not rotated");
AssertSRA(new[] { 3, 1 }, 3, 0, "Two elements, pivot at 0, target first");
AssertSRA(new[] { 3, 1 }, 1, 1, "Two elements, pivot at 0, target last");
AssertSRA(new[] { 5, 1, 3 }, 3, 2, "Pivot mid, target in right half");
AssertSRA(new[] { 1, 2, 3, 4, 5 }, 4, 3, "Fully sorted (no pivot)");
AssertSRA(new[] { 1, 2, 3, 4, 5 }, 0, -1, "Fully sorted, target absent");
AssertSRA(new[] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 10, 11 }, 11, 10, "Large rotation, target near end");
AssertSRA(new[] { 1 }, 1, 0, "Single element present");
AssertSRA(new[] { 1 }, 0, -1, "Single element absent");

Console.WriteLine();
Console.WriteLine($"Total: {passed + failed} | Passed: {passed} | Failed: {failed}");
if (failed > 0)
{
    Console.WriteLine("⚠ Some cases failed.");
}
#endregion
