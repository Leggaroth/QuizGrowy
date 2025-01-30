namespace ProjektDextop
{
    partial class EditGameForm
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
            buttonCancel = new Button();
            buttonEdit = new Button();
            comboBoxGameList = new ComboBox();
            textBoxNewName = new TextBox();
            label = new Label();
            labelGameList = new Label();
            pictureBoxGameImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGameImage).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(167, 330);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Anuluj";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(379, 330);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Edytuj";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // comboBoxGameList
            // 
            comboBoxGameList.FormattingEnabled = true;
            comboBoxGameList.Location = new Point(167, 188);
            comboBoxGameList.Name = "comboBoxGameList";
            comboBoxGameList.Size = new Size(121, 23);
            comboBoxGameList.TabIndex = 2;
            comboBoxGameList.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBoxNewName
            // 
            textBoxNewName.Location = new Point(379, 188);
            textBoxNewName.Name = "textBoxNewName";
            textBoxNewName.Size = new Size(100, 23);
            textBoxNewName.TabIndex = 3;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(379, 93);
            label.Name = "label";
            label.Size = new Size(96, 15);
            label.TabIndex = 4;
            label.Text = "Zmień nazwę na:";
            // 
            // labelGameList
            // 
            labelGameList.AutoSize = true;
            labelGameList.Location = new Point(167, 93);
            labelGameList.Name = "labelGameList";
            labelGameList.Size = new Size(120, 15);
            labelGameList.TabIndex = 5;
            labelGameList.Text = "Wybierz grę do edycji";
            // 
            // pictureBoxGameImage
            // 
            pictureBoxGameImage.Location = new Point(615, 36);
            pictureBoxGameImage.Name = "pictureBoxGameImage";
            pictureBoxGameImage.Size = new Size(910, 677);
            pictureBoxGameImage.TabIndex = 6;
            pictureBoxGameImage.TabStop = false;
            // 
            // EditGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 725);
            Controls.Add(pictureBoxGameImage);
            Controls.Add(labelGameList);
            Controls.Add(label);
            Controls.Add(textBoxNewName);
            Controls.Add(comboBoxGameList);
            Controls.Add(buttonEdit);
            Controls.Add(buttonCancel);
            Name = "EditGameForm";
            Text = "EditGameForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGameImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonEdit;
        private ComboBox comboBoxGameList;
        private TextBox textBoxNewName;
        private Label label;
        private Label labelGameList;
        private PictureBox pictureBoxGameImage;
    }
}