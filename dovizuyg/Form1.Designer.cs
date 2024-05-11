namespace dovizuyg
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            listBox1 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label8 = new Label();
            label7 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(562, 504);
            dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(580, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(152, 504);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 522);
            button1.Name = "button1";
            button1.Size = new Size(162, 47);
            button1.TabIndex = 2;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 533);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 3;
            label1.Text = "Son Güncelleme:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(339, 533);
            label9.Name = "label9";
            label9.Size = new Size(22, 25);
            label9.TabIndex = 4;
            label9.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(738, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 190);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alış";
            // 
            // button2
            // 
            button2.Location = new Point(28, 116);
            button2.Name = "button2";
            button2.Size = new Size(216, 52);
            button2.TabIndex = 4;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 33);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 29);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 1;
            label4.Text = "Miktar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 29);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 0;
            label3.Text = "Kur";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(744, 42);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 6;
            label5.Text = "Döviz";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(738, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 190);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Satış";
            // 
            // button3
            // 
            button3.Location = new Point(28, 116);
            button3.Name = "button3";
            button3.Size = new Size(216, 52);
            button3.TabIndex = 4;
            button3.Text = "Hesapla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(144, 57);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 33);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(28, 57);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 33);
            textBox3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 29);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 1;
            label6.Text = "Miktar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 29);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 0;
            label2.Text = "Kur";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(738, 491);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 7;
            label8.Text = "Toplam : ";
            // 
            // label7
            // 
            label7.Location = new Point(831, 491);
            label7.Name = "label7";
            label7.Size = new Size(173, 25);
            label7.TabIndex = 8;
            label7.Text = "label7";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1016, 576);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "Form1";
            Text = "Döviz Uygulaması";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ListBox listBox1;
        private Button button1;
        private Label label1;
        private Label label9;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Button button2;
        private GroupBox groupBox2;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private Label label2;
        private Label label8;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}
