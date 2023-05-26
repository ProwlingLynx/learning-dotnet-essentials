// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting numerical data in .NET

int[] quarters = { 1, 2, 3, 4 };
int[] sales = { 100000, 150000, 200000, 225000 };
double[] intlMixPct = { .386, .413, .421, .457 };
int val1 = 1234;
decimal val2 = 1234.5678m;

// TODO: Specifying Numerical formatting
// General format is {index[,alignment]:[format]}
// Common types are N (Number), G (General), F (Fixed-point),
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)
// Console.WriteLine($"{val1:d}, {val1:n}, {val1:f}, {val1:g}"); // If you add a space between the colon and format code it will break.
// Console.WriteLine($"{val2:e}, {val2:n}, {val2:f}, {val2:g}");

// TODO: Add a number after the format to specify precision
// Console.WriteLine($"{val1:d6}, {val1:n2}, {val1:f1}, {val1:g3}");


// TODO: Formatting with alignment and spacing
Console.WriteLine("Sales by Quarter:");
Console.WriteLine($"{quarters[0],12} {quarters[1],12} {quarters[2],12} {quarters[3],12}");
Console.WriteLine($"{sales[0],12:c0} {sales[1],12:c0} {sales[2],12:c0} {sales[3],12:c0}");
Console.WriteLine("International Sales:");
Console.WriteLine($"{intlMixPct[0],12:p0} {intlMixPct[1],12:p0} {intlMixPct[2],12:p1} {intlMixPct[3],12:p2}");

