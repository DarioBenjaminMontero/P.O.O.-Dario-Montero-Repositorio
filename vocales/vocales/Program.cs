Console.Write("Escribi una frase: ");
string frase = Console.ReadLine();

int contador = 0;

for (int i = 0; i < frase.Length; i++)
{
    char min = char.ToLower(frase[i]);

    if (min == 'a' || min == 'e' || min == 'i' || min == 'o' || min == 'u')
        contador = contador + 1;
}

Console.WriteLine("Total de vocales: " + contador);