using System.Drawing;

class Car
{
    public static int Count = 0;
    //private Image img; // 상속 받기 연습을 하면서 private을 사용하지 않게 되었다.
    //private int top;
    //private int left;
    protected Image img; // protected는 파생 클래스에서 접근 할 수 있게 한다.
    protected int top;
    protected int left;

    public Car() // 컨스트럭터
    {
        Count++; // 인스턴스가 생성 될 때 마다 늘릴 수 있다.
        img = Image.FromFile(".\\resources\\sonic.jpg");
        top = 1;
        left = 1;
    }


    public static string CountCar()
    {
        return "자동차는 총 " + Count + "대가 있습니다.";
    }

    public virtual void Move() // virtual과 public은 별개다.
    {
        top = top + 10;
        left = left + 10;
    }

    public void SetImg (Image i)
    {
        img = i;
    }

    public Image GetImg()
    {
        return img;
    }

    public int Top
    {
        set { top = value; }
        get { return top; }
    }

    public int Left
    {
        set { left = value; } // 여기에 Left적었다가 스택오버플로우 남
        get { return left; }
    }
}