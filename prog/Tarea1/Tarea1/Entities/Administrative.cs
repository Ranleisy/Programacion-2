namespace Tarea1.Entities;

public class administrative : employee
{
    public string position { get; set; }
    public string officelocation { get; set; }
    public string adminlevel { get; set; }
    public bool managespeople { get; set; }
    public int peopleincharge { get; set; }
    public string systemaccesslevel { get; set; }
}
