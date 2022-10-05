using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Jogador
    {
        private double altura, peso;
        private string nome, posicao, data, nacionalidade;

        public Jogador()
        {
            nome = "Genérico";
            posicao = "Meio-Campo";
            nacionalidade = "Português";
            data = "01-01-2004";
            altura = 1.80;
            peso = 70;
        }

        public Jogador(double altura,double peso,string nome,string posicao,string data,string nacionalidade)
        {
            this.altura = altura;
            this.peso = peso;   
            this.nome = nome;   
            this.posicao = posicao; 
            this.data = data;
            this.nacionalidade = nacionalidade;
        }

        public string Mnome()
        {
            Console.WriteLine("Nome:"+nome);
            Console.WriteLine("Se quiser mudar introduza S");
            string mudar =Console.ReadLine();
            if (mudar == "S")
            {
                Console.WriteLine("");
                Console.ReadLine(); 
            }
            
        }
        public int Idade(string data)
        {
            DateTime dataNascimento = Convert.ToDateTime(data);

            int anos = DateTime.Today.Year - dataNascimento.Year;

            if (dataNascimento.Month > DateTime.Today.Month || dataNascimento.Month == DateTime.Today.Month && dataNascimento.Day > DateTime.Today.Day)
                anos--;

            return anos;
        }
        
        public int Reforma(int anos,string posicao)
        {
            if (posicao == "Defesa")
            {
                int reforma = 40 - anos;
                return reforma;
            }
            else if (posicao == "Meio-Campo")
            {
                int reforma = 38 - anos;
                return reforma;
            }
            else if (posicao == "Atacantes")
            {
                int reforma = 35 - anos;
                return reforma;
            }
            else
            {
                int reforma = 45 - anos;
                return reforma;
            }
        }
    }
 
}
