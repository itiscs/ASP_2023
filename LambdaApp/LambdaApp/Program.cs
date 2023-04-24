
using LambdaApp;



ArOper arOper = new ArOper();

//MyDeleg del = new MyDeleg(arOper.Sum);
Func<int,int,int> del = new Func<int, int, int> (arOper.Sum);


Console.WriteLine(del(8, 5));

del = arOper.Min;

Console.WriteLine(del(8, 5));

del = arOper.Mult;

Console.WriteLine(del(8, 5));

del = arOper.Div;

Console.WriteLine(del.Invoke(8, 5));


//del = delegate(int k, int l) { return k * 2 + l; };
del = (k, l) => k * 3 + l; //лямбда-выражение

Console.WriteLine(del(8, 5));

del = arOper.Minimum;


//HelloDeleg hd = new HelloDeleg(arOper.Hello1);
Action hd = new Action(arOper.Hello1);
//Action<int> hd1 = new Action<int>()


hd.Invoke();

//hd -= arOper.Hello1;

hd += arOper.Hello2;
hd += arOper.Hello2;
hd += arOper.Hello2;
hd += arOper.Hello2;
hd += arOper.Hello2;
hd += delegate () { Console.WriteLine("Hello from anonim"); };
hd += () => { Console.WriteLine("Hello from lambda "); };


hd?.Invoke();

//hd = arOper.Hello1;


Console.WriteLine("************************************");
List<Student> stud = new List<Student>();
stud.Add(new Student() { 
    Id = 1, Name = "Ivan", Group = "09-911", Marks = { 4,5,4,3,4,5}
});
stud.Add(new Student()
{
    Id = 2,
    Name = "Petr",
    Group = "09-911",
    Marks = { 4, 5, 5, 5, 4, 5 }
});
stud.Add(new Student()
{
    Id = 3,
    Name = "Maria",
    Group = "09-911",
    Marks = { 4, 5, 4, 3, 4, 5,4,5,5,5,5,3,3,3 }
});
stud.Add(new Student()
{
    Id = 4,
    Name = "Anna",
    Group = "09-912",
    Marks = { 4, 5, 4, 3, 4, 5 }
});


int k = 10, n = 100, Nperpage = n/k;


var st1 = stud.Where(s => s.Group == "09-911")
    .OrderByDescending(s => s.Marks.Count).Skip(1);

foreach(var st in  st1)
{
    Console.WriteLine(st);
}

var st2 = stud.Select(s => new {s.Name, s.Group });

foreach(var st in st2)
{
    Console.WriteLine(st);
}


