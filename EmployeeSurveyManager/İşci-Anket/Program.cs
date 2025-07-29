using System.Globalization;

List<string> isciliste = new List<string>();
List<string> anketliste = new List<string>();

string iscidata = "iscidata.txt";
string anketdata = "anketdata.txt";

if (File.Exists(iscidata) && File.Exists(anketdata))
{
    string[] iscilerim = File.ReadAllLines(iscidata);
    string[] anketlerim = File.ReadAllLines(anketdata);

    int say = Math.Min(iscilerim.Length, anketlerim.Length);

    for (int i = 0; i < say; i++)
    {
        isciliste.Add(iscilerim[i]);
        anketliste.Add(anketlerim[i]);
    }
}
//--------------------------------------------------------------------------
string adminisim = "";
string adminparol = "";

string isimdata = "isimdata.txt";
string paroldata = "paroldata.txt";

if ((File.Exists(isimdata) && File.Exists(paroldata)) && (new FileInfo(isimdata).Length > 0 && new FileInfo(paroldata).Length > 0))
{
    adminisim = File.ReadAllLines(isimdata)[0];
    adminparol = File.ReadAllLines(paroldata)[0];
}
else
{
    Console.WriteLine("Admin hesabiniz yoxdur! Yeni Admin hesabi yaradin!");
    Console.Write("Admin hesabinin adi: ");
    string adminad = Console.ReadLine();
    Console.Write("Admin hesabinin sifresi(Sadece reqem ve herfler): ");
    string adminsifre = Console.ReadLine();

    adminisim = adminad;
    adminparol = adminsifre;

    File.WriteAllText(isimdata, adminisim);
    File.WriteAllText(paroldata, adminparol);
}


//---------------------------------------------------------------------------

void iscielaveet()
{
    Console.WriteLine("-----------------");
    Console.Write("Elave etmek istediginiz iscinin adi: ");
    string ad = Console.ReadLine();
    Console.Write("Elave etmek istediginiz iscinin soyadi: ");
    string soyad = Console.ReadLine();
    Console.Write("Elave etmek istediginiz iscinin telefon nomresi: ");
    string telefon = "";
    int cehd = 3;

    while (cehd > 0)
    {
        Console.Write("Elave etmek istediyiniz iscinin telefon nomresi: ");
        telefon = Console.ReadLine();

        if (telefon.Contains(".") || telefon.Contains(","))
        {
            cehd--;
            Console.WriteLine("Telefon nomresinde ',' və ya '.' işaresi olmamalıdır! Qalan cehd: " + cehd);
        }
        else
        {
            break;
        }
    }

    if (cehd == 0)
    {
        Console.WriteLine("Cehd sansiniz qalmadi elaveet funksiyasi avtomatik olaraq bitirildi!");
        return;
    }
    Console.Write("Elave etmek istediginiz iscinin Maasi(Tam eded): ");
    string maas = Console.ReadLine();

    string tamadlar = ad + " " + soyad + " " + telefon + " " + maas;
    isciliste.Add(tamadlar);
    File.WriteAllLines(iscidata, isciliste);

    Console.WriteLine("Ugurnan elave olundu!");
    Console.WriteLine(tamadlar);
}

void iscilerebax()
{
    if (isciliste.Count != 0)
    {
        for (int i = 0; i < isciliste.Count; i++)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("ID - AD - SOYAD - NOMRE - MAAS");
            Console.WriteLine(i + 1 + "-" + isciliste[i]);
        }
    }
    else
    {
        Console.WriteLine("Hec bir isci elave olunmuyub!");
  }

}

void iscisil()
{
    iscilerebax();
    Console.WriteLine("-----------------");
    Console.Write("Silmek istediginiz iscinin ID: ");
    int iscilersil = Convert.ToInt32(Console.ReadLine());
    if (iscilersil <= isciliste.Count + 1)
    {
        isciliste.RemoveAt(iscilersil - 1);
        File.WriteAllLines(iscidata, isciliste);
        Console.WriteLine("Isci ugurnan silindi!");
    }
    else
    {
        Console.WriteLine("Sehv id!");
    }

}

//------------------------------------------------------------

void anketelaveet()
{
    Console.WriteLine("-----------------");
    Console.Write("Elave etmek istediginiz anket suali: ");
    string anketsuali = Console.ReadLine();

    anketliste.Add(anketsuali);
    File.WriteAllLines(anketdata,anketliste);
}

void anketbax()
{   if (anketliste.Count != 0)
    {
        for (int i = 0; i < anketliste.Count; i++)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("ID - ANKET");
            Console.WriteLine(i + 1 + "-" + anketliste[i]);
        }
    }
    else
    {
        Console.WriteLine("Anket elave olunmuyub!");
}

}

void anketsil()
{
    anketbax();
    Console.WriteLine("-----------------");
    Console.Write("Silmek istediginiz anketin ID: ");
    int anketsil = Convert.ToInt32(Console.ReadLine());
    if (anketsil <= anketliste.Count + 1)
    {
        anketliste.RemoveAt(anketsil - 1);
        File.WriteAllLines(anketdata, anketliste);
        Console.WriteLine("anket ugurnan silindi!");
    }
    else
    {
        Console.WriteLine("Sehv id!");
    }
}

void anketgonder()
{
    /* Burada adminlər müəyyən nömrələrə müəyyən anketler göndərə biləcəyə funksiya yazılacaq.
    Bu plan gələcəkdəki plandır.
    */
}

int he = 0;
int yox = 0;

string hedata = "hedata.txt";
string yoxdata = "yoxdata.txt";

if (File.Exists(hedata) && File.Exists(yoxdata) &&
    new FileInfo(hedata).Length > 0 && new FileInfo(yoxdata).Length > 0)
{
    he = File.ReadAllLines(hedata).Length;
    yox = File.ReadAllLines(yoxdata).Length;
}

void anketnetice()
{
    int cem = he + yox;
    Console.WriteLine("----------------------");
    if (cem > 0)
    {
        double heFaiz = (double)he / cem * 100;
        double yoxFaiz = (double)yox / cem * 100;

        Console.WriteLine("He: " + Math.Round(heFaiz, 2) + " %");
        Console.WriteLine("Yox: " + Math.Round(yoxFaiz, 2) + " %");
    }
    else
    {
        Console.WriteLine("Ses yoxdur.");
    }
}

//------------------------------------------------------------------
string girisadminad = "";
string girisadminparol = "";

while(girisadminad.Length == 0 || girisadminparol.Length == 0){
    int giriscehd = 3;
    Console.WriteLine("Admin hesabiniza giris edin!");
    while (giriscehd > 0)
    {
        Console.Write("Admin adiniz: ");
        girisadminad = Console.ReadLine();
        if (girisadminad != adminisim)
        {
            giriscehd--;
            Console.WriteLine("Sehv AD! Tekrar sinayin. Qalan Cehd: " + giriscehd);
        }
        else
        {
            break;
        }
    }
    if (giriscehd == 0)
    {
        Console.WriteLine("Cehd sansiniz qalmadi!");
        return;
    }

    giriscehd = 3;

    while (giriscehd > 0)
    {
        Console.Write("Admin sifreniz: ");
        girisadminparol = Console.ReadLine();
        if (girisadminparol != adminparol)
        {
            giriscehd--;
            Console.WriteLine("Sehv PAROL! Tekrar sinayin. Qalan Cehd: " + giriscehd);
        }
        else
        {
            break;
        }
    }
    if (giriscehd == 0)
    {
        Console.WriteLine("Cehd sansiniz qalmadi!");
        return;
    }
}
if (girisadminad.Length != 0 && girisadminparol.Length != 0)
{
    do
    {
        Console.WriteLine("------------------");
        Console.WriteLine("1-İsci Menu \n2-Anket Menu \n3-Cikis");
        Console.WriteLine("-------------------");
        Console.Write("ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (id == 1)
        {
            iscimenu();
        }
        else if (id == 2)
        {
            anketmenu();
        }
        else
        {
            break;
        }


    } while (true);
}

void iscimenu()
{
    while (true)
    {
    Console.WriteLine("-----------------");
    Console.WriteLine("1-İsciler \n2-İsci Elave Et \n3-İsci Sil \n4-Esas Menu");
    Console.Write("ID: ");
    int iscimenuid = Convert.ToInt32(Console.ReadLine());
        if (iscimenuid == 1)
        {
            iscilerebax();
        }
        else if (iscimenuid == 2)
        {
            iscielaveet();
        }
        else if (iscimenuid == 3)
        {
            iscisil();
        }
        else if (iscimenuid == 4)
        {
            break;
        }
        else
        {
            Console.WriteLine("Sehv ID!");
        } 
    }

}

void anketmenu()
{
    while (true)
    {
    Console.WriteLine("-----------------");
    Console.WriteLine("1-Anketler \n2-Anket Elave Et \n3-Anker Sil \n4-Anket Gonder \n5-Anket Netice \n6-Esas Menu");
    Console.Write("ID: ");
    int anketmenuid = Convert.ToInt32(Console.ReadLine());
        if (anketmenuid == 1)
        {
            anketbax();
        }
        else if (anketmenuid == 2)
        {
            anketelaveet();
        }
        else if (anketmenuid == 3)
        {
            anketsil();
        }
        else if (anketmenuid == 4)
        {
            Console.WriteLine("Hazir deyil.");
        }
        else if (anketmenuid == 5)
        {
            anketnetice();
        }
        else if (anketmenuid == 6)
        {
            break;
        }
        else
        {
            Console.WriteLine("Sehv ID!");
        }
    }



}
