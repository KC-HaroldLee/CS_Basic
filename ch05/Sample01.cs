using System.Windows.Forms;

class Sample01
{
    public void Run()
    {
        Form fm = new Form();
        fm.Text = "클래스다!";
        fm.Width = 300; fm.Height = 200;
        PictureBox pb = new PictureBox();

        Car car = new Car();
        car.Move();
        car.Move();
        car.Move();
        car.Move();

        //pb.Image = car.image;
        //pb.Top = car.top;
        //pb.Left = car.left;

        pb.Parent = fm;
        Application.Run(fm);
    }

}