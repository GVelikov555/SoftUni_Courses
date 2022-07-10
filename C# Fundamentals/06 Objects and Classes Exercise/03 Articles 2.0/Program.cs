using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Articles
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
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        public static object Enviroment { get; private set; }

        static void Main(string[] args)
        {
            int numOfEnteredArticles = int.Parse(Console.ReadLine());
            
            IList<Article> articlesList = new List<Article>();

            
            for (int i = 0; i < numOfEnteredArticles; i++)
            {
                string[] givenArticle = Console.ReadLine().Split(", ");

                Article newArticle = new Article(givenArticle[0], givenArticle[1], givenArticle[2]);

                articlesList.Add(newArticle);
            }


            string sortCommand = Console.ReadLine();

            List<Article> sortedArticles = new List<Article>();

            if (sortCommand == "title")
            {
                sortedArticles = articlesList.OrderBy(x => x.Title).ToList();
            }
                
            else if (sortCommand == "content")
            {
                sortedArticles = articlesList.OrderBy(x => x.Content).ToList();
            }
               
            else if (sortCommand == "author")
            {
                sortedArticles = articlesList.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, sortedArticles));
        }
    }
}

