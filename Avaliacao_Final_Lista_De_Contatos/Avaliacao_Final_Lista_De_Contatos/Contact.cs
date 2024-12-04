using System;

namespace Avaliacao_Final_Lista_De_Contatos
{
    public class Contact
    {
        public Contact(
            string name, 
            string phone, 
            DateTime birthDate
        )
        {
            Name = name;
            Phone = phone;
            BirthDate = birthDate;
        }

        public string Name { get; }
        public string Phone { get; }
        public DateTime BirthDate { get; }
      
        public override string ToString() =>
            $"\nNome: {Name}\nTelefone: {Phone}\nData de Nascimento: {BirthDate:dd/MM/yyyy}\n----------------------------------------------------------------------";
    }
}