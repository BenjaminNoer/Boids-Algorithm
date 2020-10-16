using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Timers;
using System.Linq;
using System.Windows.Forms;
namespace Boids
{
    public partial class Form1 : Form
    {
        private Image iconRegular, iconZombie;
        private Swarm swarm;
        public static int count, predatorCount;
        public static float FlockStrength, AlignStrength, PredatorSpeed, Border, Sight, Space, Speed;
        public static bool isActive = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Init(int boundary, int rate)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(boundary + 150, boundary + 150);
            iconRegular = CreateIcon(Brushes.Blue);
            iconZombie = CreateIcon(Brushes.Red);
            swarm = new Swarm(boundary);
            System.Timers.Timer paintBoids = new System.Timers.Timer(rate);
            paintBoids.Elapsed += PaintBoids_Elapsed;
            paintBoids.AutoReset = true;
            paintBoids.Enabled = true;
        }
        private void PaintBoids_Elapsed(object sender, ElapsedEventArgs e)
        {
            swarm.MoveBoids();
            this.Invalidate();
        }
        private static Image CreateIcon(Brush brush)
        {
            Bitmap icon = new Bitmap(16, 16);
            Graphics g = Graphics.FromImage(icon);
            Point p1 = new Point(0, 16);
            Point p2 = new Point(16, 8);
            Point p3 = new Point(0, 0);
            Point p4 = new Point(5, 8);
            Point[] points = { p1, p2, p3, p4 };
            g.FillPolygon(brush, points);
            return icon;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (isActive)
            {
                foreach (Boid boid in swarm.Boids)
                {
                    float angle;
                    if (boid.dX == 0) angle = 90f;
                    else angle = (float)(Math.Atan(boid.dY / boid.dX) * 57.3);
                    if (boid.dX < 0f) angle += 180f;
                    Matrix matrix = new Matrix();
                    matrix.RotateAt(angle, boid.Position);
                    e.Graphics.Transform = matrix;
                    if (boid.Zombie) e.Graphics.DrawImage(iconZombie, boid.Position);
                    else e.Graphics.DrawImage(iconRegular, boid.Position);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isActive = true;
            foreach (var lbl in Controls.OfType<Label>())
                lbl.Hide();
            foreach (var nud in Controls.OfType<NumericUpDown>())
                nud.Hide();
            btnStart.Visible = false;
            count = (int)nudCount.Value;
            predatorCount = (int)nudPredators.Value;
            FlockStrength = (float)nudFlockStrength.Value;
            AlignStrength = (float)nudAlignStrength.Value;
            PredatorSpeed = (float)nudPredatorSpeed.Value;
            Border = (float)nudBorder.Value;
            Sight = (float)nudSight.Value;
            Space = (float)nudSpace.Value;
            Speed = (float)nudSpeed.Value;
            Init((int)nudBoundary.Value, (int)nudRate.Value);
        }
    }
    public class Swarm
    {
        public List<Boid> Boids = new List<Boid>();
        public Swarm(int boundary)
        {
            for (int i = 0; i < Form1.count; i++)
            {
                Boids.Add(new Boid(i > Form1.count - Form1.predatorCount - 1, boundary));
            }
        }
        public void MoveBoids()
        {
            foreach (Boid boid in Boids)
            {
                boid.Move(Boids);
            }
        }
    }
    public class Boid
    {
        public PointF Position;
        private static Random rnd = new Random();
        private float boundary;
        public bool Zombie;
        public float dX;
        public float dY;
        private float border = Form1.Border;
        private float sight = Form1.Sight;
        private float space = Form1.Space;
        private float speed = Form1.Speed;
        public Boid(bool zombie, int boundary)
        {
            Position = new PointF(rnd.Next(boundary), rnd.Next(boundary));
            this.boundary = boundary;
            Zombie = zombie;
        }
        public void Move(List<Boid> boids)
        {
            if (!Zombie) Flock(boids);
            else Hunt(boids);
            CheckBounds();
            CheckSpeed();
            Position.X += dX;
            Position.Y += dY;
        }
        private void Flock(List<Boid> boids)
        {
            foreach (Boid boid in boids)
            {
                float distance = Distance(Position, boid.Position);
                if (boid != this && !boid.Zombie)
                {
                    if (distance < space)
                    {
                        // Create space.
                        dX += Position.X - boid.Position.X;
                        dY += Position.Y - boid.Position.Y;
                    }
                    else if (distance < sight)
                    {
                        // Flock together.
                        dX += (boid.Position.X - Position.X) * Form1.FlockStrength;
                        dY += (boid.Position.Y - Position.Y) * Form1.FlockStrength;
                    }
                    if (distance < sight)
                    {
                        // Align movement.
                        dX += boid.dX * Form1.AlignStrength;
                        dY += boid.dY * Form1.AlignStrength;
                    }
                }
                if (boid.Zombie && distance < sight)
                {
                    // Avoid zombies.
                    dX += Position.X - boid.Position.X;
                    dY += Position.Y - boid.Position.Y;
                }
            }
        }
        private void Hunt(List<Boid> boids)
        {
            float range = float.MaxValue;
            Boid prey = null;
            foreach (Boid boid in boids)
            {
                if (!boid.Zombie)
                {
                    float distance = Distance(Position, boid.Position);
                    if (distance < sight && distance < range)
                    {
                        range = distance;
                        prey = boid;
                    }
                }
            }
            if (prey != null)
            {
                // Move towards closest prey.
                dX += prey.Position.X - Position.X;
                dY += prey.Position.Y - Position.Y;
            }
        }
        private void CheckBounds()
        {
            float val = boundary - this.border;
            if (Position.X < border) dX += border - Position.X;
            if (Position.Y < border) dY += border - Position.Y;
            if (Position.X > val) dX += val - Position.X;
            if (Position.Y > val) dY += val - Position.Y;
        }
        private void CheckSpeed()
        {
            float s;
            if (!Zombie) s = speed;
            else s = speed / Form1.PredatorSpeed;
            float val = Distance(new PointF(0f, 0f), new PointF(dX, dY));
            if (val > s)
            {
                dX = dX * s / val;
                dY = dY * s / val;
            }
        }
        private static float Distance(PointF p1, PointF p2)
        {
            double val = Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2);
            return (float)Math.Sqrt(val);
        }
    }
}