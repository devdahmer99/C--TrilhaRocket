using System.Globalization;
using System.Text.RegularExpressions;

namespace Estudos;

class Program
{
    static bool Main(string[] args)
    {

        //Programa 1 - Exibir mensagem personalizada
        //com o nome do usuario:

        Console.WriteLine("Olá, Digite o seu nome por favor:");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja bem-vindo!");
        Console.WriteLine("Pressione qualquer tecla para sair do sistema...");
        Console.ReadKey();



        //Programa 2 - Cocatenar o Nome e sobrenome e exibir completo:
        Console.WriteLine("Olá, Digite o seu primeiro nome: ");
        string primeiroNome = Console.ReadLine();
        Console.WriteLine("Agora, digite o seu sobrenome: ");
        string sobreNome = Console.ReadLine();
        string nomeCompleto = primeiroNome + sobreNome;
        Console.WriteLine($"Olá {nomeCompleto}!, Seja Bem-Vindo!");
        Console.ReadKey(true);

        //Programa 3 - Calculo de resultados
        Console.WriteLine("Por favor insira um valor: ");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Agora insira outro valor: ");
        double numero2 = double.Parse(Console.ReadLine());
        var Soma = numero1 + numero2;
        var Subtracao = numero1 - numero2;
        var multiplicacao = numero1 * numero2;
        var divisao = numero1 / numero2;
        var media = numero1 % numero2;
        Console.WriteLine($"A Some é: {Soma}");
        Console.WriteLine($"A Subtração é: {Subtracao}");
        Console.WriteLine($"A Subtração é: {multiplicacao}");
        Console.WriteLine($"A Divisao é: {divisao}");
        Console.WriteLine($"A ¨Media é: {media}");
        Console.ReadKey();


        //Programa 4- Verificar a quantidade de caracteres
        Console.WriteLine("Digite alguma coisa...");
        string palavra = Console.ReadLine();

        var quantidadeCaracteres = palavra.Length;
        Console.WriteLine($"A quantidade de caracteres é: {quantidadeCaracteres}");
        Console.ReadKey();

        //Programa 5 - Leitura de placa de veículo
        Console.WriteLine("Digite a placa do veículo: ");
        string placa = Console.ReadLine();

        string validacaoRegex = @"^[A-Za-z]{3}[0-9]{4}$";

        bool valido = Regex.IsMatch(validacaoRegex, placa);
        
        if(valido)
        {
             return true;
        } else
        {
             return false;
        }

        //Programa 6 - Trabalhando com datas
        var dataAtual = DateTime.UtcNow;
        string dataCompleta = dataAtual.ToString();
        Console.WriteLine($"Data completa:  {dataCompleta}");
        var dataFormatada = new DateOnly(2024,11,06);
        Console.WriteLine($"Data formatada:  {dataFormatada}");
        var horaAtual = DateTime.UtcNow;
        string horaFormatada = horaAtual.ToString("HH:mm:ss");
        Console.WriteLine(horaFormatada);
        var dataMesExtenso = DateTime.UtcNow;
        string dataExtenso = dataMesExtenso.ToString("dd 'de' MMM 'de' yyyy", new CultureInfo("pt-BR"));
        Console.WriteLine($"Data com o mês extenso: {dataExtenso}");
    }
}