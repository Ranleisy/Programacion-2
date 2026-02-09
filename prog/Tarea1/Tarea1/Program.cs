using Tarea1.Entities;

var s1 = new student
{
    id = 1,
    firstname = "luis",
    lastname = "ramirez",
    age = 19,
    gender = "male",
    email = "luis@mail.com",
    phone = "8091112222",
    address = "santo domingo",
    nationality = "dominican",
    isactive = true,
    role = "student",
    relationtoschool = "enrolled",
    organization = "art school",
    isvolunteer = false,
    notes = "likes painting",
    studentcode = "st2025",
    major = "visual arts",
    artstyle = "realism",
    gpa = 3.6,
    creditsdone = 40,
    creditsleft = 80,
    hasscholarship = true,
    scholarshipamount = 12000,
    portfoliourl = "portfolio.com/luis",
    status = "active",
    enrolldate = DateTime.Now,
    semester = 3,
    isgraduatingsoon = false
};

var t1 = new teacher
{
    id = 2,
    firstname = "maria",
    lastname = "lopez",
    age = 34,
    gender = "female",
    email = "maria@mail.com",
    phone = "8093334444",
    address = "santiago",
    nationality = "dominican",
    isactive = true,
    role = "teacher",
    relationtoschool = "staff",
    organization = "art school",
    isvolunteer = false,
    notes = "strict but cool",
    employeecode = "emp102",
    department = "painting",
    hiredate = DateTime.Now.AddYears(-4),
    isfulltime = true,
    salary = 55000,
    weeklyhours = 40,
    workshift = "morning",
    contracttype = "fixed",
    isactiveemployee = true,
    specialization = "oil painting",
    artarea = "fine arts",
    yearsexperience = 10,
    classroomassigned = "room 3",
    iscoordinator = true,
    portfoliourl = "mariaart.com",
    teachesonline = false
};

var a1 = new admin
{
    id = 3,
    firstname = "carlos",
    lastname = "perez",
    age = 41,
    gender = "male",
    email = "carlos@mail.com",
    phone = "8095556666",
    address = "la vega",
    nationality = "dominican",
    isactive = true,
    role = "admin",
    relationtoschool = "management",
    organization = "art school",
    isvolunteer = false,
    notes = "boss guy",
    employeecode = "emp001",
    department = "direction",
    hiredate = DateTime.Now.AddYears(-8),
    isfulltime = true,
    salary = 90000,
    weeklyhours = 45,
    workshift = "full day",
    contracttype = "permanent",
    isactiveemployee = true,
    position = "director",
    officelocation = "office 1",
    adminlevel = "high",
    managespeople = true,
    peopleincharge = 20,
    systemaccesslevel = "all",
    canhire = true,
    canfire = true,
    canapprovebudgets = true,
    maxbudget = 500000,
    canchangegrades = false
};

var class1 = new teaching
{
    teacherid = t1.id,
    studentid = s1.id,
    coursename = "intro to drawing",
    artarea = "drawing",
    classroom = "room 3",
    schedule = "mon wed 9am",
    weeklyhours = 4,
    currentgrade = 88.5,
    isapproved = true,
    feedback = "doing great"
};

Console.WriteLine(s1.firstname + " " + s1.lastname);
Console.WriteLine(t1.firstname + " teaches " + class1.coursename);
Console.WriteLine(a1.firstname + " manages the school");
