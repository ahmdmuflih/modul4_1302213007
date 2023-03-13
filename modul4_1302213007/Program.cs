public class KodeBuah_1302213007
{
    public string getKodeBuah_1302213007(string buah)
    {
        switch (buah)
        {
            case "Apel":
                return "A00";
            case "Aprikot":
                return "B00";
            case "Alpukat":
                return "C00";
            case "Pisang":
                return "D00";
            case "Paprika":
                return "E00";
            case "Blackberry":
                return "F00";
            case "Ceri":
                return "H00";
            case "Kelapa":
                return "I00";
            case "Jagung":
                return "J00";
            case "Kurma":
                return "K00";
            case "Durian":
                return "L00";
            case "Anggur":
                return "M00";
            case "Melon":
                return "N00";
            case "Semangka":
                return "O00";
            default:
                return "Kode tidak ditemukan";
        }
    }
}

public class Program
{
    static void Main()
    {
        KodeBuah_1302213007 kodeBuah = new KodeBuah_1302213007();

        Console.WriteLine("|Buah\t\t|Kode Buah|");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"|Apel\t\t| {kodeBuah.getKodeBuah_1302213007("Apel")}\t|");
        Console.WriteLine($"|Aprikot\t| {kodeBuah.getKodeBuah_1302213007("Aprikot")}\t|");
        Console.WriteLine($"|Alpukat\t| {kodeBuah.getKodeBuah_1302213007("Alpukat")}\t|");
        Console.WriteLine($"|Pisang\t\t| {kodeBuah.getKodeBuah_1302213007("Pisang")}\t|");
        Console.WriteLine($"|Paprika\t| {kodeBuah.getKodeBuah_1302213007("Paprika")}\t|");
        Console.WriteLine($"|Blackberry\t| {kodeBuah.getKodeBuah_1302213007("Blackberry")}\t|");
        Console.WriteLine($"|Ceri\t\t| {kodeBuah.getKodeBuah_1302213007("Ceri")}\t|");
        Console.WriteLine($"|Kelapa\t\t| {kodeBuah.getKodeBuah_1302213007("Kelapa")}\t|");
        Console.WriteLine($"|Jagung\t\t| {kodeBuah.getKodeBuah_1302213007("Jagung")}\t|");
        Console.WriteLine($"|Kurma\t\t| {kodeBuah.getKodeBuah_1302213007("Kurma")}\t|");
        Console.WriteLine($"|Durian\t\t| {kodeBuah.getKodeBuah_1302213007("Durian")}\t|");
        Console.WriteLine($"|Anggur\t\t| {kodeBuah.getKodeBuah_1302213007("Anggur")}\t|");
        Console.WriteLine($"|Melon\t\t| {kodeBuah.getKodeBuah_1302213007("Melon")}\t|");
        Console.WriteLine($"|Semangka\t| {kodeBuah.getKodeBuah_1302213007("Semangka")}\t|");
        Console.WriteLine("-------------------------------------------");
    }
}