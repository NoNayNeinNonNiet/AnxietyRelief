using Entities.DbEntities;
using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface IJournalEntryRepository
    {
        bool Add(ApplicationUser user, JournalEntry entry);
        bool Edit(ApplicationUser user, JournalEntry entry);
        bool Delete(ApplicationUser user, JournalEntry entry);
        IEnumerable<JournalEntry> All(ApplicationUser user);
    }
}
