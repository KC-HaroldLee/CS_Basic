using System.Windows.Forms;
using System.Drawing;

class Sample08
{
    public void Run()
    {
        Form fm = new Form();
        fm.Text = "샘플";

        int w;
        w = 100;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(".\\resources\\sonic.jpg");
        pb.Top = pb.Top + 10;
        pb.Left = pb.Left + 10;

        pb.Parent = fm;

        Application.Run(fm);

    }
}