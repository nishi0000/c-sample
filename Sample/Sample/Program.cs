// See https://aka.ms/new-console-template for more information

//int a = 0;
//int b = 1;

//while (true)
//{
//    if (a > 500)
//    {
//        break;
//    }

//    a += b;
//    b++;
//    Console.WriteLine(a);
//}



//float[] weights = { 41.2f,42.5f,44.9f,43.2f,45.1f,43.2f,42.7f };

//foreach (float w in weights)
//{
//    if (w <= 43f)
//    {
//        Console.WriteLine(w);
//    }
//}


//void Shop()
//{
//    Console.WriteLine("いらっしゃいませ！");
//}

//Shop();
//Shop();
//Shop();


//void Shop(string itemName)
//{
//    Console.WriteLine("いらっしゃいませ！");

//    if (itemName == "薬草")
//    {
//        Console.WriteLine(itemName + "は100円です");
//    }else if(itemName == "こん棒")
//    {
//        Console.WriteLine(itemName + "は1500円です");
//    }
//    else
//    {
//        Console.WriteLine("取り扱っていません");
//    }

//}


//Shop("薬草");
//Shop("こん棒");
//Shop("はがねのつるぎ");


//void ShowEvenOrOdd(int i)
//{
//    if (i%2 == 0)
//    {
//        Console.WriteLine("偶数です");
//    }
//    else
//    {
//        Console.WriteLine("奇数です");
//    }
//}


//ShowEvenOrOdd(2);
//ShowEvenOrOdd(4);
//ShowEvenOrOdd(5);



//int Shop(string itemName)
//{
//    Console.WriteLine("いらっしゃいませ！");
//    int price = 0;

//    if(itemName == "薬草")
//    {
//        Console.WriteLine(itemName + "は100円です");

//    }
//}


//int Shop(string item,int money)
//{
//    Console.WriteLine("いらっしゃいませ！");

//    if (item == "薬草")
//    {
//        Console.WriteLine("薬草は100円です。");
//        Console.WriteLine("ご購入ありがとうございます！");

//        money -= 100;


//    }
//    else if (item == "こんぼう")
//    {
//        Console.WriteLine("こんぼうは500円です。");
//        Console.WriteLine("ご購入ありがとうございます！");

//        money -= 500;

//    }
//    else if (item == "万能薬")
//    {
//        Console.WriteLine("万能薬は1000円です。");
//        Console.WriteLine("ご購入ありがとうございます！");

//        money -= 1000;

//    }
//    else
//    {
//        Console.WriteLine("当店ではその品は扱っておりません。");
//    }

//    Console.WriteLine("所持金は" + money + "です");
//    return money;
//}


//Shop("薬草", 1500);


//float CalcAverage (float a ,float b,   float c)
//{
//   float average= a + b + c / 3;
//   return average;
//}


//Console.WriteLine(CalcAverage(23f, 32f, 46f));


//using Sample;

//Player player1 = new Player("たろう",100);

//player1.Hp -= 700;

//Console.WriteLine(player1.Hp);


//int hp = player1.GetHp();

//int newHP = hp - 1000;

//player1.SetHp(newHP);

//Console.WriteLine("HPは" + player1.GetHp());

//player1.SetName("12345679");


//player1.Attack();




//using Sample;

//SkyKart skyKart = new SkyKart();
//TurboKart turboKart =new TurboKart();

//skyKart.Flying();
//skyKart.Force();
//turboKart.Force();
//turboKart.Turbo();

//SuperTurboKart superKart =new SuperTurboKart();

//superKart.Force();


//using Sample;

//Kart kart = new Kart();

//kart.Wan2();

using Sample;

Kart[] karts = new Kart[2];

karts[0] = new SkyKart();
karts[1] = new TurboKart();

for(int i = 0; i < karts.Length; i++)
{
    karts[i].Horn();
}










