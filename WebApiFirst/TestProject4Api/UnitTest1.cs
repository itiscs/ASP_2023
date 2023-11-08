using Moq;
using WebApiFirst.Controllers;
using WebApiFirst.Data;
using WebApiFirst.Models;

namespace TestProject4Api
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetItemsCount()
        {
            //Arrange
            var mockRepo = new Mock<ITodoRepository>();
            mockRepo.Setup(repo => repo.GetAll())
                .ReturnsAsync(GetItems);

            TodoItemsController contr = new TodoItemsController(mockRepo.Object);

            //Act
            var res = contr.GetItems().Result;

            //Assert

            Assert.NotNull(res);

        }


        private IEnumerable<TodoItem> GetItems()
        {
            return new List<TodoItem> { new TodoItem() { Id = 1, Name = "abc", IsComplete = true },
            new TodoItem() { Id = 2, Name = "abcd", IsComplete = true },
            new TodoItem() { Id = 3, Name = "abce", IsComplete = true }
            };
        }
    }
}