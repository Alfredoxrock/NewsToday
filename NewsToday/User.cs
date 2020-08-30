using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsToday
{
    class User
    {
        public string nickname, passwordMD5;
        public int ID;
        public Birth birth;
        public Location location;
        public Email email;

        public string SHA512(string password)
        {
            return Helper.calculateMD5Hash(nickname + password);

        }

        public User(int ID_, string nickname_, string password_, Birth birth_, Location place_, Email email_)
        {
            ID = ID_;
            nickname = nickname_;
            passwordMD5 = SHA512(password_);
            birth = birth_;
            location = place_;
            email = email_;

        }

        public User(string line)
        {
            string[] parts = line.Split(',');
            ID = int.Parse(parts[0]);
            nickname = parts[1];
            passwordMD5 = parts[2];
            birth = new Birth(parts[3]);
            location = new Location(parts[4]);
            email = new Email(parts[5]);

        }



        public string serialize()
        {
            return ID.ToString() + "," + nickname + "," + passwordMD5 + 
                "," + birth.serlialize() + "," + location.serialize() + "," 
                + email.serlialize();
        }

        public string getReportString()
        {
            return string.Format("{0,-20}{1,-50}{2,-70}{3,-90}", ID.ToString(), nickname, birth.serlialize(), location.serialize());
        }

        public override string ToString()
        {
            return this.serialize();
        }
    }
}
