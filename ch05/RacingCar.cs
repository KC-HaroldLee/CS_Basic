using System.Drawing;

class RacingCar : Car
{
    //변수는 이미 다 상속 받았다
    //public static int Count = 0;
    //private Image img;
    //private int top;
    //private int left;

    /*
     memo : abstract 는 추상 클래스 / interface는 인터페이스, 여기엔 인자만 적을 수 있다.
     
     */
    public RacingCar() // 컨스트럭터
    {
        Count++; // 인스턴스가 생성 될 때 마다 늘릴 수 있다.
        img = Image.FromFile(".\\resources\\sonic.jpg");
        top = 0;
        left = 0;
    }

    public override void Move() // 다시 정의한다. 하지만 상속클래스에 virtual을 붙어야한다.
    {
        top = top + 100;
        left = left + 100;
    }

}