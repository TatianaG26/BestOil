namespace _27._04._23
{
    partial class BestOil
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kol_L = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cena = new System.Windows.Forms.TextBox();
            this.rB_sum = new System.Windows.Forms.RadioButton();
            this.rB_L = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.itogoAvto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.sum_grn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.price_croissant = new System.Windows.Forms.TextBox();
            this.price_hot_dog = new System.Windows.Forms.TextBox();
            this.price_burger = new System.Windows.Forms.TextBox();
            this.price_tea = new System.Windows.Forms.TextBox();
            this.price_coffee = new System.Windows.Forms.TextBox();
            this.croissant = new System.Windows.Forms.CheckBox();
            this.hot_dog = new System.Windows.Forms.CheckBox();
            this.burger = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tea = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.itogoCafe = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.coffee = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.labRezult = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Паливо";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "92",
            "95",
            "ДП"});
            this.comboBox1.Location = new System.Drawing.Point(77, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.kol_L);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Cena);
            this.groupBox1.Controls.Add(this.rB_sum);
            this.groupBox1.Controls.Add(this.rB_L);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 326);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(171, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "л.";
            // 
            // kol_L
            // 
            this.kol_L.Location = new System.Drawing.Point(109, 123);
            this.kol_L.Name = "kol_L";
            this.kol_L.Size = new System.Drawing.Size(56, 22);
            this.kol_L.TabIndex = 7;
            this.kol_L.TextChanged += new System.EventHandler(this.kol_L_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(159, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "грн.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ціна";
            // 
            // Cena
            // 
            this.Cena.Location = new System.Drawing.Point(77, 69);
            this.Cena.Name = "Cena";
            this.Cena.ReadOnly = true;
            this.Cena.Size = new System.Drawing.Size(76, 22);
            this.Cena.TabIndex = 4;
            // 
            // rB_sum
            // 
            this.rB_sum.AutoSize = true;
            this.rB_sum.ForeColor = System.Drawing.Color.Black;
            this.rB_sum.Location = new System.Drawing.Point(18, 152);
            this.rB_sum.Name = "rB_sum";
            this.rB_sum.Size = new System.Drawing.Size(62, 20);
            this.rB_sum.TabIndex = 3;
            this.rB_sum.Text = "Сума";
            this.rB_sum.UseVisualStyleBackColor = true;
            this.rB_sum.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rB_L
            // 
            this.rB_L.AutoSize = true;
            this.rB_L.ForeColor = System.Drawing.Color.Black;
            this.rB_L.Location = new System.Drawing.Point(18, 126);
            this.rB_L.Name = "rB_L";
            this.rB_L.Size = new System.Drawing.Size(85, 20);
            this.rB_L.TabIndex = 2;
            this.rB_L.Text = "Кількість";
            this.rB_L.UseVisualStyleBackColor = true;
            this.rB_L.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.itogoAvto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(18, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "До сплати";
            // 
            // itogoAvto
            // 
            this.itogoAvto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itogoAvto.ForeColor = System.Drawing.Color.DarkGreen;
            this.itogoAvto.Location = new System.Drawing.Point(6, 43);
            this.itogoAvto.Name = "itogoAvto";
            this.itogoAvto.Size = new System.Drawing.Size(114, 48);
            this.itogoAvto.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(126, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "грн.";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.sum_grn);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(6, 111);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(193, 78);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            // 
            // sum_grn
            // 
            this.sum_grn.Location = new System.Drawing.Point(99, 43);
            this.sum_grn.Name = "sum_grn";
            this.sum_grn.Size = new System.Drawing.Size(56, 22);
            this.sum_grn.TabIndex = 9;
            this.sum_grn.TextChanged += new System.EventHandler(this.kol_L_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(161, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "грн.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.price_croissant);
            this.groupBox3.Controls.Add(this.price_hot_dog);
            this.groupBox3.Controls.Add(this.price_burger);
            this.groupBox3.Controls.Add(this.price_tea);
            this.groupBox3.Controls.Add(this.price_coffee);
            this.groupBox3.Controls.Add(this.croissant);
            this.groupBox3.Controls.Add(this.hot_dog);
            this.groupBox3.Controls.Add(this.burger);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tea);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.coffee);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(239, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 326);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Міні-кафе";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(144, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Кількість";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(147, 144);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(56, 22);
            this.textBox10.TabIndex = 32;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(147, 120);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(56, 22);
            this.textBox9.TabIndex = 31;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(147, 94);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(56, 22);
            this.textBox8.TabIndex = 30;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(147, 69);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(56, 22);
            this.textBox7.TabIndex = 29;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(147, 43);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(56, 22);
            this.textBox6.TabIndex = 28;
            // 
            // price_croissant
            // 
            this.price_croissant.Location = new System.Drawing.Point(88, 144);
            this.price_croissant.Name = "price_croissant";
            this.price_croissant.ReadOnly = true;
            this.price_croissant.Size = new System.Drawing.Size(53, 22);
            this.price_croissant.TabIndex = 27;
            // 
            // price_hot_dog
            // 
            this.price_hot_dog.Location = new System.Drawing.Point(88, 118);
            this.price_hot_dog.Name = "price_hot_dog";
            this.price_hot_dog.ReadOnly = true;
            this.price_hot_dog.Size = new System.Drawing.Size(53, 22);
            this.price_hot_dog.TabIndex = 26;
            // 
            // price_burger
            // 
            this.price_burger.Location = new System.Drawing.Point(88, 94);
            this.price_burger.Name = "price_burger";
            this.price_burger.ReadOnly = true;
            this.price_burger.Size = new System.Drawing.Size(53, 22);
            this.price_burger.TabIndex = 25;
            // 
            // price_tea
            // 
            this.price_tea.Location = new System.Drawing.Point(88, 68);
            this.price_tea.Name = "price_tea";
            this.price_tea.ReadOnly = true;
            this.price_tea.Size = new System.Drawing.Size(53, 22);
            this.price_tea.TabIndex = 24;
            // 
            // price_coffee
            // 
            this.price_coffee.Location = new System.Drawing.Point(88, 43);
            this.price_coffee.Name = "price_coffee";
            this.price_coffee.ReadOnly = true;
            this.price_coffee.Size = new System.Drawing.Size(53, 22);
            this.price_coffee.TabIndex = 23;
            // 
            // croissant
            // 
            this.croissant.AutoSize = true;
            this.croissant.Location = new System.Drawing.Point(6, 146);
            this.croissant.Name = "croissant";
            this.croissant.Size = new System.Drawing.Size(84, 20);
            this.croissant.TabIndex = 22;
            this.croissant.Text = "Круасан";
            this.croissant.UseVisualStyleBackColor = true;
            this.croissant.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // hot_dog
            // 
            this.hot_dog.AutoSize = true;
            this.hot_dog.Location = new System.Drawing.Point(6, 120);
            this.hot_dog.Name = "hot_dog";
            this.hot_dog.Size = new System.Drawing.Size(78, 20);
            this.hot_dog.TabIndex = 21;
            this.hot_dog.Text = "Хот-дог";
            this.hot_dog.UseVisualStyleBackColor = true;
            this.hot_dog.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // burger
            // 
            this.burger.AutoSize = true;
            this.burger.Location = new System.Drawing.Point(6, 94);
            this.burger.Name = "burger";
            this.burger.Size = new System.Drawing.Size(76, 20);
            this.burger.TabIndex = 20;
            this.burger.Text = "Бургер";
            this.burger.UseVisualStyleBackColor = true;
            this.burger.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(96, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ціна";
            // 
            // tea
            // 
            this.tea.AutoSize = true;
            this.tea.Location = new System.Drawing.Point(6, 68);
            this.tea.Name = "tea";
            this.tea.Size = new System.Drawing.Size(54, 20);
            this.tea.TabIndex = 18;
            this.tea.Text = "Чай";
            this.tea.UseVisualStyleBackColor = true;
            this.tea.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.itogoCafe);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(21, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 100);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "До сплати";
            // 
            // itogoCafe
            // 
            this.itogoCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itogoCafe.ForeColor = System.Drawing.Color.DarkGreen;
            this.itogoCafe.Location = new System.Drawing.Point(6, 43);
            this.itogoCafe.Name = "itogoCafe";
            this.itogoCafe.Size = new System.Drawing.Size(114, 48);
            this.itogoCafe.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(126, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "грн.";
            // 
            // coffee
            // 
            this.coffee.AutoSize = true;
            this.coffee.Location = new System.Drawing.Point(6, 43);
            this.coffee.Name = "coffee";
            this.coffee.Size = new System.Drawing.Size(61, 20);
            this.coffee.TabIndex = 17;
            this.coffee.Text = "Кава";
            this.coffee.UseVisualStyleBackColor = true;
            this.coffee.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonResult);
            this.groupBox5.Controls.Add(this.labRezult);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(12, 344);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(440, 139);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ВСЬОГО до сплати";
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(116, 49);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(117, 44);
            this.buttonResult.TabIndex = 16;
            this.buttonResult.Text = "Розрахувати";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // labRezult
            // 
            this.labRezult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labRezult.ForeColor = System.Drawing.Color.DarkGreen;
            this.labRezult.Location = new System.Drawing.Point(244, 70);
            this.labRezult.Name = "labRezult";
            this.labRezult.Size = new System.Drawing.Size(114, 48);
            this.labRezult.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(371, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "грн.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_27._04._23.Properties.Resources._100х100;
            this.pictureBox1.Location = new System.Drawing.Point(6, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BestOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 495);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "BestOil";
            this.Text = "BestOil";
            this.Load += new System.EventHandler(this.BestOil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB_L;
        private System.Windows.Forms.RadioButton rB_sum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sum_grn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kol_L;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cena;
        private System.Windows.Forms.Label itogoAvto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label itogoCafe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox croissant;
        private System.Windows.Forms.CheckBox hot_dog;
        private System.Windows.Forms.CheckBox burger;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox tea;
        private System.Windows.Forms.CheckBox coffee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox price_croissant;
        private System.Windows.Forms.TextBox price_hot_dog;
        private System.Windows.Forms.TextBox price_burger;
        private System.Windows.Forms.TextBox price_tea;
        private System.Windows.Forms.TextBox price_coffee;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label labRezult;
        private System.Windows.Forms.Label label11;
    }
}

