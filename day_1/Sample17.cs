using System;
using System.Windows.Forms;
using System.Drawing;

class Sample17
{
    public void Run()
    {
        Form fm = new Form();
        fm.Text = "배열 선언!";
        fm.Width = 300; fm.Height = 200;

        // 이렇게 말고
        //PictureBox pb1 = new PictureBox();
        //PictureBox pb2 = new PictureBox();

        // 형명[] 배열명;
        // 배열명 = new 형명[요소 수];

        PictureBox[] pb_array;
        pb_array = new PictureBox[5];

        // 위를 합치면
        // 형명 [] 배열명 = new 형명 [요소 수];
        PictureBox[] pb_array_1 = new PictureBox[8]; // <- 첨자...!

        Console.WriteLine("pb_array의 길이는 -> {0}", pb_array.Length);
        Console.WriteLine("pb_array_1의 길이는 -> {0}", pb_array_1.Length);

    }
}