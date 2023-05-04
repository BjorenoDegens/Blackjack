using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Card
    { 
        string nameCard;
        string iconCard;
        int valueCard; 
        public Card(int i, int j)
        {

                switch (i)
                {
                    case 0:
                        iconCard = "Klaver";
                        break;
                    case 1:
                        iconCard = "Ruit";
                        break;
                    case 2:
                        iconCard = "Harte";
                        break;
                    case 3:
                        iconCard = "Schoppen";
                        break;
                }
   

                switch (j)
                {
                    case 0:
                        nameCard = "2";
                        break;
                    case 1:
                        nameCard = "3";
                        break;
                    case 2:
                        nameCard = "4";
                        break;
                    case 3:
                        nameCard = "5";
                        break;
                    case 4:
                        nameCard = "6";
                        break;
                    case 5:
                        nameCard = "7";
                        break;
                    case 6:
                        nameCard = "8";
                        break;
                    case 7:
                        nameCard = "9";
                        break;
                    case 8:
                        nameCard = "10";
                        break;
                    case 9:
                        nameCard = "Heer";
                        break;
                    case 10:
                        nameCard = "Vrouw";
                        break;
                    case 11:
                        nameCard = "Boer";
                        break;
                    case 12:
                        nameCard = "Aas";
                        break;
                }

                switch (nameCard)
                {
                    case "2":
                        valueCard = 2;
                        break;
                    case "3":
                        valueCard = 3;
                        break;
                    case "4":
                        valueCard = 4;
                        break;
                    case "5":
                        valueCard = 5;
                        break;
                    case "6":
                        valueCard = 6;
                        break;
                    case "7":
                        valueCard = 7;
                        break;
                    case "8":
                        valueCard = 8;
                        break;
                    case "9":
                        valueCard = 9;
                        break;
                    case "10":
                        valueCard = 10;
                        break;
                    case "Heer":
                        valueCard = 10;
                        break;
                    case "Vrouw":
                        valueCard = 10;
                        break;
                    case "Boer":
                        valueCard = 10;
                        break;
                    case "Aas":
                        valueCard = 11;
                        break;
                }





        }
    }
}
