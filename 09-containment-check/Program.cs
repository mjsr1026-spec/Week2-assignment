bool accepted = CanContain(10, 6, 5);

if (accepted)
{
    Console.WriteLine("ACCEPTED");
}
else
{
    Console.WriteLine("REJECTED");
}

static bool CanContain(int capacity, int occupied, int incoming)
{
    // TODO
    return occupied + incoming <= capacity;
}
