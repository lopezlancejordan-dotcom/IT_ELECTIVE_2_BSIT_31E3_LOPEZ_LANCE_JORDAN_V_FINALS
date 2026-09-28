namespace IT_ELECTIVE_2_BSIT_31E3_LOPEZ_LANCE_JORDAN.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; // Backend, Frontend, QA
    }
}