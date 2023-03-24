string[] stringArray = {"bndty", "bn", "156", ",", "%#$", "9"};

string[] group = Array.FindAll(stringArray, max3 => max3.Length <= 3);
foreach (var max3 in group) Console.WriteLine(max3);
