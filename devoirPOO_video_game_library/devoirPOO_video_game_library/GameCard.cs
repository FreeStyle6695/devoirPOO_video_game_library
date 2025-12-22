using devoirPOO_video_game_library.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace devoirPOO_video_game_library
{
    // On garde une trace de l'objet complet
    public partial class GameCard : UserControl
    {
        // On stocke l'objet complet pour pouvoir le retrouver lors de la suppression
        public VideoGame GameData { get; private set; }
        // Cette propriété permet à Form1 de lire le titre du jeu
        public string Title => GameData?.Title ?? "Sans titre";

        [Category("Appearance")] // La propriété apparaîtra dans la catégorie "Apparence"
        [Description("Indique si la carte est sélectionnée ou non.")]
        [Browsable(true)] // Permet de voir la propriété dans la fenêtre Propriétés (F4)
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        // Propriété pour savoir si la carte est sélectionnée
        private bool _isSelected = false; // Le champ caché (backing field)

        [Category("Appearance")]
        [Description("Indique si la carte est sélectionnée ou non.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    // On demande au contrôle de se redessiner immédiatement
                    this.Invalidate();
                }
            }
        }
        public GameCard()
        {
            InitializeComponent();

            // On lie l'événement Paint pour dessiner la bordure
            this.Paint += GameCard_Paint;

            // ASTUCE : On lie le clic de TOUS les composants internes à la carte
            BindClickEvents(this);
        }

        // Cette méthode permet de cliquer n'importe où (sur l'image, le texte, etc.)
        // pour sélectionner la carte
        private void BindClickEvents(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.Click += (s, e) => this.OnHeaderClicked(e);
                if (c.HasChildren) BindClickEvents(c);
            }
        }

        private void OnHeaderClicked(EventArgs e)
        {
            // On appelle l'événement Click de la GameCard elle-même
            this.OnClick(e);
        }

        private void GameCard_Paint(object sender, PaintEventArgs e)
        {
            if (IsSelected)
            {
                // Dessine une bordure de 3 pixels à l'intérieur du contrôle
                int thickness = 3;
                using (Pen p = new Pen(Color.DodgerBlue, thickness))
                {
                    // On ajuste le rectangle pour que la bordure ne soit pas coupée
                    e.Graphics.DrawRectangle(p,
                        thickness / 2,
                        thickness / 2,
                        this.Width - thickness,
                        this.Height - thickness);
                }
            }
        }
        public void SetGameCardValues(Classes.VideoGame videoGame)
        {
            this.GameData = videoGame; // <--- AJOUTE CETTE LIGNE (très important pour la suppression !)

            lblNameVG.Text = videoGame.Title;
            lblPf.Text = videoGame.Platform;
            lblType.Text = videoGame.Type;
            lblYP.Text = videoGame.ReleaseYear.ToString();
            lblDesc.Text = videoGame.Description;

            // On vérifie si l'image existe avant de faire quoi que ce soit
            if (!string.IsNullOrEmpty(videoGame.ImagePath) && System.IO.File.Exists(videoGame.ImagePath))
            {
                // On charge l'image une seule fois
                Image baseImage = Image.FromFile(videoGame.ImagePath);

                if (videoGame.IsHacked)
                {
                    Image stamp = Resources.game_hacked;
                    pictureBoxJacket.Image = AddHackedStamp(baseImage, stamp);
                }
                else
                {
                    pictureBoxJacket.Image = baseImage;
                }
            }
            else
            {
                pictureBoxJacket.Image = null; // Ou une image par défaut
            }
        }
    }
}
