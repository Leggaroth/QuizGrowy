namespace ProjektDextop
{
    partial class AddGameForm
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
            buttonBrowseImage = new Button();
            labelImagePath = new Label();
            labelGameTitle = new Label();
            textBoxGameTitle = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // buttonBrowseImage
            // 
            buttonBrowseImage.Location = new Point(76, 44);
            buttonBrowseImage.Name = "buttonBrowseImage";
            buttonBrowseImage.Size = new Size(97, 23);
            buttonBrowseImage.TabIndex = 0;
            buttonBrowseImage.Text = "Wybierz obraz";
            buttonBrowseImage.UseVisualStyleBackColor = true;
            buttonBrowseImage.Click += buttonBrowseImage_Click;
            // 
            // labelImagePath
            // 
            labelImagePath.AutoSize = true;
            labelImagePath.Location = new Point(76, 102);
            labelImagePath.Name = "labelImagePath";
            labelImagePath.Size = new Size(0, 15);
            labelImagePath.TabIndex = 1;
            // 
            // labelGameTitle
            // 
            labelGameTitle.AutoSize = true;
            labelGameTitle.Location = new Point(76, 150);
            labelGameTitle.Name = "labelGameTitle";
            labelGameTitle.Size = new Size(62, 15);
            labelGameTitle.TabIndex = 2;
            labelGameTitle.Text = "Nazwa gry";
            // 
            // textBoxGameTitle
            // 
            textBoxGameTitle.Location = new Point(76, 204);
            textBoxGameTitle.Name = "textBoxGameTitle";
            textBoxGameTitle.Size = new Size(100, 23);
            textBoxGameTitle.TabIndex = 3;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(426, 213);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Anuluj";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(426, 65);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Dodaj";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 269);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxGameTitle);
            Controls.Add(labelGameTitle);
            Controls.Add(labelImagePath);
            Controls.Add(buttonBrowseImage);
            Name = "AddGameForm";
            Text = "AddGameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBrowseImage;
        private Label labelImagePath;
        private Label labelGameTitle;
        private TextBox textBoxGameTitle;
        private Button buttonCancel;
        private Button buttonSave;
    }
}