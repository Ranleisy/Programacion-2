namespace Tarea1.Entities;

public class admin : administrative
{
    public bool canhire { get; set; }
    public bool canfire { get; set; }
    public bool canapprovebudgets { get; set; }
    public double maxbudget { get; set; }
    public bool canchangegrades { get; set; }
}
