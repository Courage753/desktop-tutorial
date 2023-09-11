namespace Client
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
            buttonadd = new Button();
            buttonmodify = new Button();
            buttondelete = new Button();
            buttonsearch = new Button();
            buttonclear = new Button();
            comboBox1 = new ComboBox();
            textBoxinput = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonadd
            // 
            buttonadd.Location = new Point(716, 169);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(75, 23);
            buttonadd.TabIndex = 1;
            buttonadd.Text = "添加";
            buttonadd.UseVisualStyleBackColor = true;
            buttonadd.Click += buttonadd_Click;
            // 
            // buttonmodify
            // 
            buttonmodify.Location = new Point(716, 198);
            buttonmodify.Name = "buttonmodify";
            buttonmodify.Size = new Size(75, 23);
            buttonmodify.TabIndex = 2;
            buttonmodify.Text = "修改";
            buttonmodify.UseVisualStyleBackColor = true;
            // 
            // buttondelete
            // 
            buttondelete.Location = new Point(716, 227);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(75, 23);
            buttondelete.TabIndex = 3;
            buttondelete.Text = "刪除";
            buttondelete.UseVisualStyleBackColor = true;
            buttondelete.Click += buttondelete_Click;
            // 
            // buttonsearch
            // 
            buttonsearch.Location = new Point(716, 256);
            buttonsearch.Name = "buttonsearch";
            buttonsearch.Size = new Size(75, 23);
            buttonsearch.TabIndex = 4;
            buttonsearch.Text = "查詢";
            buttonsearch.UseVisualStyleBackColor = true;
            // 
            // buttonclear
            // 
            buttonclear.Location = new Point(716, 285);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(75, 23);
            buttonclear.TabIndex = 5;
            buttonclear.Text = "清空";
            buttonclear.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "型號", "型體" });
            comboBox1.Location = new Point(589, 256);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // textBoxinput
            // 
            textBoxinput.Location = new Point(589, 285);
            textBoxinput.Name = "textBoxinput";
            textBoxinput.Size = new Size(121, 23);
            textBoxinput.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(571, 406);
            dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxinput);
            Controls.Add(comboBox1);
            Controls.Add(buttonclear);
            Controls.Add(buttonsearch);
            Controls.Add(buttondelete);
            Controls.Add(buttonmodify);
            Controls.Add(buttonadd);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonadd;
        private Button buttonmodify;
        private Button buttondelete;
        private Button buttonsearch;
        private Button buttonclear;
        private ComboBox comboBox1;
        private TextBox textBoxinput;
        private DataGridView dataGridView1;
    }
}