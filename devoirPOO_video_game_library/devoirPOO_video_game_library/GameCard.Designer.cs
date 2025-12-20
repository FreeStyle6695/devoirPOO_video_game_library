using System.Drawing; // Vérifie que tu as bien ce using en haut
using System.Drawing.Drawing2D; // Nécessaire pour la qualité du dessin
namespace devoirPOO_video_game_library;
using System.Drawing.Imaging;
partial class GameCard
{
    /// <summary> 
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    /// <summary> 
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        lblNameVG = new Label();
        lblPf = new Label();
        lblType = new Label();
        lblYP = new Label();
        pictureBoxJacket = new PictureBox();
        lblDesc = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBoxJacket).BeginInit();
        SuspendLayout();
        // 
        // lblNameVG
        // 
        lblNameVG.AutoSize = true;
        lblNameVG.Location = new Point(3, 0);
        lblNameVG.MinimumSize = new Size(305, 0);
        lblNameVG.Name = "lblNameVG";
        lblNameVG.Size = new Size(305, 20);
        lblNameVG.TabIndex = 0;
        lblNameVG.Text = "nom du jeu vidéo";
        lblNameVG.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblPf
        // 
        lblPf.Location = new Point(34, 270);
        lblPf.MinimumSize = new Size(250, 0);
        lblPf.Name = "lblPf";
        lblPf.Size = new Size(250, 20);
        lblPf.TabIndex = 1;
        lblPf.Text = "plateforme";
        lblPf.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblType
        // 
        lblType.Location = new Point(34, 290);
        lblType.Name = "lblType";
        lblType.Size = new Size(250, 20);
        lblType.TabIndex = 2;
        lblType.Text = "type";
        lblType.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblYP
        // 
        lblYP.Location = new Point(34, 310);
        lblYP.Name = "lblYP";
        lblYP.Size = new Size(250, 20);
        lblYP.TabIndex = 3;
        lblYP.Text = "année";
        lblYP.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pictureBoxJacket
        // 
        pictureBoxJacket.Location = new Point(34, 23);
        pictureBoxJacket.Name = "pictureBoxJacket";
        pictureBoxJacket.Size = new Size(250, 250);
        pictureBoxJacket.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxJacket.TabIndex = 4;
        pictureBoxJacket.TabStop = false;
        // 
        // lblDesc
        // 
        lblDesc.Location = new Point(34, 330);
        lblDesc.Name = "lblDesc";
        lblDesc.Size = new Size(250, 20);
        lblDesc.TabIndex = 5;
        lblDesc.Text = "Description";
        lblDesc.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // GameCard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblDesc);
        Controls.Add(pictureBoxJacket);
        Controls.Add(lblYP);
        Controls.Add(lblType);
        Controls.Add(lblPf);
        Controls.Add(lblNameVG);
        MaximumSize = new Size(311, 350);
        MinimumSize = new Size(311, 350);
        Name = "GameCard";
        Size = new Size(311, 350);
        ((System.ComponentModel.ISupportInitialize)pictureBoxJacket).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblNameVG;
    private Label lblPf;
    private Label lblType;
    private Label lblYP;
    private PictureBox pictureBoxJacket;
    private Label lblDesc;

    public void SetGameCardValues(Classes.VideoGame videoGame)
    {
        lblNameVG.Text = videoGame.Title;
        lblPf.Text = videoGame.Platform;
        lblType.Text = videoGame.Type;
        lblYP.Text = videoGame.ReleaseYear.ToString();
        lblDesc.Text = videoGame.Description;
        // Charger l'image depuis le chemin spécifié
        if (!string.IsNullOrEmpty(videoGame.ImagePath) && System.IO.File.Exists(videoGame.ImagePath))
        {
            pictureBoxJacket.SizeMode = PictureBoxSizeMode.StretchImage; // Ajuster l'image à la taille de la PictureBox
        }
        else
        {
            // Gérer le cas où le chemin de l'image est invalide ou le fichier n'existe pas
            pictureBoxJacket.Image = null; // Ou définir une image par défaut
        }
        Image baseImage = Image.FromFile(videoGame.ImagePath);
        if (videoGame.IsHacked)
        {
            // SI HACKÉ : On fusionne avec l'image des ressources
            // Remplace 'Properties.Resources.img_hacked_stamp' par le vrai nom de ton image dans les ressources
            Image stamp = devoirPOO_video_game_library.Resources.game_hacked;
            pictureBoxJacket.Image = AddHackedStamp(baseImage, stamp);
        }
        else
        {
            // SINON : On affiche juste la jaquette de base
            // ATTENTION : Il faut cloner l'image car le 'using' va détruire l'originale
            pictureBoxJacket.Image = Image.FromFile(videoGame.ImagePath);
        }
    }
    // Fonction pour ajouter une image par-dessus une autre
    private Image AddHackedStamp(Image image, Image imageHacked)
    {
        // 1. On crée une nouvelle image vide de la taille de la jaquette de base
        // On utilise Format32bppArgb pour gérer la transparence (Alpha)
        Bitmap imageCombined = new Bitmap(image.Width, image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

        // 2. On crée un "outil de dessin" (Graphics) sur cette nouvelle image
        using (Graphics g = Graphics.FromImage(imageCombined))
        {
            // Optionnel : Paramètres pour que le redimensionnement soit joli
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // 3. On dessine la DESS OUS (la jaquette) en premier
            // Elle remplit tout l'espace (0,0 jusqu'à la largeur/hauteur totale)
            g.DrawImage(image, 0, 0, image.Width, image.Height);

            // On définit le niveau d'opacité souhaité (entre 0.0f = invisible et 1.0f = opaque)
            // Essayons 0.7f pour une transparence légère (70% visible)
            float opacite = 0.45f;

            // On crée une "Matrice de couleur". C'est une grille qui modifie les couleurs RGBA.
            // La valeur à la position [3][3] contrôle le canal Alpha (la transparence globale).
            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = opacite; // On applique notre facteur d'opacité

            using (ImageAttributes attributes = new ImageAttributes())
            {
                // On assigne la matrice aux attributs
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);


                // --- NOUVEAUTÉ 2 : LE CENTRAGE ---

                // Calcul de la taille (on garde 1/3 de la largeur, tu peux changer ça si tu veux)
                int largeurOverlay = image.Width/2;
                // Calcul de la hauteur proportionnelle
                int hauteurOverlay = (imageHacked.Height * largeurOverlay) / imageHacked.Width;

                // Calcul de la position CENTRÉE
                // Formule : (LargeurContenant - LargeurContenu) / 2
                int positionX = image.Width - largeurOverlay;
                int positionY = image.Height - hauteurOverlay;

                // On définit le rectangle de destination (où ça va atterrir et quelle taille)
                Rectangle rectDestination = new Rectangle(positionX, positionY, largeurOverlay, hauteurOverlay);


                // 4. Dessin du TAMPON avec les ATTRIBUTS (Transparence + Position centrée)
                // On utilise une version plus complexe de DrawImage qui accepte les 'attributes'
                g.DrawImage(
                    imageHacked,           // L'image à dessiner
                    rectDestination,       // Le rectangle cible calculé au-dessus (centré)
                    0, 0,                  // Coin haut-gauche de l'image source
                    imageHacked.Width,     // Largeur totale de l'image source
                    imageHacked.Height,    // Hauteur totale de l'image source
                    GraphicsUnit.Pixel,    // Unité de mesure
                    attributes);           // <-- LA MAGIE DE LA TRANSPARENCE EST ICI
            }          // <-- LA MAGIE DE LA TRANSPARENCE EST ICI
        }

        // 6. On renvoie l'image fusionnée
        return imageCombined;
    }
}
