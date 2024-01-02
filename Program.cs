namespace Enum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("///Erzurum Hava Durumu///");
        //Console.WriteLine("Lütfen hava durumunu giriniz:");
        int weather = 24; //Convert.ToInt32(Console.ReadLine());
        if( weather <= (int)Havadurumu.coksıcak)
        {
            Console.WriteLine("Hava birşeyler yapmak için ideal :)");
        }
        else if(weather <= (int)Havadurumu.soguk)
        {
            Console.WriteLine("Hava çok soğuk lütfen mecbur kalmadıkça dışarıya çıkma !");
        }
        else if(weather >= (int)Havadurumu.Normal && weather <=(int)Havadurumu.coksıcak)
        {
            Console.WriteLine("Ne çok sıcak nede çok soğuk,kahvenin tam zamanı :))");
        }
        



        

    }
}


enum Havadurumu
{
  Normal = 10,
  normalustu = 15,

  Sıcak = 20,


  coksıcak = 25,
 

  soguk = 0,


 



}
