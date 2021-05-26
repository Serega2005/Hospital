using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Clinic : Appointment
    {
        private readonly int schol_dni;
        private readonly int ne_schol_dni;
        private readonly double _PTime;

        public Clinic(int PTime) => _PTime = PTime;

        public double CalcRecording_Time()
        {
            Recording_Time = ne_schol_dni - schol_dni;
            return Recording_Time;
        }
    }
}
