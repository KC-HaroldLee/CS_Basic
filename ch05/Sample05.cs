using System.Windows.Forms;
using System;

class Sample05
{
    public void Run()
    {
        Form fm = new Form();
        fm.Text = "클래스 상속";
        fm.Width = 300; fm.Height = 200;

        PictureBox[] pb_arr = new PictureBox[2];

        for (int i = 0; i < pb_arr.Length; i++)
        {
            pb_arr[i] = new PictureBox();
            pb_arr[i].Parent = fm;
        }

        Car[] c_arr = new Car[2];

        c_arr[0] = new Car();
        c_arr[1] = new RacingCar();

        for (int i = 0; i < c_arr.Length; i++)
        {
            c_arr[i].Move(); // 유일하게 다른 것이겠지.
            pb_arr[i].Image = c_arr[i].GetImg(); // 정적으로 가지고 있는 Image
            pb_arr[i].Top = c_arr[i].Top;
            pb_arr[i].Left = c_arr[i].Left;
        }

        Application.Run(fm);

    }

}