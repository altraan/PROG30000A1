namespace Assign1PROG30000.Models.Repository
{
    public interface IRsvpRepository
    {
        IEnumerable<Rsvp> GetAllRsvps();
        IEnumerable<Rsvp> GetRsvpsByEventId(int eventId);
        Rsvp? GetRsvpById(int id);
        void AddRsvp(Rsvp rsvp);
        void UpdateRsvp(Rsvp rsvp);
        void DeleteRsvp(int id);
        void SaveChanges();
    }
}