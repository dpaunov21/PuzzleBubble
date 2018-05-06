using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleBubble {
    public class Bubble {
        public static int Radius = 25;
        public Point Center { get; set; }
        public Color color { get; set; }
        public Point direction { get; set; }

        public Bubble(int x, int y, Color color, Point start) {
            this.Center = new Point(x, y);
            this.color = color;
            direction = start;
        }


        public void Draw(Graphics g) {
            Brush b = new SolidBrush(color);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
        }

        public void DrawDirection(Graphics g, Point start) {
            Pen p = new Pen(new SolidBrush(color));
            g.DrawLine(p, start, direction);


        }


        public void Move() {

            Center = new Point(Center.X, Center.Y - 30);
        }
        public void DirectionLeft() {

            if (direction.Y != 660 || direction.X > 0) {
                if (direction.X > 0 && direction.X < 510) {
                    direction = new Point(direction.X - 20, direction.Y);
                }
                if (direction.X < 0) {
                    direction = new Point(direction.X, direction.Y + 20);
                }
                if (direction.Y > 0 && direction.X == 510) {
                    direction = new Point(direction.X, direction.Y - 20);
                    if (direction.Y == 0) {
                        direction = new Point(490, direction.Y);
                    }
                }
            }
        }

        public void DirectionRight() {
            if (direction.Y != 660 || direction.X < 0) {
                if (direction.X > 0 && direction.X < 510) {
                    direction = new Point(direction.X + 20, direction.Y);
                }
                if (direction.X >= 510) {
                    direction = new Point(direction.X, direction.Y + 20);
                }

                if(direction.Y > 0 && direction.X == -10) {
                    direction = new Point(direction.X, direction.Y - 20);
                        if(direction.Y == 0) {
                        direction = new Point(10, direction.Y);
                    }


                }


            }

        }

    }
}
