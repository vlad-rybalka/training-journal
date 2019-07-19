namespace my_work
{
    partial class Exercise
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.approach = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.Repetition = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.app1 = new System.Windows.Forms.Label();
            this.app2 = new System.Windows.Forms.Label();
            this.app3 = new System.Windows.Forms.Label();
            this.app4 = new System.Windows.Forms.Label();
            this.app5 = new System.Windows.Forms.Label();
            this.weightSum = new System.Windows.Forms.Label();
            this.repetition5 = new System.Windows.Forms.Label();
            this.repetition4 = new System.Windows.Forms.Label();
            this.repetitionSum = new System.Windows.Forms.Label();
            this.repetition3 = new System.Windows.Forms.Label();
            this.repetition2 = new System.Windows.Forms.Label();
            this.repetition1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.weight5 = new System.Windows.Forms.Label();
            this.weight4 = new System.Windows.Forms.Label();
            this.weight3 = new System.Windows.Forms.Label();
            this.weight2 = new System.Windows.Forms.Label();
            this.weight1 = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.name.Location = new System.Drawing.Point(5, 7);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(534, 28);
            this.name.TabIndex = 0;
            this.name.Text = "Жим";
            // 
            // approach
            // 
            this.approach.AutoSize = true;
            this.approach.BackColor = System.Drawing.Color.Transparent;
            this.approach.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.approach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.approach.Location = new System.Drawing.Point(11, 57);
            this.approach.Name = "approach";
            this.approach.Size = new System.Drawing.Size(91, 26);
            this.approach.TabIndex = 1;
            this.approach.Text = "Подходы";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.BackColor = System.Drawing.Color.Transparent;
            this.Weight.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.Weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.Weight.Location = new System.Drawing.Point(11, 101);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(82, 26);
            this.Weight.TabIndex = 2;
            this.Weight.Text = "Вес (кг)";
            // 
            // Repetition
            // 
            this.Repetition.AutoSize = true;
            this.Repetition.BackColor = System.Drawing.Color.Transparent;
            this.Repetition.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.Repetition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.Repetition.Location = new System.Drawing.Point(11, 144);
            this.Repetition.Name = "Repetition";
            this.Repetition.Size = new System.Drawing.Size(172, 26);
            this.Repetition.TabIndex = 3;
            this.Repetition.Text = "Повторения (раз)";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BackgroundImage = global::my_work.Properties.Resources.closeButton;
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(587, 10);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(15, 15);
            this.delete.TabIndex = 4;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // app1
            // 
            this.app1.AutoSize = true;
            this.app1.BackColor = System.Drawing.Color.Transparent;
            this.app1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.app1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.app1.Location = new System.Drawing.Point(239, 57);
            this.app1.Name = "app1";
            this.app1.Size = new System.Drawing.Size(0, 26);
            this.app1.TabIndex = 5;
            // 
            // app2
            // 
            this.app2.AutoSize = true;
            this.app2.BackColor = System.Drawing.Color.Transparent;
            this.app2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.app2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.app2.Location = new System.Drawing.Point(304, 57);
            this.app2.Name = "app2";
            this.app2.Size = new System.Drawing.Size(0, 26);
            this.app2.TabIndex = 6;
            // 
            // app3
            // 
            this.app3.AutoSize = true;
            this.app3.BackColor = System.Drawing.Color.Transparent;
            this.app3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.app3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.app3.Location = new System.Drawing.Point(369, 57);
            this.app3.Name = "app3";
            this.app3.Size = new System.Drawing.Size(0, 26);
            this.app3.TabIndex = 7;
            // 
            // app4
            // 
            this.app4.AutoSize = true;
            this.app4.BackColor = System.Drawing.Color.Transparent;
            this.app4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.app4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.app4.Location = new System.Drawing.Point(434, 57);
            this.app4.Name = "app4";
            this.app4.Size = new System.Drawing.Size(0, 26);
            this.app4.TabIndex = 8;
            // 
            // app5
            // 
            this.app5.AutoSize = true;
            this.app5.BackColor = System.Drawing.Color.Transparent;
            this.app5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.app5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.app5.Location = new System.Drawing.Point(499, 57);
            this.app5.Name = "app5";
            this.app5.Size = new System.Drawing.Size(0, 26);
            this.app5.TabIndex = 9;
            // 
            // weightSum
            // 
            this.weightSum.AutoSize = true;
            this.weightSum.BackColor = System.Drawing.Color.Transparent;
            this.weightSum.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.weightSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.weightSum.Location = new System.Drawing.Point(564, 101);
            this.weightSum.Name = "weightSum";
            this.weightSum.Size = new System.Drawing.Size(24, 26);
            this.weightSum.TabIndex = 14;
            this.weightSum.Text = "0";
            this.weightSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repetition5
            // 
            this.repetition5.AutoSize = true;
            this.repetition5.BackColor = System.Drawing.Color.Transparent;
            this.repetition5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.repetition5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.repetition5.Location = new System.Drawing.Point(499, 144);
            this.repetition5.Name = "repetition5";
            this.repetition5.Size = new System.Drawing.Size(0, 26);
            this.repetition5.TabIndex = 21;
            // 
            // repetition4
            // 
            this.repetition4.AutoSize = true;
            this.repetition4.BackColor = System.Drawing.Color.Transparent;
            this.repetition4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.repetition4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.repetition4.Location = new System.Drawing.Point(434, 144);
            this.repetition4.Name = "repetition4";
            this.repetition4.Size = new System.Drawing.Size(0, 26);
            this.repetition4.TabIndex = 19;
            // 
            // repetitionSum
            // 
            this.repetitionSum.AutoSize = true;
            this.repetitionSum.BackColor = System.Drawing.Color.Transparent;
            this.repetitionSum.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.repetitionSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.repetitionSum.Location = new System.Drawing.Point(564, 144);
            this.repetitionSum.Name = "repetitionSum";
            this.repetitionSum.Size = new System.Drawing.Size(24, 26);
            this.repetitionSum.TabIndex = 20;
            this.repetitionSum.Text = "0";
            // 
            // repetition3
            // 
            this.repetition3.AutoSize = true;
            this.repetition3.BackColor = System.Drawing.Color.Transparent;
            this.repetition3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.repetition3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.repetition3.Location = new System.Drawing.Point(369, 144);
            this.repetition3.Name = "repetition3";
            this.repetition3.Size = new System.Drawing.Size(0, 26);
            this.repetition3.TabIndex = 18;
            // 
            // repetition2
            // 
            this.repetition2.AutoSize = true;
            this.repetition2.BackColor = System.Drawing.Color.Transparent;
            this.repetition2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.repetition2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.repetition2.Location = new System.Drawing.Point(304, 144);
            this.repetition2.Name = "repetition2";
            this.repetition2.Size = new System.Drawing.Size(0, 26);
            this.repetition2.TabIndex = 17;
            // 
            // repetition1
            // 
            this.repetition1.AutoSize = true;
            this.repetition1.BackColor = System.Drawing.Color.Transparent;
            this.repetition1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.repetition1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.repetition1.Location = new System.Drawing.Point(239, 144);
            this.repetition1.Name = "repetition1";
            this.repetition1.Size = new System.Drawing.Size(0, 26);
            this.repetition1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label4.Location = new System.Drawing.Point(564, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "∑";
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.BackgroundImage = global::my_work.Properties.Resources.editButton;
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Location = new System.Drawing.Point(555, 8);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(20, 20);
            this.edit.TabIndex = 23;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // weight5
            // 
            this.weight5.AutoSize = true;
            this.weight5.BackColor = System.Drawing.Color.Transparent;
            this.weight5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.weight5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.weight5.Location = new System.Drawing.Point(499, 101);
            this.weight5.Name = "weight5";
            this.weight5.Size = new System.Drawing.Size(0, 26);
            this.weight5.TabIndex = 28;
            // 
            // weight4
            // 
            this.weight4.AutoSize = true;
            this.weight4.BackColor = System.Drawing.Color.Transparent;
            this.weight4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.weight4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.weight4.Location = new System.Drawing.Point(434, 101);
            this.weight4.Name = "weight4";
            this.weight4.Size = new System.Drawing.Size(0, 26);
            this.weight4.TabIndex = 27;
            // 
            // weight3
            // 
            this.weight3.AutoSize = true;
            this.weight3.BackColor = System.Drawing.Color.Transparent;
            this.weight3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.weight3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.weight3.Location = new System.Drawing.Point(369, 101);
            this.weight3.Name = "weight3";
            this.weight3.Size = new System.Drawing.Size(0, 26);
            this.weight3.TabIndex = 26;
            // 
            // weight2
            // 
            this.weight2.AutoSize = true;
            this.weight2.BackColor = System.Drawing.Color.Transparent;
            this.weight2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.weight2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.weight2.Location = new System.Drawing.Point(304, 101);
            this.weight2.Name = "weight2";
            this.weight2.Size = new System.Drawing.Size(0, 26);
            this.weight2.TabIndex = 25;
            // 
            // weight1
            // 
            this.weight1.AutoSize = true;
            this.weight1.BackColor = System.Drawing.Color.Transparent;
            this.weight1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.weight1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.weight1.Location = new System.Drawing.Point(239, 101);
            this.weight1.Name = "weight1";
            this.weight1.Size = new System.Drawing.Size(0, 26);
            this.weight1.TabIndex = 24;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Transparent;
            this.infoPanel.BackgroundImage = global::my_work.Properties.Resources.UI1;
            this.infoPanel.Location = new System.Drawing.Point(263, 57);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(263, 113);
            this.infoPanel.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(756, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(691, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(626, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label5.Location = new System.Drawing.Point(561, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 26);
            this.label5.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label6.Location = new System.Drawing.Point(496, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 26);
            this.label6.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label7.Location = new System.Drawing.Point(756, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 26);
            this.label7.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label8.Location = new System.Drawing.Point(691, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 26);
            this.label8.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label9.Location = new System.Drawing.Point(626, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 26);
            this.label9.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label10.Location = new System.Drawing.Point(561, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 26);
            this.label10.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label11.Location = new System.Drawing.Point(496, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 26);
            this.label11.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label12.Location = new System.Drawing.Point(756, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 26);
            this.label12.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label13.Location = new System.Drawing.Point(691, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 26);
            this.label13.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label14.Location = new System.Drawing.Point(626, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 26);
            this.label14.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label15.Location = new System.Drawing.Point(561, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 26);
            this.label15.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label16.Location = new System.Drawing.Point(496, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 26);
            this.label16.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label17.Location = new System.Drawing.Point(268, 244);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 26);
            this.label17.TabIndex = 30;
            this.label17.Text = "Повторения (раз)";
            // 
            // Exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::my_work.Properties.Resources.ExerciseBG;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.weight5);
            this.Controls.Add(this.weight4);
            this.Controls.Add(this.weight3);
            this.Controls.Add(this.weight2);
            this.Controls.Add(this.weight1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.repetition5);
            this.Controls.Add(this.repetition4);
            this.Controls.Add(this.repetitionSum);
            this.Controls.Add(this.repetition3);
            this.Controls.Add(this.repetition2);
            this.Controls.Add(this.repetition1);
            this.Controls.Add(this.weightSum);
            this.Controls.Add(this.app5);
            this.Controls.Add(this.app4);
            this.Controls.Add(this.app3);
            this.Controls.Add(this.app2);
            this.Controls.Add(this.app1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Repetition);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.approach);
            this.Controls.Add(this.name);
            this.Controls.Add(this.infoPanel);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.Name = "Exercise";
            this.Size = new System.Drawing.Size(615, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label approach;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label Repetition;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label app1;
        private System.Windows.Forms.Label app2;
        private System.Windows.Forms.Label app3;
        private System.Windows.Forms.Label app4;
        private System.Windows.Forms.Label app5;
        private System.Windows.Forms.Label weightSum;
        private System.Windows.Forms.Label repetition5;
        private System.Windows.Forms.Label repetition4;
        private System.Windows.Forms.Label repetitionSum;
        private System.Windows.Forms.Label repetition3;
        private System.Windows.Forms.Label repetition2;
        private System.Windows.Forms.Label repetition1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label weight5;
        private System.Windows.Forms.Label weight4;
        private System.Windows.Forms.Label weight3;
        private System.Windows.Forms.Label weight2;
        private System.Windows.Forms.Label weight1;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}
