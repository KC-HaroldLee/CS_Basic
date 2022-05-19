using System.Windows.Forms;
using System.Drawing;
using System;

class Sample20 
{ 
    public void Run()
    {
        // 난 foreach가 편하지
        string[] str_list = new string[3] { "연필", "지우개", "자" };

        foreach (string item in str_list)
        {
            Console.WriteLine("이번 준비물은!! {0}", item);
        }
    }
}