using Entities.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
