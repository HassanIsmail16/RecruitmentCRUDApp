namespace RecruitmentApplication.Views
{
    partial class QuestionsForm
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
            labelAnswer = new Label();
            comboBoxQuestions = new ComboBox();
            SuspendLayout();
            // 
            // labelAnswer
            // 
            labelAnswer.AutoSize = true;
            labelAnswer.Location = new Point(417, 85);
            labelAnswer.Name = "labelAnswer";
            labelAnswer.Size = new Size(80, 15);
            labelAnswer.TabIndex = 1;
            labelAnswer.Text = "(Answer here)";
            // 
            // comboBoxQuestions
            // 
            comboBoxQuestions.FormattingEnabled = true;
            comboBoxQuestions.Location = new Point(44, 82);
            comboBoxQuestions.Name = "comboBoxQuestions";
            comboBoxQuestions.Size = new Size(282, 23);
            comboBoxQuestions.TabIndex = 2;
            // 
            // QuestionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 416);
            Controls.Add(comboBoxQuestions);
            Controls.Add(labelAnswer);
            Name = "QuestionsForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelAnswer;
        private ComboBox comboBoxQuestions;
    }
}