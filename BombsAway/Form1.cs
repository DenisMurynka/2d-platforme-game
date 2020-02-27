using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BombsAway.Properties;
//using WMPLib;
using System.IO;
//using MySql.Data.MySqlClient;

namespace BombsAway
{
    public partial class Form1 : Form
    {
        
        #region MUSIC obj
      
        System.Media.SoundPlayer mus_jump = new System.Media.SoundPlayer();
        System.Media.SoundPlayer mus_pause = new System.Media.SoundPlayer();
        System.Media.SoundPlayer mus_gameover = new System.Media.SoundPlayer();
        WMPLib.WindowsMediaPlayer pl_mus = new WMPLib.WindowsMediaPlayer();
        System.Media.SoundPlayer mus_coin = new System.Media.SoundPlayer();
        

        #endregion
        public Form1()
        {
            InitializeComponent();
           
            mus_jump.SoundLocation = "smb3_jump.wav";
            mus_pause.SoundLocation = "smb3_pause.wav";
            mus_gameover.SoundLocation = "smb_gameover.wav";
            mus_coin.SoundLocation = "smb3_coin.wav";
           
        }

        #region Vars
        bool shot = false;
        PictureBox[] Bombs = new PictureBox[10];
        PictureBox[] Explosives = new PictureBox[10];// boooom
        PictureBox[] WorldObjects = new PictureBox[10];
       
        PictureBox[] NPC = new PictureBox[2];
        Random rng = new Random();
        Random rnd = new Random();

        MENU form2 = new MENU();

        bool last_cloud_left = true;
        bool last_cloud2_left = true;
        bool Player_Jump = false;    
        bool Player_Left = false;    
        bool Player_Right = false;   
        bool LastDirRight = true;    
        bool GameOn = false;       
        bool GodMode = false;
      
        int Gravity = 20;
        int Anim = 0;
        int Force = 0;
       
       
        int BombSize = 16;
        int Speed_Movement = 3;
        int Speed_Jump = 3;
        int Speed_Fall = 3;
        int Score = 0;
        int CoinScore = 0;
        void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = System.Drawing.Color.DarkOrange;
            bullet.Height = 5;
            bullet.Width = 10;
            bullet.Left = pb_Player.Left + pb_Player.Width;
            bullet.Top = pb_Player.Top + pb_Player.Height / 2;
            bullet.Tag = "bullet";
            this.Controls.Add(bullet);
        }
        #endregion
        #region Check functions COLLISION

        public Boolean InAirNoCollision(PictureBox obj)
        {   
            if (!OutsideWorldFrame(obj))//Checks if the target Picturebox is Outside of the frame
            {
                foreach (PictureBox Obj in WorldObjects)
                {   
                    if (!obj.Bounds.IntersectsWith(Obj.Bounds))//OR if it's not COlliding with anything
                    {
                        if (obj.Location.Y < WorldFrame.Width)
                        {   

                            return true;//it's not under gr
                        }
                    }
                }
            }
           
            return false;
        }

        public Boolean OutsideWorldFrame(PictureBox obj)
        {
            if (obj.Location.X < 0) //Is it outside of the left side?
                return true;

            if (obj.Location.X > WorldFrame.Width)  //right
                return true;

            if (obj.Location.Y + obj.Height > WorldFrame.Height - 3)
                return true;                        //Or above the WorldFrame?

            foreach (PictureBox Obj in WorldObjects)
            {
                if (Obj != null)
                {   //Or, intersecting with any world object
                    if (obj.Bounds.IntersectsWith(Obj.Bounds))
                        return true;
                }
            }
            return false;
        }
        public Boolean Collision_Top(PictureBox tar)
        {
            foreach (PictureBox obj in WorldObjects)
            {
                if (obj != null)
                {
                    PictureBox temp1 = new PictureBox();    //Creates a obj asks if anything is colliding with it
                    temp1.Bounds = obj.Bounds;
                    
                    temp1.SetBounds(temp1.Location.X - 3, temp1.Location.Y - 1, temp1.Width + 6, 1);

                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Bottom(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                   
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + temp1.Height, temp1.Width, 1);

                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Left(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    
                    temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y + 1, 1, temp1.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }
        public Boolean Collision_Right(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp2 = new PictureBox();
                    temp2.Bounds = ob.Bounds;
                   
                    temp2.SetBounds(temp2.Location.X + temp2.Width, temp2.Location.Y + 1, 1, temp2.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp2.Bounds))
                        return true;
                }
            }
           
            return false;
        }
        #endregion COLLISION
       
        #region Voids
        public void Dead()
        {
            if (!GodMode) 
            {
                mus_gameover.Play();
                pb_Player.Visible = false;
                label_Dead.Visible = true;
                GameOn = false;
            }
            
        }
        public void Reset()
        {   
            label_Dead.Visible = false;
            int x = 0;
            CoinScore = 0;

            foreach (PictureBox Bomb in Bombs)
            {
                if (Bomb != null)
                {   
                    Bomb.Dispose();
                    Bombs[x] = null; ;
                }
                x++;
            }

            int x2 = 0;
            foreach (PictureBox Boom in Explosives)
            {
                if (Boom != null)
                {   Boom.Dispose();
                    Bombs[x2] = null; ;
                }
                x2++;
            }
            //LOCATION
            pb_Player.Visible = true;  
            pb_Player.Location = new System.Drawing.Point(167, WorldFrame.Size.Height - 10 - pb_Player.Height);
            pb_NPC1.Location = new System.Drawing.Point(1, WorldFrame.Size.Height - 1 - pb_NPC1.Height);
            pb_NPC2.Location = new System.Drawing.Point(WorldFrame.Width-10, WorldFrame.Size.Height - 1 - pb_NPC2.Height);
            pb_Player.Image = Character.stand_r;
            Score = 0;
            BombSize = 16;
            GameOn = true;
        }
        public void CreateBoom(int x, int y)
        {   PictureBox Boom = new PictureBox();
            Boom.Name = "Boom";
            Boom.BackColor = Color.Transparent;
            Boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Boom.Size = new System.Drawing.Size(BombSize, BombSize);
            Boom.Image = World.Boom;
            Boom.Location = new System.Drawing.Point(x, y);
            WorldFrame.Controls.Add(Boom);
            Explosives[0] = Boom;
        }
      
        #endregion
        #region Keyboard
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {

                case Keys.Escape:
                    this.Close();
                    form2.Show();
                    break;

                case Keys.Z:
                    Score += 120;
                    break;

                case Keys.X:
                    pb_Player.Top+=3;
                    break;
              
                case Keys.P:                   
                    if (GameOn)
                    {
                        GameOn = false;         //Game Pauses
                        mus_pause.Play();
                        label_Dead.Text = "Paused, press P to Continue";
                        label_Dead.Visible = true;
                    }
                    else
                    {
                        GameOn = true;
                        label_Dead.Text = "You died, press Space to start";
                        label_Dead.Visible = false;
                      
                       
                    }
                    break;

                case Keys.Left:                 // On Left Keypress down
                    if (GameOn)
                    {
                        LastDirRight = false;   //For the animation, stand right or left
                        Player_Left = true;     //Walk left
                    }
                    break;

                case Keys.Right:                // On Right Keypress down
                    if (GameOn)
                    {
                        LastDirRight = true;
                        Player_Right = true;
                    }
                    break;

                case Keys.Space:    // On Space Keypress down
                    if (label_Dead.Visible && !label_Dead.Text.Contains("Paused"))
                    {               // If pressed Space and the death label is shown
                        Reset();    //Reset the game
                    }
                    else
                    {
                        if (!Player_Jump && !InAirNoCollision(pb_Player))
                        {   
                            if (LastDirRight)       
                            {
                                pb_Player.Image = Character.jump_r;
                               
                            }
                            else
                            {
                                pb_Player.Image = Character.jump_l;
                               
                            }
                            pb_Player.Top -= Speed_Jump;    
                            Force = Gravity;        
                            Player_Jump = true;     
                            mus_jump.Play();
                        }
                    }
                    break;

            }
            if (e.KeyCode == Keys.Space && shot == false)
            {
                makeBullet();
                shot = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (GameOn)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:     
                        
                        pb_Player.Image = Character.stand_l;    
                        LastDirRight = false;                   
                        Player_Left = false;                    
                        break;
                    case Keys.Right:

                        pb_Player.Image = Character.stand_r;
                        LastDirRight = true;
                        Player_Right = false;
                        break;
                }
                if (shot == true)
                {
                    shot = false;
                }
            }
        }
        #endregion
        #region TimerTicks | VIP Region
        private void timer_Jump_Tick(object sender, EventArgs e)
        {
            if (GameOn)
            {
                if (Player_Right && pb_Player.Right <= WorldFrame.Width - 3 && !Collision_Left(pb_Player))
                {
                    pb_Player.Left += Speed_Movement; 
                }
                if (Player_Left && pb_Player.Location.X >= 3 && !Collision_Right(pb_Player))
                { 
                    pb_Player.Left -= Speed_Movement;
                }
            }
            else
            {
                Player_Right = false;
                Player_Left = false;
            }

            if (Force > 0)
            {   
                if (Collision_Bottom(pb_Player))
                {   
                    Force = 0;
                    
                }
                else
                {  
                    Force--;
                    pb_Player.Top -= Speed_Jump;
                }
            }
            else
            {   
                Player_Jump = false;
            }
        }

        private void timer_Anim_Tick(object sender, EventArgs e)
        {
           
            Anim++; 
            label2.Text = "Highscore: " + Properties.Settings.Default.Highscore;
            if (Player_Right == true && Anim % 15 == 0)
            {  
                pb_Player.Image = Character.walk_r;
            }
            if (Player_Left == true && Anim % 15 == 0)
            {
                pb_Player.Image = Character.walk_l;
            }

            foreach (PictureBox Bomb in Bombs)
            {
                if (Bomb != null)
                {   
                    if (pb_Player.Bounds.IntersectsWith(Bomb.Bounds))
                    {
                        if (Bomb.Name == "Coin")
                        {
                            mus_coin.Play();
                            Score++;
                            CoinScore++;
                            Bomb.Dispose();
     
                        }
                        else
                        {
                            
                            Dead();
                            mus_gameover.Play();
                            Bomb.Dispose();
                        }
                    }
                }
            }

            #region NPC
            foreach (PictureBox npc in NPC)
            {
                if (npc.Bounds.IntersectsWith(pb_Player.Bounds))
                {
                    mus_gameover.Play();
                    Dead();
                    
                }
                else
                {
                    if (npc.Location.X > pb_Player.Location.X && npc.Location.X < WorldFrame.Width && !Collision_Right(npc) && GameOn)
                    {
                        npc.Left--;
                        npc.Image = Resources.Enemy_left;
                    }
                    if (npc.Location.X < pb_Player.Location.X && npc.Location.X > 0 && !Collision_Left(npc) && GameOn)
                    {
                        npc.Left++;
                        npc.Image = Resources.Enemy_right;
                    }
                }
            }
        }

        public Boolean NoCollision(PictureBox tar)
        {
            foreach (PictureBox obj in WorldObjects)
            {
                if (obj != null)
                {
                    if (tar.Bounds.IntersectsWith(obj.Bounds))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
            #endregion

        private void timer_Gravity_Tick(object sender, EventArgs e)
        {
            if (!Player_Jump && pb_Player.Location.Y + pb_Player.Height < WorldFrame.Height - 2 && !Collision_Top(pb_Player))
            {   
                pb_Player.Top += Speed_Fall; //Player falls
            }

            if (!Player_Jump && pb_Player.Location.Y + pb_Player.Height > WorldFrame.Height - 1)
            {   
                pb_Player.Top--;
            }

            int x = 0;
            if (GameOn) 
            {
                foreach (PictureBox Bomb in Bombs)  
                {
                    if (Bomb != null)              
                    {
                        try
                        {
                            if (!OutsideWorldFrame(Bomb))
                            {
                                if (Bomb.Name == "pb" || Bomb.Name == "Coin")
                                {
                                    Bomb.Top += 3;
                                }
                                if (Bomb.Name == "pbR")
                                {
                                    Bomb.Left += 3;
                                }
                                if (Bomb.Name == "pbL")
                                {
                                    Bomb.Left -= 3;
                                }
                            }
                            else // If the bomb is not above the ground
                            {
                                if (OutsideWorldFrame(Bomb))
                                {   //If the Rocket going Right is out of frame, it gets removed
                                    Bombs[x] = null;
                                    Bomb.Dispose();

                                    if (OutsideWorldFrame(Bomb))
                                    {// /If the Rocket going LEft is out of frame, it gets removed
                                        Bombs[x] = null;
                                        Bomb.Dispose();

                                    }// if Rocet going down 
                                    Bombs[x] = null;
                                    Bomb.Dispose();

                                    if (Explosives[0] != null)
                                    {
                                        Explosives[0].Dispose();
                                        Explosives[0] = null;

                                    }
                                    CreateBoom(Bomb.Location.X, Bomb.Location.Y);
                                }
                            }
                        }
                        catch (Exception) { }
                    }
                    x++; // count of which bomb is on
                    if (x >= 10)
                    {   //Going back to 0 if bomb array is more then 10
                        x = 0;
                    }
                }

            }
        }
        private void timer_Randombomb_Tick(object sender, EventArgs e) 
        {
            Random rng = new Random();
            if (GameOn || (!GameOn && !label_Dead.Visible))
                if (GetBombsNum(Bombs) == 10)
                {
                    timer_BombFailsafe.Enabled = true;
                }
                else
                {
                    timer_BombFailsafe.Enabled = false;
                    {
                        int r = 2;
                        int NextSpot = NextBomb(Bombs);
                        if (Score > 20 && Score < 40) r = 12;
                        if (Score > 40 && Score < 80) r = 13;
                        if (Score > 80) r = 14;
                        switch (rng.Next(1, r))
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                                NextSpot = NextBomb(Bombs);
                                PictureBox pb = new PictureBox();
                                pb.Name = "pb";
                                pb.BackColor = Color.Transparent;
                                pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                                pb.Size = new System.Drawing.Size(16, 16);
                                pb.Image = Enemy.Bomb;
                                if (Score > 120)
                                {
                                    pb.Location = new System.Drawing.Point(rng.Next(pb_Player.Location.X-10, pb_Player.Location.X+10), 0);
                                }
                                else
                                {
                                    pb.Location = new System.Drawing.Point(rng.Next(0, WorldFrame.Width), 0);
                                }
                                WorldFrame.Controls.Add(pb);
                                Bombs[NextBomb(Bombs)] = pb;
                                break;
                            case 9:
                            case 10:
                            case 11:
                                NextSpot = NextBomb(Bombs);
                                PictureBox Coin = new PictureBox();
                                Coin.Name = "Coin";
                                Coin.BackColor = Color.Transparent;
                                Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                                Coin.Size = new System.Drawing.Size(20, 29);
                                Coin.Image = World.Coin;
                                Coin.Location = new System.Drawing.Point(rng.Next(0, WorldFrame.Width), 0);
                                WorldFrame.Controls.Add(Coin);
                                Bombs[NextBomb(Bombs)] = Coin;
                            
                                break;
                            case 13:
                                NextSpot = NextBomb(Bombs);
                                PictureBox pbR = new PictureBox();
                                pbR.Name = "pbR";
                                pbR.BackColor = Color.Transparent;
                                pbR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                                pbR.Size = new System.Drawing.Size(30, 20);
                                pbR.Image = Enemy.Rocket_R;
                                if (rng.Next(1, 3) == 1)
                                {
                                    pbR.Location = new System.Drawing.Point(1, 205);
                                }
                                else
                                {
                                    pbR.Location = new System.Drawing.Point(1, 124);
                                }
                                WorldFrame.Controls.Add(pbR);
                                Bombs[NextBomb(Bombs)] = pbR;
                              
                                break;
                            case 12:
                                NextSpot = NextBomb(Bombs);
                                PictureBox pbL = new PictureBox();
                                pbL.Name = "pbL";
                                pbL.BackColor = Color.Transparent;
                                pbL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                                pbL.Size = new System.Drawing.Size(30, 20);
                                pbL.Image = Enemy.Rocket_L;
                                if (rng.Next(1, 3) == 1)
                                {
                                    pbL.Location = new System.Drawing.Point(WorldFrame.Width + 30, 205);
                                }
                                else
                                {
                                    pbL.Location = new System.Drawing.Point(WorldFrame.Width + 30, 151);
                                }
                                WorldFrame.Controls.Add(pbL);
                                Bombs[NextBomb(Bombs)] = pbL;
                               
                                break;
                        }
                    }
                }
        }

        private void timer_Sec_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (Bombs[i] != null && Bombs[i].IsDisposed)
                {
                    Bombs[i] = null;
                }
            }
            label_Score.Text = "Score: " + Score;
            label3.Text = "Coin score: " + CoinScore;
           
            if (!label_Dead.Visible)
            {
                Score++;
                BombSize++;
                if (timer_Randombomb.Interval > 1)
                {
                    timer_Randombomb.Interval--;
                }
                if (Score > Properties.Settings.Default.Highscore)
                {
                 
                   Properties.Settings.Default.Highscore = Score;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void timerBoomRemove_Tick(object sender, EventArgs e)
        {
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox)
                {
                    if (X.Name == "Boom")
                    {
                        X.Dispose();
                    }
                }
            }

            foreach (PictureBox Boom in Explosives)
            {
                if (Boom != null)
                {
                    Boom.Dispose();
                }
            }
        }

        private void timer_BombFailsafe_Tick(object sender, EventArgs e)
        {   
            for (int i = 0; i < 10; i++)
            {   // bomb==10/ 3 sec==reset
                if (Explosives[0] != null)
                {
                    Explosives[0].Dispose();
                    Explosives[0] = null;
                }
                if (Bombs[i] != null)
                {
                    Bombs[i].Dispose();
                    Bombs[i] = null;
                }
            }
           
        }

        private void timerCloud_Tick(object sender, EventArgs e)
        {
            if (GameOn)
            {
                if (last_cloud_left == true)
                {
                    cloud.Left -= 1;
                }
                if (cloud.Right == 0)
                {
                    last_cloud_left = false;
                }
                if (last_cloud_left == false)
                {
                    cloud.Left += 1;
                }

                if (cloud.Left == WorldFrame.Width)
                {
                    last_cloud_left = true;
                }
            }
        }

        private void timerCloud2_Tick(object sender, EventArgs e)
        {
            if (GameOn)
            {
                if (last_cloud2_left == false)
                {
                    cloud2.Left -= 1;
                }
                if (cloud2.Right == 0)
                {
                    last_cloud2_left = true;
                }
                if (last_cloud2_left == true)
                {
                    cloud2.Left += 1;
                }

                if (cloud2.Left == WorldFrame.Width)
                {
                    last_cloud2_left = false;
                }
            }
        }
        #endregion
        #region Other

        public int GetBombsNum(PictureBox[] Arr)
        {
            int x = 0;  //Gets every non null value in the array
            foreach (PictureBox Bomb in Arr)
            {
                if (Bomb != null)
                {
                    x++;
                }
            }
            return x;
        }

        public int NextBomb(PictureBox[] Arr)
        {
            if (GetBombsNum(Arr) < 10)
            {
                for (int i = 0; i < 10; i++)
                {   //Returns the first space in the array that isn't null
                    if (Arr[i] == null)
                    {
                        return i;
                    }
                }
            }   //If for some reason it cant find any. This failsafe runs
            Bombs[0] = null;    //First bomb gets removed
            return 0;
        }
        #endregion
        #region LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            WorldObjects[0] = pb_Pipe;
            WorldObjects[1] = pb_Block1;
            WorldObjects[2] = pb_Block2;
            NPC[0] = pb_NPC1;
            NPC[1] = pb_NPC2;
        }
        #endregion

        private void scrollingTimer_Tick(object sender, EventArgs e)
        {
            foreach(Control X in this.Controls)
            {
                if (X is PictureBox && X.Tag == "bullet")
                {
                    X.Left += 15;
                    if (X.Left > 900)
                    {
                        this.Controls.Remove(X );
                        X.Dispose();
                    }
                    
                }
            }
        }
    }
}
