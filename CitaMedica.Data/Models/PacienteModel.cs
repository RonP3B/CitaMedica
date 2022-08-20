namespace CitaMedica.Data.Models
{
    public class PacienteModel
    {
        public string FotoPaciente { get; set; }

        public int IdPaciente { get; set; }

        public string NombrePaciente { get; set; }

        public string TelefonoPaciente { get; set; }

        public string CorreoPaciente { get; set; }

        public PacienteModel() { }

        public PacienteModel
            (string FotoPaciente, int IdPaciente, string NombrePaciente, string TelefonoPaciente, string CorreoPaciente)
        {
            this.FotoPaciente = FotoPaciente;
            this.IdPaciente = IdPaciente;
            this.NombrePaciente = NombrePaciente;
            this.TelefonoPaciente = TelefonoPaciente;
            this.CorreoPaciente = CorreoPaciente;
        }
    }
}
