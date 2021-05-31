namespace _10_Game
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b_computer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.b_player = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.l_comp1 = new System.Windows.Forms.Label();
            this.l_comp2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_pl1 = new System.Windows.Forms.Label();
            this.l_pl2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_winner = new System.Windows.Forms.Label();
            this.l_csum = new System.Windows.Forms.Label();
            this.l_psum = new System.Windows.Forms.Label();
            this.csum = new System.Windows.Forms.Label();
            this.psum = new System.Windows.Forms.Label();
            this.b_winner = new System.Windows.Forms.Button();
            this.winner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Правило:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.MaximumSize = new System.Drawing.Size(600, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Каждый игрок бросает одновременно два кубика. Сумма очков должна быть максимально" +
    " близка 10. Тот игрок, чья сумма очков в кубиках ближе всего к 10, побеждает.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Компьютер бросает кубик:";
            // 
            // b_computer
            // 
            this.b_computer.Location = new System.Drawing.Point(260, 191);
            this.b_computer.Name = "b_computer";
            this.b_computer.Size = new System.Drawing.Size(170, 33);
            this.b_computer.TabIndex = 3;
            this.b_computer.Text = "Бросить кубик";
            this.b_computer.UseVisualStyleBackColor = true;
            this.b_computer.Click += new System.EventHandler(this.b_computer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Игрок бросает кубик:";
            // 
            // b_player
            // 
            this.b_player.Location = new System.Drawing.Point(260, 252);
            this.b_player.Name = "b_player";
            this.b_player.Size = new System.Drawing.Size(170, 33);
            this.b_player.TabIndex = 5;
            this.b_player.Text = "Бросить кубик";
            this.b_player.UseVisualStyleBackColor = true;
            this.b_player.Click += new System.EventHandler(this.b_player_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(36, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Очки компьютера:";
            // 
            // l_comp1
            // 
            this.l_comp1.AutoSize = true;
            this.l_comp1.Location = new System.Drawing.Point(184, 324);
            this.l_comp1.Name = "l_comp1";
            this.l_comp1.Size = new System.Drawing.Size(16, 17);
            this.l_comp1.TabIndex = 7;
            this.l_comp1.Text = "_";
            // 
            // l_comp2
            // 
            this.l_comp2.AutoSize = true;
            this.l_comp2.Location = new System.Drawing.Point(184, 358);
            this.l_comp2.Name = "l_comp2";
            this.l_comp2.Size = new System.Drawing.Size(16, 17);
            this.l_comp2.TabIndex = 8;
            this.l_comp2.Text = "_";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(36, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Очки игрока:";
            // 
            // l_pl1
            // 
            this.l_pl1.AutoSize = true;
            this.l_pl1.Location = new System.Drawing.Point(184, 416);
            this.l_pl1.Name = "l_pl1";
            this.l_pl1.Size = new System.Drawing.Size(16, 17);
            this.l_pl1.TabIndex = 10;
            this.l_pl1.Text = "_";
            // 
            // l_pl2
            // 
            this.l_pl2.AutoSize = true;
            this.l_pl2.Location = new System.Drawing.Point(184, 452);
            this.l_pl2.Name = "l_pl2";
            this.l_pl2.Size = new System.Drawing.Size(16, 17);
            this.l_pl2.TabIndex = 11;
            this.l_pl2.Text = "_";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(463, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Поздравляем победителя:";
            // 
            // l_winner
            // 
            this.l_winner.AutoSize = true;
            this.l_winner.Location = new System.Drawing.Point(428, 432);
            this.l_winner.Name = "l_winner";
            this.l_winner.Size = new System.Drawing.Size(12, 17);
            this.l_winner.TabIndex = 13;
            this.l_winner.Text = ".";
            // 
            // l_csum
            // 
            this.l_csum.AutoSize = true;
            this.l_csum.Location = new System.Drawing.Point(271, 346);
            this.l_csum.Name = "l_csum";
            this.l_csum.Size = new System.Drawing.Size(58, 17);
            this.l_csum.TabIndex = 14;
            this.l_csum.Text = "Сумма: ";
            // 
            // l_psum
            // 
            this.l_psum.AutoSize = true;
            this.l_psum.Location = new System.Drawing.Point(271, 432);
            this.l_psum.Name = "l_psum";
            this.l_psum.Size = new System.Drawing.Size(58, 17);
            this.l_psum.TabIndex = 15;
            this.l_psum.Text = "Сумма: ";
            // 
            // csum
            // 
            this.csum.AutoSize = true;
            this.csum.Location = new System.Drawing.Point(352, 346);
            this.csum.Name = "csum";
            this.csum.Size = new System.Drawing.Size(16, 17);
            this.csum.TabIndex = 16;
            this.csum.Text = "_";
            // 
            // psum
            // 
            this.psum.AutoSize = true;
            this.psum.Location = new System.Drawing.Point(355, 432);
            this.psum.Name = "psum";
            this.psum.Size = new System.Drawing.Size(16, 17);
            this.psum.TabIndex = 17;
            this.psum.Text = "_";
            // 
            // b_winner
            // 
            this.b_winner.Location = new System.Drawing.Point(468, 252);
            this.b_winner.Name = "b_winner";
            this.b_winner.Size = new System.Drawing.Size(286, 33);
            this.b_winner.TabIndex = 18;
            this.b_winner.Text = "Узнать победителя";
            this.b_winner.UseVisualStyleBackColor = true;
            this.b_winner.Click += new System.EventHandler(this.b_winner_Click);
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.Location = new System.Drawing.Point(560, 324);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(88, 17);
            this.winner.TabIndex = 19;
            this.winner.Text = "__________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.b_winner);
            this.Controls.Add(this.psum);
            this.Controls.Add(this.csum);
            this.Controls.Add(this.l_psum);
            this.Controls.Add(this.l_csum);
            this.Controls.Add(this.l_winner);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.l_pl2);
            this.Controls.Add(this.l_pl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l_comp2);
            this.Controls.Add(this.l_comp1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b_player);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_computer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_computer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_player;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l_comp1;
        private System.Windows.Forms.Label l_comp2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_pl1;
        private System.Windows.Forms.Label l_pl2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_winner;
        private System.Windows.Forms.Label l_csum;
        private System.Windows.Forms.Label l_psum;
        private System.Windows.Forms.Label csum;
        private System.Windows.Forms.Label psum;
        private System.Windows.Forms.Button b_winner;
        private System.Windows.Forms.Label winner;
    }
}

