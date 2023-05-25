using Kutyak;

List<KutyaFajtak> kutyafajtak = new List<KutyaFajtak>();
List<KutyaNevek> kutyanevek = new List<KutyaNevek>();
List<kutyak> kutyak = new List<kutyak>();

foreach (var sor in File.ReadAllLines("KutyaFajtak.csv").Skip(1))
{
    KutyaFajtak kutya = new KutyaFajtak(sor);
    kutyafajtak.Add(kutya);
}
foreach (var sor in File.ReadAllLines("KutyaNevek.csv").Skip(1))
{
    KutyaNevek kutya = new KutyaNevek(sor);
    kutyanevek.Add(kutya);
}
foreach (var sor in File.ReadAllLines("Kutyak.csv").Skip(1))
{
    kutyak kutya = new kutyak(sor);
    kutyak.Add(kutya);
}
Console.WriteLine($"3. feladat: Kutyanevek száma: {kutyanevek.Count()}");
Console.WriteLine($"6. feladat: Kutyák átlag életkora: {Math.Round(kutyak.Average(x => x.KutyaKor), 2)}");
Console.WriteLine($"7. feladat: Legidősebb kutya neve és fajtája: {kutyanevek.Where(x => x.KutyaId == kutyak.OrderByDescending(x => x.KutyaKor).First().NevAzon).First().KutyaNev}," +
    $" {kutyafajtak.Where(x => x.KutyaId == kutyak.OrderByDescending(x => x.KutyaKor).First().FajtaAzon).First().KutyaNev}");

kutyak.Where(x => x.UtolsoEll == DateTime.Parse("2018.01.10.")).ToList().ForEach(x => Console.WriteLine(x.FajtaAzon));
