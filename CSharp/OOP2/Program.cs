using P6_OOP2;

namespace OOP2
{
    internal class Program
    {
        static void Main1(string[] args)
        {

            //Assignment 1
            //A1_Employee e = new A1_Employee("Omkar", 24, 101);

            //e.DisplayPerson();
            //e.DisplayEmployee();

            //*************************************************************************************

            //Assignment 2
            //A2_Vehicle v = new A2_Vehicle("SUV");
            //v.DisplayVehicle();

            //A2_Car c = new A2_Car("SUV","TATA");
            //c.DisplayCar();

            //A2_ElectricCar e = new A2_ElectricCar("SUV", "TATA",1000);
            //e.DisplayElectricCar();

            //*************************************************************************************

            //Assignment 3
            //A3_Company c = new A3_Company();

            //A3_Company c = new A3_Company();
            //A3_Department d = new A3_Department();

            //A3_Department d = new A3_Department();

            //*************************************************************************************

            //Assignment 4

            //Aggregation (Has-A)
            //A4_Engine e = new A4_Engine(1000);
            //A4_Car c = new A4_Car("Red","TATA");

            //c.EngineObj = e;
            //c.StartCar();

            //******************************

            //Composition
            //A4_Car c = new A4_Car("Red", "TATA", new A4_Engine(1000));
            //c.StartCar();

            //*************************************************************************************

            //Assignment 5
            //A5_Student s = new A5_Student(101, "Omkar", new A5_Address("Pune", "Maharashtra"));
            //s.DisplayStudent();

            //*************************************************************************************

            //Assignment 6
            //A6_Person p = new A6_Person("Omkar", "9999999999", "omkar@gmail.com");
            //p.Display();

            //Console.WriteLine();

            //A6_Person e = new A6_Emp("Rahul", "8888888888", "rahul@gmail.com", 101, 50000);
            //e.Display();

            //*************************************************************************************

            //Assignment 7
            // Emp object with Person reference
            //A6_Person p = new A6_Emp(
            //    "Omkar",
            //    "9999999999",
            //    "omkar@gmail.com",
            //    101,
            //    50000
            //);

            // Calling display method
            //p.Display();

            //*************************************************************************************

            //Assignment 8
            //Console.WriteLine("Enter customer type (1 = Customer, 2 = RegCustomer): ");
            //int choice = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Email Id:");
            //string email = Console.ReadLine();

            //Console.WriteLine("Enter Address:");
            //string address = Console.ReadLine();

            //A8_Customer customer;

            //if (choice == 2)
            //{
            //    Console.WriteLine("Enter Registration Number:");
            //    int regNo = int.Parse(Console.ReadLine());

            //    customer = new A8_RegCustomer(email, address, regNo);
            //}
            //else
            //{
            //    customer = new A8_Customer(email, address);
            //}

            //Console.WriteLine("Enter Shopping Price:");
            //double price = double.Parse(Console.ReadLine());

            //double finalPrice = customer.GiveDiscount(price);

            //Console.WriteLine("Final Price after discount: " + finalPrice);


            //*************************************************************************************

            //Assignment 9
            A9_Emp[] employees = new A9_Emp[3];

            employees[0] = new A9_SalesManager(
                "Omkar", "9999999999", "omkar@gmail.com",
                101, 40000, 5000);

            employees[1] = new A9_Programmer(
                "Rahul", "8888888888", "rahul@gmail.com",
                102, 45000, 20, 500);

            employees[2] = new A9_Admin(
                "Neha", "7777777777", "neha@gmail.com",
                103, 35000, 3000);

            foreach (A9_Emp emp in employees)
            {
                Console.WriteLine("Total Salary = " + emp.CalSalary());
            }
        }
    }
}
