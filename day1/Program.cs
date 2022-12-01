
using System;
using System.IO;
using System.Linq;

day1();
day2();

void day1()
{
    var lines = File.ReadAllText(@"input1.txt");

    var groups = lines.Split(Environment.NewLine + Environment.NewLine);
    List<int> maxList = new();
    foreach(var group in groups)
    {
        maxList.Add(group.Split("\n").Select(x => int.Parse(x)).Sum());
    }

    Console.WriteLine(maxList.Max());
}

void day2()
{
    var lines = File.ReadAllText(@"input1.txt");

    var groups = lines.Split(Environment.NewLine + Environment.NewLine);
    List<int> maxList = new();
    foreach(var group in groups)
    {
        maxList.Add(group.Split("\n").Select(x => int.Parse(x)).Sum());
    }

    Console.WriteLine(maxList.OrderDescending().Take(3).Sum());
}
