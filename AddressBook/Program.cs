using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main()
    {
        bool exit = false;
        AddressBook addressBook = new();
        while (!exit)
        {
            Console.WriteLine("Please select an option from 1 to 5");
            Console.WriteLine("1. Display the contact list");
            Console.WriteLine("2. Add a contact");
            Console.WriteLine("3. Edit a contact");
            Console.WriteLine("4. Delete a contact");
            Console.WriteLine("5. Check a contact");

            switch (Console.ReadLine())
            {
                case "1":
                    addressBook.DisplayContacts();
                    break;
                case "2":
                    addressBook.AddContact();
                    break;
                case "5":
                    addressBook.FindContact();
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

class AddressBook
{
    private List<Contact> contacts = new();

    public void DisplayContacts()
    {
        if (contacts.Count <= 0)
        {
            Console.WriteLine("No contact, please add contact first");
        }
        else
        {
            int index = 1;
            foreach (Contact contact in contacts)
            {
                Console.Write($"{index}.");
                Console.WriteLine($"Name: {contact.Name}");
                Console.WriteLine($"Email: {contact.Email}");
                index++;
            }
        }
    }

    public void AddContact()
    {
        string name = "";
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Please input the name of the contact");
            name = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please input a valid name");
            }
        }
        Console.WriteLine("Please input the email address of the contact");
        string email = Console.ReadLine() ?? "Unset Email";

        Contact newContact = new(name, email);
        contacts.Add(newContact);
        Console.WriteLine($"Contact {newContact.Name} has been added");
    }

    public void FindContact()
    {
        Console.WriteLine("Please input the name you want to search");
        string name = Console.ReadLine() ?? "";
        foreach (Contact contact in contacts)
        {
            int index = 1;
            if (contact.Name.Contains(name))
            {
                Console.WriteLine($"{index}. Name: {contact.Name}, Email: {contact.Email}");
                index++;
            }
        }
    }
}

class Contact(string name, string email)
{
    public string Name { get; set; } = name;
    public string? Email { get; set; } = email;
}