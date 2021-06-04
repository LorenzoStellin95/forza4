using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace connect4
{
    public partial class Form1 : Form
    {
        private Rectangle[] ColonneTabellaDiGioco; //Collonne della tabella di gioco
        private int[,] tabellaDiGioco; //Dimensione della tabella di gioco
        private int turno;  //turni per cambiare giocatore
        int VittorieGiocatore1 = 0;
        int VittorieGiocatore2 = 0;
        public Form1()
        {
            InitializeComponent();
            this.ColonneTabellaDiGioco = new Rectangle[7]; 
            this.tabellaDiGioco = new int[6, 7];
            this.turno = 1;
            contatoreVittorie.Visible = false;
        }

        private void connect4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, 24, 24, 340, 300); //Disegno la mia tabella di gioco nel form
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++) //Ciclo per fare gli spazi bianchi, dove andranno inseriti i cerchi colorati
                {
                    if (i == 0)
                    {
                        this.ColonneTabellaDiGioco[j] = new Rectangle(32 + 48 * j, 24, 32, 300);
                    }
                    e.Graphics.FillEllipse(Brushes.White, 32 + 48 * j, 32 + 48 * i, 32, 32);    //Creo gli spazi bianchi
                }
            }
        }

        private void connect4_MouseClick(object sender, MouseEventArgs e)
        {
            int indiceColonne = this.numeroColonna(e.Location); 
            if (indiceColonne != -1)
            {
                int indiceRiga = this.rigaVuota(indiceColonne);
                if (indiceRiga != -1)
                {
                    this.tabellaDiGioco[indiceRiga, indiceColonne] = this.turno;//se il contatore è uguale ad 1 il cerchio sarà rosso
                    if (this.turno == 1)
                    {
                        Graphics g = this.CreateGraphics(); //Creo un cerchio rosso nello spazio bianco selezionato
                        g.FillEllipse(Brushes.Red, 32 + 48 * indiceColonne, 32 + 48 * indiceRiga, 32, 32);
                    }
                    else if (this.turno == 2)//se il contatore è uguale ad 1 il cerchio sarà giallo
                    {
                        Graphics g = this.CreateGraphics(); //Creo un cerchio giallo nello spazio bianco selezionato
                        g.FillEllipse(Brushes.Yellow, 32 + 48 * indiceColonne, 32 + 48 * indiceRiga, 32, 32); 
                    }

                    int vincitore = this.controlloVittoria(this.turno); //Assegno la vittoria al giocatore che mette in fila 4 cerchi uguali
                    if (vincitore != -1) 
                    {
                        string giocatore = (vincitore == 1) ? usernameGiocatore1.Text : usernameGiocatore2.Text;
                        MessageBox.Show("Congratulazioni! Vince "+ giocatore + " " + "Premi Rinizia per Giocare" );
                        if (giocatore == usernameGiocatore1.Text)
                        {
                            VittorieGiocatore1 = VittorieGiocatore1 + 1;
                        }
                        else
                        {
                            VittorieGiocatore2 = VittorieGiocatore2 + 1;
                        }

                    }

                    if (this.turno == 1) //scambio il valore dei turni per far alternare un cerchio rosso ad un cerchio giallo
                    {
                        this.turno = 2;
                    }
                    else
                    {
                        this.turno = 1;
                    }
                }
            }
        }

        private int controlloVittoria(int playerTocheck) 
        {
            //Controllo se ci sono 4 pedine uguali nella stessa colonna
            for (int riga = 0; riga < this.tabellaDiGioco.GetLength(0) - 3; riga++)
            {
                for (int colonna = 0; colonna < this.tabellaDiGioco.GetLength(1); colonna++)
                {
                    if (this.AllNumbersEqual(playerTocheck, this.tabellaDiGioco[riga, colonna], this.tabellaDiGioco[riga + 1, colonna], this.tabellaDiGioco[riga + 2, colonna], this.tabellaDiGioco[riga + 3, colonna]))
                    {
                        return playerTocheck; 
                    }
                }
            }

            //Controllo se ci sono 4 pedine uguali nella stessa riga
            for (int riga = 0; riga < this.tabellaDiGioco.GetLength(0); riga++)
            {
                for (int colonna = 0; colonna < this.tabellaDiGioco.GetLength(1) - 3; colonna++)
                {
                    if (this.AllNumbersEqual(playerTocheck, this.tabellaDiGioco[riga, colonna], this.tabellaDiGioco[riga, colonna + 1], this.tabellaDiGioco[riga, colonna + 2], this.tabellaDiGioco[riga, colonna + 3]))
                    {
                        return playerTocheck;
                    }
                }
            }

            //Controllo se ci sono 4 pedine uguali messe in diagonale verso sinistra
            for (int riga = 0; riga < this.tabellaDiGioco.GetLength(0) - 3; riga++)
            {
                for (int colonna = 0; colonna < this.tabellaDiGioco.GetLength(1) - 3; colonna++)
                {
                    if (this.AllNumbersEqual(playerTocheck, this.tabellaDiGioco[riga, colonna], this.tabellaDiGioco[riga + 1, colonna + 1], this.tabellaDiGioco[riga + 2, colonna + 2], this.tabellaDiGioco[riga + 3, colonna + 3]))
                    {
                        return playerTocheck;
                    }
                }
            }

            //Controllo se ci sono 4 pedine uguali messe in diagonale verso destra

            for (int riga = 0; riga < this.tabellaDiGioco.GetLength(0)- 3; riga++)
            {
                for (int colonna = 3; colonna < this.tabellaDiGioco.GetLength(1); colonna++)
                {
                    if (this.AllNumbersEqual(playerTocheck, this.tabellaDiGioco[riga, colonna], this.tabellaDiGioco[riga + 1, colonna - 1], this.tabellaDiGioco[riga + 2, colonna - 2], this.tabellaDiGioco[riga + 3, colonna - 3]))
                    {
                        return playerTocheck;
                    }
                }
            }

            return -1;
        }

        private bool AllNumbersEqual(int toCheck, params int[] numbers) //controllo se tutti i cerchi sono dello stesso colore
        {
            foreach (int num in numbers)
            {
                if (num != toCheck)
                {
                    return false;
                }
                
            }
            return true;
        }

        private int numeroColonna(Point mouse)  //Funzione per conoscere la posizione del mouse all'interno dello spazio di gioco
        {
            for (int i = 0; i < this.ColonneTabellaDiGioco.Length; i++)
            {
                if ((mouse.X >= this.ColonneTabellaDiGioco[i].X) && (mouse.Y >= this.ColonneTabellaDiGioco[i].Y))
                {
                    if ((mouse.X <= this.ColonneTabellaDiGioco[i].X + this.ColonneTabellaDiGioco[i].Width) && (mouse.Y <= this.ColonneTabellaDiGioco[i].Y + this.ColonneTabellaDiGioco[i].Height))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private int rigaVuota(int col) //Controllo per mettere i cerchi colorati solo negli spazi bianchi, aventi o il bordo sotto o un'altro cerchio sotto
        {
            try
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (this.tabellaDiGioco[i, col] == 0)
                        return i;
                }
                return -1;
            }
            catch
            {
                return -1;
            }
        }

        private void iNIZIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameGiocatore1.Text))
            {
                MessageBox.Show("Errore inserisci nome giocatore");
            }
            else if ((string.IsNullOrEmpty(usernameGiocatore2.Text)))
            {
                MessageBox.Show("Errore inserisci nome giocatore");
            }
            else //Modifico il nome giocatore e rifaccio vedere i tasti per giocare
            {
                nomeGiocatore1.Visible = false;
                nomeGiocatore2.Visible = false;
                usernameGiocatore1.Visible = false;
                usernameGiocatore2.Visible = false;
                contatoreVittorie.Visible = true;
                contatoreVittorie.Text = usernameGiocatore1.Text + ":" + " " + VittorieGiocatore1 + " " + "-" + " " + usernameGiocatore2.Text + ":" + " " + VittorieGiocatore2;
            }
        }

        private void rINIZIALAPARTITAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Refresh(); //Cancello le pedine dalla tabella e la ricreo con il punteggio aggiornato
            turno = 1;
            this.ColonneTabellaDiGioco = new Rectangle[7]; 
            this.tabellaDiGioco = new int[6, 7];
            MessageBox.Show("Ora premi il tasto Inizia");
        }

        private void eSCIESALVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Funzione per salvare i nomi dei giocatori con le vittorie della sessione corrente.
            string file = @"giocatoriforza4.txt";
            string percorso = AppDomain.CurrentDomain.BaseDirectory + file;
            StreamWriter punteggi = new StreamWriter(percorso, true);

            punteggi.WriteLine("Utente: " + usernameGiocatore1.Text);
            punteggi.WriteLine("Vittorie: " + VittorieGiocatore1);
            punteggi.WriteLine("Utente: " + usernameGiocatore2.Text);
            punteggi.WriteLine("Vittorie: " + VittorieGiocatore2);
            punteggi.Close();
            MessageBox.Show("Punteggio salvato con successo");
            this.Close();
        }

        private void temaBianco_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            contatoreVittorie.ForeColor = Color.Black;
            nomeGiocatore1.ForeColor = Color.Black;
            nomeGiocatore2.ForeColor = Color.Black;
            colG1.ForeColor = Color.Black;
            colG2.ForeColor = Color.Black;
            temaLabel.ForeColor = Color.Black;
        }

        private void temaScuro_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            contatoreVittorie.ForeColor = Color.White;
            nomeGiocatore1.ForeColor = Color.White;
            nomeGiocatore2.ForeColor = Color.White;
            colG1.ForeColor = Color.White;
            colG2.ForeColor = Color.White;
            temaLabel.ForeColor = Color.White;
        }
    }
}
