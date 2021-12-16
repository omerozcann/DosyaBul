using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DosyaBul
{    
    public partial class DosyaBulFrm : Form
    {
        List<string> liste = new List<string>();
        String[] uzantilar = null;
        String secilendizin = "";
        public DosyaBulFrm()
        {
            InitializeComponent();
        }

        public void DosyaAra(string aramadizini,string []uzanti)
        {
            try
            {
                for (int i = 0; i < uzanti.Length; i++)
                {
                    foreach (string file in Directory.GetFiles(aramadizini, "*"+uzanti[i].Trim()))
                    {
                        string extension = Path.GetExtension(file);

                        if (extension != null)
                        {
                            liste.Add(file);
                        }
                    }
                }                

                foreach (string directory in Directory.GetDirectories(aramadizini))
                {
                    DosyaAra(directory,uzanti);
                }
            }
            catch (System.Exception e)
            {
                //Console.WriteLine(e.Message);
            }
        }
        private void arabtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (uzantilarlst.Items.Count > 0)
                {
                    uzantilar = new String[uzantilarlst.Items.Count];
                    for (int i = 0; i < uzantilar.Length; i++)
                    {
                        uzantilar[i] = uzantilarlst.Items[i].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Uzantı Seçiniz");
                }
            if(tumsurucurb.Checked==true)
            {
                DriveInfo []di = DriveInfo.GetDrives();//tüm sürücülerin listesini ver
                for(int i=0;i<di.Length;i++)
                {
                        DosyaAra(di[i].Name,uzantilar);   
                }
                    

            }
            if(secilensurucurb.Checked==true)
            {
                    DosyaAra(secilensurucucmb.Items[secilensurucucmb.SelectedIndex].ToString(), uzantilar);
            }
            if(secilendizinrb.Checked==true)
            {
                    DosyaAra(secilendizin, uzantilar);
            }
                for (int i = 0; i < liste.Count; i++)
                {
                    if (liste[i].Contains(aratxt.Text) == true)
                    {
                        sonuclarlst.Items.Add(liste[i]);
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void uzantieklebtn_Click(object sender, EventArgs e)
        {
            uzantilarlst.Items.Add(uzantilarcmb.Items[uzantilarcmb.SelectedIndex]);
        }

        private void secilensurucurb_CheckedChanged(object sender, EventArgs e)
        {
            secilensurucucmb.Items.Clear();
            secilensurucucmb.Items.AddRange(DriveInfo.GetDrives());            
        }

        private void secilendizinbtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            secilendizin = folderBrowserDialog1.SelectedPath;
        }
    }
}
