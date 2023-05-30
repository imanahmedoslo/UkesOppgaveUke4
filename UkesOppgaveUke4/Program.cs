using System;
using System.IO;
using System.Runtime.Versioning;
using System.Text;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 Vi skal lage et program som bruker en ordliste til å lage en spesiell type ordgåter. Greia er å finne et ord som slutter på det samme
som et annet begynner på, for eksempel kremost og ostekake. Gåten blir da krem_ og _ekake, og så skal man sette inn det samme sist i første
ord som først i siste ord og få to meningsfulle ord. 

lastnet ordliste.txt

Lag et program som leser inn alle linjene inn i en array og så går gjennom denne, splitter opp på tabulatortegnet
('\t') og printer så ut selve oppslagsordet. Ikke skriv ut ordet hvis det er det samme som som du skrev ut sist. 
 
 PrintWord.Contains(NextWord[i])|| 

 ' ', ',', '.', ':',
 
 */

string EntireText = File.ReadAllText("C:\\Users\\imana\\Downloads\\ordliste.txt", Encoding.UTF8);
char[] delimiterChars = { '\t' };
string[] FilteredText= new string[EntireText.Length];
FilteredText= EntireText.Split('\t');
var OrdListe= new List<string>();
string SeachedWord = "";
string PrintWord = "";
string [] NextWord =new string[FilteredText.Length];
NextWord = EntireText.Split('\t');
//AddAllUniqueWords();
AddAllUniqueWordsWithRightLength();
void printAllTabSeperatedStrings()
{
    for (int i = 0; i < FilteredText.Length; i++)
    {
        NextWord[i] = PrintWord;
        PrintWord = FilteredText[i];
        // SeachedWord= Console.ReadLine();
        if (NextWord.Contains(PrintWord))
        {
            continue;
            // Console.WriteLine($" this is an example {PrintWord}");
            // Console.WriteLine($" this is an example {NextWord}");
        }
        else Console.WriteLine(PrintWord);
    }
}




/*for (int i = 0; i < FilteredText.Length; i++)
{
    PrintWord = SeachedWord;
    //NextWord[i] = PrintWord;
    // SeachedWord = PrintWord;

    SeachedWord = Console.ReadLine();
    if (FilteredText.Contains(SeachedWord) && PrintWord != SeachedWord)
    {
        Console.WriteLine(SeachedWord);

        continue;
        // Console.WriteLine($" this is an example {PrintWord}");
        // Console.WriteLine($" this is an example {NextWord}");
    }

}*/

/*4:*/void AddAllUniqueWordsWithRightLength()
{
    for (int i = 0; i < NextWord.Length; i++)
    {
        //SeachedWord = PrintWord;
        PrintWord = NextWord[i];
        // SeachedWord= Console.ReadLine();
        if (OrdListe.Contains(PrintWord))
        {
            continue;
            // Console.WriteLine($" this is an example {PrintWord}");
            // Console.WriteLine($" this is an example {NextWord}");
        }
        else if((PrintWord.Length >= 7 && PrintWord.Length <= 10) && !PrintWord.Contains("-"))
        {
            OrdListe.Add(PrintWord);
          Console.WriteLine(PrintWord);

        }
    }
}
/*3:
 void AddAllUniqueWords()
{
    for (int i = 0; i < NextWord.Length; i++)
    {
        //SeachedWord = PrintWord;
        PrintWord = NextWord[i];
        // SeachedWord= Console.ReadLine();
        if (OrdListe.Contains(PrintWord))
        {
            continue;
            // Console.WriteLine($" this is an example {PrintWord}");
            // Console.WriteLine($" this is an example {NextWord}");
        }
        else
        {
            OrdListe.Add(PrintWord);
          // Console.WriteLine(PrintWord);

        }
    }
}*/





