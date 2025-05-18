using agendadorBackend.Domain;

namespace agendadorBackend.Application;
public class TaskService
{
    private int _idCounter = 1;

    public TaskItem Add(TaskItem task)
    {
        task.Id = _idCounter++;
        return task;
    }
}
