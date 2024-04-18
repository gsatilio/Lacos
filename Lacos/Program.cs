int n1 = 0 , max = 0, i = 0, contador = 0, aux = 0;

Console.WriteLine("Informe um numero");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe um numero incrementador");
max = int.Parse(Console.ReadLine());


// laço de do while
aux = n1;
Console.WriteLine("aqui eh o do");
do
{
    Console.WriteLine(aux);
    aux++;
    contador++;
} while (contador <= max);

// teste 
//laço de while
aux = n1;
Console.WriteLine("aqui eh o while");
contador = 0;
while (contador <= max)
{
    Console.WriteLine(aux);
    aux++;
    contador++;
}

// laço de for
aux = n1;
Console.WriteLine("Aqui eh o for");
for(contador = 0; contador <= max; contador++)
{
    Console.WriteLine(aux);
    aux++;
}


Console.ReadKey();