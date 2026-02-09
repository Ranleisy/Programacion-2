namespace Tarea1.Entities;

public class teaching
{
    public int teacherid { get; set; }
    public int studentid { get; set; }
    public string coursename { get; set; }
    public string artarea { get; set; }
    public string classroom { get; set; }
    public string schedule { get; set; }
    public int weeklyhours { get; set; }
    public double currentgrade { get; set; }
    public bool isapproved { get; set; }
    public string feedback { get; set; }
}
