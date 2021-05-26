using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Maternity_H : Emergency_Room
    {
        private int Size_Pazient;
        private int Size_Vipisali;
        private readonly int _dovolni;

        public Maternity_H(int dovolni) => _dovolni = dovolni;

        public double CalcPerformance()
        {
            Performance = Size_Pazient - Size_Vipisali;
            return Performance;
        }
    }
}
