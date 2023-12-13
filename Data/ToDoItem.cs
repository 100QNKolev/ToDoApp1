namespace ToDoApp.Data
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string  AssigneeId { get; set; }
        public virtual AppUser? Asignee { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public int ToDoListId { get; set; }
        public virtual ToDoList? ToDoList { get; set; }
    }
}