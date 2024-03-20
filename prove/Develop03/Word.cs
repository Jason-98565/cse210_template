using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Word
{
    private string _word;
    public bool flag;
    public Word (string word)
    {
        _word = word;
        flag = false;
    }
    override
    public string ToString()
    {
        string wyrd = ($"{_word}");
        return wyrd;
    }
    public void Show_word()
    {
        flag = false;
    }
    public void Hide_word()
    {
        if (flag == false)
        {
            int letter = _word.Count();
            _word = "";
            for (int i = 0; i < letter; i++)
            {
                _word = _word+"_";
                flag = true;
            }
        }
    }
}