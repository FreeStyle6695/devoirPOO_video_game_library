using devoirPOO_video_game_library.Classes;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
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
                isMultiplayer : isMultiplayer,
                isFavorite : isFavorite,
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
        }

        private void btnJacket_Click(object sender, EventArgs e)
        {
            // 1. On crée l'explorateur de fichiers
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 2. On définit le titre et les types de fichiers autorisés (Filtre)
                openFileDialog.Title = "Choisir la jaquette du jeu";
                openFileDialog.Filter = "Images (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tous les fichiers (*.*)|*.*";

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
        public void SaveGameLibrary(string filePath) {
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
                flowLayoutPanelList.Controls.Add(gameCard);
            }
        }
    }
}