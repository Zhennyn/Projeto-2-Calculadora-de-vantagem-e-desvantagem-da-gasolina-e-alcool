using System;

class Program
{
    public static void Main(string[] args)
    {

        //Variável
        bool pergunta = true;

        //Perguntas
        while (pergunta)
        {
            Console.WriteLine("Qual o valor da gasolina?");
            double precoGasolina = double.Parse(Console.ReadLine());

            if (precoGasolina <= 0)
            {
                Console.WriteLine("O valor da gasolina deve ser maior que zero.");
                continue;
            }

            Console.WriteLine("Qual o valor do álcool?");
            double precoAlcool = double.Parse(Console.ReadLine());

            if (precoAlcool <= 0)
            {
                Console.WriteLine("O valor do álcool deve ser maior que zero.");
                continue;
            }

            double consumo = 0.7;
            double preco = precoAlcool / precoGasolina;

            //Respostas
            if (preco < consumo)
            {
                Console.WriteLine("Vale a pena comprar o álcool.");
            }
            else if (preco > consumo)
            {
                Console.WriteLine("Vale a pena comprar a gasolina.");
            }
            else if (preco == consumo)
            {
                Console.WriteLine("Sem diferença ");
            }

            Console.WriteLine("Deseja fazer novamente? (S/N)");
            string resposta = Console.ReadLine();
            if (resposta == "n")
            {
                pergunta = false;

            }
        }
    }
}