namespace Tarea1.Entities;

public class teacher : employee
{
    public string specialization { get; set; }
    public string artarea { get; set; }
    public int yearsexperience { get; set; }
    public string classroomassigned { get; set; }
    public bool iscoordinator { get; set; }
    public string portfoliourl { get; set; }
    public bool teachesonline { get; set; }
}
