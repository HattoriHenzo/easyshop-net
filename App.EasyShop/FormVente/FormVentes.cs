using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using App.Reporting;
using App.BusinessObject;
using App.BusinessLogic;
using App.Tools;

namespace App.EasyShop.FormVente
{
    public partial class FormVentes : Form
    {
        //Objet de type article
        private ArchiveVenteBO currentArticle = null;

        private ArticleBO selectedArticle = null;

        //Liste des articles achetés
        private ArchiveVenteBOListView listeArticle = null;

        private ArticleBLL articleBLL;
        private ArchiveVenteBLL archiveVenteBLL;
        private VenteBLL venteBLL;

        private int lastInsertedRow = 0;

        private bool venteValide = false;

        private string articleSelected = string.Empty;

        private string numeroVente = string.Empty;

        /// <summary>
        /// Article sélectionné lors de la recherche
        /// </summary>
        public string ArticleSelected
        {
            get { return articleSelected; }
            set { articleSelected = value; }
        }

        public FormVentes()
        {
            articleBLL = new ArticleBLL();
            archiveVenteBLL = new ArchiveVenteBLL();
            venteBLL = new VenteBLL();
            InitializeComponent();
        }

        private void FormVentes_Load(object sender, EventArgs e)
        {
            this.currentArticle = new ArchiveVenteBO();
            this.cbxArticle.DataSource = articleBLL.GetArticlesWithPrice(string.Empty);
            this.cbxArticle.ValueMember = "IdArt";
            this.cbxArticle.DisplayMember = "LibelleArt";

            this.listeArticle = new ArchiveVenteBOListView();            

            //On effectue une liaison entre la liste et le datagridview
            this.archiveVenteBOBindingSource.DataSource = this.listeArticle;
            this.gridArticlesAchetes.DataSource = this.archiveVenteBOBindingSource;

            //A chaque ouverture de la fenetre on genere un nouveau numero de facture ou de vente
            numeroVente = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString()
                + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            this.txtNumeroVente.Text = numeroVente;

            this.cbxTypeVente.SelectedIndex = 0;
            this.cbxRemisePourcentage.SelectedIndex = 0;
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRech_Click(object sender, EventArgs e)
        {
            //Affichage de l'article recherché
            
            
        }                   

        private void gridArticles_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void gridArticlesAchetes_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridArticlesAchetes.RowCount != 0)
            {
                //On récupère l'article courant
                this.currentArticle = (ArchiveVenteBO)this.gridArticlesAchetes.CurrentRow.DataBoundItem;
                this.cbxArticle.Text = this.currentArticle.LibelleArt; 
              
                //On affiche le sous-total                
                this.txtSousTotal.Value = (archiveVenteBLL.GetMontantTotal(this.currentArticle) - (archiveVenteBLL.GetRemisePourcentage(this.currentArticle) + this.currentArticle.RemiseMontant)).ToString();
            }
        }

       
        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (this.gridArticlesAchetes.RowCount != 0)
            {
                if (AppMessage.Question("Voulez vous vraiment annuler cette ligne du panier ?") != DialogResult.No)
                {
                    int qteAchat = this.currentArticle.QteVente;
                    string libelleArt = this.currentArticle.LibelleArt;

                    if (this.listeArticle.Remove(this.currentArticle) == true)
                    {
                        //On se replace sur l'article
                        this.cbxArticle.Text = libelleArt;

                        //On actualise temporairement la quantité en stock
                        ((ArticleBO)this.cbxArticle.SelectedItem).QteStockArt += qteAchat;
                        this.txtQteStock.Text = ((ArticleBO)this.cbxArticle.SelectedItem).QteStockArt.ToString();                        

                        this.gridArticlesAchetes.Refresh();
                        
                        //On affiche le sous-total
                        this.txtSousTotal.Value = (archiveVenteBLL.GetMontantTotal(this.currentArticle) - (archiveVenteBLL.GetRemisePourcentage(this.currentArticle) + this.currentArticle.RemiseMontant)).ToString();

                        //On affiche le total
                        this.txtTotalAchat.Value = this.DisplayTotalAchat().ToString();

                        //On renseigne l'utilisateur sur la disponibilité de l'article
                        this.DisponibiliteArticle(int.Parse(this.txtQteStock.Text), int.Parse(this.txtSeuil.Text));

                        AppMessage.Success("La ligne sélectionnée a été annulée !");

                        //Si le datagridview est vide, on initialise les totaux à 0
                        if (this.gridArticlesAchetes.RowCount == 0)
                        {
                            this.txtSousTotal.Value = "0";
                            this.txtTotalAchat.Value = "0";
                        }
                    }
                }
            }            
        }

        
        private void cbxArticle_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cbxArticle.Items.Count != 0)
            {
                this.selectedArticle = (ArticleBO)this.cbxArticle.SelectedItem;
                this.txtCategorie.Text = ((ArticleBO)this.cbxArticle.SelectedItem).Categorie.LibelleCat;
                this.txtPrixVente.Value = ((ArticleBO)this.cbxArticle.SelectedItem).PrixVenteArt.ToString();
                this.txtQteStock.Text = ((ArticleBO)this.cbxArticle.SelectedItem).QteStockArt.ToString();
                this.txtSeuil.Text = ((ArticleBO)this.cbxArticle.SelectedItem).SeuilArt.ToString();

                //On détermine l'état de l'article
                int artEtat = articleBLL.IsAvailable(((ArticleBO)this.cbxArticle.SelectedItem).IdArt);

                switch (artEtat)
                {
                    //Cas ou l'article est disponible en stock
                    case 1:

                        this.txtEtatArticle.BackColor = Color.GreenYellow;
                        this.txtEtatArticle.Text = "Article disponible";

                    break;

                    //Cas ou l'article est en dessa du seuil
                    case 2:

                        this.txtEtatArticle.BackColor = Color.Orange;
                        this.txtEtatArticle.Text = "Article en dessous du seuil";

                     break;

                    //Cas ou l'article en rupture de stock
                    case 3:

                        this.txtEtatArticle.BackColor = Color.Red;
                        this.txtEtatArticle.Text = "Article non disponible";

                    break;
                }

                //On renseigne l'utilisateur sur la disponibilité de l'article
                this.DisponibiliteArticle(int.Parse(this.txtQteStock.Text), int.Parse(this.txtSeuil.Text));
            }

            
        }

        private void txtEtatArticle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmdInsertPanier_Click(object sender, EventArgs e)
        {
            if (this.cbxArticle.SelectedItem != null)
            {
                if (this.txtQteAchete.Value != "0")
                {
                    //On verifie si l'article en question est disponible en stock
                    int stock = ((ArticleBO)this.cbxArticle.SelectedItem).QteStockArt;
                    int achat = int.Parse(this.txtQteAchete.Value);
                    if (stock < achat)
                    {
                        AppMessage.Error("Veuillez saisir une quantité inférieure ou égale a la quantité en stock !");
                    }
                    else
                    {
                        if (AppMessage.Question("Voulez vous ajouter cet article au panier ?") != DialogResult.No)
                        {
                            bool articleExiste = false;

                            //On récupère l'article
                            var article = from art in this.listeArticle
                                          where art.IdArt == ((ArticleBO)this.cbxArticle.SelectedItem).IdArt
                                          select art;

                            foreach (var art in article)
                            {
                                if (art != null)
                                {
                                    articleExiste = true;
                                }
                            }

                            //On vérifie si l'objet existe dans la liste
                            if (articleExiste == false)
                            {
                                try
                                {
                                    //Création d'un nouvel article
                                    ArchiveVenteBO newArt = new ArchiveVenteBO();
                                    newArt.IdArt = ((ArticleBO)this.cbxArticle.SelectedItem).IdArt;
                                    newArt.LibelleArt = ((ArticleBO)this.cbxArticle.SelectedItem).LibelleArt;

                                    //On verifie si on effectue une vente en gros ou en detail
                                    switch (this.cbxTypeVente.Text)
                                    {
                                        case "DETAIL":
                                            newArt.PrixVente = ((ArticleBO)this.cbxArticle.SelectedItem).PrixVenteArt;
                                            break;

                                        case "DEMI GROS":
                                            newArt.PrixVente = ((ArticleBO)this.cbxArticle.SelectedItem).PrixEnDemiGros;
                                            break;

                                        case "GROS":
                                            newArt.PrixVente = ((ArticleBO)this.cbxArticle.SelectedItem).PrixEnGros;
                                            break;                                                                                  
                                    }

                                    newArt.PrixVente = int.Parse(this.txtPrixVente.Value);

                                    newArt.QteVente = int.Parse(this.txtQteAchete.Value);
                                    newArt.LibelleCat = ((ArticleBO)this.cbxArticle.SelectedItem).Categorie.LibelleCat;
                                    newArt.TypeVente = this.cbxTypeVente.Text;
                                    newArt.RemisePourcentage = int.Parse(this.cbxRemisePourcentage.Text);
                                    newArt.RemiseMontant = int.Parse(this.txtRemiseMontant.Value);

                                    //Insertion dans le panier
                                    this.listeArticle.Add(newArt);

                                    //Actualisation temporaire de la quantité en stock
                                    ((ArticleBO)this.cbxArticle.SelectedItem).QteStockArt -= int.Parse(this.txtQteAchete.Value);
                                    this.txtQteStock.Text = ((ArticleBO)this.cbxArticle.SelectedItem).QteStockArt.ToString();

                                    this.txtTotalAchat.Value = this.DisplayTotalAchat().ToString();

                                    //On renseigne l'utilisateur sur la disponibilité de l'article
                                    this.DisponibiliteArticle(((ArticleBO)this.cbxArticle.SelectedItem).QteStockArt, ((ArticleBO)this.cbxArticle.SelectedItem).SeuilArt);

                                    AppMessage.Success("L'article a été ajouté au panier !");

                                }
                                catch (AppValidationException appValEx)
                                {
                                    AppMessage.Error(appValEx.Message);
                                }
                            }
                            //L'article existe dans la liste
                            else
                            {
                                AppMessage.Error("Cet article existe déjà dans le panier ! Veuillez en choisir un autre !");
                            }
                        }
                    }                    
                }
                else
                {
                    AppMessage.Error("Veuillez saisir une quantité supérieure à 0");
                }
            }                                   
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {            
            if (this.gridArticlesAchetes.RowCount != 0)
            {
                if (this.txtQteModif.Value != "0")
                {
                    if (AppMessage.Question("Voulez vous ajouter " + this.txtQteModif.Value + " " + this.currentArticle.LibelleArt + " (S) au panier ?") != DialogResult.No)
                    {
                        //On effectue un ajout à la quantité actuelle
                        this.currentArticle.QteVente += int.Parse(this.txtQteModif.Value);
                        this.gridArticlesAchetes.Refresh();

                        //On actualise temporairement la quantité en stock                                                                       
                        ((ArticleBO)this.cbxArticle.SelectedItem).QteStockArt -= int.Parse(this.txtQteModif.Value);
                        this.txtQteStock.Text = ((ArticleBO)this.cbxArticle.SelectedItem).QteStockArt.ToString();

                        //On affiche le sous-total
                        this.txtSousTotal.Value = (archiveVenteBLL.GetMontantTotal(this.currentArticle) - (archiveVenteBLL.GetRemisePourcentage(this.currentArticle) + this.currentArticle.RemiseMontant)).ToString();

                        //On affiche le total
                        this.txtTotalAchat.Value = this.DisplayTotalAchat().ToString();

                        //On renseigne l'utilisateur sur la disponibilité de l'article
                        this.DisponibiliteArticle(((ArticleBO)this.cbxArticle.SelectedItem).QteStockArt, ((ArticleBO)this.cbxArticle.SelectedItem).SeuilArt);
                        AppMessage.Success("L'ajout s'est effectuée avec succès !");
                    }
                }
                else
                {
                    AppMessage.Error("Veuillez saisir une quantité supérieure à 0 !");
                }
            }
        }

        private void cmdRetirer_Click(object sender, EventArgs e)
        {
            if (this.gridArticlesAchetes.RowCount != 0)
            {
                if (this.txtQteModif.Value != "0")
                {
                    if (AppMessage.Question("Voulez vous retirer " + this.txtQteModif.Value + " " + this.currentArticle.LibelleArt + " (S) du panier ?") != DialogResult.No)
                    {
                        //On effectue un retrait sur la quantité actuelle
                        this.currentArticle.QteVente -= int.Parse(this.txtQteModif.Value);
                        this.gridArticlesAchetes.Refresh();

                        //On actualise temporairement la quantité en stock
                        ((ArticleBO)this.cbxArticle.SelectedItem).QteStockArt += int.Parse(this.txtQteModif.Value);
                        this.txtQteStock.Text = ((ArticleBO)this.cbxArticle.SelectedItem).QteStockArt.ToString();

                        //On affiche le sous-total
                        this.txtSousTotal.Value = (archiveVenteBLL.GetMontantTotal(this.currentArticle) - (archiveVenteBLL.GetRemisePourcentage(this.currentArticle) + this.currentArticle.RemiseMontant)).ToString();

                        //On affiche le total
                        this.txtTotalAchat.Value = this.DisplayTotalAchat().ToString();

                        //On renseigne l'utilisateur sur la disponibilité de l'article
                        this.DisponibiliteArticle(((ArticleBO)this.cbxArticle.SelectedItem).QteStockArt, ((ArticleBO)this.cbxArticle.SelectedItem).SeuilArt);
                        AppMessage.Success("Le retrait s'est effectuée avec succès !");                        
                    }
                }
                else
                {
                    AppMessage.Error("Veuillez saisir une quantité supérieure à 0 !");
                }
            }
        }

        /// <summary>
        /// Affiche le total d'une vente
        /// </summary>
        /// <returns>Renvoie un entier</returns>
        private int DisplayTotalAchat()
        {
            int total = 0;

            foreach (ArchiveVenteBO a in this.listeArticle)
            {
                total += archiveVenteBLL.GetMontantTotal(a) - (archiveVenteBLL.GetRemisePourcentage(a) + a.RemiseMontant);
            }
            return total;
        }

        private void gridArticlesAchetes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridArticlesAchetes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.lastInsertedRow = e.RowIndex;                   
        }

        private void cmdValiderVente_Click(object sender, EventArgs e)
        {
            if (this.gridArticlesAchetes.RowCount != 0)
            {
                try
                {
                    if (AppMessage.Question("Voulez vous valider la vente effectuée ?") != DialogResult.No)
                    {
                        //On effectue tout d'abord une insertion dans la table Vente
                        VenteBO v = new VenteBO();
                        v.NumeroVente = this.numeroVente;
                        //v.DateVente = DateTime.Parse(DateTime.Today.ToShortDateString());
                        v.DateVente = DateTime.Parse(this.dtpDateJour.Value.ToShortDateString());
                        venteBLL.Insert(v);

                        foreach (ArchiveVenteBO art in this.listeArticle)
                        {                            
                            //Insertion dans la base de données
                            ArchiveVenteBO ac = new ArchiveVenteBO();

                            ac.DateVente = DateTime.Parse(this.dtpDateJour.Value.ToShortDateString());
                            //ac.DateVente = DateTime.Parse(DateTime.Today.ToShortDateString());
                            ac.HeureVente = DateTime.Today.ToShortTimeString();
                            ac.IdArt = art.IdArt;
                            ac.PrixAchat = articleBLL.GetArticleById(art.IdArt).PrixAchatArt;
                            ac.PrixVente = art.PrixVente;
                            ac.QteVente = art.QteVente;
                            ac.IdUser = ((FormMain)this.Owner).CurrentUtil.IdUtil;                            
                            ac.NumeroVente = this.numeroVente;
                            ac.TypeVente = art.TypeVente;
                            ac.RemisePourcentage = int.Parse(this.cbxRemisePourcentage.Text);
                            ac.RemiseMontant = int.Parse(this.txtRemiseMontant.Value);

                            archiveVenteBLL.Insert(ac);

                            //Actualisation des quantités
                            articleBLL.UpdateQuantite((-1) * art.QteVente, art.IdArt);
                        }

                        AppMessage.Success("La vente a été validée avec succès !");

                        this.venteValide = true;

                        if(AppMessage.Question("Voulez-vous imprimer cette facture ?") == DialogResult.Yes)
                        {                           
                            RetailPrinter.InsertHeader(this.txtNumeroVente.Text.Trim());
                            List<ArchiveVenteBO> ventes = archiveVenteBLL.GetVentesById(this.txtNumeroVente.Text.Trim()).ToList<ArchiveVenteBO>();
                            RetailPrinter.InsertBody(ventes);
                            RetailPrinter.InsertFooter();
                            //On imprime la facture
                            RawPrinterHelper.SendStringToPrinter("Star TSP100 Cutter (TSP143)", RetailPrinter.GetRetail());
                        }

                        //Fermeture de la fenêtre
                        this.Close();
                    }                
                }
                catch (AppException appEx)
                {
                    AppMessage.Error(appEx.Message);
                }                
            }
            else
            {
                AppMessage.Error("Veuillez saisir au moins une vente !");

                this.venteValide = false;
            }
        }

        private void cmdArticles_Click(object sender, EventArgs e)
        {
            FormRechArticle formRech = new FormRechArticle();
            formRech.Owner = this;
            formRech.ShowDialog();

            //Après la fermeture on vérifie
            if (this.articleSelected != string.Empty)
            {
                this.cbxArticle.Text = this.articleSelected;
            }
        }

        private void DisponibiliteArticle(int qte, int seuil)
        {            
            //Cas ou la produit disponible
            if (qte > seuil)
            {
                this.txtEtatArticle.BackColor = Color.GreenYellow;
                this.txtEtatArticle.Text = "Article disponible";
            }

            //Cas ou le seuil est atteint
            if (qte <= seuil)
            {
                this.txtEtatArticle.BackColor = Color.Orange;
                this.txtEtatArticle.Text = "Article en dessous du seuil";
            }

            //Cas ou le produit n'est plus disponible
            if (qte <= 0)
            {
                this.txtEtatArticle.BackColor = Color.Red;
                this.txtEtatArticle.Text = "Article non disponible";
            }                      
        }        

        private void FormVentes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.gridArticlesAchetes.RowCount != 0)
            {
                //La vente n'a pas été validée
                if (this.venteValide != true)
                {
                    if (AppMessage.Question("Voulez vous annuler les ventes effctuées ?") != DialogResult.Yes)
                    {
                        e.Cancel = true;
                    }                    
                }
            }            
        }

        private void cbxTypeVente_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cbxTypeVente.Text)
            {
                case "DETAIL":
                    this.txtPrixVente.Value = articleBLL.GetArticleById(selectedArticle.IdArt).PrixVenteArt.ToString();
                    break;

                case "DEMI GROS":
                    this.txtPrixVente.Value = articleBLL.GetArticleById(selectedArticle.IdArt).PrixEnDemiGros.ToString();
                    break;

                case "GROS":
                    this.txtPrixVente.Value = articleBLL.GetArticleById(selectedArticle.IdArt).PrixEnGros.ToString();
                    break;
            }            
        }

        private void cbxTypeVente_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxTypeVente_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}