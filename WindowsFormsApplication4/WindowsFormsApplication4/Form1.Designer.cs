namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Play = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.Previous = new System.Windows.Forms.Button();
            this.Resume = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbFirst = new System.Windows.Forms.Label();
            this.LbSecond = new System.Windows.Forms.Label();
            this.Cb_Ale = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SavePlayList = new System.Windows.Forms.Button();
            this.Begin = new System.Windows.Forms.Button();
            this.Fast = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DeleteOne = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-563, -3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(550, 10);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Green;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play.Cursor = System.Windows.Forms.Cursors.Default;
            this.Play.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Play.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Play.Location = new System.Drawing.Point(482, 12);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 1;
            this.Play.Text = "4";
            this.Play.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(483, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "||";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Pause_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button3.Location = new System.Drawing.Point(482, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.SkyBlue;
            this.Next.Font = new System.Drawing.Font("AR CENA", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(482, 99);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 4;
            this.Next.Text = "NEXT";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(563, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 238);
            this.listBox1.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Teal;
            this.trackBar1.Location = new System.Drawing.Point(6, 291);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(368, 45);
            this.trackBar1.TabIndex = 6;
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.Teal;
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(6, 194);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 91);
            this.trackBar2.TabIndex = 17;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar2.Value = 50;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.Color.SkyBlue;
            this.Previous.Font = new System.Drawing.Font("AR CENA", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous.Location = new System.Drawing.Point(482, 128);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 9;
            this.Previous.Text = "PREVIOUS";
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Resume
            // 
            this.Resume.BackColor = System.Drawing.Color.OliveDrab;
            this.Resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Resume.ForeColor = System.Drawing.SystemColors.Control;
            this.Resume.Location = new System.Drawing.Point(483, 157);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(75, 23);
            this.Resume.TabIndex = 10;
            this.Resume.Text = "RESUME";
            this.Resume.UseVisualStyleBackColor = false;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.MediumOrchid;
            this.Add.Font = new System.Drawing.Font("Banco", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(483, 186);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(483, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 20);
            this.textBox1.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LbFirst
            // 
            this.LbFirst.AutoSize = true;
            this.LbFirst.BackColor = System.Drawing.Color.Teal;
            this.LbFirst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbFirst.Location = new System.Drawing.Point(442, 290);
            this.LbFirst.Name = "LbFirst";
            this.LbFirst.Size = new System.Drawing.Size(0, 13);
            this.LbFirst.TabIndex = 7;
            // 
            // LbSecond
            // 
            this.LbSecond.AutoSize = true;
            this.LbSecond.BackColor = System.Drawing.Color.Teal;
            this.LbSecond.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbSecond.Location = new System.Drawing.Point(442, 311);
            this.LbSecond.Name = "LbSecond";
            this.LbSecond.Size = new System.Drawing.Size(0, 13);
            this.LbSecond.TabIndex = 8;
            // 
            // Cb_Ale
            // 
            this.Cb_Ale.AutoSize = true;
            this.Cb_Ale.BackColor = System.Drawing.Color.Teal;
            this.Cb_Ale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cb_Ale.Location = new System.Drawing.Point(727, 289);
            this.Cb_Ale.Name = "Cb_Ale";
            this.Cb_Ale.Size = new System.Drawing.Size(58, 17);
            this.Cb_Ale.TabIndex = 18;
            this.Cb_Ale.Text = "CB Ale";
            this.Cb_Ale.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SavePlayList
            // 
            this.SavePlayList.Font = new System.Drawing.Font("AR ESSENCE", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePlayList.Location = new System.Drawing.Point(646, 285);
            this.SavePlayList.Name = "SavePlayList";
            this.SavePlayList.Size = new System.Drawing.Size(75, 23);
            this.SavePlayList.TabIndex = 20;
            this.SavePlayList.Text = "Save PlayList";
            this.SavePlayList.UseVisualStyleBackColor = true;
            this.SavePlayList.Click += new System.EventHandler(this.SavePlayList_Click);
            // 
            // Begin
            // 
            this.Begin.BackColor = System.Drawing.Color.White;
            this.Begin.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Begin.Location = new System.Drawing.Point(563, 12);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(57, 23);
            this.Begin.TabIndex = 21;
            this.Begin.Text = "BEGIN";
            this.Begin.UseVisualStyleBackColor = false;
            this.Begin.Click += new System.EventHandler(this.Begin_Click);
            // 
            // Fast
            // 
            this.Fast.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Fast.Font = new System.Drawing.Font("VAGRounded BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fast.Location = new System.Drawing.Point(659, 12);
            this.Fast.Name = "Fast";
            this.Fast.Size = new System.Drawing.Size(53, 23);
            this.Fast.TabIndex = 23;
            this.Fast.Text = "FAST";
            this.Fast.UseVisualStyleBackColor = false;
            this.Fast.Click += new System.EventHandler(this.Fast_Click);
            // 
            // End
            // 
            this.End.BackColor = System.Drawing.Color.Black;
            this.End.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.End.Location = new System.Drawing.Point(753, 12);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(54, 23);
            this.End.TabIndex = 24;
            this.End.Text = "END";
            this.End.UseVisualStyleBackColor = false;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(380, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "Текущ. время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(380, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "Общ. время   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Volume";
            // 
            // DeleteOne
            // 
            this.DeleteOne.BackColor = System.Drawing.Color.DarkOrange;
            this.DeleteOne.Font = new System.Drawing.Font("Incised901 Ct BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOne.Location = new System.Drawing.Point(483, 215);
            this.DeleteOne.Name = "DeleteOne";
            this.DeleteOne.Size = new System.Drawing.Size(75, 23);
            this.DeleteOne.TabIndex = 28;
            this.DeleteOne.Text = "DELETE";
            this.DeleteOne.UseVisualStyleBackColor = false;
            this.DeleteOne.Click += new System.EventHandler(this.DeleteOne_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.BurlyWood;
            this.ClearAll.Font = new System.Drawing.Font("Incised901 Ct BT", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.Location = new System.Drawing.Point(483, 244);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(75, 23);
            this.ClearAll.TabIndex = 29;
            this.ClearAll.Text = "CLEAR_ALL";
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.Безимени_3;
            this.ClientSize = new System.Drawing.Size(813, 344);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.DeleteOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Fast);
            this.Controls.Add(this.Begin);
            this.Controls.Add(this.SavePlayList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cb_Ale);
            this.Controls.Add(this.LbSecond);
            this.Controls.Add(this.LbFirst);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Resume;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LbFirst;
        private System.Windows.Forms.Label LbSecond;
        private System.Windows.Forms.CheckBox Cb_Ale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SavePlayList;
        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.Button Fast;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button DeleteOne;
        private System.Windows.Forms.Button ClearAll;
        public System.Windows.Forms.Button Add;
    }
}

