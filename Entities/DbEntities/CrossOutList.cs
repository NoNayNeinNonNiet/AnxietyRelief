namespace Entities.DbEntities
{
    public class CrossOutList
    {
        public bool Filtering { get; set; }
        public bool Overgeneralization { get; set; }
        public bool PolarizedThinking { get; set; }
        public bool Catastrophising { get; set; }
        public bool Shoulds { get; set; }
        public bool MindReading { get; set; }
        public bool EmotionalReasoning { get; set; }
        public bool Personalizing { get; set; }



        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}