namespace time_sheet.Departaments_Editing
{
    partial class SubmitDepartamentChange
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
            submitchanges_TextBox = new TextBox();
            SubmitDepartamentChangeButton = new Button();
            submitchanges_Lable = new Label();
            SuspendLayout();
            // 
            // submitchanges_TextBox
            // 
            submitchanges_TextBox.Location = new Point(12, 91);
            submitchanges_TextBox.Name = "submitchanges_TextBox";
            submitchanges_TextBox.Size = new Size(482, 23);
            submitchanges_TextBox.TabIndex = 0;
            // 
            // SubmitDepartamentChangeButton
            // 
            SubmitDepartamentChangeButton.Location = new Point(204, 170);
            SubmitDepartamentChangeButton.Name = "SubmitDepartamentChangeButton";
            SubmitDepartamentChangeButton.Size = new Size(87, 23);
            SubmitDepartamentChangeButton.TabIndex = 1;
            SubmitDepartamentChangeButton.Text = "Подтвердить";
            SubmitDepartamentChangeButton.UseVisualStyleBackColor = true;
            SubmitDepartamentChangeButton.Click += SubmitDepartamentChangeButton_Click;
            // 
            // submitchanges_Lable
            // 
            submitchanges_Lable.AutoSize = true;
            submitchanges_Lable.Location = new Point(12, 56);
            submitchanges_Lable.Name = "submitchanges_Lable";
            submitchanges_Lable.Size = new Size(38, 15);
            submitchanges_Lable.TabIndex = 2;
            submitchanges_Lable.Text = "label1";
            submitchanges_Lable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SubmitDepartamentChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 218);
            Controls.Add(submitchanges_Lable);
            Controls.Add(SubmitDepartamentChangeButton);
            Controls.Add(submitchanges_TextBox);
            Name = "SubmitDepartamentChange";
            ShowIcon = false;
            Text = "Подтверждение";
            Load += SubmitDepartamentChange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox submitchanges_TextBox;
        private Button SubmitDepartamentChangeButton;
        private Label submitchanges_Lable;
    }
}