namespace Automations.DTOs.CRUDDTOs
{
    public class Content
    {
        public string ModelName { get; set; } = "MODEL_NAME";
        public string ProjectName { get; set; }
        public bool WithStatus { get; set; } = false;
        public bool StringBasedId { get; set; } = false;
    }
}
