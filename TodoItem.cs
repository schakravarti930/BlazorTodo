using System.Threading;
public class TodoItem
{
    static int nextId;
    public string Title{ get; set; }
    public bool IsDone { get; set; }
    public int Id { get;private set; }
    public TodoItem()
    {
        Id = Interlocked.Increment(ref nextId);
    }
}