using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // пустой список контактов
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            // список контактов по имени и фамилии
            var sortedPhoneBook = phoneBook.OrderBy(c => c.Name).ThenBy(c => c.LastName);

            // вывод отсортированных контактов
            foreach (var contact in sortedPhoneBook)
            {
                Console.WriteLine($"{contact.LastName} {contact.Name}, тел. {contact.PhoneNumber}, email: {contact.Email}");
            }

            Console.ReadKey();
        }
    }

    public class Contact//класс контакта
    {
        public Contact(string name, string lastName, long phoneNumber, string email) // конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name { get; }
        public string LastName { get; }
        public long PhoneNumber { get; }
        public string Email { get; }
    }
}

