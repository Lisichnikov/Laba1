using System;
/*
class Program
{
    static void Main()
    {
        ProductionWorker worker = new ProductionWorker();

        Console.Write("Введите имя сотрудника: ");
        worker.Name = Console.ReadLine();

        Console.Write("Введите номер сотрудника: ");
        worker.EmployeeNumber = Console.ReadLine();

        Console.Write("Введите номер смены (1 - дневная, 2 - вечерняя): ");
        worker.ShiftNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите почасовую ставку оплаты труда: ");
        worker.HourlyRate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nДанные сотрудника:");
        Console.WriteLine("Имя сотрудника: " + worker.Name);
        Console.WriteLine("Номер сотрудника: " + worker.EmployeeNumber);
        Console.WriteLine("Номер смены: " + worker.ShiftNumber);
        Console.WriteLine("Почасовая ставка оплаты труда: " + worker.HourlyRate);
    }
}
public class Employee
{
    public string Name { get; set; }
    public string EmployeeNumber { get; set; }
}
public class ProductionWorker : Employee
{
    public int ShiftNumber { get; set; }
    public double HourlyRate { get; set; }
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////

/*
class Program
{
    static void Main()
    {
        ShiftSupervisor supervisor = new ShiftSupervisor();

        Console.Write("Введите имя начальника смены: ");
        supervisor.Name = Console.ReadLine();

        Console.Write("Введите номер начальника смены: ");
        supervisor.EmployeeNumber = Console.ReadLine();

        Console.Write("Введите годовой оклад начальника смены: ");
        supervisor.AnnualSalary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите годовую производственную премию начальника смены: ");
        supervisor.AnnualProductionBonus = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nДанные начальника смены:");
        Console.WriteLine("Имя начальника смены: " + supervisor.Name);
        Console.WriteLine("Номер начальника смены: " + supervisor.EmployeeNumber);
        Console.WriteLine("Годовой оклад начальника смены: " + supervisor.AnnualSalary);
        Console.WriteLine("Годовая производственная премия начальника смены: " + supervisor.AnnualProductionBonus);
    }
}
public class Employee
{
    public string Name { get; set; }

    public string EmployeeNumber { get; set; }
}

public class ShiftSupervisor : Employee
{
    public double AnnualSalary { get; set; }

    public double AnnualProductionBonus { get; set; }
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////


class Program
{
    static void Main()
    {
        Customer customer = new Customer();

        Console.Write("Введите имя клиента: ");
        customer.Name = Console.ReadLine();

        Console.Write("Введите адрес клиента: ");
        customer.Address = Console.ReadLine();

        Console.Write("Введите телефонный номер клиента: ");
        customer.PhoneNumber = Console.ReadLine();

        Console.Write("Введите номер клиента: ");
        customer.CustomerNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Хочет ли клиент быть в списке рассылки? (true/false): ");
        customer.MailingList = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("\nДанные клиента:");
        Console.WriteLine("Имя клиента: " + customer.Name);
        Console.WriteLine("Адрес клиента: " + customer.Address);
        Console.WriteLine("Телефонный номер клиента: " + customer.PhoneNumber);
        Console.WriteLine("Номер клиента: " + customer.CustomerNumber);
        Console.WriteLine("На списке рассылки: " + customer.MailingList);
    }
}
public class Person
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}

public class Customer : Person
{
    public int CustomerNumber { get; set; }
    public bool MailingList { get; set; }
}
