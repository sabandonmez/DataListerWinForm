namespace DataListerWinForm
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
            dataLister = new DataGridView();
            listButton = new Button();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataLister).BeginInit();
            SuspendLayout();
            // 
            // dataLister
            // 
            dataLister.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataLister.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataLister.BackgroundColor = SystemColors.Control;
            dataLister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLister.Location = new Point(36, 34);
            dataLister.Name = "dataLister";
            dataLister.RowHeadersWidth = 51;
            dataLister.RowTemplate.Height = 29;
            dataLister.Size = new Size(548, 281);
            dataLister.TabIndex = 0;
            // 
            // listButton
            // 
            listButton.Location = new Point(36, 340);
            listButton.Name = "listButton";
            listButton.Size = new Size(153, 67);
            listButton.TabIndex = 1;
            listButton.Text = "Listele";
            listButton.UseVisualStyleBackColor = true;
            listButton.Click += listButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(195, 340);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(175, 67);
            clearButton.TabIndex = 2;
            clearButton.Text = "Temizle";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 450);
            Controls.Add(clearButton);
            Controls.Add(listButton);
            Controls.Add(dataLister);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataLister).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataLister;
        private Button listButton;
        private Button clearButton;
    }
}
