namespace BombsAway
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WorldFrame = new System.Windows.Forms.Panel();
            this.label_Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.cloud = new System.Windows.Forms.PictureBox();
            this.pb_NPC2 = new System.Windows.Forms.PictureBox();
            this.pb_NPC1 = new System.Windows.Forms.PictureBox();
            this.label_Dead = new System.Windows.Forms.Label();
            this.pb_Block1 = new System.Windows.Forms.PictureBox();
            this.pb_Block2 = new System.Windows.Forms.PictureBox();
            this.pb_Pipe = new System.Windows.Forms.PictureBox();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.timer_Gravity = new System.Windows.Forms.Timer(this.components);
            this.timer_Jump = new System.Windows.Forms.Timer(this.components);
            this.timer_Anim = new System.Windows.Forms.Timer(this.components);
            this.timer_Randombomb = new System.Windows.Forms.Timer(this.components);
            this.timer_BombFailsafe = new System.Windows.Forms.Timer(this.components);
            this.timer_Sec = new System.Windows.Forms.Timer(this.components);
            this.timerBoomRemove = new System.Windows.Forms.Timer(this.components);
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            this.timerCloud = new System.Windows.Forms.Timer(this.components);
            this.WorldFloor = new System.Windows.Forms.Panel();
            this.timerCloud2 = new System.Windows.Forms.Timer(this.components);
            this.scrollingTimer = new System.Windows.Forms.Timer(this.components);
            this.WorldFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // WorldFrame
            // 
            this.WorldFrame.BackColor = System.Drawing.Color.SkyBlue;
            this.WorldFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WorldFrame.Controls.Add(this.label_Score);
            this.WorldFrame.Controls.Add(this.label2);
            this.WorldFrame.Controls.Add(this.label3);
            this.WorldFrame.Controls.Add(this.cloud2);
            this.WorldFrame.Controls.Add(this.cloud);
            this.WorldFrame.Controls.Add(this.pb_NPC2);
            this.WorldFrame.Controls.Add(this.pb_NPC1);
            this.WorldFrame.Controls.Add(this.label_Dead);
            this.WorldFrame.Controls.Add(this.pb_Block1);
            this.WorldFrame.Controls.Add(this.pb_Block2);
            this.WorldFrame.Controls.Add(this.pb_Pipe);
            this.WorldFrame.Controls.Add(this.pb_Player);
            this.WorldFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorldFrame.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorldFrame.Location = new System.Drawing.Point(0, 0);
            this.WorldFrame.Margin = new System.Windows.Forms.Padding(4);
            this.WorldFrame.Name = "WorldFrame";
            this.WorldFrame.Size = new System.Drawing.Size(875, 308);
            this.WorldFrame.TabIndex = 0;
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.BackColor = System.Drawing.Color.Transparent;
            this.label_Score.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score.Location = new System.Drawing.Point(6, 0);
            this.label_Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(72, 17);
            this.label_Score.TabIndex = 16;
            this.label_Score.Text = "Score: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(98, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Highscore: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(740, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Coin score: 0";
            // 
            // cloud2
            // 
            this.cloud2.Image = global::BombsAway.Properties.Resources.ішяу1;
            this.cloud2.Location = new System.Drawing.Point(420, 41);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(63, 42);
            this.cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cloud2.TabIndex = 14;
            this.cloud2.TabStop = false;
            this.cloud2.Tag = "cloud";
            // 
            // cloud
            // 
            this.cloud.Image = global::BombsAway.Properties.Resources.ішяу1;
            this.cloud.Location = new System.Drawing.Point(178, 12);
            this.cloud.Name = "cloud";
            this.cloud.Size = new System.Drawing.Size(65, 47);
            this.cloud.TabIndex = 13;
            this.cloud.TabStop = false;
            this.cloud.Tag = "cloud";
            // 
            // pb_NPC2
            // 
            this.pb_NPC2.Image = global::BombsAway.Enemy.Enemy_left;
            this.pb_NPC2.Location = new System.Drawing.Point(51, 79);
            this.pb_NPC2.Margin = new System.Windows.Forms.Padding(4);
            this.pb_NPC2.Name = "pb_NPC2";
            this.pb_NPC2.Size = new System.Drawing.Size(27, 25);
            this.pb_NPC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_NPC2.TabIndex = 10;
            this.pb_NPC2.TabStop = false;
            // 
            // pb_NPC1
            // 
            this.pb_NPC1.Image = global::BombsAway.Properties.Resources.Enemy_right;
            this.pb_NPC1.Location = new System.Drawing.Point(16, 79);
            this.pb_NPC1.Margin = new System.Windows.Forms.Padding(4);
            this.pb_NPC1.Name = "pb_NPC1";
            this.pb_NPC1.Size = new System.Drawing.Size(27, 25);
            this.pb_NPC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_NPC1.TabIndex = 9;
            this.pb_NPC1.TabStop = false;
            // 
            // label_Dead
            // 
            this.label_Dead.AutoSize = true;
            this.label_Dead.BackColor = System.Drawing.Color.Transparent;
            this.label_Dead.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dead.Location = new System.Drawing.Point(306, 100);
            this.label_Dead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Dead.Name = "label_Dead";
            this.label_Dead.Size = new System.Drawing.Size(248, 17);
            this.label_Dead.TabIndex = 1;
            this.label_Dead.Text = "You died, press Space to start";
            this.label_Dead.Visible = false;
            // 
            // pb_Block1
            // 
            this.pb_Block1.BackColor = System.Drawing.Color.Gray;
            this.pb_Block1.BackgroundImage = global::BombsAway.World.Platform;
            this.pb_Block1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Block1.Location = new System.Drawing.Point(601, 230);
            this.pb_Block1.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Block1.Name = "pb_Block1";
            this.pb_Block1.Size = new System.Drawing.Size(201, 29);
            this.pb_Block1.TabIndex = 8;
            this.pb_Block1.TabStop = false;
            // 
            // pb_Block2
            // 
            this.pb_Block2.BackColor = System.Drawing.Color.Gray;
            this.pb_Block2.BackgroundImage = global::BombsAway.World.Platform;
            this.pb_Block2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Block2.Location = new System.Drawing.Point(64, 194);
            this.pb_Block2.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Block2.Name = "pb_Block2";
            this.pb_Block2.Size = new System.Drawing.Size(179, 29);
            this.pb_Block2.TabIndex = 7;
            this.pb_Block2.TabStop = false;
            // 
            // pb_Pipe
            // 
            this.pb_Pipe.BackgroundImage = global::BombsAway.World.pillar__8_;
            this.pb_Pipe.Location = new System.Drawing.Point(333, 249);
            this.pb_Pipe.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Pipe.Name = "pb_Pipe";
            this.pb_Pipe.Size = new System.Drawing.Size(47, 55);
            this.pb_Pipe.TabIndex = 5;
            this.pb_Pipe.TabStop = false;
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Transparent;
            this.pb_Player.Image = global::BombsAway.Character.stand_r;
            this.pb_Player.Location = new System.Drawing.Point(16, 116);
            this.pb_Player.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(21, 39);
            this.pb_Player.TabIndex = 0;
            this.pb_Player.TabStop = false;
            // 
            // timer_Gravity
            // 
            this.timer_Gravity.Enabled = true;
            this.timer_Gravity.Interval = 1;
            this.timer_Gravity.Tick += new System.EventHandler(this.timer_Gravity_Tick);
            // 
            // timer_Jump
            // 
            this.timer_Jump.Enabled = true;
            this.timer_Jump.Interval = 1;
            this.timer_Jump.Tick += new System.EventHandler(this.timer_Jump_Tick);
            // 
            // timer_Anim
            // 
            this.timer_Anim.Enabled = true;
            this.timer_Anim.Interval = 1;
            this.timer_Anim.Tick += new System.EventHandler(this.timer_Anim_Tick);
            // 
            // timer_Randombomb
            // 
            this.timer_Randombomb.Enabled = true;
            this.timer_Randombomb.Interval = 800;
            this.timer_Randombomb.Tick += new System.EventHandler(this.timer_Randombomb_Tick);
            // 
            // timer_BombFailsafe
            // 
            this.timer_BombFailsafe.Enabled = true;
            this.timer_BombFailsafe.Interval = 3000;
            this.timer_BombFailsafe.Tick += new System.EventHandler(this.timer_BombFailsafe_Tick);
            // 
            // timer_Sec
            // 
            this.timer_Sec.Enabled = true;
            this.timer_Sec.Interval = 1000;
            this.timer_Sec.Tick += new System.EventHandler(this.timer_Sec_Tick);
            // 
            // timerBoomRemove
            // 
            this.timerBoomRemove.Enabled = true;
            this.timerBoomRemove.Tick += new System.EventHandler(this.timerBoomRemove_Tick);
            // 
            // timerCloud
            // 
            this.timerCloud.Enabled = true;
            this.timerCloud.Interval = 50;
            this.timerCloud.Tick += new System.EventHandler(this.timerCloud_Tick);
            // 
            // WorldFloor
            // 
            this.WorldFloor.BackgroundImage = global::BombsAway.Properties.Resources.floor;
            this.WorldFloor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WorldFloor.Location = new System.Drawing.Point(0, 304);
            this.WorldFloor.Margin = new System.Windows.Forms.Padding(4);
            this.WorldFloor.Name = "WorldFloor";
            this.WorldFloor.Size = new System.Drawing.Size(875, 31);
            this.WorldFloor.TabIndex = 1;
            // 
            // timerCloud2
            // 
            this.timerCloud2.Enabled = true;
            this.timerCloud2.Interval = 45;
            this.timerCloud2.Tick += new System.EventHandler(this.timerCloud2_Tick);
            // 
            // scrollingTimer
            // 
            this.scrollingTimer.Enabled = true;
            this.scrollingTimer.Interval = 20;
            this.scrollingTimer.Tick += new System.EventHandler(this.scrollingTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 335);
            this.Controls.Add(this.WorldFloor);
            this.Controls.Add(this.WorldFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.WorldFrame.ResumeLayout(false);
            this.WorldFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WorldFrame;
        private System.Windows.Forms.Panel WorldFloor;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Timer timer_Gravity;
        private System.Windows.Forms.Timer timer_Jump;
        private System.Windows.Forms.Timer timer_Anim;
        private System.Windows.Forms.Timer timer_Randombomb;
        private System.Windows.Forms.Timer timer_BombFailsafe;
        private System.Windows.Forms.Label label_Dead;
        private System.Windows.Forms.Timer timer_Sec;
        private System.Windows.Forms.Timer timerBoomRemove;
        private System.Windows.Forms.PictureBox pb_Pipe;
        private System.Windows.Forms.PictureBox pb_Block1;
        private System.Windows.Forms.PictureBox pb_Block2;
        private System.Windows.Forms.PictureBox pb_NPC1;
        private System.Windows.Forms.PictureBox pb_NPC2;
        private System.Windows.Forms.Timer testTimer;
        private System.Windows.Forms.PictureBox cloud;
        private System.Windows.Forms.Timer timerCloud;
        private System.Windows.Forms.PictureBox cloud2;
        private System.Windows.Forms.Timer timerCloud2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer scrollingTimer;
    }
}

