using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Resuscitation : Emergency_Room
    {
        private double Speed_Auto;
        private double Speed_Human;
        private int _saved_lives;

        public Resuscitation(int saved_lives) => _saved_lives = saved_lives;

        public double CalcPerformance()
        {
            Performance = Speed_Auto + Speed_Human;
            return Performance;
        }
    }
}
