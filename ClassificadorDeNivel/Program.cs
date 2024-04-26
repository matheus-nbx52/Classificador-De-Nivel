using System;

namespace HeroXPLevels
{
    class Program
    {
        static void Main(string[] args)
        {
            // Coleta o nome e a XP do herói
            Console.Write("Digite o nome do herói: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a quantidade de experiência (XP) do herói: ");
            int xp = int.Parse(Console.ReadLine());

            // Determina o nível do herói
            string nivel;
            if (xp < 1000)
                nivel = "Ferro";
            else if (xp <= 2000)
                nivel = "Bronze";
            else if (xp <= 5000)
                nivel = "Prata";
            else if (xp <= 7000)
                nivel = "Ouro";
            else if (xp <= 8000)
                nivel = "Platina";
            else if (xp <= 9000)
                nivel = "Ascendente";
            else if (xp <= 10000)
                nivel = "Imortal";
            else
                nivel = "Radiante";

            // Exibe a mensagem com o nível do herói
            Console.WriteLine($"O Herói de nome {nome} está no nível de {nivel}.");
        }
    }
}
