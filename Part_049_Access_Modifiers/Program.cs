public class Customer
{
    private int _id;


    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }

    protected string Name = "Amir";

    //public string Name = "Amir";

    public void PrintName()
    {
        //Protected member ID is accessible with in Customer class
        Console.WriteLine(this.Name);
    }
}

public class CorporateCustomer : Customer
{
    public void PrintCustomerName()
    {
        CorporateCustomer corporateCustomerInstance = new CorporateCustomer();

        corporateCustomerInstance.Name = "Hamza";

        // Can access the base class protected instance member using the derived class object		
        Console.WriteLine("In derived class, PrintCustomerName() method, corporateCustomerInstance.Name =" + corporateCustomerInstance.Name);

        Console.WriteLine("In derived class, PrintCustomerName() method, corporateCustomerInstance.Id =" + corporateCustomerInstance.Id); // Id is public. 

        // Can access the base class protected instance member using this or base keyword		
        Console.WriteLine("In derived class, PrintCustomerName() method, this.Name = " + this.Name);
        Console.WriteLine("In derived class, PrintCustomerName() method, base.Name = " + base.Name);
    }
    public void PrintCustomerName1()
    {
        Customer customer = new Customer();
        /*
        // Can not access the base class protected instance member using the base class object
        Console.WriteLine(customer.Name); // Compile error
        */
        customer.Id = 50;
        Console.WriteLine("In derived class PrintCustomerName1() method, customer.Id = " + customer.Id); // Id is public
    }
}

public class MainClass
{
    private static void Main()
    {
        Customer customerInstance = new Customer();
        customerInstance.Id = 101;

        Console.WriteLine("In Main Method customerInstance.Id = " + customerInstance.Id);

        // Compiler Error : 'Customer._id' is inaccessible due to its protection level
        // CustomerInstance._id = 101; //because _id is private

        /*
        Console.WriteLine(customerInstance.Name); 
        // because Name is protected. Name is accessible with derived class object only.
        */

        /*
        //Both these below lines also produce the same Error
        Console.WriteLine(this.Name); // Error
        Console.WriteLine(base.Name); // Error
        */

        MainClass mainClassObject = new MainClass();

        /*
        // MainClass class is not deriving from Customer class, hence it is an error
        //to access Customer class protected Name member, using the mainClassObject
        Console.WriteLine(mainClassObject.Name); //Error
        */


        CorporateCustomer corporateCustomerObject = new CorporateCustomer();
        corporateCustomerObject.PrintCustomerName();

        corporateCustomerObject.PrintCustomerName1();
    }
}

/*
 There are 3 ways to access, the base class protected member in the derived class as shown below.
1. Using the derived class object.
Console.WriteLine(corporateCustomerInstance.Name);
2. Using the this keyword
Console.WriteLine(this.Name);
3. Using the base keyword
Console.WriteLine(base.Name);
 */