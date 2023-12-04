using System;
using System.Collections.Generic;

namespace Lesson6.FindAndReplaceManager;

class Book
{
    private string content;
    private readonly Notes bookNotes;

    public Book(string content)
    {
        this.content = content;
        this.bookNotes = new Notes();
    }

    public void FindNext(string str)
    {
        int position = content.IndexOf(str, StringComparison.CurrentCultureIgnoreCase);
        if (position < 0)
        {
            Console.WriteLine("Рядок не знайдено.");
        }
        else
        {
            Console.WriteLine($"Рядок знайдено на позиції: {position}");
        }
    }

    public Notes BookNotes => bookNotes;

    public class Notes
    {
        private List<string> notes = new List<string>();

        public void AddNote(string note)
        {
            notes.Add(note);
        }

        public IEnumerable<string> GetNotes()
        {
            return notes;
        }
    }
}