using System;

using System.Globalization;


namespace Proj1
{


    public class Estudante
    {

        public string Email { get; set; }
        public string Nome { get; set; }

        public  Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;  
        }

        public override string ToString() {
            return Nome + ' ' + Email;             
        }
        

    }
}