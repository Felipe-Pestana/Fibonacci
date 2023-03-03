double ant = 1, prox = 0;
int posicao;

Console.Write("Informe a posicao desejada: ");
posicao = int.Parse(Console.ReadLine());

for (int i = 0; i < posicao; i++)
{
    Console.Write(ant + " ");
    ant = prox + ant;
    prox = ant - prox;
}