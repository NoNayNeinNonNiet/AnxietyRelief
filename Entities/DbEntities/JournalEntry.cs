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
