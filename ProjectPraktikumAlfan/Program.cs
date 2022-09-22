namespace TugasPraktikumInheritance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Agya mobil1 = new Agya();
            mobil1.ban = new Michelin();
            mobil1.merk = "Michelin";
            Console.WriteLine("Merk ban mobil " + mobil1.tipe + " adalah " + mobil1.merk);
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();
            Avanza mobil2 = new Avanza();
            mobil2.ban = new Bridgestone();
            mobil2.NyalakanLampu();
            Civic civic1 = new Civic();
            civic1.ban = new Bridgestone();
            civic1.VtecKickedin();
        }
    }
}
class Mobil
{
    public string merk;
    public string tipe;
    public Ban ban;

    public void NyalakanMesin()
    {
        Console.WriteLine("Mesin mobil " + merk + " bertipe " + tipe + " menyala");
    }
    public void MatikanMesin()
    {
        Console.WriteLine("Mesin mobil " + merk + " bertipe " + tipe + " mati");
    }
}
class Ban
{
    public string merk;
    public Ban(string merk)
    {
        this.merk = merk;
    }
}

class Michelin : Ban
{
    public Michelin() : base("Michelin")
    {
    }
}

class Bridgestone : Ban
{
    public Bridgestone() : base("Bridgestone")
    {
    }
}

class Toyota : Mobil
{
    public Toyota()
    {
        merk = "Toyota";
    }
}

class Daihatsu : Mobil
{
    public Daihatsu()
    {
        merk = "Daihatsu";
    }
}

class Honda : Mobil
{
    public Honda()
    {
        merk = "Honda";
    }
}

class Agya : Toyota
{
    public Agya()
    {
        tipe = "Agya";
    }
}

class Innova : Toyota
{
    public Innova()
    {
        tipe = "Innova";
    }
}

class Avanza : Toyota
{
    public Avanza()
    {
        tipe = "Avanza";
    }
    public void NyalakanLampu()
    {
        Console.WriteLine("Lampu mobil " + merk + " bertipe " + tipe + " menyala");
    }
}

class Ayla : Daihatsu
{
    public Ayla()
    {
        tipe = "Ayla";
    }
}

class Xenia : Daihatsu
{
    public Xenia()
    {
        tipe = "Xenia";
    }
}

class Brio : Honda
{
    public Brio()
    {
        tipe = "Brio";
    }
}

class Civic : Honda
{
    public Civic()
    {
       tipe = "Civic";
    }
    public void VtecKickedin()
    {
        Console.WriteLine("Ngeeeng Wooosh!!!");
    }
}

