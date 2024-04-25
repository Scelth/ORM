namespace HW1
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
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView = new DataGridView();
            allButton = new Button();
            maxButton = new Button();
            minButton = new Button();
            yourButton = new Button();
            yourTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 213;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(allButton, 0, 0);
            tableLayoutPanel1.Controls.Add(maxButton, 0, 1);
            tableLayoutPanel1.Controls.Add(minButton, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.49495F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.50505F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 152F));
            tableLayoutPanel1.Size = new Size(213, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.38422F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.61578F));
            tableLayoutPanel2.Controls.Add(yourButton, 1, 0);
            tableLayoutPanel2.Controls.Add(yourTextBox, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(583, 32);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 32);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(583, 418);
            dataGridView.TabIndex = 1;
            // 
            // allButton
            // 
            allButton.Dock = DockStyle.Fill;
            allButton.Location = new Point(3, 3);
            allButton.Name = "allButton";
            allButton.Size = new Size(207, 141);
            allButton.TabIndex = 0;
            allButton.Text = "Output all";
            allButton.UseVisualStyleBackColor = true;
            allButton.Click += allButton_Click;
            // 
            // maxButton
            // 
            maxButton.Dock = DockStyle.Fill;
            maxButton.Location = new Point(3, 150);
            maxButton.Name = "maxButton";
            maxButton.Size = new Size(207, 144);
            maxButton.TabIndex = 1;
            maxButton.Text = "Output maximum salary";
            maxButton.UseVisualStyleBackColor = true;
            // 
            // minButton
            // 
            minButton.Dock = DockStyle.Fill;
            minButton.Location = new Point(3, 300);
            minButton.Name = "minButton";
            minButton.Size = new Size(207, 147);
            minButton.TabIndex = 2;
            minButton.Text = "Output minimum salary";
            minButton.UseVisualStyleBackColor = true;
            // 
            // yourButton
            // 
            yourButton.Dock = DockStyle.Fill;
            yourButton.Location = new Point(425, 3);
            yourButton.Name = "yourButton";
            yourButton.Size = new Size(155, 26);
            yourButton.TabIndex = 0;
            yourButton.Text = "Output";
            yourButton.UseVisualStyleBackColor = true;
            // 
            // yourTextBox
            // 
            yourTextBox.Anchor = AnchorStyles.None;
            yourTextBox.Location = new Point(6, 4);
            yourTextBox.Name = "yourTextBox";
            yourTextBox.Size = new Size(409, 23);
            yourTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button allButton;
        private Button maxButton;
        private Button minButton;
        private DataGridView dataGridView;
        private TableLayoutPanel tableLayoutPanel2;
        private Button yourButton;
        private TextBox yourTextBox;
    }
}