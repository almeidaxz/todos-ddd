using Todo.Domain.Commands;

namespace Todo.Domain.Tests;

[TestClass]
public class CreateTodoCommandTests
{
    private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);
    private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Título da tarefa", "lucasbraz", DateTime.Now);

    public CreateTodoCommandTests()
    {
        _invalidCommand.Validate();
        _validCommand.Validate();
    }

    [TestMethod]
    public void Given_an_invalid_command()
    {

        Assert.AreEqual(_invalidCommand.Valid, false);
    }

    [TestMethod]
    public void Given_an_valid_command()
    {

        Assert.AreEqual(_validCommand.Valid, true);
    }
}