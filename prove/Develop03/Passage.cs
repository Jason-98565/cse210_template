using System;

public class Passage
{
    public List<Word> words = new List<Word>();
    public Passage (string passage)
    {
        string[] wordlist = passage.Split(" ");
        for (int w = 0; w < wordlist.Length; w++)
        {
            Word wurd = new Word(wordlist[w]);
            words.Add(wurd);
        }
    }
    public void hide_words()
    {
        Random ran = new Random();
        int value = ran.Next(0,words.Count);
        Word w4rd = words[value];
        if (w4rd.flag == false)
        {
            w4rd.Hide_word();
        }
    }
    public void Wrdss()
    {
        string x = "";
        for (int i = 0; i < words.Count; i++)
        {
            x = x + " " + words[i];
        }
        Console.WriteLine(x);
    }
}