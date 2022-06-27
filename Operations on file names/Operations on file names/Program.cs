using System;

namespace Operations_on_file_names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniverysityDocuments firstDoment = new UniverysityDocuments(".html", ".pdf", ".index", ".doc", ".mp3", ".txt", ".torrent");
            Console.WriteLine("Enter file : ");
            string target = Console.ReadLine();
            Console.WriteLine(firstDoment.IsCheckDocument(target));
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Choose language(Russian,English,Azerbaijan)");
            firstDoment.Info(Console.ReadLine());
            firstDoment.Extension();
            Console.WriteLine("---------------------------------------------");
            firstDoment.CheckTypeExtension(target);

        }
        class UniverysityDocuments
        {
            private string[] _extension;
            public UniverysityDocuments(params string[] extension)
            {
                _extension = extension;
            }
            public bool IsCheckDocument(string document)

            {
                string text = "";
                for (int i = 0; i < document.Length; i++)
                {
                    if (document[i] == '.')
                    {
                        for (int z = i; z < document.Length; z++)
                        {
                            text += document[z];
                        }
                    }
                }
                for (int i = 0; i < _extension.Length; i++)
                {
                    if (_extension[i] == text)
                    {
                        return true;
                    }
                }
                return false;
            }
            public void Info(string language)
            {
                switch (language)
                {
                    case "English":
                        Console.WriteLine("Possible file types:");
                        break;
                    case "Russian":
                        Console.WriteLine("Vozmozhnyye tipy faylov:");
                        break;
                    case "Azerbaijan":
                        Console.WriteLine("Mumkun fayl novleri:");
                        break;

                    default:
                        Console.WriteLine("Possible file types:");
                        break;
                }
            }
            public void Extension()
            {
                for (int i = 0; i < _extension.Length; i++)
                {
                    Console.WriteLine(_extension[i]);
                }
            }
            public void CheckTypeExtension(string document)
            {
                string text = "";
                for (int i = 0; i < document.Length; i++)
                {
                    if (document[i] == '.')
                    {
                        for (int z = i; z < document.Length; z++)
                        {
                            text += document[z];
                        }
                    }
                }
                Console.WriteLine(text);
            }
        }
    }
}

}
