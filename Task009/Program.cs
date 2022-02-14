// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// ¬ - знак отрицания
// ⋀ - логическое "И"
// ⋁ - логическое "ИЛИ"
// следовательно не (X или Y)= не X и не Y

bool x = true;
bool y = true;

if (!(x || y) == (!x && !y))
    Console.WriteLine("(вар 1) утверждение истинно при x = true y = true");
else
    Console.WriteLine("(вар 1) утверждение не истинно при x = true y = true");

x = true;
y = false;

if (!(x || y) == (!x && !y)) 
    Console.WriteLine("(вар 2) утверждение истинно при x = true y = false");
else
    Console.WriteLine("(вар 2) утверждение не истинно при x = true y = false");

x = false;
y = true;

if (!(x || y) == (!x && !y))
    Console.WriteLine("(вар 3) утверждение истинно при x = false y = true");
else
    Console.WriteLine("(вар 3) утверждение не истинно при x = false y = true");

x = false;
y = false;

if (!(x || y) == (!x && !y))
    Console.WriteLine("(вар 4) утверждение истинно при x = false y = false");
else
    Console.WriteLine("(вар 4) утверждение не истинно при x = false y = false");