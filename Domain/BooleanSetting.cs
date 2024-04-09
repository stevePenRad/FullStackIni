namespace Domain
{
    public class BooleanSetting
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool Value { get; set; }
        public int SectionId { get; set; }
        public Section? Section { get; set; }
        
    }
}