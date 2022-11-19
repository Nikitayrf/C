// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void coordinate (int[] point){
    int count=0;
    for (int i = 0; i<point.Length;i++){
        Console.Write($"{count+1}-e значение : ");
        point[i] = Convert.ToInt32(Console.ReadLine());
        count++;
    }
}

void printArray (int[] array) {
    for (int i =0; i<array.Length;i++){
        Console.Write($"{array[i]} ");
    }
}

int plane = 3; //кол-во плоскостей

Console.WriteLine("Введите координаты точки A ");
int[] A = new int[plane];

coordinate(A);
Console.Write($"Координаты точки A : ");
printArray(A);

Console.WriteLine("\n\nВведите координаты точки B ");
int[] B = new int[plane];

coordinate(B);
Console.Write($"Координаты точки B : ");
printArray(B);

double result = Math.Round(Math.Sqrt((Math.Pow(A[0] -B[0],2) + Math.Pow(A[1]-B[1],2) + Math.Pow(A[2]-B[2],2))),2);

Console.WriteLine($"\nРасстояние между точками A и B в 3D пространстве равно -> {result}");