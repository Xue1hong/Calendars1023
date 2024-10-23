using Calendars.Models;
namespace Calendars.Interfaces
{
    public interface IMember
    {
        public Task<IEnumerable<Member>> GetAllMembers();
    }
}
