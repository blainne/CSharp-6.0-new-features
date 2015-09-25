<Query Kind="Program">
  <Namespace>static System.Console</Namespace>
  <Namespace>static System.DayOfWeek</Namespace>
  <Namespace>static System.Math</Namespace>
</Query>

//Old way
//using System

//New way
//using static System.DayOfWeek;
//using static System.Math;
//using static System.Console;

void Main()
{
	(DayOfWeek.Friday - DayOfWeek.Monday).Dump("Old way");
	(Friday - Monday).Dump("New way");


	Math.Round(Math.PI, 5).Dump("Old way");
	Round(PI, 5).Dump("New way");


	Console.WriteLine("Old way");
	WriteLine("New way");
}