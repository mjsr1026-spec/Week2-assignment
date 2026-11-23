while (true)
{
    Console.Write("Command: ");
    string? command = Console.ReadLine();
    
    if (command.ToUpper() == "EXIT" || command == null)
    {
        break;
    }
    
    Console.WriteLine($"Received: {command}"); 
    // TODO: Avslutt med break når command er EXIT eller null.
    // TODO: Ellers skrivReceived: <command>.
}

Console.WriteLine("Receiver stopped.");
