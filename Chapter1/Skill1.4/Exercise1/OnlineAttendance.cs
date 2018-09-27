using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1.Skill1._4.Exercise1
{
    class OnlineAttendance
    {
        public void Run()
        {
            WelcomeUser wu = new WelcomeUser();
            wu.BannedUser += BannedNameAlarmRaised;
            string username = wu.GreetUser();
            while(username.ToUpper() != "Q")
            {
                wu.CheckUserName(username);
                Console.WriteLine();
                username = wu.GreetUser();
            }            
        }

        public static void BannedNameAlarmRaised(object sender, BannedUserEventArgs eventArgs)
        {
            string bannedUsername = eventArgs.User;
            Console.WriteLine("Banned name alarm raised!");
            Console.WriteLine($"User name: {bannedUsername} banned from application");
            Console.WriteLine("Writing a mail to the administration...");
        }
    }
}
