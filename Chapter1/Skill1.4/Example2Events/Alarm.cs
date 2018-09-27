using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1.Skill1._4.Example2Events
{
    class Alarm
    {
        public event Action OnAlarmRaised = delegate { };

        public void RaisAlarm()
        {
            OnAlarmRaised();
        }
    }
}
