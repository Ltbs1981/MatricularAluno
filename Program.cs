using System;

namespace MatricularAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 4)
            {
                Console.WriteLine("opções: \nDigite 1 para registrar um aluno\nDigite 2 para buscar o registro de um aluno\nDigite 3 para listar todos os alunos\nSair, digite 4");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Registrar um aluno");
                        break;
                    case 2:
                        Console.WriteLine("Consultar aluno");
                        break;
                    case 3:
                        Console.WriteLine("Lista de alunos");
                        break;
                    case 4:
                        Console.WriteLine("Obrigado");
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }

            }
        }
        }
            }
