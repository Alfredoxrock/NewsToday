using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Text.RegularExpressions;

namespace NewsToday
{
    static class Helper
    {

        public static string userFile = "user.txt";
        public static string articleFile = "article.txt";
        public static string articleFilePreview = "articlePreview.txt";

        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public static void saveArticlesPreview(List<Article> articles)
        {
            string[] articleString = new string[articles.Count];
            for(int i = 0; i < articles.Count; i++)
            {
                articleString[i] = articles[i].ToString();
            }
            File.WriteAllLines(articleFilePreview, articleString);
        }

        public static void loadArticlePreview()
        {
            string[] data = File.ReadAllLines(articleFilePreview);
            Data.articlesPreview.Clear();
            foreach(string line in data)
            {
                Data.addArticlePreview(new Article(line));
            }
        }

        public static void loadArticles()
        {
            string[] data = File.ReadAllLines(articleFile);
            Data.articles.Clear();
            foreach(string line in data)
            {
                Data.addArticle(new Article(line));
            }
        }

        public static void saveArticles(List<Article> articles)
        {
            string[] articleString = new string[articles.Count];

            for (int i = 0; i < articles.Count; i++)
            {
                articleString[i] = articles[i].ToString();

            }
            File.WriteAllLines(articleFile, articleString);

        }

        public static void saveUsers(List<User> users)
        {
            string[] peopleString = new string[users.Count];

            for (int i = 0; i < users.Count; i++)
            {
                peopleString[i] = users[i].ToString();


            }

            File.WriteAllLines(userFile, peopleString);
        }

        public static void loadUsers()
        {
            string[] data = File.ReadAllLines(userFile);


            Data.users.Clear();
            foreach (string line in data)
            {

                Data.addUser(new User(line));

            }

            //usa.gov employment
        }



        // HASHING WAY

        public static string calculateMD5Hash(string input)
        {
            var provider = SHA512.Create();
            
            byte[] bytes = provider.ComputeHash(Encoding.ASCII.GetBytes(input));
            return BitConverter.ToString(bytes);
        }
    }
}
