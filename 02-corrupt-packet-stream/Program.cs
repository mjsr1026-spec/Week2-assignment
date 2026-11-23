string[] packets = { "P-100", "CORRUPT", "P-101", "P-102", "CORRUPT", "P-103" };
int processedCount = 0;

foreach (string packet in packets)
{
    if(packet == "CORRUPT")
    {
        continue;
    }
    else
    {
        processedCount += 1;
    }
    // TODO: Bruk continue for CORRUPT.
    // TODO: Prosesser resten og øk processedCount.
}

Console.WriteLine($"Processed packets: {processedCount}");
