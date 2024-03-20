using System;
using System.IO;
using System.IO.Enumeration;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        string _selection;
        Journal journal = new Journal();
        List<string> _promptList = new List<string>();
        do
        {
        Console.WriteLine("Welcome to the Journal");
        Console.WriteLine("Please select one of the options");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do");
        _selection = Console.ReadLine();
        if (_selection == "1")
        {
            Entry new_entry = new Entry();
            _promptList.Add("Who was the most interesting person I interacted with today?");
            _promptList.Add("What was the best part of my day?");
            _promptList.Add("How did I see the hand of the Lord in my life today?");
            _promptList.Add("What was the strongest emotion I felt today?");
            _promptList.Add("If I had one thing I could do over today, what would it be?");
            Random random = new Random();
            int choice = random.Next(0,5);
            string _chosenPrompt = _promptList[choice];
            Console.Write(_chosenPrompt);
            new_entry._currentPrompt = _chosenPrompt;
            Console.WriteLine();
            string Response = Console.ReadLine();
            new_entry._response = Response;
            DateTime _date_time =DateTime.Now;
            string _dateText = _date_time.ToShortDateString();
            new_entry._datetime = _dateText;
            journal._entryList.Add(new_entry);
        }
        if (_selection == "2")
        {
            journal._display_Entries();
        }
        if (_selection == "3")
        {
            Console.WriteLine("What do you want to name the file?");
            journal._fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(journal._fileName);
            journal = new Journal();
            foreach (string line in lines)
            {
                string[] parts = line.Split("_");
                string Date = parts[1];
                string Prompt = parts[3];
                string Response = parts[5];
                Entry new_entry = new Entry();
                new_entry._datetime = Date;
                new_entry._currentPrompt = Prompt;
                new_entry._response = Response;
                journal._entryList.Add(new_entry);
            }
        }
        if (_selection == "4")
        {
            Console.WriteLine("What do you want to name the file?");
            journal._fileName = Console.ReadLine(); 
            using (StreamWriter outputFile = new StreamWriter(journal._fileName))
            {
                foreach (Entry _entry in journal._entryList)
                outputFile.WriteLine(_entry); 
            }
        }
        } while (_selection != "5");
    }
}