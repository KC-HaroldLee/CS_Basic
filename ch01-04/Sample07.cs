using System.Windows.Forms;
using System.Drawing;

class Sample07
{
    public void Run()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        int w;
        w = 100;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(".\\resources\\sonic.jpg");
        pb.Top = w;

        pb.Parent = fm;

        Application.Run(fm);

    }
}