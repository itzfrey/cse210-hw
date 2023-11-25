public class Journal 
{
    public List<Entry> _entries;
    
    public Journal()
    {
        _entries = new List<Entry>();
    }
    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        Console.WriteLine("Journal Entries:\n");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
        {
            Console.Write("Enter the filename to save the journal (without extention): ");
            string filename = Console.ReadLine();

            filename += ".csv";

            using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }

        Console.WriteLine($"Journal saved to {filename}\n");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename: ");
        String filename = Console.ReadLine();

        filename += ".csv";
        
        if (File.Exists(filename))
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string[] entryData = reader.ReadLine().Split("|");
                    Entry loadedEntry = new Entry
                    {
                        _date = entryData[0],
                        _promptText = entryData[1],
                        _entryText = entryData[2]   
                    };

                    _entries.Add(loadedEntry);
                }
            }
            

            Console.WriteLine($"Journal loaded from {filename}\n");
        }
        else
        {
            Console.WriteLine("File not found. Please make sure the file exists.\n");
        }




    }
}
