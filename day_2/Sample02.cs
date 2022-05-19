using System.Windows.Forms;
using System;

class Sample02
{
    public void Run()
    {
        // 생성자는 알아서 해주나 보다.
        Calc calc = new Calc();
        int result = calc.Add(4, 8);
        Console.WriteLine("답은 {0}", result);
    }

}