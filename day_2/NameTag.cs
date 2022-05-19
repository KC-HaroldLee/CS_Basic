using System;

class NameTag
{
    public string name;
    private int age;
    public int id_No;

    public NameTag(string input_name, int input_age, int input_id_No)
    {
        name = input_name;
        age = input_age;
        id_No = input_id_No;
    }
    public void ChangeAge(int value)
    {
        Console.WriteLine("age is changed {0} -> {1}", age , value);
        age = value;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine("name is {0}", name);
        Console.WriteLine("age is {0}", age);
        Console.WriteLine("id_No is {0}", id_No);

    }
}