using System.Windows.Forms;
using System.Drawing;
using System;

class Sample21
{ 
    public void Run()
    {
        // 다차원 배열
        // 형명[,] 배열명;
        // 배열명 = new 배열명[행의 개수, 열의 개수]
        //string[,] cities; < 이 방법보다는 
        //cities = new string[4, 3] // 넘파이를 기억하자
        //{
        //    { "서울","1","seoul"},
        //    { "인천","2","incheon" },
        //    { "대구","3","Deagu"},
        //    { "부산","4","Busan" }
        //};
        string[][] cities; // 이게 더 편하다. 
        cities = new string[4][] // 넘파이를 기억하자...!
        {
            new string[] { "서울","1","seoul"},
            new string[] { "인천","2","incheon" },
            new string[] { "대구","3","Deagu"},
            new string[] { "부산","4","Busan" }
        };


        //foreach (string[,] city in cities)
        //{
        //왜 안되는가...!
        //}
        for (int i =0 ; i < cities.Length; i++)
        {
            Console.WriteLine("{0}의 정보를 말하자면", cities[i][0]);
            for ( int j = 0; j < cities[i].Length; j++)
            {
                Console.WriteLine("{0}이다!", cities[i][j]);
            }
        }

    }
}