using System;
using System.Globalization;
using System.Text.Json.Serialization.Metadata;

namespace SistemaBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mangas = {"Berserk", "Terra das Gemas", "Boa Noite Punpun", "Monster", "One Piece"};
            string[] estado_manga = {"Disponivel", "Disponivel", "Disponivel", "Disponivel", "Disponivel"};
            int manga_disponivel = 0;
            int opcao;

            do
            {
                Console.WriteLine("1 - Listar mangás.");
                Console.WriteLine("2 - Emprestar um mangá.");
                Console.WriteLine("3 - Devolver um mangá.");
                Console.WriteLine("4 - Buscar mangá pelo nome.");
                Console.WriteLine("5 - Ver estatísticas");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Digite um número das opções: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("###Lista de Mangás###");
                        for (int i = 0, j = 0; i < mangas.Length && j < mangas.Length; i++, j++)
                        {
                            Console.WriteLine($"Nome: {mangas[i]} || Estado: {estado_manga[i]}");
                        }
                        break;
                    case 2:
                        for (int i = 0; i < mangas.Length; i++)
                        {
                            if (estado_manga[i] == "Disponivel")
                            {
                                manga_disponivel++;
                            }
                            else if (estado_manga[i] == "Emprestado")
                            {
                                manga_disponivel--;
                            }
                            else
                            {
                                Console.WriteLine("Erro!!!!");
                                break;
                            }
                        }

                        if (manga_disponivel <= 0)
                        {
                            Console.WriteLine("Não Temos mangás disponiveis, volte mais tarde.");
                        }
                        else
                        {
                            Console.WriteLine("Temos mangás disponiveis");
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine("Manga Devolvido");
                        break;
                    case 4:
                        Console.WriteLine("Procurando Manga....");
                        break;
                    case 5:
                        Console.WriteLine("Estatisticas.......");
                        break;
                    case 0:
                        Console.WriteLine("Volte Sempre.");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!!!!!");
                        break;
                }
            }while (opcao != 0);
        }
    }
}