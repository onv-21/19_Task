List<PC> listPC = new List<PC>
{
    new PC{Code=1, Model="Acer Aspire XC-830",CPU ="Intel Celeron", CPUFrequency = 2000, RAMSize=4, HDD=128, VideoCardMemory=1, Price=17000, NumberOfProducts=32},
    new PC{Code=2, Model="DEXP Atlas H312", CPU="Intel Pentium", CPUFrequency=4100, RAMSize=8, HDD=256, VideoCardMemory=2, Price=23000, NumberOfProducts=10},
    new PC{Code=3, Model="ZET Gaming WARD H117", CPU="Intel Core i5", CPUFrequency=2900, RAMSize=16, HDD=512, VideoCardMemory=8, Price=133000, NumberOfProducts=3},
    new PC{Code=4, Model="MSI MAG Codex 5", CPU="Intel Core i5", CPUFrequency=2600, RAMSize=16, HDD=512, VideoCardMemory=6, Price=108000, NumberOfProducts=1},
    new PC{Code=5, Model="HP Pavilion Gaming TG01", CPU="AMD Ryzen 5", CPUFrequency=3900, RAMSize=16, HDD=1024, VideoCardMemory=4, Price=78000, NumberOfProducts=8},
    new PC{Code=6, Model="DEXP Mars E335", CPU="Intel Core i5", CPUFrequency=2900, RAMSize=8, HDD=512, VideoCardMemory=4, Price=73000, NumberOfProducts=10},
    new PC{Code=7, Model="HP Slim S01", CPU="Intel Core i5", CPUFrequency=2900, RAMSize=16, HDD=1024, VideoCardMemory=6, Price=84000, NumberOfProducts=12},
    new PC{Code=8, Model="MSI Cubi 5", CPU="Intel Celeron", CPUFrequency=2000, RAMSize=4, HDD=128, VideoCardMemory=1, Price=23000, NumberOfProducts=35},
    new PC{Code=9, Model="Lenovo Idea", CPU="AMD Ryzen 5", CPUFrequency=3900, RAMSize=16, HDD=512, VideoCardMemory=4, Price=75000, NumberOfProducts=11},
    new PC{Code=10, Model="Asus PN40", CPU="Intel Celeron", CPUFrequency=2600, RAMSize=4, HDD=128, VideoCardMemory=1, Price=28000, NumberOfProducts=33}
};
Console.WriteLine("Введите тип процессора, выбрав из предложенных: 1) Intel Celeron  2) Intel Pentium  3) AMD Ryzen 5   4) Intel Core i5");
string cpu = Console.ReadLine();
List<PC> PCs = listPC
    .Where(a => a.CPU.Contains(cpu))
    .ToList();
foreach (PC a in PCs)
    Console.WriteLine($"{a.Code} {a.Model} {a.CPU} {a.CPUFrequency} {a.RAMSize} {a.HDD} {a.VideoCardMemory} {a.Price} {a.NumberOfProducts}");
Console.WriteLine();

Console.WriteLine("Введите необходимый объём оперативной памяти (Гб) из предложенных: 1) 4   2) 8   3) 16");
int ram = Convert.ToInt32(Console.ReadLine());
List<PC> PC2 = listPC
    .Where(b => b.RAMSize >= ram)
    .ToList();
foreach (PC b in PC2)
    Console.WriteLine($"{b.Code} {b.Model} {b.CPU} {b.CPUFrequency} {b.RAMSize} {b.HDD} {b.VideoCardMemory} {b.Price} {b.NumberOfProducts}");
Console.WriteLine();

Console.WriteLine("Список компьютеров в порядке возрастания цены:");
List<PC> PC3 = listPC
    .OrderBy(c => c.Price)
    .ToList();
foreach (PC c in PC3)
    Console.WriteLine($"{c.Code} {c.Model} {c.CPU} {c.CPUFrequency} {c.RAMSize} {c.HDD} {c.VideoCardMemory} {c.Price} {c.NumberOfProducts}");
Console.WriteLine();

Console.WriteLine("Список компьютеров по типу процессоров:");
var pcGroups = from pc in listPC
               group pc by pc.CPU;
  
foreach (IGrouping<string,PC> d in pcGroups)
{
    Console.WriteLine(d.Key);
    foreach (var t in d)
        Console.WriteLine(t.Model);
}
Console.WriteLine();

Console.WriteLine("Самый дорогой компьютер:");
int max = listPC.Max(f => f.Price);
Console.WriteLine(max);
Console.WriteLine();

Console.WriteLine("Самый бюджетный компьютер:");
int min = listPC.Min(n => n.Price);
Console.WriteLine(min);
Console.WriteLine();

Console.WriteLine("Есть ли хотя бы одна модель компьютера в количестве не менее 30 шт:");
bool result1 = listPC.Any(u => u.NumberOfProducts >= 30);
if (result1)
    Console.WriteLine("Да, такие модели имеются");
else
    Console.WriteLine("Компьютеров одной модели в таком количестве нет");
class PC
{
    public int Code { get; set; }
    public string Model { get; set; }
    public string CPU{ get; set; }
    public int CPUFrequency { get; set; }
    public int RAMSize { get; set; }
    public int HDD { get; set; }
    public int VideoCardMemory { get; set; }
    public int Price { get; set; }
    public int NumberOfProducts { get; set; }
}

