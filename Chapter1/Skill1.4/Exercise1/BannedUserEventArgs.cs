using System;

namespace Chapter1.Skill1._4.Exercise1
{
    public class BannedUserEventArgs : EventArgs
    {
        public BannedUserEventArgs(string username)
        {
            User = username;
        }

        public string User { get; set; }
    }
}