
using Lab4CSharp;

Console.WriteLine("Lab4 C# ");
void Test()
{
    Console.WriteLine("STUDENT: Faryna Yurii, 341b");

    Console.WriteLine("Task 1:");
    Money money = new Money(50, 100);
    Console.WriteLine("1. Indexer: " + money[0] + ", " + money[1]);
    Console.WriteLine("2. ++");

    money++;
    Console.WriteLine(money);

    Console.WriteLine("3. --");
    Console.WriteLine("4. implicit - to string");
    money--;
    Console.WriteLine(money);

    Console.WriteLine("5. explicit - to Money");
    string str = "23,100";
    Money strMoney = (Money) str;
    Console.WriteLine(strMoney);

    Console.WriteLine("6. (!) " + !money);

    Console.WriteLine("7. (vec + 3) " + (money + 3));


    Console.WriteLine("\nTask 2:");
    VectorLong vector1 = new VectorLong(2, 2);
    VectorLong vector2 = new VectorLong(3, 3);
    Console.WriteLine("1. Vector 1 Output:");
    vector1.Output();

    Console.WriteLine("2. Vector 2 Output:");
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