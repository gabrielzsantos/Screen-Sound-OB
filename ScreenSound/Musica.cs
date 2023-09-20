class Musica
{
    public string nome;
    public string artista;
    public int duracaoEmSegundos;
    public bool disponivel;

    public void ExibirfixaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracaoEmSegundos}");
        if (disponivel)
        {
            Console.WriteLine("Disponivel no plano\n");
        } else
        {
            Console.WriteLine("Adquira no plano Plus+\n");
        }
    }
}