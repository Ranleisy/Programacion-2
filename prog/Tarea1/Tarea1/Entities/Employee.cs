namespace Tarea1.Entities;

public class employee : communitymember
{
    public string employeecode { get; set; }
    public string department { get; set; }
    public DateTime hiredate { get; set; }
    public bool isfulltime { get; set; }
    public double salary { get; set; }
    public int weeklyhours { get; set; }
    public string workshift { get; set; }
    public string contracttype { get; set; }
    public bool isactiveemployee { get; set; }
}
