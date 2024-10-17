namespace Pitstop.WebApp.Commands
{
    public class RegisterDIYAvond : Command
    {
        public readonly string AvondId;
        public readonly string Title;
        public readonly string ExtraInfo;
        public readonly DateTime StartDate;
        public readonly TimeOnly StartTime;
        public readonly DateTime EndDate;
        public readonly TimeOnly EndTime;
        public readonly List<string> Reparateurs;

        public RegisterDIYAvond(Guid messageId, string avondId, string naam, string beschrijving, 
            DateTime startDate, TimeOnly starttime, DateTime endDate, TimeOnly endTime, List<string> reparateurs) :
             base(messageId)
        {
            AvondId = avondId;
            Title = naam;
            ExtraInfo = beschrijving;
            StartDate = startDate;
            EndDate = endDate;
            StartTime = starttime;
            EndTime = endTime;
            Reparateurs = reparateurs;
        }
    }
}
