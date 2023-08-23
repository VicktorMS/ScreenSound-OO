using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_OO
{
    internal class Musica
    {
        public string nome;
        public string artista;
        public int duracao;

        public bool disponivel { get; set; } //Os Getters e Setters são declarados dessa forma


        /* public void SetDisponivel(bool value)
         {
             disponivel = value;
         }

         public bool GetDisponivel()
         {
             return disponivel;
         }*/

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Artista: {artista}");
            Console.WriteLine($"Duração: {duracao}");
            if (disponivel)
            {
                Console.WriteLine("Disponível no plano");
            }
            else
            {
                Console.WriteLine("Adquira o plano Plus+");
            }
        }

    }
}
