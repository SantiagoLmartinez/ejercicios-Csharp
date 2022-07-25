//imprimir numeros pares por consola
for(int i = 0; i <=10; i++)
{
    if((i % 2) != 0)
    {
        Console.WriteLine("Numero Impar "+ i);
    }
    if ((i % 2) == 0)
    {
        Console.WriteLine("Numero Par "+ i);
    }
}
//Imprimir Secuencia Fibbonacci
int x1 = 0;
int x2 = 1;
int x3;

//int fn = x1 - 1 + x2 - 2;
Console.WriteLine("/////////////////");
for (int i = 0; i <= 10; i++)
{
    x3 = x1 + x2;
    x1 = x2;
    x2 = x3;

    Console.WriteLine("Fibbonacci " + x3);
}
