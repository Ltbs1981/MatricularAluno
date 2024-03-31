using System;

namespace MatricularAlunos
{
    class Matriculados
    {
        public static string DataBase = "MySQL";
        private static int _index = 0;
        private static Alunos[] _alunos = new Alunos[100];

        public static void AdicionarAluno(Alunos aluno) {
            _alunos[_index] = aluno;
            _index++;
        }
        public static Alunos BuscarAluno(int indice) 
        {
            return _alunos[indice];
        }
        public static int GetQuantidadeAlunos()
        {
            return _index;
        }
    }
}
