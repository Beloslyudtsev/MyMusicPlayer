using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        string[] Musicas = new string[1000];
        int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar2.Value;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count!=0)
                try
                {
                    if (listBox1.SelectedIndex != listBox1.Items.Count - 1)
                    {
                        listBox1.SetSelected(listBox1.SelectedIndex + 1, true);
                        axWindowsMediaPlayer1.URL = Musicas[listBox1.SelectedIndex];
                    }
                }
                catch
                    {
                        // Если ни одна песня не запущена, игнорируем нажатие кнопки
                    }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToDouble(LbFirst.Text.Replace(":", ""));
            }

            catch
            {
                // Если ни одна песня не запущена, игнорируем нажатие кнопки
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            try
            {   
                axWindowsMediaPlayer1.URL = Musicas[listBox1.SelectedIndex];
                timer1.Start();
            }

            catch
            {
                // Выводим сообщение о ошибке
                MessageBox.Show("       !!!Не выбрана песня!!!");
            }

            
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count != 0)
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToDouble(LbFirst.Text.Replace(":", ""));
            }

            catch
            {
                // Если ни одна песня не запущена, игнорируем нажатие кнопки
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count != 0)

                try
                {
                    if (listBox1.SelectedIndex != 0)
                    {
                        listBox1.SetSelected(listBox1.SelectedIndex - 1, true);
                        axWindowsMediaPlayer1.URL = Musicas[listBox1.SelectedIndex];
                    }
                }
                catch
                    {
                        // Если ни одна песня не запущена, игнорируем нажатие кнопки
                    }
        }

        private void Begin_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.SetSelected(0, true);
                axWindowsMediaPlayer1.URL = Musicas[listBox1.SelectedIndex];
            }

            catch
            {
                // Если плэйлист пуст, игнорируем нажатие кнопки
            }
        }

        private void End_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.SetSelected(listBox1.Items.Count - 1, true);
                axWindowsMediaPlayer1.URL = Musicas[listBox1.SelectedIndex];
            }

            catch
            {
                // Если плэйлист пуст, игнорируем нажатие кнопки
            }
        }
        
        public void Add_Click(object sender, EventArgs e)
        {
            int lll;
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "MP3 files|*.mp3|WMV files|*.wmv";
            open.FilterIndex = 1;

            if (open.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < open.FileNames.LongLength; i++)
                {
                    if (listBox1.Items.Contains(open.FileNames.GetValue(i)) == false)
                    {
                        listBox1.Items.Add(open.SafeFileNames.GetValue(i));
                        Musicas[count] = open.FileNames.GetValue(i).ToString();
                        count += 1;
                    }

                }
                if (listBox1.SelectedIndex < 0) { listBox1.SetSelected(0, true); }
            }
        }
       
        private void Fast_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if( Cb_Ale.Checked==true && LbFirst.Text !="" && Convert.ToInt32(LbFirst.Text.Replace(":", "")) == Convert.ToInt32(LbSecond.Text.Replace(":", ""))-2)
            {
                Random random = new Random();

                listBox1.SetSelected(random.Next(listBox1.Items.Count), true);
                axWindowsMediaPlayer1.URL = Musicas[listBox1.SelectedIndex];
            }
           
            LbSecond.Text = axWindowsMediaPlayer1.currentMedia.durationString;
            LbFirst.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            
        }

        private void DeleteOne_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Stop_Click(sender, e);
            count = 0;
            LbFirst.ResetText();
            LbSecond.ResetText();
            timer1.Stop();
        }

        private void SavePlayList_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult dr = MessageBox.Show("Вы уверены что хотите выйти?", "Music Player Stasya", MessageBoxButtons.YesNo);
           if (dr == DialogResult.Yes)
               e.Cancel = false;
           else
               e.Cancel = true;
        }
    }
}
