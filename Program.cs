using ConsoleApp1.models;

using (var context = new BelegContext())
{
    // Benutzer hinzufügen
    var benutzer1 = new Benutzer { Name = "Benutzer 1" };
    var benutzer2 = new Benutzer { Name = "Benutzer 2" };
    context.Benutzer.AddRange(benutzer1, benutzer2);

    // Artikel hinzufügen
    var artikel1 = new Artikel { Bezeichnung = "Artikel 1" };
    var artikel2 = new Artikel { Bezeichnung = "Artikel 2" };
    context.Artikel.AddRange(artikel1, artikel2);

    // Beleg hinzufügen und mit Benutzer und Artikel verknüpfen
    var beleg1 = new Beleg { Datum = DateTime.Now, Benutzer = benutzer1, Artikel = new List<Artikel>() };
    beleg1.Artikel.Add(artikel1);
    beleg1.Artikel.Add(artikel2);

    var beleg2 = new Beleg { Datum = DateTime.Now, Benutzer = benutzer2, Artikel = new List<Artikel>() };
    beleg2.Artikel.Add(artikel2);

    context.Belege.AddRange(beleg1, beleg2);

    context.SaveChanges();
}
var test = new { v = "test", w = "teest" };
Console.WriteLine(test);