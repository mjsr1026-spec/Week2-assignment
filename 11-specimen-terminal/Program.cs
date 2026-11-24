List<string> specimens = new List<string>();

while (true)
{
    Console.Write("Command (ADD/REMOVE/LIST/COUNT/QUIT): ");
    string? command = Console.ReadLine();

    // TODO: Implementer kommandoene.
    // Tips: specimens må IKKE opprettes på nytt inne i løkken.

        if (command.ToUpper() == "ADD")
        {
            Console.WriteLine("Enter specimen to be added: ");
            string? name = Console.ReadLine();

            if(name != null)
            {
                specimens.Add(name);

                Console.WriteLine($"Specimen {name} has added successfully");
            }
           
        
        }
        else if (command.ToUpper() == "REMOVE")
        {
            Console.WriteLine("Enter specimen to be removed: ");
            string? name = Console.ReadLine();

            specimens.Remove(name);

            Console.WriteLine($"Specimen {name} has removed successfully");
        }
        else if (command.ToUpper() == "LIST")
        {

            Console.WriteLine(string.Join(",",specimens));

        }
        else if (command.ToUpper() == "COUNT")
        {
            Console.WriteLine($"Specimens count:  {specimens.Count}");

        }

        else if (command.ToUpper() == "QUIT")
        {
            break;
        }

        else
            {
                Console.WriteLine("Invalid command");
            }
}