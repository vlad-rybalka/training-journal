namespace my_work
{
    partial class EditExercise
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.repetition = new System.Windows.Forms.NumericUpDown();
            this.listApproaches = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repetition)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.button2.Location = new System.Drawing.Point(12, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 74);
            this.button2.TabIndex = 14;
            this.button2.Text = "Добавить подход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Вес (кг)";
            // 
            // weight
            // 
            this.weight.DecimalPlaces = 2;
            this.weight.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.weight.Location = new System.Drawing.Point(13, 114);
            this.weight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(119, 31);
            this.weight.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Повторения (раз)";
            // 
            // repetition
            // 
            this.repetition.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.repetition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.repetition.Location = new System.Drawing.Point(12, 53);
            this.repetition.Name = "repetition";
            this.repetition.Size = new System.Drawing.Size(120, 31);
            this.repetition.TabIndex = 10;
            // 
            // listApproaches
            // 
            this.listApproaches.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.listApproaches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.listApproaches.FormattingEnabled = true;
            this.listApproaches.ItemHeight = 24;
            this.listApproaches.Location = new System.Drawing.Point(138, 30);
            this.listApproaches.Name = "listApproaches";
            this.listApproaches.Size = new System.Drawing.Size(350, 148);
            this.listApproaches.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.button1.Location = new System.Drawing.Point(232, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Удалить подход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.delete_Click);
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
            this.Close.Location = new System.Drawing.Point(473, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(26, 24);
            this.Close.TabIndex = 18;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // moveUp
            // 
            this.moveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.moveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveUp.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.moveUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.moveUp.Location = new System.Drawing.Point(138, 184);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(41, 41);
            this.moveUp.TabIndex = 19;
            this.moveUp.Text = "↑";
            this.moveUp.UseVisualStyleBackColor = false;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveDown
            // 
            this.moveDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.moveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveDown.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.moveDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.moveDown.Location = new System.Drawing.Point(185, 184);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(41, 41);
            this.moveDown.TabIndex = 20;
            this.moveDown.Text = "↓";
            this.moveDown.UseVisualStyleBackColor = false;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // EditExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::my_work.Properties.Resources.EditProgramBG;
            this.ClientSize = new System.Drawing.Size(500, 235);
            this.Controls.Add(this.moveDown);
            this.Controls.Add(this.moveUp);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listApproaches);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.repetition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditExercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditExercisecs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditExercise_FormClosed);
            this.Load += new System.EventHandler(this.EditExercise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repetition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown weight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown repetition;
        private System.Windows.Forms.ListBox listApproaches;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveDown;
    }
}