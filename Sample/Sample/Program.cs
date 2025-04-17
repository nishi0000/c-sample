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

//using Sample;

//Kart[] karts = new Kart[2];

//karts[0] = new SkyKart();
//karts[1] = new TurboKart();

//for(int i = 0; i < karts.Length; i++)
//{
//    karts[i].Horn();
//}



//List<float> weights = new List<float>();

//weights.Add(42.2f);
//weights.Add(42.5f);
//weights.Add(44.9f);
//weights.Add(43.2f);
//weights.Add(42.7f);
//weights.Add(41.7f);

//for(int i =0; i < weights.Count; i++)
//{
//    Console.WriteLine(weights[i]);
//}


//List<String> names = new List<string>();

//names.Add("test");
//names.Add("test2");
//names.Add("test3");
//names.Add("test4");
//names.Add("test5");

//for (int i = 0;  i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}

//names.RemoveAt(1);

//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}

//names.Remove("test");

//for (int i = 0;i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}



//List<float> weights = new List<float>();

//weights.Add(42.2f);
//weights.Add(42.5f);
//weights.Add(44.9f);
//weights.Add(43.2f);
//weights.Add(42.7f);
//weights.Add(41.7f);

//weights.Sort();

//for (int i = 1; i <= 3; i++)
//{
//    Console.WriteLine(weights[weights.Count - i]);
//}

//Dictionary <String,float> weights = new Dictionary<String,float>();

//weights.Add("2023/12/10",41.2f);
//weights.Add("2023/12/11", 42.5f);
//weights.Add("2023/12/12", 44.9f);
//weights.Add("2023/12/13", 43.2f);
//weights.Add("2023/12/14", 43.2f);
//weights.Add("2023/12/15", 42.7f);
//weights.Add("2023/12/16", 41.7f);

//Console.WriteLine(weights["2023/12/13"]);


//Dictionary<String,String> weights = new Dictionary<String, String>();

//weights.Add("000-123-4563","山田");
//weights.Add("000-469-2488", "小山田");
//weights.Add("000-312-7721", "山本");

//Console.WriteLine(weights["000-123-4563"]);

//int Add(int n)
//{
//    return n + 5;
//}

//int a = 0;

//Console.WriteLine(Add(a));

//int[] hp = { 420, 120, 600, 0, 1200 };
//List<int> newHp = new List<int>();

//for (int i = 0; i < hp.Length; i++)
//{
//    if(hp[i] > 500)
//    {
//        newHp.Add(hp[i]);
//    }
//}

//foreach (int i in newHp)
//{
//    Console.WriteLine(i);
//}


//int[] hp = { 420, 120, 600, 0, 1200 };

//var newHP = hp.Where(x => x >= 500);

//foreach (int i in newHP)
//{
//    Console.WriteLine(i);
//}

//int[] hp = { 550,420,600,800,220};
//List<int> newHP = new List<int>();

//for (int i = 0; i < hp.Length; i++)
//{
//    int a = hp[i] - 100;
//    newHP.Add(a);
//}

//foreach (int a in newHP)
//{
//    Console.WriteLine(a);
//}

//int[] hp = { 550, 420, 600, 800, 220 };

//var newHP = hp.Select(x => x - 100);

//foreach (int a in newHP)
//{
//    Console.WriteLine(a);
//}

//int[] hp = { 550, 0, 600, 0, 220 };
//int dieEnemy = 0;

//for (int i = 0; i < hp.Length; i++)
//{
//    if (hp[i] == 0)
//    {
//        dieEnemy ++;
//    }

//}

//Console.WriteLine(dieEnemy);

//int[] hp = { 550, 0, 600, 0, 220 };

//var count = hp.Where(x => x == 0).Count();

//Console.WriteLine(count);

//int[] nums = { -1, -10, -5, -40, -15 };

//var newNums = nums.Select(x => x + 10);

//newNums = newNums.Where(x => x >= 0);

//foreach (var newNum in newNums)
//{
//    Console.WriteLine(newNum);
//}

using Sample;

List<Player> players = new List<Player>();
players.Add(new Player("一郎",70));
players.Add(new Player("太郎", 60));
players.Add(new Player("次郎", 100));

var sortPlayers = players.OrderBy(n => n.Hp);

foreach (var player in sortPlayers)
{
    Console.WriteLine(player.name + player.hp);
}