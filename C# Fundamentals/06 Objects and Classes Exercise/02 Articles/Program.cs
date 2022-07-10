using System;
using System.Collections.Generic;

namespace _02_Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void EditArticle(string editCommandIndexedOne)
        {
            this.Content = editCommandIndexedOne;
        }

        public void ChangeAuthorArticle(string editCommandIndexedOne)
        {
            this.Author = editCommandIndexedOne;
        }

        public void RenameArticle(string editCommandIndexedOne)
        {
            this.Title = editCommandIndexedOne;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] givenArticle = Console.ReadLine().Split(", ");

            Article newArticle = new Article(givenArticle[0], givenArticle[1], givenArticle[2]);

            int numOfEdits = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfEdits; i++)
            {
                string[] editCommand = Console.ReadLine().Split(": ");
                
                if (editCommand[0] == "Edit")
                {
                    newArticle.EditArticle(editCommand[1]);
                }
                else if (editCommand[0] == "ChangeAuthor")
                {
                    newArticle.ChangeAuthorArticle(editCommand[1]);
                }
                else if (editCommand[0] == "Rename")
                {
                    newArticle.RenameArticle(editCommand[1]);
                }
            }
            Console.WriteLine(newArticle);
        }
    }
}
