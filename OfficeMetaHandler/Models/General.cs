namespace OfficeMetaHandler.Models
{
    public class FillColumns
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }

    public enum ExtractionType
    {
        ContentControls,

        FormFields
    }
}
