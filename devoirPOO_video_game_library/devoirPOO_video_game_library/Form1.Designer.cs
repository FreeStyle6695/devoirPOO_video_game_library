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
            toList = new TabPage();
            addGame = new TabPage();
            deleteGame = new TabPage();
            editGame = new TabPage();
            label1 = new Label();
            textBox1 = new TextBox();
            container = new TabControl();
            container.SuspendLayout();
            toList.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            container.Controls.Add(toList);
            container.Controls.Add(addGame);
            container.Controls.Add(deleteGame);
            container.Controls.Add(editGame);
            container.Location = new Point(12, 12);
            container.Name = "container";
            container.SelectedIndex = 0;
            container.Size = new Size(1288, 738);
            container.TabIndex = 0;
            // 
            // toList
            // 
            toList.Controls.Add(textBox1);
            toList.Controls.Add(label1);
            toList.Location = new Point(4, 29);
            toList.Name = "toList";
            toList.Padding = new Padding(3);
            toList.Size = new Size(1280, 705);
            toList.TabIndex = 0;
            toList.Text = "Lister";
            toList.UseVisualStyleBackColor = true;
            // 
            // addGame
            // 
            addGame.Location = new Point(4, 29);
            addGame.Name = "addGame";
            addGame.Padding = new Padding(3);
            addGame.Size = new Size(1280, 705);
            addGame.TabIndex = 1;
            addGame.Text = "Ajouter";
            addGame.UseVisualStyleBackColor = true;
            // 
            // deleteGame
            // 
            deleteGame.Location = new Point(4, 29);
            deleteGame.Name = "deleteGame";
            deleteGame.Padding = new Padding(3);
            deleteGame.Size = new Size(1280, 705);
            deleteGame.TabIndex = 2;
            deleteGame.Text = "Supprimer";
            deleteGame.UseVisualStyleBackColor = true;
            // 
            // editGame
            // 
            editGame.Location = new Point(4, 29);
            editGame.Name = "editGame";
            editGame.Padding = new Padding(3);
            editGame.Size = new Size(1280, 705);
            editGame.TabIndex = 3;
            editGame.Text = "Modifier";
            editGame.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(6, 44);
            label1.MaximumSize = new Size(1268, 600);
            label1.MinimumSize = new Size(1268, 600);
            label1.Name = "label1";
            label1.Size = new Size(1268, 600);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(6, 6);
            textBox1.MaximumSize = new Size(1268, 30);
            textBox1.MinimumSize = new Size(1268, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1268, 30);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 762);
            Controls.Add(container);
            Name = "Form1";
            Text = "Form1";
            container.ResumeLayout(false);
            toList.ResumeLayout(false);
            toList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage toList;
        private TabPage addGame;
        private TabPage deleteGame;
        private TabPage editGame;
        private TextBox textBox1;
        private Label label1;
    }
}
