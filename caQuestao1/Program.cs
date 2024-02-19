using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nome do aluno: Luís Guilherme Silva Matos

            NomeProprio nome1 = new NomeProprio("Edgar Afonso Lamounier");
            NomeProprio nome2 = new NomeProprio("Edgar A. Lamounier");
            NomeProprio nome3 = new NomeProprio("Edgar Lamounier");

            nome1.ImprimeNomePaper();
            nome2.ImprimeNomePaper();
            nome3.ImprimeNomePaper();
        }
    }
}
