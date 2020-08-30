using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media;


namespace NewsToday
{
    class Data
    {
        public static List<User> users = new List<User>();
        public static List<Article> articles = new List<Article>();
        public static List<Article> articlesPreview = new List<Article>();

        public static int articlePreviewGetNextID()
        {
            if (articlesPreview.Count == 0) return 0;
            return articlesPreview[articlesPreview.Count - 1].articleID + 1;
        }

        public static Brush colorGet(Article u)
        {
            if (u.category == "News")
            {
                return Brushes.Red;
            }
            else if (u.category == "Politics")
            {
                return Brushes.Blue;
            }
            else if (u.category == "Opinion")
            {
                return Brushes.DarkGreen;
            }
            else if(u.category == "Sports")
            {
                return Brushes.Purple;
            }
            else if (u.category == "Entertainment")
            {
                return Brushes.DarkOrange;
            }
            else if (u.category == "Social")
            {
                return Brushes.DeepPink;
            }
            return null;

        }
        public static int articleGetNextID()
        {
            if (articles.Count == 0) return 0;
            return articles[articles.Count - 1].articleID + 1;
        }

        public static void deleteArticle(int index)
        {
            articles.RemoveAt(index);
            Helper.saveArticles(articles);
        }

        public static void addArticle(Article article)
        {
            articles.Add(article);
            Helper.saveArticles(articles);
        }

        public static void addArticlePreview(Article articlePrev)
        {
            articlesPreview.Add(articlePrev);
            Helper.saveArticlesPreview(articlesPreview);
        }

        public static void addUser(User user)
        {
            users.Add(user);
            Helper.saveUsers(users);


        }

        public static void deleteUser(int index)
        {
            users.RemoveAt(index);
            Helper.saveUsers(users);
        }


        public static int getNextID()
        {
            if (users.Count == 0) return 0;

            return users[users.Count - 1].ID + 1;
        }

        public static int getIDForUser(string loginID)
        {
            foreach (User user in users)
            {
                if (user.nickname == loginID) return user.ID;

            }

            return -1;
        }

        public static User getUser(int ID_)
        {
            foreach (User user in users)
            {
                if (user.ID == ID_) return user;

            }

            return null;
        }

        public static void loadINI()
        {
            //File.WriteAllText("Voter.ini", "");
            //Never Writeit anymore
            string[] data = File.ReadAllLines("Voter.ini");

            foreach (string line in data)
            {
                string l = line.Replace(" ", "");
                string[] parts = l.Split('=');
                if (parts[0].ToLower() == "userfile")
                {
                    Helper.userFile = parts[1];
                }
            }
        }

    }
}
