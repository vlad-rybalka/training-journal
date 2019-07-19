namespace my_work
{
    partial class AddExercise
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
            this.exerciseBox = new System.Windows.Forms.ComboBox();
            this.exerciseName = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.groupName = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exerciseBox
            // 
            this.exerciseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exerciseBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.exerciseBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.exerciseBox.FormattingEnabled = true;
            this.exerciseBox.Items.AddRange(new object[] {
            "Жим",
            "Подтягивания",
            "Разводка"});
            this.exerciseBox.Location = new System.Drawing.Point(8, 120);
            this.exerciseBox.Name = "exerciseBox";
            this.exerciseBox.Size = new System.Drawing.Size(460, 34);
            this.exerciseBox.TabIndex = 0;
            // 
            // exerciseName
            // 
            this.exerciseName.AutoSize = true;
            this.exerciseName.BackColor = System.Drawing.Color.Transparent;
            this.exerciseName.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.exerciseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.exerciseName.Location = new System.Drawing.Point(3, 91);
            this.exerciseName.Name = "exerciseName";
            this.exerciseName.Size = new System.Drawing.Size(228, 26);
            this.exerciseName.TabIndex = 2;
            this.exerciseName.Text = "Выберите упражнение:";
            // 
            // add
            // 
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.add.Location = new System.Drawing.Point(8, 170);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(460, 38);
            this.add.TabIndex = 5;
            this.add.Text = "Добавить упражнение";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // groupName
            // 
            this.groupName.AutoSize = true;
            this.groupName.BackColor = System.Drawing.Color.Transparent;
            this.groupName.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.groupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.groupName.Location = new System.Drawing.Point(3, 20);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(213, 26);
            this.groupName.TabIndex = 10;
            this.groupName.Text = "Выберите категорию:";
            // 
            // groupBox
            // 
            this.groupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Items.AddRange(new object[] {
            "Бицепс",
            "Трицепс",
            "Предплечья",
            "Грудь",
            "Плечи",
            "Пресс",
            "Спина ",
            "Ноги"});
            this.groupBox.Location = new System.Drawing.Point(8, 49);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(460, 34);
            this.groupBox.TabIndex = 9;
            this.groupBox.SelectedIndexChanged += new System.EventHandler(this.groupBox_SelectedIndexChanged);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.Close.Location = new System.Drawing.Point(452, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(26, 24);
            this.Close.TabIndex = 11;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // AddExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::my_work.Properties.Resources.AddExerciseFormBG;
            this.ClientSize = new System.Drawing.Size(480, 220);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.add);
            this.Controls.Add(this.exerciseName);
            this.Controls.Add(this.exerciseBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddExercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление упражнения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddExercise_FormClosed);
            this.Load += new System.EventHandler(this.AddExercise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox exerciseBox;
        private System.Windows.Forms.Label exerciseName;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label groupName;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.Button Close;
    }
}