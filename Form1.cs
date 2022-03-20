// Staffan Leandersson, Sleandersson@yahoo.se, L0002B, Uppgift 1 WF-variant
namespace Uppgift1WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        InitializeComponent();
        }
            
        void btnCalculate_Click(object sender, EventArgs e)
        {
        //St�dar resultatboxen, arrar val�rerna, parsar textboxarna till int:ar, r�knar ut och l�gger var.diff i en label och anv�nder f�r utr�kning.
        //M�rker att jag har sv�rt att "lita" p� att �,� och �:n ska l�sas ordentligt och deklarerar ibland med m�rkliga namn. Tror det �r VBA/Excel-skada
        //fr�n jobbet.
        rTBResultat.Text = "";
        string[] v�xel = { "Tv�hundring(ar)", "Hundring(ar)", "Femtiolapp(ar)", "Tjugolapp(ar)", "Tiokron(a/or)", "Femkron(a/or)", "Enkron(a/or)" };
        int total = Int32.Parse(tbAttBetala.Text);
        int frKund = Int32.Parse(tbFrKund.Text); //Skulle vilja l�gga n�gon IsNumeric koll men f�r inte till det.
        int diff = frKund - total;
        lblV�xel.Text = diff.ToString() + " krona(or)";

            //If sats, kollar om man har f�tt f�r lite pengar och varnar f�r det. Annars b�rjar utr�kningen.
            if (diff < 0)
            {
            MessageBox.Show("Du har f�tt f�r lite pengar! �tg�rda och prova igen.");
            }
            else
            {
            int r�knare = 200;  //R�knare som anv�nder st�rsta val�ren som startv�rde
            int i = 0;          //Index-r�knare f�r att vandra i arrayen "v�xel", startar p� "Tv�hundring(ar)".
 
                do    //Do-While diff(v�xelsumman) �r st�rre �n 0. R�knar av v�xelsumman med best�mda val�rer som l�ggs i "r�knare".
                {     //Val�ren i r�knare dras av fr�n diff och var.antal + 1 vid varje iteration.
                int antal = 0;  //R�knare f�r antalet sedlar/mynt.             
                    do
                    {
                        if (diff >= r�knare)
                        {                          
                        int nyDiff = diff - r�knare;
                        antal++;
                        diff = nyDiff;
                        }
                    } while (diff >= r�knare);   //N�r var.r�knare inte l�ngre f�r plats i var.diff hoppar vi ur do-while:n.

                    //Om var.antal �r st�rre �n noll och isf. skriver ut ett resultat i richTextBox.
                    if (antal >0)
                    rTBResultat.AppendText(" " +  antal.ToString() + " " + v�xel[i] + "\n");
                    else
                    antal = 0; //avslutar if-satsen med n�got harml�st som att nolla var.antal

                    //Om r�knare delat med 2 blir 100,50,10 eller 5. Dela r�knaren med tv�. Om r�knare blir 25 subtrahera 30. 
                    if (r�knare / 2 == 100 || r�knare / 2 == 50 || r�knare / 2 == 10 || r�knare / 2 == 5)
                    {
                    r�knare = r�knare / 2;
                    }
                    else if (r�knare / 2 == 25)
                    {
                    r�knare = r�knare - 30;
                    }
                    else if (diff > 0) //Om inget av ovanst�ende st�mmer �r diff mindre �n fem och kan skrivas ut som enkrona(or).
                    {
                        rTBResultat.AppendText(" " + diff.ToString() + " " + v�xel[6]);
                    int nyDiff = diff - r�knare;
                    diff = nyDiff;
                    }

                i++; //stegar till n�sta val�r i arrayen.

                } while (diff > 0);
            } //slut p� if sats
        } //slut p� btnClick-event

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}