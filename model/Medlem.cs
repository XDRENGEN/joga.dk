namespace joga.dk.model
{
    public class Medlem : Person
    {

        //instans felt
        private int _medlemsId;
        private bool _status;

        //properties

        public int MedlemsId
        {
            get { return _medlemsId; } 
            set { _medlemsId = value; }
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        //Konstruktør
        //Default
        public Medlem():base ()
        {
            _medlemsId = 0;
            _status = false;
        }

        public Medlem(string navn, string tlf, string email, string adresse, int medlemsId, bool status):
            base(navn, tlf, email, adresse)
        {
            _medlemsId = medlemsId;
            _status = status;
        }

        public override string ToString()
        {
            return $"{{{nameof(MedlemsId)}={MedlemsId}, {nameof(Status)}={Status}, {nameof(Navn)}={Navn}, {nameof(Email)}={Email}, {nameof(Tlf)}={Tlf}, {nameof(Adresse)}={Adresse}}}";
        }
    }

}
