
using HWOperation;

Camp c1 = new Camp(7.5, 50.1, 4, 5, 8);
Camp c2 = new Camp(3.5, 5.1, 2, 2, 18);
if(c1>c2)
    Console.WriteLine("c1 is bigger");
else
    if(c1<c2)
    Console.WriteLine("c2 is Bigger");
Camp c3 = c1 + c2;
Console.WriteLine(c3.ToString());
List<Camp> list = new List<Camp>();
list.Add(c3);
list.Add(c1);
list.Add(c2);
list.PrintCampList();




