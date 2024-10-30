/*
 * The Strategy pattern is a behavioral design pattern that allows you to define a family of algorithms,
 * encapsulate each one, and make them interchangeable. It lets the algorithm vary independently
 * from clients that use it.
 * 
 * Here is a simple example of types of sorting algorithms that are applied to a list of integers.
 */

global using Strategy;
global using Strategy.Interfaces;

List<int> list = new() { 3, 2, 1, 5, 4 };

/* SortContext is the instance that will hold the sorting strategy. */
SortContext context = new();

/* Strategies can be changed at runtime. */
context.SetSortStrategy(new BubbleSort());
context.Sort(list);
Console.WriteLine(string.Join(", ", list));

context.SetSortStrategy(new InsertionSort());
context.Sort(list);
Console.WriteLine(string.Join(", ", list));

context.SetSortStrategy(new SelectionSort());
context.Sort(list);
Console.WriteLine(string.Join(", ", list));