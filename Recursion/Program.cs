using System;
using System.Collections.Generic;
using System.Globalization;

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

#region
var nums = new List<int>() {3, 2, 1};
var sol = PowerSetSolution.PowerSet(nums);
PrintListOfLists(sol);

#endregion