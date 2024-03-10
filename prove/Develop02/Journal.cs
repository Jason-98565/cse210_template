using System;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entryList = new List<Entry>();    
    public string _fileName;
    public void _display_Entries()
    {
        foreach (Entry new_entry in _entryList)
        {
            string x = new_entry.ToString();
            Console.WriteLine(x);
        }
    }
}