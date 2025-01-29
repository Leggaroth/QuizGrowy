namespace ProjektDextop
{
    partial class RemoveGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxGames = new ComboBox();
            labelSelectedGame = new Label();
            buttonCancel = new Button();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // comboBoxGames
            // 
            comboBoxGames.FormattingEnabled = true;
            comboBoxGames.Location = new Point(263, 70);
            comboBoxGames.Name = "comboBoxGames";
            comboBoxGames.Size = new Size(121, 23);
            comboBoxGames.TabIndex = 0;
            // 
            // labelSelectedGame
            // 
            labelSelectedGame.AutoSize = true;
            labelSelectedGame.Location = new Point(144, 73);
            labelSelectedGame.Name = "labelSelectedGame";
            labelSelectedGame.Size = new Size(75, 15);
            labelSelectedGame.TabIndex = 1;
            labelSelectedGame.Text = "Wybrana Gra";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(144, 149);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Anuluj";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(282, 149);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Usuń";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // RemoveGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 269);
            Controls.Add(buttonRemove);
            Controls.Add(buttonCancel);
            Controls.Add(labelSelectedGame);
            Controls.Add(comboBoxGames);
            Name = "RemoveGameForm";
            Text = "RemoveGameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGames;
        private Label labelSelectedGame;
        private Button buttonCancel;
        private Button buttonRemove;
    }
}