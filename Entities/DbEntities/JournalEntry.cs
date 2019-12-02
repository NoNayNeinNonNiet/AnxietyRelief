using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DbEntities
{
    public class JournalEntry
    {
        public string Id { get; set; }
        public string EntryContent { get; set; }
        public bool IsDeleted { get; }


        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
