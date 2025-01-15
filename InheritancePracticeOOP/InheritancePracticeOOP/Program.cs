using InheritancePracticeOOP;

Student student1 = new Student() { 

    Name = "Abuzer",
    LastName = "Kömürcü",
    IdNum = 123456789 

};

Console.WriteLine("Öğrenci Bilgileri : \n");

student1.IntroduceStudent();

Console.WriteLine("------------------------------------------------------------");

Teacher teacher1 = new Teacher()
{
    Name = "Osman",
    LastName = "Başak",
    Salary = 55780

};

Console.WriteLine("Öğretmen Bilgileri :\n");

teacher1.IntroduceTeacher();



