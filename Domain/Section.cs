namespace Domain
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool Required { get; set; } = false;
        public ICollection<BooleanSetting> BooleanSettings { get; set; } = new List<BooleanSetting>();
        public ICollection<StringSetting> StringSettings { get; set;} = new List<StringSetting>();
        public ICollection<IntegerSetting> IntegerSettings { get; set; } = new List<IntegerSetting>();
    }
}