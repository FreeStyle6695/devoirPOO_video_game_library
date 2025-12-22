using System.Drawing; // Vérifie que tu as bien ce using en haut
using System.Drawing.Drawing2D; // Nécessaire pour la qualité du dessin
namespace devoirPOO_video_game_library;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
        lblNameVG.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Underline);
        lblNameVG.Location = new Point(3, 0);
        lblNameVG.MaximumSize = new Size(250, 0);
        lblNameVG.MinimumSize = new Size(250, 50);
        lblNameVG.Name = "lblNameVG";
        lblNameVG.Size = new Size(250, 50);
        lblNameVG.TabIndex = 0;
        lblNameVG.Text = "nom du jeu vidéo";
        lblNameVG.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblPf
        // 
        lblPf.AutoSize = true;
        lblPf.Font = new Font("Segoe UI", 10F);
        lblPf.Location = new Point(3, 303);
        lblPf.MaximumSize = new Size(250, 0);
        lblPf.MinimumSize = new Size(250, 20);
        lblPf.Name = "lblPf";
        lblPf.Size = new Size(250, 23);
        lblPf.TabIndex = 1;
        lblPf.Text = "plateforme";
        lblPf.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblType
        // 
        lblType.AutoSize = true;
        lblType.Font = new Font("Segoe UI", 10F);
        lblType.Location = new Point(128, 323);
        lblType.MaximumSize = new Size(125, 0);
        lblType.MinimumSize = new Size(125, 20);
        lblType.Name = "lblType";
        lblType.Size = new Size(125, 23);
        lblType.TabIndex = 2;
        lblType.Text = "Type";
        lblType.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblYP
        // 
        lblYP.AutoSize = true;
        lblYP.Font = new Font("Segoe UI", 10F);
        lblYP.Location = new Point(128, 346);
        lblYP.MaximumSize = new Size(125, 0);
        lblYP.MinimumSize = new Size(125, 20);
        lblYP.Name = "lblYP";
        lblYP.Size = new Size(125, 23);
        lblYP.TabIndex = 3;
        lblYP.Text = "Année";
        lblYP.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pictureBoxJacket
        // 
        pictureBoxJacket.Location = new Point(0, 50);
        pictureBoxJacket.Margin = new Padding(0);
        pictureBoxJacket.MaximumSize = new Size(250, 250);
        pictureBoxJacket.MinimumSize = new Size(250, 250);
        pictureBoxJacket.Name = "pictureBoxJacket";
        pictureBoxJacket.Size = new Size(250, 250);
        pictureBoxJacket.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxJacket.TabIndex = 4;
        pictureBoxJacket.TabStop = false;
        // 
        // lblDesc
        // 
        lblDesc.AutoSize = true;
        lblDesc.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
        lblDesc.Location = new Point(128, 369);
        lblDesc.MaximumSize = new Size(125, 0);
        lblDesc.MinimumSize = new Size(125, 20);
        lblDesc.Name = "lblDesc";
        lblDesc.Size = new Size(125, 23);
        lblDesc.TabIndex = 5;
        lblDesc.Text = "Description";
        lblDesc.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // GameCard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        Controls.Add(lblDesc);
        Controls.Add(pictureBoxJacket);
        Controls.Add(lblYP);
        Controls.Add(lblType);
        Controls.Add(lblPf);
        Controls.Add(lblNameVG);
        Margin = new Padding(5);
        MaximumSize = new Size(250, 0);
        MinimumSize = new Size(250, 400);
        Name = "GameCard";
        Size = new Size(250, 400);
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
                int largeurOverlay = image.Width / 2;
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
