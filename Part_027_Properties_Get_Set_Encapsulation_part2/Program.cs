internal class Program
{
    public static void Main(string[] args)
    {
        Student s2 = new Student();
        s2.Id = 10;
        Console.WriteLine("Id is " + s2.Id);
        s2.Name = "Hamza";
        Console.WriteLine("Name is " + s2.Name);
        Console.WriteLine("Pass Mark is " + s2.PassMark);
        s2.Email = "hamza@yahoo.com";
        s2.City = "Dhaka";

        Console.WriteLine("city is " + s2.City);
        Console.WriteLine("email is " + s2.Email);
        Console.ReadKey();
    }
}

public class Student
{
    private int _id;
    private string _name;
    private int _passMark = 35;
    private string _city;
    private string _email;


    /*
    public void SetId(int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Student Id can not be negative");
        }
        this._id = Id;
    }
    public int GetId()
    {
        return this._id;
    }
    */

    public int Id
    {
        set
        {
            if (value < 0)
            {
                throw new Exception("Student Id can not be negative");
            }
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }

    /*
    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name can not be null or empty");
        }
        _name = Name;
    }

    public string GetName()
    {
        return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
    }
    */

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name can not be null or empty");
            }
            _name = value;
        }

        get
        {
            return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
        }
    }

    /*
    public int GetPassMark()
    {
        return _passMark; 
    }
    */

    public int PassMark
    {
        get
        {
            return _passMark;
        }
    }

    public string City
    {
        get
        {
            return this._city;
        }
        set
        {
            this._city = value;
        }
    }

    public string Email { get; set; }

}