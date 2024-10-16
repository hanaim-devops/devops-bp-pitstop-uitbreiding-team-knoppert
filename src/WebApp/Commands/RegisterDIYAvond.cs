namespace Pitstop.WebApp.Commands
{
    public class RegisterDIYAvond : Command
    {
        public readonly string AvondId;
        public readonly string Naam;
        public readonly string Beschrijving;
        public readonly DateTime Datum;
        public readonly string Locatie;
        public readonly string ReparateurId;

        public RegisterDIYAvond(Guid messageId, string avondId, string naam, string beschrijving, DateTime datum, string locatie, string reparateurId) :
             base(messageId)
        {
            AvondId = avondId;
            Naam = naam;
            Beschrijving = beschrijving;
            Datum = datum;
            Locatie = locatie;
            ReparateurId = reparateurId;
        }
    }
}
