using System.Windows.Forms;
using System.Drawing;

class Sample11
{
    public void Run()
    {
        Form fm = new Form();
        fm.Text = "조건문을 달아보자";
        fm.Width = 300; fm.Height = 200;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile(".\\resources\\sonic.jpg");
        pb.Left = 100;

        Label lb = new Label();
        lb.Top = pb.Bottom;
        lb.Width = 170;
        lb.Text = "자동차 입니다.";

        if (pb.Left >= 150)
        {
            lb.Text = "자동차는 동쪽에 있습니다";
        }
        else if (pb.Left <=20)
        {
            lb.Text = "자동차는 서쪽에 있습니다";
        }
        else
        {
            lb.Text = "자동차는 중앙에 있습니다";
        }

        pb.Parent = fm;
        lb.Parent = fm;

        Application.Run(fm);
    }
}