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
            bool erro = false;
            int opcao, opcao_emprestimo;

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
                                erro = true;
                                break;
                            }

                            if (manga_disponivel < 0)
                            {
                                manga_disponivel = 0;
                            }
                        }

                        if (erro == true)
                        {
                            Console.WriteLine("O programa sera encerrado!!!!");
                            Environment.Exit(0);
                        } 
                        else
                        {
                            if (manga_disponivel <= 0)
                            {
                                Console.WriteLine("Não temos mangás disponiveis, volte mais tarde.");
                            } 
                            else
                            {
                                do{
                                    for (int i = 0; i < mangas.Length; i++)
                                    {
                                        Console.WriteLine($"{i + 1} - {mangas[i]} || {estado_manga[i]}");
                                    }
                                    Console.WriteLine("0 - Voltar.");
                                    
                                    Console.WriteLine("Digite o número do mangá que você quer pegar emprestado: ");
                                    opcao_emprestimo = int.Parse(Console.ReadLine());

                                    switch (opcao_emprestimo)
                                    {
                                        case 1:
                                            if (estado_manga[opcao_emprestimo - 1] == "Disponivel")
                                            {
                                                Console.WriteLine($"Você pegou {mangas[opcao_emprestimo - 1]} emprestado.");
                                                estado_manga[opcao_emprestimo - 1] = "Emprestado";
                                                manga_disponivel--;
                                            } 
                                            else if (estado_manga[opcao_emprestimo - 1] == "Emprestado")
                                            {
                                                Console.WriteLine("Esse mangá não esta disponivel para emprestimo no momento");
                                            } 
                                            else
                                            {
                                                Console.WriteLine("ERRO!!!! O Programa será fechado!!!!!!");
                                                Environment.Exit(0);
                                            }
                                            break;
                                        case 2:
                                            if (estado_manga[opcao_emprestimo - 1] == "Disponivel")
                                            {
                                                Console.WriteLine($"Você pegou {mangas[opcao_emprestimo - 1]} emprestado.");
                                                estado_manga[opcao_emprestimo - 1] = "Emprestado";
                                                manga_disponivel--;
                                            } 
                                            else if (estado_manga[opcao_emprestimo - 1] == "Emprestado")
                                            {
                                                Console.WriteLine("Esse mangá não esta disponivel para emprestimo no momento");
                                            } 
                                            else
                                            {
                                                Console.WriteLine("ERRO!!!! O Programa será fechado!!!!!!");
                                                Environment.Exit(0);
                                            }
                                            break;
                                        case 3:
                                            if (estado_manga[opcao_emprestimo - 1] == "Disponivel")
                                            {
                                                Console.WriteLine($"Você pegou {mangas[opcao_emprestimo - 1]} emprestado.");
                                                estado_manga[opcao_emprestimo - 1] = "Emprestado";
                                                manga_disponivel--;
                                            } 
                                            else if (estado_manga[opcao_emprestimo - 1] == "Emprestado")
                                            {
                                                Console.WriteLine("Esse mangá não esta disponivel para emprestimo no momento");
                                            } 
                                            else
                                            {
                                                Console.WriteLine("ERRO!!!! O Programa será fechado!!!!!!");
                                                Environment.Exit(0);
                                            }
                                            break;
                                        case 4:
                                            if (estado_manga[opcao_emprestimo - 1] == "Disponivel")
                                            {
                                                Console.WriteLine($"Você pegou {mangas[opcao_emprestimo - 1]} emprestado.");
                                                estado_manga[opcao_emprestimo - 1] = "Emprestado";
                                                manga_disponivel--;
                                            } 
                                            else if (estado_manga[opcao_emprestimo - 1] == "Emprestado")
                                            {
                                                Console.WriteLine("Esse mangá não esta disponivel para emprestimo no momento");
                                            } 
                                            else
                                            {
                                                Console.WriteLine("ERRO!!!! O Programa será fechado!!!!!!");
                                                Environment.Exit(0);
                                            }
                                            break;
                                        case 5:
                                            if (estado_manga[opcao_emprestimo - 1] == "Disponivel")
                                            {
                                                Console.WriteLine($"Você pegou {mangas[opcao_emprestimo - 1]} emprestado.");
                                                estado_manga[opcao_emprestimo - 1] = "Emprestado";
                                                manga_disponivel--;
                                            } 
                                            else if (estado_manga[opcao_emprestimo - 1] == "Emprestado")
                                            {
                                                Console.WriteLine("Esse mangá não esta disponivel para emprestimo no momento");
                                            } 
                                            else
                                            {
                                                Console.WriteLine("ERRO!!!! O Programa será fechado!!!!!!");
                                                Environment.Exit(0);
                                            }
                                            break;
                                        case 0:
                                            break;
                                        default:
                                            Console.WriteLine("Opção incorreta!!!!");
                                            break;
                                    }

                                    if (manga_disponivel < 0)
                                    {
                                        manga_disponivel = 0;
                                    }

                                    if (manga_disponivel == 0)
                                    {
                                        Console.WriteLine("Não temos mangás disponiveis, volte mais tarde.");
                                        break;
                                    }
                                } while(opcao_emprestimo != 0);
                            }
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