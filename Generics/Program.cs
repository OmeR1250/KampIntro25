



using Generics;

List<string> araclar1 = new List<string>();
araclar1.Add("Audi");
araclar1.Add("Land Rover");
Console.WriteLine(araclar1.Count);
araclar1.GetEach();


MyList<string> araclar2 = new MyList<string>();
araclar2.Add("KIA");
araclar2.Add("Volkswagen");
Console.WriteLine(araclar2.Count);
araclar2.GetEach();