using System.Windows.Forms;
using System.Drawing;
using System;

class Sample19
{
    public void Run()
    {
        string[] str = new string[3] { "연필", "지우개", "자" };
        for(int i = 0; i < str.Length; i++)
        {
            Console.WriteLine("이번 준비물은 {0}", str[i]);
        }
    }
}