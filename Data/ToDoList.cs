using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Data
{
    public class ToDoList
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual AppUser? User{ get; set; }
        public string Title { get; set; }
        public List<ToDoItem> Items { get; set; }

        public ToDoList()
        {
            Items = new List<ToDoItem>();
        }
    }
}