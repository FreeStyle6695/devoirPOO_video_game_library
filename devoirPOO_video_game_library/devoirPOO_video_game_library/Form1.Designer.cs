namespace devoirPOO_video_game_library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControl container;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toList = new TabPage();
            flowLayoutPanelList = new FlowLayoutPanel();
            gameCard1 = new GameCard();
            gameCard2 = new GameCard();
            gameCard3 = new GameCard();
            gameCard4 = new GameCard();
            gameCard5 = new GameCard();
            gameCard6 = new GameCard();
            gameCard7 = new GameCard();
            gameCard8 = new GameCard();
            inputSort = new TextBox();
            addGame = new TabPage();
            gbYP = new GroupBox();
            lblYP = new Label();
            inputYP = new ComboBox();
            gbPf = new GroupBox();
            inputPf = new ComboBox();
            lblPf = new Label();
            bgType = new GroupBox();
            lblType = new Label();
            inputType = new ComboBox();
            gbDesc = new GroupBox();
            lblDesc = new Label();
            inputDesc = new TextBox();
            gbNameVG = new GroupBox();
            lblNameVG = new Label();
            inputNameVG = new TextBox();
            btnAddGame = new Button();
            gbJacket = new GroupBox();
            pictureBoxJacket = new PictureBox();
            lblDisplayPathJacket = new Label();
            btnJacket = new Button();
            inputHacked = new CheckBox();
            gbStatut = new GroupBox();
            RBToDo = new RadioButton();
            RBFinish = new RadioButton();
            RBCurrent = new RadioButton();
            inputFav = new CheckBox();
            inputMp = new CheckBox();
            deleteGame = new TabPage();
            editGame = new TabPage();
            container = new TabControl();
            container.SuspendLayout();
            toList.SuspendLayout();
            flowLayoutPanelList.SuspendLayout();
            addGame.SuspendLayout();
            gbYP.SuspendLayout();
            gbPf.SuspendLayout();
            bgType.SuspendLayout();
            gbDesc.SuspendLayout();
            gbNameVG.SuspendLayout();
            gbJacket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJacket).BeginInit();
            gbStatut.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            resources.ApplyResources(container, "container");
            container.Controls.Add(toList);
            container.Controls.Add(addGame);
            container.Controls.Add(deleteGame);
            container.Controls.Add(editGame);
            container.Name = "container";
            container.SelectedIndex = 0;
            // 
            // toList
            // 
            toList.Controls.Add(flowLayoutPanelList);
            toList.Controls.Add(inputSort);
            resources.ApplyResources(toList, "toList");
            toList.Name = "toList";
            toList.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelList
            // 
            resources.ApplyResources(flowLayoutPanelList, "flowLayoutPanelList");
            flowLayoutPanelList.Controls.Add(gameCard1);
            flowLayoutPanelList.Controls.Add(gameCard2);
            flowLayoutPanelList.Controls.Add(gameCard3);
            flowLayoutPanelList.Controls.Add(gameCard4);
            flowLayoutPanelList.Controls.Add(gameCard5);
            flowLayoutPanelList.Controls.Add(gameCard6);
            flowLayoutPanelList.Controls.Add(gameCard7);
            flowLayoutPanelList.Controls.Add(gameCard8);
            flowLayoutPanelList.Name = "flowLayoutPanelList";
            // 
            // gameCard1
            // 
            resources.ApplyResources(gameCard1, "gameCard1");
            gameCard1.Name = "gameCard1";
            // 
            // gameCard2
            // 
            resources.ApplyResources(gameCard2, "gameCard2");
            gameCard2.Name = "gameCard2";
            // 
            // gameCard3
            // 
            resources.ApplyResources(gameCard3, "gameCard3");
            gameCard3.Name = "gameCard3";
            // 
            // gameCard4
            // 
            resources.ApplyResources(gameCard4, "gameCard4");
            gameCard4.Name = "gameCard4";
            // 
            // gameCard5
            // 
            resources.ApplyResources(gameCard5, "gameCard5");
            gameCard5.Name = "gameCard5";
            // 
            // gameCard6
            // 
            resources.ApplyResources(gameCard6, "gameCard6");
            gameCard6.Name = "gameCard6";
            // 
            // gameCard7
            // 
            resources.ApplyResources(gameCard7, "gameCard7");
            gameCard7.Name = "gameCard7";
            // 
            // gameCard8
            // 
            resources.ApplyResources(gameCard8, "gameCard8");
            gameCard8.Name = "gameCard8";
            // 
            // inputSort
            // 
            resources.ApplyResources(inputSort, "inputSort");
            inputSort.Name = "inputSort";
            // 
            // addGame
            // 
            addGame.Controls.Add(gbYP);
            addGame.Controls.Add(gbPf);
            addGame.Controls.Add(bgType);
            addGame.Controls.Add(gbDesc);
            addGame.Controls.Add(gbNameVG);
            addGame.Controls.Add(btnAddGame);
            addGame.Controls.Add(gbJacket);
            addGame.Controls.Add(inputHacked);
            addGame.Controls.Add(gbStatut);
            addGame.Controls.Add(inputFav);
            addGame.Controls.Add(inputMp);
            resources.ApplyResources(addGame, "addGame");
            addGame.Name = "addGame";
            addGame.UseVisualStyleBackColor = true;
            // 
            // gbYP
            // 
            gbYP.Controls.Add(lblYP);
            gbYP.Controls.Add(inputYP);
            resources.ApplyResources(gbYP, "gbYP");
            gbYP.Name = "gbYP";
            gbYP.TabStop = false;
            // 
            // lblYP
            // 
            resources.ApplyResources(lblYP, "lblYP");
            lblYP.Name = "lblYP";
            // 
            // inputYP
            // 
            inputYP.FormattingEnabled = true;
            inputYP.Items.AddRange(new object[] { resources.GetString("inputYP.Items"), resources.GetString("inputYP.Items1"), resources.GetString("inputYP.Items2"), resources.GetString("inputYP.Items3"), resources.GetString("inputYP.Items4"), resources.GetString("inputYP.Items5"), resources.GetString("inputYP.Items6"), resources.GetString("inputYP.Items7"), resources.GetString("inputYP.Items8"), resources.GetString("inputYP.Items9"), resources.GetString("inputYP.Items10"), resources.GetString("inputYP.Items11"), resources.GetString("inputYP.Items12"), resources.GetString("inputYP.Items13"), resources.GetString("inputYP.Items14"), resources.GetString("inputYP.Items15"), resources.GetString("inputYP.Items16"), resources.GetString("inputYP.Items17"), resources.GetString("inputYP.Items18"), resources.GetString("inputYP.Items19"), resources.GetString("inputYP.Items20"), resources.GetString("inputYP.Items21"), resources.GetString("inputYP.Items22"), resources.GetString("inputYP.Items23"), resources.GetString("inputYP.Items24"), resources.GetString("inputYP.Items25"), resources.GetString("inputYP.Items26"), resources.GetString("inputYP.Items27"), resources.GetString("inputYP.Items28"), resources.GetString("inputYP.Items29"), resources.GetString("inputYP.Items30"), resources.GetString("inputYP.Items31"), resources.GetString("inputYP.Items32"), resources.GetString("inputYP.Items33"), resources.GetString("inputYP.Items34"), resources.GetString("inputYP.Items35"), resources.GetString("inputYP.Items36"), resources.GetString("inputYP.Items37"), resources.GetString("inputYP.Items38"), resources.GetString("inputYP.Items39"), resources.GetString("inputYP.Items40"), resources.GetString("inputYP.Items41"), resources.GetString("inputYP.Items42"), resources.GetString("inputYP.Items43"), resources.GetString("inputYP.Items44"), resources.GetString("inputYP.Items45"), resources.GetString("inputYP.Items46"), resources.GetString("inputYP.Items47"), resources.GetString("inputYP.Items48"), resources.GetString("inputYP.Items49"), resources.GetString("inputYP.Items50"), resources.GetString("inputYP.Items51"), resources.GetString("inputYP.Items52"), resources.GetString("inputYP.Items53"), resources.GetString("inputYP.Items54"), resources.GetString("inputYP.Items55"), resources.GetString("inputYP.Items56"), resources.GetString("inputYP.Items57"), resources.GetString("inputYP.Items58"), resources.GetString("inputYP.Items59"), resources.GetString("inputYP.Items60"), resources.GetString("inputYP.Items61"), resources.GetString("inputYP.Items62"), resources.GetString("inputYP.Items63"), resources.GetString("inputYP.Items64"), resources.GetString("inputYP.Items65"), resources.GetString("inputYP.Items66"), resources.GetString("inputYP.Items67"), resources.GetString("inputYP.Items68"), resources.GetString("inputYP.Items69"), resources.GetString("inputYP.Items70"), resources.GetString("inputYP.Items71"), resources.GetString("inputYP.Items72"), resources.GetString("inputYP.Items73"), resources.GetString("inputYP.Items74"), resources.GetString("inputYP.Items75"), resources.GetString("inputYP.Items76"), resources.GetString("inputYP.Items77"), resources.GetString("inputYP.Items78"), resources.GetString("inputYP.Items79"), resources.GetString("inputYP.Items80"), resources.GetString("inputYP.Items81"), resources.GetString("inputYP.Items82"), resources.GetString("inputYP.Items83") });
            resources.ApplyResources(inputYP, "inputYP");
            inputYP.Name = "inputYP";
            // 
            // gbPf
            // 
            gbPf.Controls.Add(inputPf);
            gbPf.Controls.Add(lblPf);
            resources.ApplyResources(gbPf, "gbPf");
            gbPf.Name = "gbPf";
            gbPf.TabStop = false;
            // 
            // inputPf
            // 
            inputPf.FormattingEnabled = true;
            inputPf.Items.AddRange(new object[] { resources.GetString("inputPf.Items"), resources.GetString("inputPf.Items1"), resources.GetString("inputPf.Items2"), resources.GetString("inputPf.Items3"), resources.GetString("inputPf.Items4"), resources.GetString("inputPf.Items5"), resources.GetString("inputPf.Items6"), resources.GetString("inputPf.Items7"), resources.GetString("inputPf.Items8"), resources.GetString("inputPf.Items9"), resources.GetString("inputPf.Items10"), resources.GetString("inputPf.Items11"), resources.GetString("inputPf.Items12"), resources.GetString("inputPf.Items13"), resources.GetString("inputPf.Items14"), resources.GetString("inputPf.Items15"), resources.GetString("inputPf.Items16"), resources.GetString("inputPf.Items17"), resources.GetString("inputPf.Items18"), resources.GetString("inputPf.Items19"), resources.GetString("inputPf.Items20"), resources.GetString("inputPf.Items21"), resources.GetString("inputPf.Items22"), resources.GetString("inputPf.Items23"), resources.GetString("inputPf.Items24"), resources.GetString("inputPf.Items25"), resources.GetString("inputPf.Items26"), resources.GetString("inputPf.Items27"), resources.GetString("inputPf.Items28"), resources.GetString("inputPf.Items29"), resources.GetString("inputPf.Items30"), resources.GetString("inputPf.Items31"), resources.GetString("inputPf.Items32"), resources.GetString("inputPf.Items33"), resources.GetString("inputPf.Items34"), resources.GetString("inputPf.Items35"), resources.GetString("inputPf.Items36"), resources.GetString("inputPf.Items37"), resources.GetString("inputPf.Items38"), resources.GetString("inputPf.Items39"), resources.GetString("inputPf.Items40"), resources.GetString("inputPf.Items41"), resources.GetString("inputPf.Items42"), resources.GetString("inputPf.Items43"), resources.GetString("inputPf.Items44"), resources.GetString("inputPf.Items45"), resources.GetString("inputPf.Items46"), resources.GetString("inputPf.Items47"), resources.GetString("inputPf.Items48"), resources.GetString("inputPf.Items49"), resources.GetString("inputPf.Items50"), resources.GetString("inputPf.Items51"), resources.GetString("inputPf.Items52"), resources.GetString("inputPf.Items53"), resources.GetString("inputPf.Items54"), resources.GetString("inputPf.Items55"), resources.GetString("inputPf.Items56"), resources.GetString("inputPf.Items57"), resources.GetString("inputPf.Items58"), resources.GetString("inputPf.Items59"), resources.GetString("inputPf.Items60") });
            resources.ApplyResources(inputPf, "inputPf");
            inputPf.Name = "inputPf";
            // 
            // lblPf
            // 
            resources.ApplyResources(lblPf, "lblPf");
            lblPf.Name = "lblPf";
            // 
            // bgType
            // 
            bgType.Controls.Add(lblType);
            bgType.Controls.Add(inputType);
            resources.ApplyResources(bgType, "bgType");
            bgType.Name = "bgType";
            bgType.TabStop = false;
            // 
            // lblType
            // 
            resources.ApplyResources(lblType, "lblType");
            lblType.Name = "lblType";
            // 
            // inputType
            // 
            inputType.FormattingEnabled = true;
            inputType.Items.AddRange(new object[] { resources.GetString("inputType.Items"), resources.GetString("inputType.Items1"), resources.GetString("inputType.Items2"), resources.GetString("inputType.Items3"), resources.GetString("inputType.Items4"), resources.GetString("inputType.Items5"), resources.GetString("inputType.Items6"), resources.GetString("inputType.Items7"), resources.GetString("inputType.Items8"), resources.GetString("inputType.Items9"), resources.GetString("inputType.Items10"), resources.GetString("inputType.Items11"), resources.GetString("inputType.Items12"), resources.GetString("inputType.Items13"), resources.GetString("inputType.Items14"), resources.GetString("inputType.Items15"), resources.GetString("inputType.Items16"), resources.GetString("inputType.Items17"), resources.GetString("inputType.Items18"), resources.GetString("inputType.Items19"), resources.GetString("inputType.Items20"), resources.GetString("inputType.Items21"), resources.GetString("inputType.Items22"), resources.GetString("inputType.Items23"), resources.GetString("inputType.Items24"), resources.GetString("inputType.Items25"), resources.GetString("inputType.Items26"), resources.GetString("inputType.Items27"), resources.GetString("inputType.Items28"), resources.GetString("inputType.Items29"), resources.GetString("inputType.Items30"), resources.GetString("inputType.Items31"), resources.GetString("inputType.Items32"), resources.GetString("inputType.Items33") });
            resources.ApplyResources(inputType, "inputType");
            inputType.Name = "inputType";
            // 
            // gbDesc
            // 
            gbDesc.Controls.Add(lblDesc);
            gbDesc.Controls.Add(inputDesc);
            resources.ApplyResources(gbDesc, "gbDesc");
            gbDesc.Name = "gbDesc";
            gbDesc.TabStop = false;
            // 
            // lblDesc
            // 
            resources.ApplyResources(lblDesc, "lblDesc");
            lblDesc.Name = "lblDesc";
            // 
            // inputDesc
            // 
            inputDesc.AutoCompleteMode = AutoCompleteMode.Append;
            resources.ApplyResources(inputDesc, "inputDesc");
            inputDesc.Name = "inputDesc";
            // 
            // gbNameVG
            // 
            gbNameVG.Controls.Add(lblNameVG);
            gbNameVG.Controls.Add(inputNameVG);
            resources.ApplyResources(gbNameVG, "gbNameVG");
            gbNameVG.Name = "gbNameVG";
            gbNameVG.TabStop = false;
            // 
            // lblNameVG
            // 
            resources.ApplyResources(lblNameVG, "lblNameVG");
            lblNameVG.Name = "lblNameVG";
            // 
            // inputNameVG
            // 
            inputNameVG.AutoCompleteMode = AutoCompleteMode.Append;
            resources.ApplyResources(inputNameVG, "inputNameVG");
            inputNameVG.Name = "inputNameVG";
            // 
            // btnAddGame
            // 
            resources.ApplyResources(btnAddGame, "btnAddGame");
            btnAddGame.Name = "btnAddGame";
            btnAddGame.UseVisualStyleBackColor = true;
            btnAddGame.Click += btnAddGame_Click;
            // 
            // gbJacket
            // 
            resources.ApplyResources(gbJacket, "gbJacket");
            gbJacket.Controls.Add(pictureBoxJacket);
            gbJacket.Controls.Add(lblDisplayPathJacket);
            gbJacket.Controls.Add(btnJacket);
            gbJacket.Name = "gbJacket";
            gbJacket.TabStop = false;
            // 
            // pictureBoxJacket
            // 
            resources.ApplyResources(pictureBoxJacket, "pictureBoxJacket");
            pictureBoxJacket.Name = "pictureBoxJacket";
            pictureBoxJacket.TabStop = false;
            // 
            // lblDisplayPathJacket
            // 
            resources.ApplyResources(lblDisplayPathJacket, "lblDisplayPathJacket");
            lblDisplayPathJacket.BorderStyle = BorderStyle.Fixed3D;
            lblDisplayPathJacket.Name = "lblDisplayPathJacket";
            // 
            // btnJacket
            // 
            resources.ApplyResources(btnJacket, "btnJacket");
            btnJacket.Name = "btnJacket";
            btnJacket.UseVisualStyleBackColor = true;
            btnJacket.Click += btnJacket_Click;
            // 
            // inputHacked
            // 
            resources.ApplyResources(inputHacked, "inputHacked");
            inputHacked.Name = "inputHacked";
            inputHacked.UseVisualStyleBackColor = true;
            // 
            // gbStatut
            // 
            gbStatut.Controls.Add(RBToDo);
            gbStatut.Controls.Add(RBFinish);
            gbStatut.Controls.Add(RBCurrent);
            resources.ApplyResources(gbStatut, "gbStatut");
            gbStatut.Name = "gbStatut";
            gbStatut.TabStop = false;
            // 
            // RBToDo
            // 
            resources.ApplyResources(RBToDo, "RBToDo");
            RBToDo.Name = "RBToDo";
            RBToDo.TabStop = true;
            RBToDo.UseVisualStyleBackColor = true;
            // 
            // RBFinish
            // 
            resources.ApplyResources(RBFinish, "RBFinish");
            RBFinish.Name = "RBFinish";
            RBFinish.TabStop = true;
            RBFinish.UseVisualStyleBackColor = true;
            // 
            // RBCurrent
            // 
            resources.ApplyResources(RBCurrent, "RBCurrent");
            RBCurrent.Name = "RBCurrent";
            RBCurrent.TabStop = true;
            RBCurrent.UseVisualStyleBackColor = true;
            // 
            // inputFav
            // 
            resources.ApplyResources(inputFav, "inputFav");
            inputFav.Name = "inputFav";
            inputFav.UseVisualStyleBackColor = true;
            // 
            // inputMp
            // 
            resources.ApplyResources(inputMp, "inputMp");
            inputMp.Name = "inputMp";
            inputMp.UseVisualStyleBackColor = true;
            // 
            // deleteGame
            // 
            resources.ApplyResources(deleteGame, "deleteGame");
            deleteGame.Name = "deleteGame";
            deleteGame.UseVisualStyleBackColor = true;
            // 
            // editGame
            // 
            resources.ApplyResources(editGame, "editGame");
            editGame.Name = "editGame";
            editGame.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(container);
            DoubleBuffered = true;
            Name = "Form1";
            container.ResumeLayout(false);
            toList.ResumeLayout(false);
            toList.PerformLayout();
            flowLayoutPanelList.ResumeLayout(false);
            addGame.ResumeLayout(false);
            addGame.PerformLayout();
            gbYP.ResumeLayout(false);
            gbPf.ResumeLayout(false);
            bgType.ResumeLayout(false);
            gbDesc.ResumeLayout(false);
            gbDesc.PerformLayout();
            gbNameVG.ResumeLayout(false);
            gbNameVG.PerformLayout();
            gbJacket.ResumeLayout(false);
            gbJacket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJacket).EndInit();
            gbStatut.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage toList;
        private TabPage addGame;
        private TabPage deleteGame;
        private TabPage editGame;
        private TextBox inputSort;
        private TextBox inputDesc;
        private CheckBox inputMp;
        private Label lblNameVG;
        private Label lblYP;
        private Label lblType;
        private Label lblPf;
        private Label lblDesc;
        private TextBox inputNameVG;
        private CheckBox inputFav;
        private ComboBox inputType;
        private ComboBox inputYP;
        private GroupBox gbStatut;
        private RadioButton RBCurrent;
        private RadioButton RBToDo;
        private RadioButton RBFinish;
        private Label lblDisplayPathJacket;
        private Button btnJacket;
        private CheckBox inputHacked;
        private GroupBox gbJacket;
        private Button btnAddGame;
        private GroupBox gbDesc;
        private GroupBox gbNameVG;
        private GroupBox bgType;
        private GroupBox gbPf;
        private GroupBox gbYP;
        private ComboBox inputPf;
        private FlowLayoutPanel flowLayoutPanelList;
        private GameCard gameCard1;
        private GameCard gameCard2;
        private GameCard gameCard3;
        private GameCard gameCard4;
        private GameCard gameCard5;
        private GameCard gameCard6;
        private GameCard gameCard7;
        private GameCard gameCard8;
        private PictureBox pictureBoxJacket;
    }
}
