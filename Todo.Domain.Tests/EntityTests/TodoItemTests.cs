using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{

    [TestClass]
    public class TodoItemTests
    {
        private readonly TodoItem _validTodo = new TodoItem("Nome da Tarefa", "lucasbraz", DateTime.Now);

        [TestMethod]
        public void Given_a_new_task_it_should_not_be_done()
        {
            Assert.AreEqual(_validTodo.Done, false);
        }
    }
}