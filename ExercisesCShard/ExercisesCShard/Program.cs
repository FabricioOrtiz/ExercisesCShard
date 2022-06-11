// See https://aka.ms/new-console-template for more information
/*
 Escribir un programa que muestre en pantalla los números del 1 al 100, sustituyendo los múltiplos de 3 por la palabra “fizz”, los múltiplos de 5 por “buzz” y los múltiplos de ambos, es decir, los múltiplos de 3 y 5 (o de 15), por la palabra “fizzbuzz”.
 */


using ExercisesCShard;

using System.Collections;

TestClass t = new TestClass();

//Stack st = new Stack();
//st.Push(1);
//st.Push(1.1);
//st.Push('z');
//st.Push("Hello");

//foreach (var e in st)
//{
//    Console.WriteLine(e);
//}



//int i = 5;
//t.DoTask(ref i);

//Console.WriteLine(i);

//test student = new test();
//student.Name = "Julia";

//Console.WriteLine(student.Name);




//int amountOfEvenNumbersRequired = Convert.ToInt32(Console.ReadLine());

//List<int> numbers = new List<int>();
//for (int i = 1; i <= 200; i++)
//{
//    numbers.Add(i);
//}
//List<int> res = t.GetEvenNumbers(numbers, amountOfEvenNumbersRequired);

//foreach (var evenNumber in res)
//{
//    Console.WriteLine(evenNumber);
//}






int collectionCount = Convert.ToInt32(Console.ReadLine().Trim());

List<int> collection = new List<int>();

for (int i = 0; i < collectionCount; i++)
{
    int collectionItem = Convert.ToInt32(Console.ReadLine().Trim());
    collection.Add(collectionItem);
}

int d = Convert.ToInt32(Console.ReadLine().Trim());

List<int> result = t.hackerCards(collection, d);

Console.WriteLine(String.Join("\n", result));