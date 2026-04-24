using System;
using System.Collections.Generic;
using System.Globalization;

#region Helper Methods
void PrintLists(List<int> list, string indent = "")
{
	if (list == null)
	{
		Console.WriteLine(indent + "null");
		return;
	}

	Console.Write(indent);
	Console.Write("[");
	for (int i = 0; i < list.Count; i++)
	{
		Console.Write(list[i]);
		if (i < list.Count - 1) Console.Write(", ");
	}
	Console.WriteLine("]");
}

void PrintListOfLists(List<List<int>> lists)
{
	if (lists == null)
	{
		Console.WriteLine("null");
		return;
	}

	Console.WriteLine("[");
	foreach (var l in lists)
	{
		PrintLists(l, "  ");
	}
	Console.WriteLine("]");
}

void ClearConsole()
{
	try
	{
		if (!Console.IsOutputRedirected)
		{
			Console.Clear();
			return;
		}
	}
	catch
	{
		// ignore and try fallback
	}

	// Fallback: ANSI clear (works in terminals that support it)
	try
	{
		Console.Write("\u001b[2J\u001b[H");
		Console.Out.Flush();
		return;
	}
	catch
	{
		// ignore
	}

	// Last resort: emit several new lines to push previous output out of view
	for (int i = 0; i < 50; i++) Console.WriteLine();
}

#endregion

#region Power Set Problem
ClearConsole();
var nums = new List<int>() {3, 2, 1};
var sol = PowerSetSolution.PowerSet(nums);
PrintListOfLists(sol);
#endregion

#region Count all subsequences with sum K
ClearConsole();
var answer = CountSubsequenceWithTargetSumSolution.CountSubsequenceWithTargetSum(new int[5] {4,9,2,5,1}, 10);
Console.WriteLine(answer);
#endregion

#region check if a subsequence exists with sum K
ClearConsole();
var doesExist = CheckSubsequenceSumSolution.CheckSubsequenceSum(new List<int> {4,9,2,5,1}, 10);
Console.WriteLine(doesExist);
#endregion
