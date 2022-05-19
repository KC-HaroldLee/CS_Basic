using System.Windows.Forms;
using System.Drawing;
using System;

class Sample22
{ 
    public void Run()
    {
        // foreach 되겠지?
        string[][] cities; // 이게 더 편하다. 
        cities = new string[4][] // 넘파이를 기억하자...!
        {
            new string[] { "서울","1","seoul"},
            new string[] { "인천","2","incheon" },
            new string[] { "대구","3","Deagu"},
            new string[] { "부산","4","Busan" }
        };


        foreach (string[] city in cities)
        {
            Console.WriteLine("{0}의 정보!", city[0]);
            foreach (string item in city)
            {
                Console.WriteLine("{0}!!!", item);
            }
        }


    }
}