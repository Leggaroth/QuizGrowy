namespace ProjektDextop
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
            pictureBox1 = new PictureBox();
            buttonSubmit = new Button();
            buttonStart = new Button();
            buttonRemoveQuestion = new Button();
            buttonAddQuestion = new Button();
            textBoxAnswer = new TextBox();
            listBoxHints = new ListBox();
            labelCounter = new Label();
            buttonEditQuestion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(64, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 720);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(922, 784);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 1;
            buttonSubmit.Text = "Zgaduj!";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(1475, 686);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 75);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Rozpocznij Quiz";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonRemoveQuestion
            // 
            buttonRemoveQuestion.Location = new Point(1475, 484);
            buttonRemoveQuestion.Name = "buttonRemoveQuestion";
            buttonRemoveQuestion.Size = new Size(75, 75);
            buttonRemoveQuestion.TabIndex = 3;
            buttonRemoveQuestion.Text = "Usuń Pytanie";
            buttonRemoveQuestion.UseVisualStyleBackColor = true;
            buttonRemoveQuestion.Click += buttonRemoveQuestion_Click;
            // 
            // buttonAddQuestion
            // 
            buttonAddQuestion.Location = new Point(1475, 173);
            buttonAddQuestion.Name = "buttonAddQuestion";
            buttonAddQuestion.Size = new Size(75, 75);
            buttonAddQuestion.TabIndex = 4;
            buttonAddQuestion.Text = "Dodaj Pytanie";
            buttonAddQuestion.UseVisualStyleBackColor = true;
            buttonAddQuestion.Click += buttonAddQuestion_Click;
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Location = new Point(315, 785);
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(525, 23);
            textBoxAnswer.TabIndex = 5;
            textBoxAnswer.TextChanged += textBoxAnswer_TextChanged;
            // 
            // listBoxHints
            // 
            listBoxHints.FormattingEnabled = true;
            listBoxHints.ItemHeight = 15;
            listBoxHints.Location = new Point(315, 812);
            listBoxHints.Name = "listBoxHints";
            listBoxHints.Size = new Size(525, 94);
            listBoxHints.TabIndex = 6;
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Location = new Point(1485, 41);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(0, 15);
            labelCounter.TabIndex = 7;
            // 
            // buttonEditQuestion
            // 
            buttonEditQuestion.Location = new Point(1475, 334);
            buttonEditQuestion.Name = "buttonEditQuestion";
            buttonEditQuestion.Size = new Size(75, 75);
            buttonEditQuestion.TabIndex = 8;
            buttonEditQuestion.Text = "Edytuj Pytanie";
            buttonEditQuestion.UseVisualStyleBackColor = true;
            buttonEditQuestion.Click += buttonEditQuestion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 918);
            Controls.Add(buttonEditQuestion);
            Controls.Add(labelCounter);
            Controls.Add(listBoxHints);
            Controls.Add(textBoxAnswer);
            Controls.Add(buttonAddQuestion);
            Controls.Add(buttonRemoveQuestion);
            Controls.Add(buttonStart);
            Controls.Add(buttonSubmit);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonSubmit;
        private Button buttonStart;
        private Button buttonRemoveQuestion;
        private Button buttonAddQuestion;
        private TextBox textBoxAnswer;
        private ListBox listBoxHints;
        private Label labelCounter;
        private Button buttonEditQuestion;
    }
}
