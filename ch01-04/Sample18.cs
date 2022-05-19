using System.Windows.Forms;
using System.Drawing;

class Sample18
{
    public void Run()
    {
        Form fm = new Form();
        fm.Text = "배열을 사용한다!";
        fm.Width = 300; fm.Height = 500;

        PictureBox[] pb_array = new PictureBox[5];

        for (int i = 0; i < pb_array.Length; i++)
        {
            pb_array[i] = new PictureBox(); // < 이게 꼭 필요한 걸까?
            pb_array[i].Image = Image.FromFile(".\\resources\\sonic.jpg");
            pb_array[i].Top = i * pb_array[i].Height;
            pb_array[i].Parent = fm;
        }
        Application.Run(fm);
    }
}