namespace Domain
{
    public class StringSetting
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int SectionId { get; set; }
        public Section? Section { get; set; }
    }
}