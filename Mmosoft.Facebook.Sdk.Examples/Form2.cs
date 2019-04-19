using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mmosoft.Facebook.Sdk.Examples
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }      
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select more images";
            ofd.Multiselect = true;
            ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string[] files = ofd.FileNames;
                int x = 20;
                int y = 20;
                int maxHeight = 0;
                foreach (string img in files)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(img);
                    pic.Location = new Point(x, y);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    x += pic.Width + 10;
                    maxHeight = Math.Max(pic.Height, maxHeight);
                    if( x > this.ClientSize.Width - 100)
                    {
                        x = 20;
                        y += maxHeight + 10;
                    }
                    this.panel1.Controls.Add(pic);
                }
            }
        }
    }
}
