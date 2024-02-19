using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao1
{
    internal class NomeProprio
    {
        string nome_completo;
        string nome_paper;

        public string Nome_completo { get => nome_completo; set => nome_completo = value; }
        public string Nome_paper { get => nome_paper; set => nome_paper = value; }

        public NomeProprio()
        {

        }

        public NomeProprio(string nome_completo)
        {
            Nome_completo = nome_completo;

            string primeiro_nome = "";
            string segundo_nome = "";
            string sobrenome = "";
            int qntEspaco = 0;

            for(int i = 0; i < nome_completo.Length; i++)
            {

                if (qntEspaco == 0)
                {
                    //primeiro_nome = primeiro_nome + Convert.ToString(nome_completo[i]);
                    if (Convert.ToString(nome_completo[i]) == " ")
                    {
                        qntEspaco = 1;
                    }
                    else
                    {
                        primeiro_nome = primeiro_nome + Convert.ToString(nome_completo[i]);
                    }
                }
                else if (qntEspaco == 1)
                {
                    //segundo_nome = segundo_nome + Convert.ToString(nome_completo[i]);
                    //Console.WriteLine("Entrou no segundo if");
                    if (Convert.ToString(nome_completo[i]) == " ")
                    {
                        qntEspaco = 2;
                    }
                    else
                    {
                        segundo_nome = segundo_nome + Convert.ToString(nome_completo[i]);
                    }
                }
                else if (qntEspaco == 2)
                {
                    //sobrenome = sobrenome + Convert.ToString(nome_completo[i]);
                    if (Convert.ToString(nome_completo[i]) == " ")
                    {
                        qntEspaco = 2;
                    }
                    else
                    {
                        sobrenome = sobrenome + Convert.ToString(nome_completo[i]);
                    }
                }


                //primeiro_nome = primeiro_nome + Convert.ToString(nome_completo[i]);
            }

            //Console.WriteLine(primeiro_nome);
            //Console.WriteLine(segundo_nome);
            //Console.WriteLine(sobrenome);
            //Console.ReadLine();

            string segundo_nome_paper = "";

            if(qntEspaco == 2)
            {
                segundo_nome_paper = segundo_nome[0] + ".";
                Nome_paper = sobrenome + ", " + primeiro_nome + " " + segundo_nome_paper; 
            }
            else if (qntEspaco == 1)
            {
                sobrenome = segundo_nome;
                Nome_paper = sobrenome + ", " + primeiro_nome;
            }

            //Console.WriteLine(Nome_paper);
            //Console.ReadLine();

        }

        public void ImprimeNomePaper()
        {
            Console.WriteLine(Nome_paper);
            Console.ReadLine();
        }

    }
}
