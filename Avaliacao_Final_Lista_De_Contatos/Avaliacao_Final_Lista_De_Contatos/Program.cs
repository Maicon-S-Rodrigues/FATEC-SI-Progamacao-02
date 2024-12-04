using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Avaliacao_Final_Lista_De_Contatos
{
    internal class Program
    {
        static List<Contact> _contacts = new List<Contact>();
        static string _file => Path.Combine(AppContext.BaseDirectory, "contacts.txt");

        static void Main(string[] args)
        {
            LoadContacts();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=- Menu Principal -=");
                Console.WriteLine("1 - Cadastrar um novo contato");
                Console.WriteLine("2 - Mostrar todos os contatos");
                Console.WriteLine("3 - Localizar um contato pelo nome");
                Console.WriteLine("4 - Localizar contatos pelo telefone");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddContact();
                        break;

                    case "2":
                        ShowContacts();
                        break;

                    case "3":
                        SearchByContactName();
                        break;

                    case "4":
                        SearchByPhoneNumber();
                        break;

                    case "5":
                        SaveContacts();
                        return;

                    default:
                        Console.WriteLine("Opção inválida! Pressione ['Enter'] para tentar novamente.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void AddContact()
        {
            Console.Clear();
            Console.WriteLine("=-- Cadastrar Novo Contato --=");

            string name;
            while (true)
            {
                Console.Write("Digite o Nome (mínimo 2 caracteres): ");
                name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name) && name.Length >= 2) 
                    break;

                Console.WriteLine("Nome inválido. Pressione ['Enter'] para tentar novamente.");
                Console.ReadKey();
                Console.Clear();
            }

            string phone;
            while (true)
            {
                Console.Write("Digite o telefone (mínimo 6 caracteres): ");
                phone = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(phone) && phone.Length >= 6)
                    break;

                Console.WriteLine("Telefone inválido. Pressione ['Enter'] para tentar novamente.");
                Console.ReadKey();
                Console.Clear();
            }

            DateTime birthDate;
            while (true)
            {
                Console.Write("Digite a data de nascimento (dd/mm/yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate)) 
                    break;

                Console.WriteLine("Data de nascimento inválida. Pressione ['Enter'] para tentar novamente.");
                Console.ReadKey();
                Console.Clear();
            }

            _contacts.Add(new Contact(name, phone, birthDate));

            Console.WriteLine("Contato cadastrado com sucesso! Pressione ['Enter'] para continuar.");
            Console.ReadLine();
        }

        static void ShowContacts()
        {
            Console.Clear();
            Console.WriteLine("=-- Lista de Contatos --=");

            if (!_contacts.Any())
            {
                Console.WriteLine("Nenhum contato cadastrado.");
            }
            else
            {
                var orderedContacts = _contacts.OrderBy(contact => contact.Name).ToList();

                foreach (var contact in orderedContacts)
                    Console.WriteLine(contact);
                
            }

            Console.WriteLine("\nPressione ['Enter'] para voltar ao menu principal.");
            Console.ReadLine();
        }

        static void SearchByContactName()
        {
            Console.Clear();
            Console.WriteLine("=-- Localizar Contato por Nome --=");
            Console.Write("Buscar por: ");
            var filter = Console.ReadLine();

            filter = filter.ToLowerInvariant();

            var result = _contacts
                .Where(contact => contact.Name.ToLowerInvariant().Contains(filter))
                .OrderBy(contact => contact.Name)
                .ToList();

            ShowFilteredContats(result);

            Console.WriteLine("\n\nAperte [ 'Enter' ] para voltar ao menu principal...");
            Console.ReadLine();
            Console.Clear();
        }

        static void SearchByPhoneNumber()
        {
            Console.Clear();
            Console.WriteLine("----- Localizar Contato por Telefone -----");
            Console.Write("Digite o telefone ou parte do telefone: ");
            var filter = Console.ReadLine();

            filter = filter.ToLowerInvariant();

            var result = _contacts
                .Where(contact => contact.Phone.ToLowerInvariant().Contains(filter))
                .OrderBy(contact => contact.Name)
                .ToList();

            ShowFilteredContats(result);

            Console.WriteLine("\n\nAperte [ 'Enter' ] para voltar ao menu principal...");
            Console.ReadLine();
            Console.Clear();
        }

        private static void ShowFilteredContats(List<Contact> result)
        {
            if (!result.Any())
                Console.WriteLine("Nenhum contato encontrado.");

            else
                foreach (var contact in result)
                    Console.WriteLine(contact);
        }

        static void LoadContacts()
        {
            if (!File.Exists(_file)) 
                return;

            var lines = File.ReadAllLines(_file);

            foreach (var line in lines)
            {
                var data = line.Split(';');

                if (data.Length == 3 && DateTime.TryParse(data[2], out var birthDate))
                    _contacts.Add(new Contact(data[0], data[1], birthDate));       
            }
        }

        static void SaveContacts()
        {
            var lines = _contacts.Select(contact => $"{contact.Name};{contact.Phone};{contact.BirthDate:dd/MM/yyyy}");

            File.WriteAllLines(_file, lines);
        }
    }
}