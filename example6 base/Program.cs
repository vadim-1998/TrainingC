﻿int a = 5;
int b = 3;
int c = 4;
int d = 8;
int e = 2;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max= ");
Console.WriteLine(max);