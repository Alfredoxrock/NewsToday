using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace NewsToday.ViewModels
{
    class MainWindowViewModel
    {
        public ObservableCollection<Article> NewsArticles { get; set; } = new ObservableCollection<Article>();
        public ObservableCollection<Article> OneArticle { get; set; } = new ObservableCollection<Article>();
        public ObservableCollection<Article> OneArticle2 { get; set; } = new ObservableCollection<Article>();
        public ObservableCollection<Article> OneArticle3 { get; set; } = new ObservableCollection<Article>();
        public ObservableCollection<Article> OneArticle4 { get; set; } = new ObservableCollection<Article>();
        public ObservableCollection<Article> OneArticle5 { get; set; } = new ObservableCollection<Article>();
        public ObservableCollection<Article> OneArticle6 { get; set; } = new ObservableCollection<Article>();
        public ObservableCollection<Article> NewsArticles_Category { get; set; } = new ObservableCollection<Article>();


        public MainWindowViewModel()
        {

            //NewsArticles.Add(new Article() { Title = "Uno" });
            //NewsArticles.Add(new Article() { SourceImg = "Dos" });
            //NewsArticles.Add(new Article() { Byline = "Tres" });

            #region Data binding first part

            foreach (Article u in Data.articles)
            {
                if (u.articleID > Data.articles.Count - 10)
                {
                    NewsArticles.Insert(0, u);

                }
            }

            foreach (Article u in Data.articles)
            {

                if (u.articleID == Data.articles.Count - 1)
                {
                    OneArticle.Insert(0, u);
                }

            }


            foreach (Article u in Data.articles)
            {

                if (u.articleID == Data.articles.Count - 2)
                {
                    OneArticle2.Insert(0, u);
                }

            }


            foreach (Article u in Data.articles)
            {

                if (u.articleID == Data.articles.Count - 3)
                {
                    OneArticle3.Insert(0, u);
                }

            }

            foreach (Article u in Data.articles)
            {

                if (u.articleID == Data.articles.Count - 4)
                {
                    OneArticle4.Insert(0, u);
                }

            }

            foreach (Article u in Data.articles)
            {

                if (u.articleID == Data.articles.Count - 5)
                {
                    OneArticle5.Insert(0, u);
                }

            }

            foreach (Article u in Data.articles)
            {

                if (u.articleID == Data.articles.Count - 6)
                {
                    OneArticle6.Insert(0, u);
                }

            }

            #endregion

            foreach (Article u in Data.articles)
            {
               
                    if (SomeCategory.currentCategory == "News")
                    {
                        if (u.articleID < Data.articles.Count & u.category == "News")
                        {
                            NewsArticles_Category.Insert(0, u);

                        }
                    }
                   else if(SomeCategory.currentCategory == "Politics")
                   {
                        if (u.articleID < Data.articles.Count & u.category == "Politics")
                        {
                            //NewsArticles_Category.Clear();
                            NewsArticles_Category.Insert(0, u);

                        }
                   }
                    else if (SomeCategory.currentCategory == "Opinion")
                    {
                        if (u.articleID < Data.articles.Count & u.category == "Opinion")
                        {
                        //NewsArticles_Category.Clear();
                        NewsArticles_Category.Insert(0, u);

                        }
                    }
                else if (SomeCategory.currentCategory == "Sports")
                {
                    if (u.articleID < Data.articles.Count & u.category == "Sports")
                    {
                        //NewsArticles_Category.Clear();
                        NewsArticles_Category.Insert(0, u);

                    }
                }

                else if (SomeCategory.currentCategory == "Entertainment")
                {
                    if (u.articleID < Data.articles.Count & u.category == "Entertainment")
                    {
                        //NewsArticles_Category.Clear();
                        NewsArticles_Category.Insert(0, u);

                    }
                }
                else if (SomeCategory.currentCategory == "Social")
                {
                    if (u.articleID < Data.articles.Count & u.category == "Social")
                    {
                        //NewsArticles_Category.Clear();
                        NewsArticles_Category.Insert(0, u);

                    }
                }

            }
        }
    }
}
