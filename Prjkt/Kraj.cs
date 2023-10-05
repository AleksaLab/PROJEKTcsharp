using System;
using System.Threading;

public class Kraj
{
    public string nazwa;
    public int ekonomia;
    public int wojsko;
    public int ludnosc;
    public int ekologia;
    public int satysfakcja;

    public Kraj(string nazwa, int ekonomia = 50, int wojsko = 50, int ludnosc = 50, int ekologia = 50, int satysfakcja = 50)
    {
        this.nazwa = nazwa;
        this.ekonomia = ekonomia;
        this.wojsko = wojsko;
        this.ludnosc = ludnosc;
        this.ekologia = ekologia;
        this.satysfakcja = satysfakcja;
    }

    public void Checker()
    {
        if (ekonomia <= 0)
        {
            Console.WriteLine("Jesteś w wielkim jak Piwniczak sasinowym długu!!!!!!!! ");
        }

        if (wojsko <= 0)
        {
            Console.WriteLine("Twoje wojsko jest zbyt słabe i Kim Jong Un podarował ci uzbrojoną handmade atomic bomb Nagranie ze zdarzenia *mocne*   https://drive.google.com/file/d/17GAollhLRgM22b8HepU3msyuvP6AW8ja/view?usp=sharing");
        }

        if (ludnosc <= 0)
        {
            Console.WriteLine("Byłeś mega samotny i pociąłeś się mydłem w płynie a potem skoczyłeś z dywanu.   https://drive.google.com/file/d/10VleoghoIasBFFJCI836n7PloeMiWynK/view?usp=sharing");
        }

        if (ekologia <= 0)
        {
            Console.WriteLine("Greta Thunberg sie wkurzyła i nie żyjesz xd   https://drive.google.com/file/d/10VleoghoIasBFFJCI836n7PloeMiWynK/view?usp=sharing");
        }

        if (satysfakcja <= 0)
        {
            Console.WriteLine("Ludność się zbuntowała bo jesteś słabym pszyfudcom i zostałeś ukrzyżowany za swoje grzechy   https://drive.google.com/file/d/13c11Xy4Sv8GjKR3pyKSG_V2-EwFBzjHW/view?usp=sharing");
        }


    }



    public override string ToString()
    {
        return $"Ekonomia: {ekonomia}\nWojsko: {wojsko}\nLudnosc: {ludnosc}\nEkologia: {ekologia}\nSatysfakcja: {satysfakcja}";
    }
}