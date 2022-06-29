using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("==============");

Employee Employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Rebeca",
    LastName = "Herazo",
    BirthDate = new Date(2000,07,02),
    HiringDate = new Date(2022,01,01),
    Salary = 1600000M,
    IsActive = true

};
Console.WriteLine(Employee1);

Employee Employee2 = new CommissionEmployee()
{
    Id = 1011,
    FirstName = "Jeronimo",
    LastName = "Herazo",
    BirthDate = new Date(2001, 07, 02),
    HiringDate = new Date(2022, 06, 01),
    IsActive = true ,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F


};

Console.WriteLine(Employee2);

