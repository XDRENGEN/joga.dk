namespace joga.dk.model
{
    public class Person
    {
        // Instans felter

        private string _navn;
        private string _email;
        private string _tlf;
        private string _adresse;
        



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


       
        // Constructor

        public Person()
        {
            _navn = Navn;
            _tlf = Tlf;
            _email = Email;
            _adresse = Adresse;
            
        }


        public Person(string navn, string email, string tlf, string adresse)
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
