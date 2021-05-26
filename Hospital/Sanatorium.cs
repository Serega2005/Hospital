using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Sanatorium : Appointment
    {
        private readonly int rabocie_dni;
        private readonly int ne_rabocie_dni;
        private int _dovolni;

        public Sanatorium(int dovolni) => _dovolni = dovolni;

        public double CalcRecording_Time()
        {
            Recording_Time = ne_rabocie_dni - rabocie_dni;
            return Recording_Time;
        }
    }
}
