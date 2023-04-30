namespace time_sheet.Departaments_Editing
{
    partial class DepartamentsEditingForm
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
            AddDepartamentButton = new Button();
            departaments_listbox = new ListBox();
            EditDepartamentButton = new Button();
            DeleteDepartamentButton = new Button();
            SuspendLayout();
            // 
            // AddDepartamentButton
            // 
            AddDepartamentButton.Location = new Point(48, 42);
            AddDepartamentButton.Name = "AddDepartamentButton";
            AddDepartamentButton.Size = new Size(75, 23);
            AddDepartamentButton.TabIndex = 0;
            AddDepartamentButton.Text = "Добавить";
            AddDepartamentButton.UseVisualStyleBackColor = true;
            AddDepartamentButton.Click += AddDepartamentButton_Click;
            // 
            // departaments_listbox
            // 
            departaments_listbox.FormattingEnabled = true;
            departaments_listbox.ItemHeight = 15;
            departaments_listbox.Location = new Point(12, 93);
            departaments_listbox.Name = "departaments_listbox";
            departaments_listbox.Size = new Size(551, 349);
            departaments_listbox.TabIndex = 1;
            // 
            // EditDepartamentButton
            // 
            EditDepartamentButton.Location = new Point(226, 42);
            EditDepartamentButton.Name = "EditDepartamentButton";
            EditDepartamentButton.Size = new Size(75, 23);
            EditDepartamentButton.TabIndex = 2;
            EditDepartamentButton.Text = "Изменить";
            EditDepartamentButton.UseVisualStyleBackColor = true;
            EditDepartamentButton.Click += EditDepartamentButton_Click;
            // 
            // DeleteDepartamentButton
            // 
            DeleteDepartamentButton.Location = new Point(416, 42);
            DeleteDepartamentButton.Name = "DeleteDepartamentButton";
            DeleteDepartamentButton.Size = new Size(75, 23);
            DeleteDepartamentButton.TabIndex = 3;
            DeleteDepartamentButton.Text = "Удалить";
            DeleteDepartamentButton.UseVisualStyleBackColor = true;
            DeleteDepartamentButton.Click += DeleteDepartamentButton_Click;
            // 
            // DepartamentsEditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 450);
            Controls.Add(DeleteDepartamentButton);
            Controls.Add(EditDepartamentButton);
            Controls.Add(departaments_listbox);
            Controls.Add(AddDepartamentButton);
            Name = "DepartamentsEditingForm";
            ShowIcon = false;
            Text = "Редактирование Департаментов";
            FormClosed += DepartamentsEditingForm_FormClosed;
            Load += DepartamentsEditingForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button AddDepartamentButton;
        private ListBox departaments_listbox;
        private Button EditDepartamentButton;
        private Button DeleteDepartamentButton;
    }
}