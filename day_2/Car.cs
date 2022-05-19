using System.Drawing;

class Car
{
    public Image image;
    public int top;
    public int left;

    public Car() // 컨스트럭터
    {
        image = Image.FromFile(".\\resources\\sonic.jpg");
        top = 0;
        left = 0;
    }
    public void Move() // 메소드
    {
        top = top + 10;
        left = left + 10;
    }
}