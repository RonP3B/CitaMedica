using System;
using System.Collections.Generic;
using System.Linq;
namespace CitaMedica.Data.Models
{
    public class CitaModel
    {
        public int IdCita { get; set; }

        public int IdDoctor { get; set; }

        public int IdPaciente { get; set; }

        public string LugarCita { get; set; }
        
        public string Tratamiento  { get; set; }

        public DateTime FechaCita { get; set; }

        public CitaModel() { }

        public CitaModel
            (int IdCita, int IdDoctor, int IdPaciente, string LugarCita,  string Tratamiento, DateTime FechaCita)
        {
            this.IdCita = IdCita;
            this.IdPaciente = IdPaciente;
            this.IdDoctor = IdDoctor;
            this.LugarCita = LugarCita;
            this.Tratamiento = Tratamiento;
            this.FechaCita = FechaCita;
        }
    }
}
