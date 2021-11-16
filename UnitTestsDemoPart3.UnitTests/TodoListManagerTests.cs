using System;
using Xunit;

namespace UnitTestsDemoPart3.UnitTests
{
    public class TodoListManagerTests
    {
        [Fact]
        public void AddTodo_WhenCalledWithnInvalidTodo_ThrowsArgumentException()
        {
            var sut = new TodoListManager();
            Assert.Throws<ArgumentException>(() =>
            {
                sut.AddTodo(null);
            });
        }
    }
}
