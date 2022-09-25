internal class Program
{
    private static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.SetId(5);
        Console.WriteLine("Id is " + s1.GetId());
        s1.SetName("Hamza");
        Console.WriteLine("Name is " + s1.GetName());
        Console.WriteLine("Pass Mark is " + s1.GetPassMark());

        Console.ReadKey();
    }
}

public class Student
{
    private int _id;
    private string _name;
    private int _passMark = 35;

    public void SetId(int id)
    {
        if (id <= 0)
        {
            throw new Exception("Student Id can not be negative");
        }
        this._id = id;
    }
    public int GetId()
    {
        return this._id;
    }

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
        //if (string.IsNullOrEmpty(this._name))
        //{
        //    return "No Name";
        //}
        //else 
        //{
        //    return this._name;
        //}
    }
    public int GetPassMark()
    {
        return _passMark;
    }

    /*
     * In this example we used the SetId() and GetId() Methods to encapsulate _id class field
     */
}