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
        //Städar resultatboxen, arrar valörerna, parsar textboxarna till int:ar, räknar ut och lägger var.diff i en label och använder för uträkning.
        //Märker att jag har svårt att "lita" på att å,ä och ö:n ska läsas ordentligt och deklarerar ibland med märkliga namn. Tror det är VBA/Excel-skada
        //från jobbet.
        rTBResultat.Text = "";
        string[] växel = { "Tvåhundring(ar)", "Hundring(ar)", "Femtiolapp(ar)", "Tjugolapp(ar)", "Tiokron(a/or)", "Femkron(a/or)", "Enkron(a/or)" };
        int total = Int32.Parse(tbAttBetala.Text);
        int frKund = Int32.Parse(tbFrKund.Text); //Skulle vilja lägga någon IsNumeric koll men får inte till det.
        int diff = frKund - total;
        lblVäxel.Text = diff.ToString() + " krona(or)";

            //If sats, kollar om man har fått för lite pengar och varnar för det. Annars börjar uträkningen.
            if (diff < 0)
            {
            MessageBox.Show("Du har fått för lite pengar! Åtgärda och prova igen.");
            }
            else
            {
            int räknare = 200;  //Räknare som använder största valören som startvärde
            int i = 0;          //Index-räknare för att vandra i arrayen "växel", startar på "Tvåhundring(ar)".
 
                do    //Do-While diff(växelsumman) är större än 0. Räknar av växelsumman med bestämda valörer som läggs i "räknare".
                {     //Valören i räknare dras av från diff och var.antal + 1 vid varje iteration.
                int antal = 0;  //Räknare för antalet sedlar/mynt.             
                    do
                    {
                        if (diff >= räknare)
                        {                          
                        int nyDiff = diff - räknare;
                        antal++;
                        diff = nyDiff;
                        }
                    } while (diff >= räknare);   //När var.räknare inte längre får plats i var.diff hoppar vi ur do-while:n.

                    //Om var.antal är större än noll och isf. skriver ut ett resultat i richTextBox.
                    if (antal >0)
                    rTBResultat.AppendText(" " +  antal.ToString() + " " + växel[i] + "\n");
                    else
                    antal = 0; //avslutar if-satsen med något harmlöst som att nolla var.antal

                    //Om räknare delat med 2 blir 100,50,10 eller 5. Dela räknaren med två. Om räknare blir 25 subtrahera 30. 
                    if (räknare / 2 == 100 || räknare / 2 == 50 || räknare / 2 == 10 || räknare / 2 == 5)
                    {
                    räknare = räknare / 2;
                    }
                    else if (räknare / 2 == 25)
                    {
                    räknare = räknare - 30;
                    }
                    else if (diff > 0) //Om inget av ovanstående stämmer är diff mindre än fem och kan skrivas ut som enkrona(or).
                    {
                        rTBResultat.AppendText(" " + diff.ToString() + " " + växel[6]);
                    int nyDiff = diff - räknare;
                    diff = nyDiff;
                    }

                i++; //stegar till nästa valör i arrayen.

                } while (diff > 0);
            } //slut på if sats
        } //slut på btnClick-event

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}