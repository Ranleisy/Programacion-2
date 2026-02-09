namespace Tarea1.Entities;

public class communitymember : person
{
    public string role { get; set; }
    public string relationtoschool { get; set; }
    public string organization { get; set; }
    public bool isvolunteer { get; set; }
    public string notes { get; set; }
}
