namespace Estudos;
public class Monstros
{
    enum niveisDificuldades
    {
        Baixo,
        Medio,
        Alto
    }

    void Main()
    {
        niveisDificuldades Nivel = niveisDificuldades.Alto;
        int nivelCompleto = (int)Nivel;
        Console.WriteLine(Nivel);
        Console.WriteLine(nivelCompleto);
    }
}
