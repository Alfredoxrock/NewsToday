using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsToday
{
    class Login
    {
        public static bool validationU(string userID_, string pw_)
        {

          return validateUser(userID_, Helper.calculateMD5Hash(userID_ + pw_));
            
        }

        public static bool validateUser(string userID__, string pw_MD5)
        {

            foreach (User u in Data.users)
            {
                //SignIn.print(userID__ + u.nickname);
                //SignIn.print(user.passwordMD5 + "  / " + pw_MD5);
                //SignIn.print(u.nickname + "  / " + userID__);
                if (u.nickname == userID__ && u.passwordMD5 == pw_MD5)
                    return true;


            }
            return false;
        }

        public static bool validateJustUser(string userID_)
        {
            foreach (User u in Data.users)
            {
                if (u.nickname == userID_)
                    return true;
            }
            return false;
        }
        public static bool validateEmail(string email_)
        {
            foreach (User u in Data.users)
            {
                if (u.email.email == email_)
                    return true;
            }
            return false;
        }

        public static Article validateArticlePreviewGet(string articlePreviewID_)
        {
            foreach(Article u in Data.articlesPreview)
            {
                if (u.articleID.ToString() == articlePreviewID_)
                    return u;
            }
            return null;
        }

        public static Article validateArticleGet(string articleID_)
        {
            foreach(Article u in Data.articles)
            {
                if (u.articleID.ToString() == articleID_)
                    return u;
            }
            return null;
        }

        public static User validateUserGet(string userID_)
        {

            foreach (User u in Data.users)
            {
                //SignIn.print(user.passwordMD5 + "  / " + pw_MD5);
                //SignIn.print(u.nickname + "  / " + userID__);
                if (u.nickname == userID_)
                    return u;


            }
            return null;
        }


    }
}
