using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace Estudos;
public class Carro
{
    public string Marca { get; set; } = String.Empty;
    public string Modelo { get; set; }
    public DateOnly AnoFabricacao { get; set; }
    public Cor cor { get; set; }
    
    public Carro(string modelo)
    {
        Modelo = modelo;
    }

    public void Ligar()
    {
        Console.WriteLine("Carro ligado.");
    }

    public void Desligar()
    {
        Console.WriteLine("Carro desligado.");
    }

    public void Ano()
    {
        Console.WriteLine("O ano do veículo é: " + AnoFabricacao);
    }

    public void MarcaVeículo()
    {
        Console.WriteLine("A marca do veículo é: " + Marca);
    }

    public void ModeloVeículo()
    {
        Console.WriteLine(Modelo);
    }

}
