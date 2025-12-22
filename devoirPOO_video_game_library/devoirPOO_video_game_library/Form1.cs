using devoirPOO_video_game_library.Classes;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Windows.Forms;
using System.Text.RegularExpressions; // Ne pas oublier cet import
namespace devoirPOO_video_game_library
{
    public partial class Form1 : Form
    {
        List<VideoGame> videoGame = new List<VideoGame>();
        string filePath = "game_library.json";
        public Form1()
        {
            InitializeComponent();
            LoadGameLibrary(filePath);
            DisplayGames();
        }
        private void btnAddGame_Click(object sender, EventArgs e)
        {
            string title = inputNameVG.Text;
            string platform = inputPf.Text;
            string type = inputType.SelectedItem.ToString();
            int releaseYear = int.Parse(inputYP.SelectedItem.ToString()); // Conversion du texte en nombre
            bool isMultiplayer = inputMp.Checked;
            bool isFavorite = inputFav.Checked;
            bool isHacked = inputHacked.Checked;
            string statut = gbStatut.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text ?? null;
            string description = inputDesc.Text;
            string imagePath = lblDisplayPathJacket.Text; // On stocke le chemin

            videoGame.Add(new VideoGame
            (
                title,
                platform,
                type,
                releaseYear, // Conversion du texte en nombre
                isMultiplayer: isMultiplayer,
                isFavorite: isFavorite,
                isHacked: isHacked,
                statut,
                description,
                imagePath // On stocke le chemin
            ));
            MessageBox.Show($"{this.inputNameVG.Text} ajouté avec succès !");
            ClearForm();
            SaveGameLibrary(filePath);
            DisplayGames();
        }
        public void ClearForm()
        {
            inputNameVG.Clear();
            inputDesc.Clear();
            gbStatut.Controls.OfType<RadioButton>().ToList().ForEach(r => r.Checked = false);
            inputMp.Checked = false;
            inputHacked.Checked = false;
            inputFav.Checked = false;
            inputPf.SelectedIndex = -1;
            inputType.SelectedIndex = -1;
            inputYP.SelectedIndex = -1;
            lblDisplayPathJacket.Text = "Aucun fichier sélectionné"; // Réinitialisation du label
            pictureBoxJacket.Image?.Dispose(); // Libère les ressources
            pictureBoxJacket.Image = null;
        }

        private void btnJacket_Click(object sender, EventArgs e)
        {
            // 1. On crée l'explorateur de fichiers
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 2. On définit le titre et les types de fichiers autorisés (Filtre)
                openFileDialog.Title = "Choisir la jaquette du jeu";
                openFileDialog.Filter = "Images (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                // 3. On ouvre la fenêtre et on vérifie si l'utilisateur a cliqué sur "Ouvrir"
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 4. On récupère le chemin complet du fichier sélectionné
                    string cheminFichier = openFileDialog.FileName;

                    // 5. On l'affiche dans ton label
                    lblDisplayPathJacket.Text = cheminFichier;

                    // Charge l'image dans une PictureBox pour un aperçu direct
                    pictureBoxJacket.Image = Image.FromFile(cheminFichier);
                }
            }
        }
        public void LoadGameLibrary(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"pas de données de sauvegarde trouvées..");
            }
            else
            {
                string fileContent = File.ReadAllText(filePath);
                videoGame = JsonSerializer.Deserialize<List<VideoGame>>(fileContent) ?? new List<VideoGame>();
                MessageBox.Show($"fichier chargé !");
            }

        }
        public void SaveGameLibrary(string filePath)
        {
            string jsonString = JsonSerializer.Serialize(videoGame);
            File.WriteAllText(filePath, jsonString);
            //MessageBox.Show($"modification sauvegardée !");
        }
        public void DisplayGames()

        {
            flowLayoutPanelList.Controls.Clear();
            foreach (var game in videoGame)
            {
                GameCard gameCard = new GameCard();
                gameCard.SetGameCardValues(game);
                // C'EST ICI : On dit à la carte d'appeler notre fonction de Form1
                gameCard.Click += GameCard_Click;
                // LIAISON DU MENU : On dit à la carte d'utiliser le menu contextuel de Form1
                gameCard.ContextMenuStrip = contextMenuStripCardRightClick;
                flowLayoutPanelList.Controls.Add(gameCard);
            }
            // Très important : on rappelle ton calcul de marges dynamiques ici !
            AdjustCardsMargins();
        }
        private void SearchGames(object sender, EventArgs e)
        {
            string searchText = inputSort.Text.Trim();

            // Si le champ est vide, on affiche tout et on arrête
            if (string.IsNullOrEmpty(searchText))
            {
                DisplayGames();
                return;
            }

            // On prépare la Regex pour chercher le mot exact (insensible à la casse)
            // \b signifie "bordure de mot"
            string pattern = $@"\b{Regex.Escape(searchText)}";
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);

            var filteredGames = videoGame.Where(game =>
                rgx.IsMatch(game.Title) ||
                rgx.IsMatch(game.Platform) ||
                rgx.IsMatch(game.Type)
            ).ToList();

            UpdateDisplay(filteredGames);
        }

        private void UpdateDisplay(List<VideoGame> games)
        {
            flowLayoutPanelList.Controls.Clear();

            foreach (var game in games)
            {
                GameCard gameCard = new GameCard();
                gameCard.SetGameCardValues(game);
                // ICI : C'est cette ligne qui fait le lien ("le branchement")
                gameCard.Click += GameCard_Click;
                gameCard.ContextMenuStrip = contextMenuStripCardRightClick;
                flowLayoutPanelList.Controls.Add(gameCard);
            }

            // Très important : on rappelle ton calcul de marges dynamiques ici !
            AdjustCardsMargins();

            flowLayoutPanelList.ResumeLayout();
        }

        //private void btnGameCard1(object sender, EventArgs e)
        //{
        //    gameCard1;
        //}
        // 1. La fonction qui sera appelée quand on clique sur n'importe quelle carte
        private void GameCard_Click(object sender, EventArgs e)
        {
            // Le 'sender' est la carte qui a été cliquée
            GameCard clickedCard = sender as GameCard;

            if (clickedCard != null)
            {
                // Étape A : On déselectionne toutes les cartes du panel
                foreach (Control c in flowLayoutPanelList.Controls)
                {
                    if (c is GameCard card)
                    {
                        card.IsSelected = false;
                        // Grâce à notre propriété complète, l'ancienne bordure s'efface seule
                    }
                }

                // Étape B : On sélectionne la carte cliquée
                clickedCard.IsSelected = true;
                // La nouvelle bordure apparaît seule

                // Étape C : Tu peux maintenant récupérer les infos du jeu cliqué
                // MessageBox.Show("Jeu sélectionné : " + clickedCard.Title);
            }
        }
        private void DeleteVideoGame(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            ContextMenuStrip menu = item?.Owner as ContextMenuStrip;
            GameCard cardToDelete = menu?.SourceControl as GameCard;

            if (cardToDelete?.GameData != null) // On accède directement aux données
            {
                DialogResult result = MessageBox.Show($"Supprimer {cardToDelete.Title} ?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Suppression directe de l'objet stocké dans la carte
                    videoGame.Remove(cardToDelete.GameData);

                    SaveGameLibrary(filePath);
                    DisplayGames();
                }
            }
        }
    }
}