using agendadorBackend.Application;
using agendadorBackend.Domain;

namespace agendadorBackend.Tests;
// File: TaskServiceTests.cs
public class TaskServiceTests
{
    [Fact]
    public void AddTask_ShouldReturnCreatedTask()
    {
        // Arrange
        var service = new TaskService();
        var task = new TaskItem { Title = "Test TDD" };

        // Act
        var result = service.Add(task);

        // Assert
        Assert.Equal("Test TDD", result.Title);
        Assert.True(result.Id > 0);
    }
}
