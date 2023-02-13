using System.ComponentModel.DataAnnotations;

namespace Todo.Domain.Entities
{
    public class TodoItem : Entity
    {
        public TodoItem(string title, string user, DateTime date)
        {
            Title = title;
            Date = date;
            Done = false;
            User = user;

        }

        [MaxLength(160)]
        [DataType("varchar(160)")]
        public string Title { get; private set; }

        [DataType("bit")]
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }

        [MaxLength(120)]
        [DataType("varchar(120)")]
        public string User { get; private set; }

        public void MarkAsDone()
        {
            Done = true;
        }

        public void MarkAsUndone()
        {
            Done = false;
        }

        public void UpdateTitle(string title)
        {
            Title = title;
        }
    }
}