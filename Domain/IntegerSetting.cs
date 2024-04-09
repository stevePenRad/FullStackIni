namespace Domain
{
    public class IntegerSetting
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Value { get; set; }
        public int SectionId { get; set; }
        public Section? Section { get; set; }
    }
}