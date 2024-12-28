using System;

namespace App.BusinessObject
{
    /// <summary>
    /// Classe de mappage sur la table ArchiveVente
    /// </summary>
    public class ArchiveVenteBO
    {
        private int idArch;

        /// <summary>
        /// Id de la ventte archivée
        /// </summary>
        public int IdArch
        {
            get { return idArch; }
            set { idArch = value; }
        }

        private DateTime dateVente;

        /// <summary>
        /// Date de la vente
        /// </summary>
        public DateTime DateVente
        {
            get { return dateVente; }
            set { dateVente = value; }
        }

        private string heureVente;

        /// <summary>
        /// Heure de la vente
        /// </summary>
        public string HeureVente
        {
            get { return heureVente; }
            set { heureVente = value; }
        }

        private int idArt;

        /// <summary>
        /// Id de l'article
        /// </summary>
        public int IdArt
        {
            get { return idArt; }
            set { idArt = value; }
        }

        private string libelleArt;

        /// <summary>
        /// Libellé de l'article
        /// </summary>
        public string LibelleArt
        {
            get { return libelleArt; }
            set { libelleArt = value; }
        }

        private string libelleCat;

        /// <summary>
        /// Libelle de catégorie
        /// </summary>
        public string LibelleCat
        {
            get { return libelleCat; }
            set { libelleCat = value; }
        }

        private int prixVente;

        /// <summary>
        /// Prix de vente de l'article
        /// </summary>
        public int PrixVente
        {
            get { return prixVente; }
            set 
            { 
                prixVente = value;

                if (prixVente <= 0)
                {
                    throw new AppValidationException("Impossible de valider un prix de vente inférieur ou égal à 0 !");
                }
            }
        }

        private int prixAchat;

        /// <summary>
        /// Prix d'achat du produit
        /// </summary>
        public int PrixAchat
        {
            get { return prixAchat; }
            set 
            { 
                prixAchat = value; 

                if(prixAchat <= 0)
                {
                    throw new AppValidationException("Impossible de valider un prix d'achat inférieur ou égal à 0 !");
                }
            }
        }

        private int qteVente;

        /// <summary>
        /// Quantité de la vente
        /// </summary>
        public int QteVente
        {
            get { return qteVente; }
            set 
            { 
                qteVente = value;

                if (qteVente <= 0)
                {
                    throw new AppValidationException("Impossible de valider une quantité inférieure ou égale à 0");
                }
            }
        }

        private int totalVente;

        /// <summary>
        /// Total de la vente
        /// </summary>
        public int TotalVente
        {
            get { return totalVente; }
            set { totalVente = value; }
        }
       
        private int idUser;

        /// <summary>
        /// Id de l'utilisateur
        /// </summary>
        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

        private string numeroVente;

        public string NumeroVente
        {
            get { return numeroVente; }
            set { numeroVente = value; }
        }

        private string typeVente;

        public string TypeVente
        {
            get { return typeVente; }
            set { typeVente = value; }
        }

        private int remisePourcentage;

        public int RemisePourcentage
        {
            get { return remisePourcentage; }
            set { remisePourcentage = value; }
        }

        private int remiseMontant;

        public int RemiseMontant
        {
            get { return remiseMontant; }
            set { remiseMontant = value; }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public ArchiveVenteBO()
        {

        }
    }

    /// <summary>
    /// Représente une liste d'Archive de vente
    /// </summary>
    public class ArchiveVenteBOListView : BusinessObjectListView<ArchiveVenteBO>
    {

    }
}
