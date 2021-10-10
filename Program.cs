using System;

namespace FromAtoB
{
    class Program
    {
        string[] tokens = Console.Readline().Split();

        int A = int.Parse(tokens[0]);
        int B = int.Parse(tokens[1]);

 if (A == B)
return 0;

 else if (A > B)
return A - B;
if (A <= 0 && B > 0)
return A - 1;

 if (A* 2 == 0)
return A /= 2;

 else if (A* 4 = 1 || A = 3)
return A += 1;
}
}
