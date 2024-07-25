using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Solution
{

    public class NotesStore
    {
        public NotesStore() {
            Notes = new List<Note>();

        }
        public List<Note> Notes { get; set; }
        public void AddNote(String state, String name)
        {
            if (name == null)
                throw new Exception("Name cannot be empty");

                if (state != State.active.ToString() && state != State.others.ToString() && state != State.completed.ToString())
            {
                    throw new Exception($"Invalid state {state}");
                }

            Notes.Add(new Note(name, state));

        }
        public List<String> GetNotes(String state)
        {
            List<string> names = new List<string>();
            foreach (var x in Notes)
            {
                if(x.state == state )
                    names.Add(x.name);
            }
            return names;
        }
    }
    public enum State
    {
        completed,
        active,
        others
    }

    public class Note
    {
        public string name { get; set; }
        public string state { get; set; }
        public Note(String name, String state)
        {
            this.state = state;
            this.name = name;

        }
    }

    public class Solution
    {
        public static void Main()
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}