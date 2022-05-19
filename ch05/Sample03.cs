using System.Windows.Forms;
using System;

class Sample03
{
    public void Run()
    {
        // 생성자는 알아서 해주나 보다.
        NameTag nameTag = new NameTag("커트", 27, 7);
        nameTag.PrintInfo();

        nameTag.name = "코베인";
        nameTag.id_No = 8;
        nameTag.PrintInfo();

        //nameTag.age = 2; 액세스 할 수 없다
        //Console.WriteLine("이렇게 할 수도 없다.{0}", nameTag.age);
        nameTag.ChangeAge(8); // 메소드를 만들 수밖에
        nameTag.PrintInfo();
    }

}