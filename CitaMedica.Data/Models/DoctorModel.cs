namespace CitaMedica.Data.Models
{
    public class DoctorModel
    {
        public string FotoDoctor { get; set; }

        public int IdDoctor { get; set; }

        public string NombreDoctor { get; set; }

        public string UserDoctor { get; set; }

        public string PasswordDoctor { get; set; }

        public string TelefonoDoctor { get; set; }

        public DoctorModel() { }

        public DoctorModel
            (string FotoDoctor, int IdDoctor, string NombreDoctor, string UserDoctor, string PasswordDoctor, string TelefonoDoctor)
        {
            this.FotoDoctor = FotoDoctor;
            this.IdDoctor = IdDoctor;
            this.NombreDoctor = NombreDoctor;
            this.UserDoctor = UserDoctor;
            this.PasswordDoctor = PasswordDoctor;
            this.TelefonoDoctor = TelefonoDoctor;
        }
    }
}
