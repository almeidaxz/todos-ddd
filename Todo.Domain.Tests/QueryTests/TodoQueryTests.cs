using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", "lucasbraz", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 2", "outrousuario", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 3", "outrooutrousuario", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 4", "lucasbraz", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 5", "outrousuario", DateTime.Now));
        }

        [TestMethod]
        public void Given_a_query_should_return_only_tasks_from_given_user_lucasbraz()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("lucasbraz"));
            Assert.AreEqual(2, result.Count());
        }
    }
}