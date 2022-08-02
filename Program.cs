// Exercício do site URI "Maior e Posição"
// Esse programa o usuário irá digitar 100 numeros inteiros, em seguida o o programa mostrará o maior numero e a posição dele.


int Maior = 0;
int Posicao = 0;

for (int i = 1; i <= 100; i++)
{
    int Num = int.Parse(Console.ReadLine());

    if (Num > Maior)
    {
        Maior = Num;
        Posicao = i;
    }
}
Console.WriteLine(Maior);
Console.WriteLine(Posicao);