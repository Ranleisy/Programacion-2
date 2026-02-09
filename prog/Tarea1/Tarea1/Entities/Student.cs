namespace Tarea1.Entities;

public class student : communitymember
{
    public string studentcode { get; set; }
    public string major { get; set; }
    public string artstyle { get; set; }
    public double gpa { get; set; }
    public int creditsdone { get; set; }
    public int creditsleft { get; set; }
    public bool hasscholarship { get; set; }
    public double scholarshipamount { get; set; }
    public string portfoliourl { get; set; }
    public string status { get; set; }
    public DateTime enrolldate { get; set; }
    public int semester { get; set; }
    public bool isgraduatingsoon { get; set; }
}
