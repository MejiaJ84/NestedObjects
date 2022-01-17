using NestedObjects;

Advisor ComputerScience = new()
{
    Email = "Annemarie@cptc.edu",
    FullName = "Annemarie Smith",
    OfficeLocation = "B17 Rm 150"
};

Student stu1 = new()
{
    FirstName = "Homer",
    LastName = "Simpson",
    DateOfBirth = new DateOnly(200, 3, 20),
    AssignedAdvisor = ComputerScience,
    PhoneNumber = "2535898000",
    SchoolEmail = "Homer.Simpson@students.cptc.edu"
};


Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName} as their Advisor.");
