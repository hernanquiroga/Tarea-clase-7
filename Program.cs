//Tarea clase 7 


int[] userNumber = new int[10]; // Declaro la matriz

for (int i = 0;  i < userNumber.Length; i++) // Bucle de 10 ciclos
{
    Console.WriteLine($"Ingrese el {i+1}º número");
    userNumber[i] = Convert.ToInt32(Console.ReadLine()); // Guarda los datos ingresados en cada indice generado por "i"
}

Console.WriteLine("---------------------------------------");

// Calculo de valores ingresados
int suma = 0;
int promedio = 0;

for (int i = 0; i < userNumber.Length; i++)
{
    suma += userNumber[i];  // Sumo todos los indices   
    
}

Console.WriteLine($"El resultado de la suma es {suma}");
Console.WriteLine("---------------------------------------");

// Promedio 
promedio = suma / 10;   // Calculo el promedio
Console.WriteLine($"El promedio de los números ingresados es :{promedio}");
Console.WriteLine("---------------------------------------");

// Imprimir todos los indices
Console.WriteLine("Los numeros ingresados fueron: ");

foreach (var item in userNumber)
{
    Console.Write(item +" | ");
}

Console.WriteLine("");
Console.WriteLine("---------------------------------------");

// Calcular el numero mas grande

int n = userNumber.Length;

// Bucle para ordenar los indices de mayor a menor metodo Insercion directa

for (int i = 1; i < n; ++i) 
{
    int key = userNumber[i];
    int j = i - 1;


    while (j >= 0 && userNumber[j] < key)
    {
        userNumber[j + 1] = userNumber[j];
        j = j - 1;
    }
    userNumber[j + 1] = key;
}

Console.WriteLine("El numero mayor es: "+ userNumber[0]);

Console.WriteLine("---------------------------------------");

Console.WriteLine("El numero menor es: " + userNumber[9]);

Console.WriteLine("---------------------------------------");






