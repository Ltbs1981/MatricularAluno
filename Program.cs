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
                        RegistrarAluno();
                        break;
                    case 2:
                        ConsultarAlunos();
                        break;
                    case 3:
                        ListarAlunos();
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
        static void RegistrarAluno()
        {
            Console.WriteLine("Informe o nome do aluno");
            String nome = Console.ReadLine();
            Console.WriteLine("Informe a Turma do aluno");
            string turma = Console.ReadLine();
            Alunos aluno = new Alunos(nome, turma);
            Matriculados.AdicionarAluno(aluno);

            Console.WriteLine("Aluno foi matriculado");
        }

        static void ConsultarAlunos()
        {
            Console.WriteLine("Informe o índice do aluno ");
            int indice = int.Parse(Console.ReadLine());

            Alunos aluno = Matriculados.BuscarAluno(indice);
            if (aluno != null)
                Console.WriteLine(aluno);
            else
                Console.WriteLine("Aluno não encontrado");
        }

        static void ListarAlunos()
        {
            Console.WriteLine("Lista de alunos");
            for (int i = 0; i < Matriculados.GetQuantidadeAlunos(); i++)
            {
                Alunos aluno = Matriculados.BuscarAluno(i);
                Console.WriteLine($"Índice: {i}, Id: {aluno.Id}, Nome: {aluno.Nome}, Turma: {aluno.Turma}");
            }
        }
    }
}
