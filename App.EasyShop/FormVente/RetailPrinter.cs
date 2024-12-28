using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using App.BusinessObject;


namespace App.EasyShop.FormVente
{
    public class RetailPrinter
    {
        private static string retail = "";
        private static string numeroFacture = "";
        private static int total = 0;
        private static int sousTotal = 0;
        private static int remisePourcentage = 0;
        private static int remiseMontant = 0;

        /*private static const int itemSize = 0;
        private static const int quantitySize = 0;
        private static const int totalSize = 0;*/

        /// <summary>
        /// Fonction qui insert l'entete de la facture
        /// </summary>
        /// <param name="nf">Numero de facture</param>
        public static void InsertHeader(string nf)
        {
            numeroFacture = nf;
            retail = "\x1b\x1d\x61\x1"; //Center Alignment - Refer to Pg. 3-29            
            /*retail = retail + "\x5B" + "If loaded.. Logo1 goes here" + "\x5D\n";
            retail = retail + "\x1B\x1C\x70\x1\x0";          //Stored Logo Printing - Refer to Pg. 3-38*/
            /*retail = retail + "\x1b\x69\x1\x1";
            retail = retail + "KINA KER\n";
            retail = retail + "\x1b\x69\x0\x0";*/
            retail = retail + "Rue Ben Apaloo, Face Goethe Institut\n";
            retail = retail + "BP : 864 Lome - TOGO\n";
            retail = retail + "Telephone : +228 22424195\n";
            retail = retail + "Email : kina_ker@yahoo.fr\n\n";
            retail = retail + "\x1b\x1d\x61\x0";             //Left Alignment - Refer to Pg. 3-29
            retail = retail + "\x1b\x44\x2\x10\x22\x0";      //Setting Horizontal Tab - Pg. 3-27
            retail = retail + "Date:" + DateTime.Today.ToShortDateString() + "\x9" + "  Facture:" + numeroFacture + "\n";      //Moving Horizontal Tab - Pg. 3-26
            retail = retail + "------------------------------------------------ \n";
        }

        /// <summary>
        /// Fonction qui insert le corp de la facture
        /// </summary>
        /// <param name="ventes">Liste des ventes effectuees</param>
        public static void InsertBody(List<ArchiveVenteBO> ventes)
        {
            sousTotal = ComputeSousTotal(ventes);
            remisePourcentage = ComputeRemisePourcentage(ventes);
            remiseMontant = ComputeRemiseMontant(ventes);
            total = ComputeTotal();

            retail = retail + "\x1b\x45";                    //Select Emphasized Printing - Pg. 3-14
            retail = retail + "Designation\n";
            retail = retail + "\x1b\x46";              //Cancel Emphasized Printing - Pg. 3-14            
            //On recuperela liste des ventes
            string tmpLibelleArt = string.Empty;
            foreach(ArchiveVenteBO av in ventes)
            {                
                if (av.LibelleArt.Length > 20)
                {
                    tmpLibelleArt = av.LibelleArt.Substring(0, 20).Trim();
                    retail = retail + (av.LibelleArt.Substring(0, 20).Trim() + "\x9" + GetSpaceToAddForItem(6, av.QteVente.ToString()) + av.QteVente + GetSpaceToAddForItem(6, av.PrixVente.ToString()) + av.PrixVente) + "\n";
                }
                else
                {
                    tmpLibelleArt = av.LibelleArt;
                    int tmpNumberOfSpace = 20 - tmpLibelleArt.Length;
                    for (int i = 0; i < tmpNumberOfSpace; i++)
                    {
                        tmpLibelleArt += " ";
                    }
                    retail = retail + (tmpLibelleArt + "\x9" + GetSpaceToAddForItem(6, av.QteVente.ToString()) + av.QteVente + GetSpaceToAddForItem(6, av.PrixVente.ToString()) + av.PrixVente) + "\n";                    
                }                
            }
            retail = retail + "\n";
            retail = retail + "Sous-Total " + "\x9" + " " + "\x9" + "        " + sousTotal + "\n";            
            retail = retail + "Remise % " + "\x9" + " " + "\x9" + "        " + remisePourcentage + "\n";            
            retail = retail + "Remise CFA " + "\x9" + " " + "\x9" + "        " + remiseMontant + "\n";
            retail = retail + "------------------------------------------------ \n";            
            retail = retail + "Total (FCFA) " + "\x6" + " " + "\x9" + "\x1b\x69\x1\x1" + "         " + total + "\n";    //Character Expansion - Pg. 3-10
            retail = retail + "\x1b\x69\x0\x0";                                                        //Cancel Expansion - Pg. 3-10
            retail = retail + "------------------------------------------------ \n\n\n";
        }

        /// <summary>
        /// Fonction qui insert le pied de page de la facture
        /// </summary>
        public static void InsertFooter()
        {
            retail = retail + "\x1b\x1d\x61\x1";             //Center Alignment - Refer to Pg. 3-29
            retail = retail + "Kina Ker vous remercie ! Au revoir, Good bye.\n";             //Barcode - Pg. 3-39 - 3-40
            retail = retail + "\x1b\x64\x02";                                            //Cut  - Pg. 3-41
            retail = retail + "\x7";                                                    //Open Cash Drawer
        }

        /// <summary>
        /// Fonction qui renvoie la facture etablie
        /// </summary>
        /// <returns>Renvoi une facture</returns>
        public static string GetRetail()
        {
            return retail;
        }

        /// <summary>
        /// Fonction qui calcul le Total general
        /// </summary>
        /// <returns>Renvoi le total general</returns>
        private static int ComputeTotal()
        {
            return sousTotal - (remisePourcentage + remiseMontant);
        }

        /// <summary>
        /// Fonction qui calcul le sous total
        /// </summary>
        /// <param name="ventes">Liste des ventes effectuees</param>
        /// <returns>Renvoi le sous total</returns>
        private static int ComputeSousTotal(List<ArchiveVenteBO> ventes)
        {
            int sousTotal = 0;
            foreach(ArchiveVenteBO av in ventes)
            {
                sousTotal += (av.PrixVente * av.QteVente);
            }
            return sousTotal;
        }

        /// <summary>
        /// Fonction qui renvoi la remise en pourcentage
        /// </summary>
        /// <param name="ventes">Liste des ventes effectuees</param>
        /// <returns>Renvoi la remise en pourcentage</returns>
        private static int ComputeRemisePourcentage(List<ArchiveVenteBO> ventes)
        {
            int remisePourcentage = 0;
            foreach (ArchiveVenteBO av in ventes)
            {
                remisePourcentage += ((av.PrixVente * av.QteVente) * av.RemisePourcentage) / 100;
            }
            return remisePourcentage;
        }

        /// <summary>
        /// Fonction qui renvoi la remise en montant
        /// </summary>
        /// <param name="ventes">Liste des ventes effectuees</param>
        /// <returns>Renvoi la remise en montant</returns>
        private static int ComputeRemiseMontant(List<ArchiveVenteBO> ventes)
        {
            int remiseMontant = 0;
            foreach(ArchiveVenteBO av in ventes)
            {
                remiseMontant += av.RemiseMontant;
            }
            return remiseMontant;
        }

        private static string GetSpaceToAddForItem(int defaultNumberOfSpace, string itemToPrint)
        {
            string numberOfSpace = "    ";            
            int numberOfSpaceToAdd = defaultNumberOfSpace - int.Parse(itemToPrint.ToString());
            for (int i = 0; i < numberOfSpaceToAdd; i++)
            {
                numberOfSpace += string.Empty;
            }
            return numberOfSpace;
        }
    }
}
