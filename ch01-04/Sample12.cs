using System.Windows.Forms;
using System.Drawing;

class Sample12
{
    public void Run()
    {
        Form fm = new Form();
        fm.Text = "switch문을 달아보자";
        fm.Width = 300; fm.Height = 200;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(".\\resources\\sonic.jpg");
        pb.Left = 150;

        Label lb = new Label();
        lb.Top = pb.Bottom;
        lb.Width = 170;
        lb.Text = "자동차 입니다.";

        switch (pb.Left)
        {
            case 20:
                lb.Text = "20!";
                break;
            case 150:
                lb.Text = "150!";
                break;
            default:
                lb.Text = "default!";
                break;
        }

        pb.Parent = fm;
        lb.Parent = fm;

        Application.Run(fm);
    }
}