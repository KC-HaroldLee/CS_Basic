using System.Windows.Forms;
using System.Drawing;

class Sample10
{
    public void Run()
    {
        Form fm = new Form();
        fm.Text = "조건문을 달아보자";

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(".\\resources\\sonic.jpg");
        pb.Left = 200;

        Label lb = new Label();
        lb.Top = pb.Bottom;
        lb.Width = 170;
        lb.Text = "자동차 입니다.";

        if (pb.Left >= 150)
        {
            lb.Text = "자동차는 동쪽에 있습니다";
        }

        pb.Parent = fm;
        lb.Parent = fm;

        Application.Run(fm);
    }
}