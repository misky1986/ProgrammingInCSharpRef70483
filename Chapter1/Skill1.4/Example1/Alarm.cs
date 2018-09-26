using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1.Skill1._4.Example1
{
    class Alarm
    {
        public Action OnAlarmRaised { get; set; }

        public void RaisAlarm()
        {
            if(OnAlarmRaised != null)
            {
                OnAlarmRaised();
            }
        }
    }
}
