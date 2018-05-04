using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleBubble {
    public partial class Form1 : Form {
        public Point start;
        public Color bubbleColor;
        public Bubble bubble;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            start = new Point(panel1.Width / 2, panel1.Height - 2 * Bubble.Radius);
            bubbleColor = Color.Red;
            bubble = new Bubble(start.X, start.Y, Color.Red, new Point(Width/2,0));

        }

        private void panel1_Paint(object sender, PaintEventArgs e) { 
                 bubble.Draw(e.Graphics);
                 bubble.DrawDirection(e.Graphics, start);
        }

        private void panel1_Resize(object sender, EventArgs e) {
            Invalidate(true);
        }

        private void panel1_DockChanged(object sender, EventArgs e) {
            Invalidate();
        }

        private void panel1_SizeChanged(object sender, EventArgs e) {
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Left) {
                bubble.DirectionLeft();
            }
            if (e.KeyCode == Keys.Left) {
                bubble.DirectionRight();
            }


            Invalidate(true);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e) {
            bubble.DirectionRight();
            Invalidate();
        }
    }
}
