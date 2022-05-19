using System.Windows.Forms;
using System.Drawing;

class Sample04
{
    public void Run()
    {
        Form fm = new Form();
        fm.Text = "title";

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(".\\resources\\sonic.jpg");
        pb.Parent = fm;

        Application.Run(fm);
    }
}