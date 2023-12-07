namespace joga.dk.model
{
    public class Kunde
    {
        // Instans felter

        private string _navn;
        private string _email;
        private string _tlf;
        private string _adresse;
        private int _id;



        // Properties

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }


        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }


        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }




        // Constructor

        public Kunde()
        {
            _navn = Navn;
            _tlf = Tlf;
            _email = Email;
            _adresse = Adresse;
            _id = Id;
        }


        public Kunde(string navn, string email, string tlf, string adresse)
        {
            Navn = navn;
            Email = email;
            Tlf = tlf;
            Adresse = adresse;
        }

        public override string ToString()
        {
            return $"{{{nameof(Navn)}={Navn}, {nameof(Email)}={Email}, {nameof(Tlf)}={Tlf}, {nameof(Adresse)}={Adresse}}}";
        }
    }
}
