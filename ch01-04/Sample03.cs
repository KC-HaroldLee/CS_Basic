using System.Windows.Forms;

class Sample03
{
    public void Run()
    {
        Form fm = new Form();
        fm.Text = "Title";

        Label lb = new Label();
        lb.Width = 150;
        //lb.Height = 150;
        lb.Text = "C#을 시작합니다.";
        lb.Parent = fm;

        Application.Run(fm);
    }
}
