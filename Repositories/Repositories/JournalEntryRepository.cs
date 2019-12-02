using Entities.DbEntities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Repositories.Repositories
{
    public class JournalEntryRepository : IJournalEntryRepository
    {
        public ApplicationDbContext DbContext
        {
            get
            {
                if (HttpContext.Current.Items["ApplicationDbContext"] == null)
                {
                    var context = new ApplicationDbContext();
                    HttpContext.Current.Items["ApplicationDbContext"] = context;
                    return context;
                }
                else
                {
                    return (ApplicationDbContext)HttpContext.Current.Items["ApplicationDbContext"];
                }
            }
        }



        public bool Add(ApplicationUser user, JournalEntry entry)
        {
            bool status = false;

            if (DbContext.Users.Any(x => x.Id == user.Id))
            {
                DbContext.Users.First(x => x.Id == user.Id).JournalEntries.Add(entry);
                DbContext.SaveChanges();

                status = true;
                return status;
            }
            else
            {
                throw new Exception();
            }
        }

        public IEnumerable<JournalEntry> All(ApplicationUser user)
        {
            if (DbContext.Users.Any(x => x.Id == user.Id))
            {
                return DbContext.Users.First(x => x.Id == user.Id).JournalEntries;
            }
            else
            {
                throw new Exception();
            }
        }

        public bool Delete(ApplicationUser user, JournalEntry entry)
        {
            bool status = false;

            if (DbContext.Users.Any(x => x.Id == user.Id))
            {
                status = true;

                var deleteUser = DbContext.Users.First(x => x.Id == user.Id);
                DbContext.Users.Remove(deleteUser);
                DbContext.SaveChanges();

                return status;
            }
            else
            {
                throw new Exception();
            }
        }

        public bool Edit(ApplicationUser user, JournalEntry entry)
        {
            bool status = false;

            if (DbContext.Users.Any(x => x.Id == user.Id))
            {
                status = true;

                DbContext.Entry<JournalEntry>(entry).State = EntityState.Modified;
                DbContext.SaveChanges();

                return status;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
