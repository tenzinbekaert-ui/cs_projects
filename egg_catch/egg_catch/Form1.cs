using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egg_catch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(10, 10);
            pictureBox.Size = new Size(800, 800);
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            Spawner spawner = new Spawner();
            spawner.nieuwEi += (sender, e) =>
            {
                Console.WriteLine($"er is een nieuw ei");
            };

            Image image = Image.FromFile("");
            pictureBox.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.DrawImage(image, 0, 100);
            };
        }
    }
}
