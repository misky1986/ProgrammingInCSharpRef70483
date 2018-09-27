using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1.Skill1._4.Example2Events
{
    class EventsUsage
    {
        static void AlarmListner1()
        {
            Console.WriteLine("Alarm listner 1 called");
        }

        static void AlarmListner2()
        {
            Console.WriteLine("Alarm listner 2 called");
        }

        internal void Run()
        {
            Alarm alarm = new Alarm();

            // Connect the two listner methods
            alarm.OnAlarmRaised += AlarmListner1;
            alarm.OnAlarmRaised += AlarmListner2;

            // Raise the alarm
            alarm.RaisAlarm();
            Console.WriteLine("Alarm raised!");

            // Unsubsribe from event and raise alarm again
            alarm.OnAlarmRaised -= AlarmListner1;
            alarm.RaisAlarm();
            Console.WriteLine("Alarm raised again!");

            Console.ReadKey();
        }
    }
}
