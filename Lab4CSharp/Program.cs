
using Lab4CSharp;
using Microsoft.VisualBasic.FileIO;

Console.WriteLine("Lab4 C# ");
void Test()
{
    VectorLong vector1 = new VectorLong(2, 2);
    VectorLong vector2 = new VectorLong(3, 3);
    Console.WriteLine("1. Vector 1 Output:");
    vector1.Output();

    Console.WriteLine("2. Vector 1 Output:");
    vector2.Output();

    Console.WriteLine("2. num vectors: " + VectorLong.GetNumVectors());

    Console.WriteLine("3. ++: ");
    ++vector1;
    vector1.Output();

    Console.WriteLine("3. --: ");
    --vector1;
    vector1.Output();

    if (vector1)
    {
        Console.WriteLine("vector true");
    } else
    {
        Console.WriteLine("vector false");
    }

    Console.WriteLine("3. (!) " + !vector1);

    Console.WriteLine("4. (~) ");
    (~vector1).Output();

    Console.WriteLine("5. (vec + vec) ");
    (vector1 + vector2).Output();

    Console.WriteLine("6. (vec - vec) ");
    (vector1 - vector2).Output();

    Console.WriteLine("6. (vec * vec) ");
    (vector1 * vector2).Output();

    Console.WriteLine("8. (vec / vec) ");
    (vector1 / vector2).Output();

    Console.WriteLine("9. (vec % vec) ");
    (vector1 % vector2).Output();

    Console.WriteLine("10. (vec | vec) ");
    (vector1 | vector2).Output();

    Console.WriteLine("11. (vec & vec) ");
    (vector1 & vector2).Output();

    Console.WriteLine("13. (vec ^ vec) ");
    (vector1 ^ vector2).Output();

    Console.WriteLine("14. (vec << 2) ");
    (vector1 << 2).Output();

    Console.WriteLine("15. (vec >> 2) ");
    (vector1 >> 2).Output();

    Console.WriteLine("16. (vec == vec) " + (vector1 == vector2));
    Console.WriteLine("17. (vec != vec) " + (vector1 != vector2));

    Console.WriteLine("18. (vec > vec) " + (vector1 > vector2));
    Console.WriteLine("19. (vec >= vec) " + (vector1 >= vector2));

    Console.WriteLine("20. (vec < vec) " + (vector1 < vector2));
    Console.WriteLine("21. (vec <= vec) " + (vector1 <= vector2));

    Console.WriteLine("22. vector code error " + vector1.CodeError);
    long someValue = vector1[2];
    Console.WriteLine("23. vector code error " + vector1.CodeError);

    GC.Collect();
    Console.WriteLine("24. call ~Desctructor");
}
Test();

