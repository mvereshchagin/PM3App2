using MathUtils;

Vector3d a = new (){ X = 3, Y = 5, Z = 6};
Vector3d b = new (){ X = 1, Y = 2, Z = 3};

Point3d pointA = new () { X = 2, Y = -3, Z = -5 };
Point3d pointB = new () { X = -1, Y = 2, Z = -1 };
var c = new Vector3d(pointA, pointB);

var mixedRes = Vector3d.MixedProduct(a, b, c);
var scalarRes = Vector3d.DotProduct(a, b);
var crossRes = Vector3d.CrossProduct(a, b);

var dotProduct = b * c;

Console.WriteLine($"{a} X {b} = {crossRes}");
Console.WriteLine($"{a} * {b} = {scalarRes}");
Console.WriteLine($"[{a} X {b}] * {c} = {mixedRes}");

Console.WriteLine($"{(a > b ? "a" : "b")} is larger than {(a > b ? "b" : "a")}");



