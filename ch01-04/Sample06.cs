using System.Windows.Forms;
using System.Drawing;

class Sample06
{
    public void Run()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(".\\resources\\sonic.jpg");
        pb.Top = 100;
        pb.Left = pb.Width;

        pb.Parent = fm;

        Application.Run(fm);

    }
}