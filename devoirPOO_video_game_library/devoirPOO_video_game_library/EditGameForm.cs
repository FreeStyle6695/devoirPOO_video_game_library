using devoirPOO_video_game_library.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace devoirPOO_video_game_library
{
    public partial class EditGameForm : Form
    {
        // On stocke le jeu qu'on est en train de modifier
        private VideoGame _gameToEdit;

        // Constructeur qui reçoit le jeu
        public EditGameForm(VideoGame game)
        {
            InitializeComponent();
            _gameToEdit = game;

            // --- LIGNES AJOUTÉES POUR FORCER LE FONCTIONNEMENT DES BOUTONS ---
            // Cela répare le problème si le Designer a perdu les liens
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            btnJacket.Click += btnJacket_Click;
            // -----------------------------------------------------------------

            // On remplit les champs dès l'ouverture
            LoadGameData();
        }

        private void LoadGameData()
        {
            // On remplit les cases avec les infos actuelles du jeu
            inputNameVG.Text = _gameToEdit.Title;
            inputPf.Text = _gameToEdit.Platform;
            inputType.Text = _gameToEdit.Type;
            inputYP.Text = _gameToEdit.ReleaseYear.ToString();
            inputDesc.Text = _gameToEdit.Description;

            inputMp.Checked = _gameToEdit.IsMultiplayer;
            inputFav.Checked = _gameToEdit.IsFavorite;
            inputHacked.Checked = _gameToEdit.IsHacked;

            // Gestion de l'image
            lblDisplayPathJacket.Text = _gameToEdit.ImagePath;
            if (!string.IsNullOrEmpty(_gameToEdit.ImagePath) && File.Exists(_gameToEdit.ImagePath))
            {
                pictureBoxJacket.Image = Image.FromFile(_gameToEdit.ImagePath);
            }

            // Gestion des statuts (RadioButtons)
            if (_gameToEdit.Statut == "En cours") RBCurrent.Checked = true;
            else if (_gameToEdit.Statut == "Terminé") RBFinish.Checked = true;
            else RBToDo.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // C'est ici qu'on applique les modifications À L'OBJET
            _gameToEdit.Title = inputNameVG.Text;
            _gameToEdit.Platform = inputPf.Text;
            _gameToEdit.Type = inputType.Text;

            // Gestion d'erreur simple pour l'année
            if (int.TryParse(inputYP.Text, out int year))
                _gameToEdit.ReleaseYear = year;

            _gameToEdit.Description = inputDesc.Text;
            _gameToEdit.IsMultiplayer = inputMp.Checked;
            _gameToEdit.IsFavorite = inputFav.Checked;
            _gameToEdit.IsHacked = inputHacked.Checked;
            _gameToEdit.ImagePath = lblDisplayPathJacket.Text;

            // Récupérer le texte du RadioButton coché
            _gameToEdit.Statut = gbStatut.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;

            // IMPORTANT : On dit à la fenêtre principale que tout s'est bien passé
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // On annule tout
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnJacket_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lblDisplayPathJacket.Text = openFileDialog.FileName;
                    pictureBoxJacket.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}