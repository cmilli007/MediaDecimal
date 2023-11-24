Console.Write("Digite a quantidade de numeros:");
int quantidade = Convert.ToInt32(Console.ReadLine());
decimal numeroDigitado;
int medidor = 0;

decimal soma = 0;
decimal maiorNumero = 999999.99M;
decimal menorNumero = 999999.99M;

while (medidor < quantidade)
{
    medidor +=1;
 Console.Write($"Digite o número para operação #{medidor}: ");
    numeroDigitado = Convert.ToDecimal(Console.ReadLine());
    soma = soma + numeroDigitado;

    if (medidor == 1)
    {
        maiorNumero = numeroDigitado;
        menorNumero = numeroDigitado;
    }

    if (numeroDigitado > maiorNumero)
    {
        maiorNumero = numeroDigitado;
    }

    if (numeroDigitado < menorNumero)
    {
        menorNumero = numeroDigitado;
    }
}

if (medidor> 0)
{
    decimal media = soma / quantidade;

    Console.WriteLine($"\nSoma...: {soma:N2}");
    Console.WriteLine($"Média..: {media:N2}");
    Console.WriteLine($"Número menor da operaçao..: {menorNumero:N2}");
    Console.WriteLine($"Número maior da operaçao..: {maiorNumero:N2}");
}