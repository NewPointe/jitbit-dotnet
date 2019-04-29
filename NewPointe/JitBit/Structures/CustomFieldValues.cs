
namespace NewPointe.JitBit.Structures
{

    public class CustomFieldValue
    {
                string Value { get; set; }
                int? OptionID { get; set; }
                string FieldName { get; set; }
                int FieldID { get; set; }
                CustomFieldType Type { get; set; }
                int UsageType { get; set; }
                int AccessType { get; set; }
                bool Mandatory { get; set; }
                int OrderByNumber { get; set; }
                bool ShowInGrid { get; set; }
                dynamic SelectionComboOptions { get; set; }
    }
}