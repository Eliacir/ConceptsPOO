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
//Console.WriteLine(Employee1);

Employee Employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Jeronimo",
    LastName = "Herazo",
    BirthDate = new Date(2001, 07, 02),
    HiringDate = new Date(2022, 06, 01),
    IsActive = true ,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F


};

//Console.WriteLine(Employee2);

Employee Employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Samuel",
    LastName = "Herazo",
    BirthDate = new Date(2001, 07, 02),
    HiringDate = new Date(2022, 06, 01),
    IsActive = true,
    Hours = 10F,
    HouerValue = 30000M


};

//Console.WriteLine(Employee3);

Employee Employee4 = new  BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Estein",
    LastName = "Herazo",
    BirthDate = new Date(2001, 07, 02),
    HiringDate = new Date(2022, 06, 01),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F,
    Base = 2500000M,

};

//Console.WriteLine(Employee4);


ICollection<Employee> Employees = new List<Employee>() { 
    Employee1, Employee2, Employee3, Employee4
};

//Employees.Add(Employee1);
//Employees.Add(Employee2);
//Employees.Add(Employee3);
//Employees.Add(Employee4);


decimal PayRoll = 0;

foreach (Employee employee in Employees)
{
    Console.WriteLine(employee);
    PayRoll += employee.GetValueToPay();
}

Console.WriteLine("                               ==================");
Console.WriteLine($"TOTAL                          {$"{PayRoll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Id = 1,
    Description = "Iphone 13",
    Quantity = 6,
    Price = 5300000M
};

Invoice invoice2 = new Invoice()
{
    Id = 2,
    Description = "Posta Premium",
    Quantity = 17.5F,
    Price = 32000M
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);