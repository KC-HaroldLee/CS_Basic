using System.Windows.Forms;
using System;

class Sample04
{
    public void Run()
    {
        Form fm = new Form();
        fm.Text = "정적 메소드 사용";
        fm.Width = 300; fm.Height = 200;

        Label lb = new Label();

        Car c1 = new Car();
        Car c2 = new Car();

        lb.Width = 170;
        lb.Text = Car.CountCar();

        lb.Parent = fm;

        Application.Run(fm);

    }

}