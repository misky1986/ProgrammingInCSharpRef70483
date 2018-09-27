using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1.Skill1._4.Exercise1
{
    class WelcomeUser
    {
        public event EventHandler<BannedUserEventArgs> BannedUser;

        public string GreetUser()
        {
            
            Console.Write("Please write your name as username: ");
            return Console.ReadLine();            
        }

        public void CheckUserName(string username)
        {
            List<string> bannedUsernames = new List<string> { "Jack", "Steven", "Matthew" };
            if (!bannedUsernames.Contains(username))
            {
                Console.WriteLine($"Welcome {username}");
            }
            else
            {
                BannedUser(this, new BannedUserEventArgs(username));
            }
        }
    }
}
