using System;
using System.Drawing;
using System.Windows.Forms;
using Tao.OpenGl;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        #region TEXTURES
        Bitmap btmpBasicTexture = new Bitmap("E:\\Lab\\4 курс\\Визуалка\\Лаба6\\vsrpp 6\\vsrpp 6\\tex.png");
        System.Drawing.Imaging.BitmapData dataBasicTexture;
        Bitmap btmpTableTexture = new Bitmap("E:\\Lab\\4 курс\\Визуалка\\Лаба6\\vsrpp 6\\vsrpp 6\\woodTexture.jpg");
        System.Drawing.Imaging.BitmapData dataTableTexture;
        Bitmap btmpTableTextureONE = new Bitmap("E:\\Lab\\4 курс\\Визуалка\\Лаба6\\vsrpp 6\\vsrpp 6\\woodTextureONE.jpg");
        System.Drawing.Imaging.BitmapData dataTableTextureONE;

        Bitmap btmpDice1 = new Bitmap("E:\\Lab\\4 курс\\Визуалка\\Лаба6\\vsrpp 6\\vsrpp 6\\1.jpg");
        System.Drawing.Imaging.BitmapData dataDice1;
        Bitmap btmpDice2 = new Bitmap("E:\\Lab\\4 курс\\Визуалка\\Лаба6\\vsrpp 6\\vsrpp 6\\2.jpg");
        System.Drawing.Imaging.BitmapData dataDice2;
        Bitmap btmpDice3 = new Bitmap("E:\\Lab\\4 курс\\Визуалка\\Лаба6\\vsrpp 6\\vsrpp 6\\3.jpg");
        System.Drawing.Imaging.BitmapData dataDice3;
        Bitmap btmpDice4 = new Bitmap("E:\\Lab\\4 курс\\Визуалка\\Лаба6\\vsrpp 6\\vsrpp 6\\4.jpg");
        System.Drawing.Imaging.BitmapData dataDice4;
        Bitmap btmpDice5 = new Bitmap("E:\\Lab\\4 курс\\Визуалка\\Лаба6\\vsrpp 6\\vsrpp 6\\5.jpg");
        System.Drawing.Imaging.BitmapData dataDice5;
        Bitmap btmpDice6 = new Bitmap("E:\\Lab\\4 курс\\Визуалка\\Лаба6\\vsrpp 6\\vsrpp 6\\6.jpg");
        System.Drawing.Imaging.BitmapData dataDice6;

        #endregion
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            timerForTask2.Interval = 10;
            timerForTask4.Interval = 50;
            OpenGLControl.InitializeContexts();

            btmpTableTexture = ConvertRGBtoBGR(btmpTableTexture);
            btmpTableTextureONE = ConvertRGBtoBGR(btmpTableTextureONE);

            Gl.glLoadIdentity();
            Rectangle Rect1 = new Rectangle(0, 0, btmpBasicTexture.Width, btmpBasicTexture.Height);
            Rectangle Rect2 = new Rectangle(0, 0, btmpTableTexture.Width, btmpTableTexture.Height);
            Rectangle Rect3 = new Rectangle(0, 0, btmpTableTextureONE.Width, btmpTableTextureONE.Height);
            dataBasicTexture = btmpBasicTexture.LockBits(Rect1, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            dataTableTexture = btmpTableTexture.LockBits(Rect2, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            dataTableTextureONE = btmpTableTextureONE.LockBits(Rect3, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

            Rectangle RectD1 = new Rectangle(0, 0, btmpDice1.Width, btmpDice1.Height);
            Rectangle RectD2 = new Rectangle(0, 0, btmpDice2.Width, btmpDice2.Height);
            Rectangle RectD3 = new Rectangle(0, 0, btmpDice3.Width, btmpDice3.Height);
            Rectangle RectD4 = new Rectangle(0, 0, btmpDice4.Width, btmpDice4.Height);
            Rectangle RectD5 = new Rectangle(0, 0, btmpDice5.Width, btmpDice5.Height);
            Rectangle RectD6 = new Rectangle(0, 0, btmpDice6.Width, btmpDice6.Height);
            dataDice1 = btmpDice1.LockBits(RectD1, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            dataDice2 = btmpDice2.LockBits(RectD2, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            dataDice3 = btmpDice3.LockBits(RectD3, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            dataDice4 = btmpDice4.LockBits(RectD4, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            dataDice5 = btmpDice5.LockBits(RectD5, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            dataDice6 = btmpDice6.LockBits(RectD6, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

            Gl.glTexEnvi(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_DECAL);
            Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Glu.gluPerspective(30, OpenGLControl.Width / OpenGLControl.Height, 1, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            btmpBasicTexture.Dispose();
            btmpTableTexture.Dispose();
            btmpTableTextureONE.Dispose();
            btmpDice1.Dispose();
            btmpDice2.Dispose();
            btmpDice3.Dispose();
            btmpDice4.Dispose();
            btmpDice5.Dispose();
            btmpDice6.Dispose();
        }
        private Bitmap ConvertRGBtoBGR(Bitmap image)
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);

                    int newRed = pixel.B;
                    int newBlue = pixel.R;
                    int newGreen = pixel.G;

                    Color newPixel = Color.FromArgb(newRed, newGreen, newBlue);

                    image.SetPixel(x, y, newPixel);
                }
            }
            return image;
        }

        #region Masses
        double[,,] tableObject = {
                { { -15, -0.01, -15 }, { 15, -0.01, -15 }, { 15, -0.01, 15 }, { -15, -0.01, 15 } },
                { { -15, -3, -15 }, { 15, -3, -15 }, { 15, -3, 15 }, { -15, -3, 15 } },
                { { 15, -0.01, 15 }, { 15, -3, 15 }, { 15, -3, -15 }, { 15, -0.01, -15 } },
                { { -15, -0.01, 15 }, { -15, -3, 15 }, { -15, -3, -15 }, { -15, -0.01, -15 } } };

        double[,,] tableONE = {
                { { -15, -0.01, -15 }, { 15, -0.01, -15 }, { 15, -3, -15 }, { -15, -3, -15 } },
                { { -15, -0.01, 15 }, { 15, -0.01, 15 }, { 15, -3, 15 }, { -15, -3, 15 } } };

        double[,,] pyramid = {
                { { 4, 0, 0 }, { 7, 0, -3 }, { 4, 0, -6 }, { 1, 0, -3 } },
                { { 1, 0, -3 }, { 4, 0, -6 }, { 4, 4, -3 }, { 1, 0, -3 } },
                { { 4, 0, -6 }, { 7, 0, -3 }, { 4, 4, -3 }, { 4, 0, -6 } },
                { { 1, 0, -3 }, { 4, 0, 0 }, { 4, 4, -3 }, { 1, 0, -3 } },
                { { 4, 0, 0 }, { 7, 0, -3 }, { 4, 4, -3 }, { 4, 0, 0 } } };

        double[,,] task2Figure = {
            { { 0, 0, 0 }, { 0, 3, 0 }, { 3, 3, 0 }, { 3, 0, 0 } },
            { { 0, 3, 0 }, { 0, 3, -3 }, { 3, 3, -3 }, { 3, 3, 0 } },
            { { 0, 3, 0 }, { 0, 3, -3 }, { 0, 0, -3 }, { 0, 0, 0 } },
            { { 0, 0, -3 }, { 0, 3, -3 }, { 3, 3, -3 }, { 3, 0, -3 } },
            { { 3, 0, 0 }, { 3, 3, 0 }, { 3, 3, -3 }, { 3, 0, -3 } },

            { { 0, 0, -3 }, { 0, 0, -6 }, { 3, 0, -6 }, { 3, 0, -3 } },
            { { 0, 0, -3 }, { 0, -3, -3 }, { 0, -3, -6 }, { 0, 0, -6 } },
            { { 0, 0, -6 }, { 0, -3, -6 }, { 3, -3, -6 }, { 3, 0, -6 } },
            { { 0, -3, -6 }, { 0, -3, -3 }, { 3, -3, -3 }, { 3, -3, -6 } },
            { { 3, -3, -6 }, { 3, 0, -6 }, { 3, 0, -3 }, { 3, -3, -3 } },

            { { 0, 0, 0 }, { -3, 0, 0 }, { -3, 0, -3 }, { 0, 0, -3 } },
            { { -3, 0, 0 }, { -3, -3, 0 }, { 0, -3, 0 }, { 0, 0, 0 } },
            { { -3, 0, 0 }, { -3, -3, 0 }, { -3, -3, -3 }, { -3, 0, -3 } },
            { { -3, -3, 0 }, { 0, -3, 0 }, { 0, -3, -3 }, { -3, -3, -3 } },
            { { -3, 0, -3 }, { 0, 0, -3 }, { 0, -3, -3 }, { -3, -3, -3 } },

            { { 3, 0, 0 }, { 3, 0, -3 }, { 6, 0, -3 }, { 6, 0, 0 } },
            { { 3, 0, -3 }, { 3, -3, -3 }, { 6, -3, -3 }, { 6, 0, -3 } },
            { { 6, 0, -3 }, { 6, -3, -3 }, { 6, -3, 0 }, { 6, 0, 0 } },
            { { 3, -3, -3 }, { 3, -3, 0 }, { 6, -3, 0 }, { 6, -3, -3 } },
            { { 3, 0, 0 }, { 3, -3, 0 }, { 6, -3, 0 }, { 6, 0, 0 } },

            { { 0, 0, 0 }, { 3, 0, 0 }, { 3, 0, 3 }, { 0, 0, 3 } },
            { { 0, 0, 0 }, { 0, -3, 0 }, { 0, -3, 3 }, { 0, 0, 3 } },
            { { 0, -3, 0 }, { 0, -3, 3 }, { 3, -3, 3 }, { 3, -3, 0 } },
            { { 0, 0, 3 }, { 0, -3, 3 }, { 3, -3, 3 }, { 3, 0, 3 } },
            { { 3, 0, 0 }, { 3, -3, 0 }, { 3, -3, 3 }, {  3, 0, 3 } },

            { { 0, -3, 0 }, { 0, -6, 0 }, { 3, -6, 0 }, {3, -3, 0 } },
            { { 0, -3, 0 }, { 0, -6, 0 }, { 0, -6, -3 }, { 0, -3, -3 } },
            { { 0, -6, -3 }, { 0, -3, -3 }, { 3, -3, -3 }, { 3, -6, -3 } },
            { { 3, -6, -3 }, { 3, -3, -3 }, { 3, -3, 0 }, { 3, -6, 0 } },
            { { 0, -6, 0 }, { 3, -6, 0 }, { 3, -6, -3 }, {  0, -6, -3 } } };

        #endregion

        #region BASICS
        public void MakeObjectFromPolygons(double[,,] figureObject)
        {
            double[,] textureCoordinates = { { 0, 0 }, { 0, 1 }, { 1, 1 }, { 1, 0 } };
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glColorMaterial(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            for (int xi = 0; xi < figureObject.GetLength(0); xi++)
            {
                int xx = 0; int t = 0;
                for (int yi = 0; yi < 4; yi++)
                {
                    xx += 1;
                    Gl.glTexCoord2d(textureCoordinates[t, 0], textureCoordinates[t, 1]);
                    if (t + 1 < 4)
                    {
                        t++;
                    }
                    else
                    {
                        t = 0;
                    }

                    Gl.glVertex3d((figureObject[xi, yi, 0]) / 5d, (figureObject[xi, yi, 1]) / 5d, (figureObject[xi, yi, 2]) / 5d);
                }
            }
            Gl.glPopMatrix();
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
        }
        public void CreateSphere(double[] startCoordinates, double radius = 0.5, double angle = 0)
        {
            Gl.glPushMatrix();
            Gl.glTranslated(startCoordinates[0], startCoordinates[1], startCoordinates[2]);
            var q = Glu.gluNewQuadric();
            Glu.gluQuadricTexture(q, Gl.GL_TRUE);
            Glu.gluSphere(q, radius, 30, 30);
            Gl.glPopMatrix();
        }

        public void CreateCylinder(double[] startCoordinates, double radius = 0.5, double angle = 0)
        {
            Gl.glPushMatrix();
            Gl.glTranslated(startCoordinates[0], startCoordinates[1], startCoordinates[2]);
            var q = Glu.gluNewQuadric();
            Glu.gluQuadricTexture(q, Gl.GL_TRUE);

            Gl.glRotated(-90, 1, 0, 0);
            Glu.gluDisk(q, 0, radius, 16, 1);
            Glu.gluCylinder(q, radius, radius, 1, 30, 30);
            Gl.glTranslatef(0, 0, 1);
            Glu.gluDisk(q, 0, radius, 16, 1);
            Gl.glPopMatrix();
        }
        #endregion

        #region TASK1
        private void button1_Click(object sender, EventArgs e)
        {
            timerForTask4.Stop();
            timerForTask2.Stop();

            trackBarXrot1.Value = 20;
            trackBarYrot1.Value = 60;
            trackBarZrot1.Value = 0;
            trackBarZvalueTask1.Value = -10;

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glTranslatef(0, 0, -10);
            Gl.glRotated(20, 1, 0, 0);
            Gl.glRotated(60, 0, 1, 0);

            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glDisable(Gl.GL_TEXTURE_2D);

            CreateSphere(new double[] { -1, 0.4, 0 }, 0.4);


            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataTableTexture.Width, dataTableTexture.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataTableTexture.Scan0);
            MakeObjectFromPolygons(tableObject);

            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataTableTextureONE.Width, dataTableTextureONE.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataTableTextureONE.Scan0);
            MakeObjectFromPolygons(tableONE);

            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataBasicTexture.Width, dataBasicTexture.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataBasicTexture.Scan0);
            MakeObjectFromPolygons(pyramid);


            CreateCylinder(new double[] { 0, 0, -1.8 });


            Gl.glFlush();


            OpenGLControl.Invalidate();
        }
        private void rotateTask1()
        {
            timerForTask4.Stop();
            timerForTask2.Stop();
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glTranslatef(0, -0f, trackBarZvalueTask1.Value);
            Gl.glRotated(trackBarXrot1.Value, 1, 0, 0);
            Gl.glRotated(trackBarYrot1.Value, 0, 1, 0);
            Gl.glRotated(trackBarZrot1.Value, 0, 0, 1);

            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glDisable(Gl.GL_TEXTURE_2D);

            CreateSphere(new double[] { -1, 0.4, 0 }, 0.4);


            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataTableTexture.Width, dataTableTexture.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataTableTexture.Scan0);
            MakeObjectFromPolygons(tableObject);

            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataTableTextureONE.Width, dataTableTextureONE.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataTableTextureONE.Scan0);
            MakeObjectFromPolygons(tableONE);

            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataBasicTexture.Width, dataBasicTexture.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataBasicTexture.Scan0);
            MakeObjectFromPolygons(pyramid);

            CreateCylinder(new double[] { 0, 0, -1.8 });

            Gl.glFlush();
            OpenGLControl.Invalidate();
        }
        private void trackBarXrot1_ValueChanged(object sender, EventArgs e) => rotateTask1();
        private void trackBarYrot1_ValueChanged(object sender, EventArgs e) => rotateTask1();
        private void trackBarZrot1_ValueChanged(object sender, EventArgs e) => rotateTask1();
        private void trackBarZvalueTask1_ValueChanged(object sender, EventArgs e) => rotateTask1();
        #endregion

        #region TASK2
        float xrot2 = 0f;
        float yrot2 = 0f;
        float zrot2 = 0f;
        bool timerTask2IsRunning = false;
        private void button2_Click(object sender, EventArgs e)
        {
            timerForTask4.Stop();
            timerForTask2.Stop();

            trackBarXrot2.Value = 0;
            trackBarYrot2.Value = 0;
            trackBarZrot2.Value = 0;

            timerTask2IsRunning = false;
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glTranslatef(0, 0, -6.0f);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataBasicTexture.Width, dataBasicTexture.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataBasicTexture.Scan0);
            MakeObjectFromPolygons(task2Figure);
            Gl.glFlush();
            OpenGLControl.Invalidate();
        }
        private void timerForTask2_Tick(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glTranslatef(0, 0, -8.0f);
            Gl.glRotated(xrot2 += 2, 1, 0, 0);
            Gl.glRotated(yrot2 += 1, 0, 1, 0);
            Gl.glRotated(zrot2 += 0.5f, 0, 0, 1);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataBasicTexture.Width, dataBasicTexture.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataBasicTexture.Scan0);
            MakeObjectFromPolygons(task2Figure);
            Gl.glFlush();
            OpenGLControl.Invalidate();
        }
        private void buttonTask2RotationByTimer_Click(object sender, EventArgs e)
        {
            if (timerTask2IsRunning)
            {
                timerForTask2.Stop();
                timerTask2IsRunning = false;
            }
            else
            {
                timerForTask2.Start();
                timerTask2IsRunning = true;
            }
        }
        private void rotateTask2()
        {
            timerForTask4.Stop();
            timerForTask2.Stop();
            timerTask2IsRunning = false;
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glTranslatef(0, 0, -6.0f);
            Gl.glRotated(trackBarXrot2.Value, 1, 0, 0);
            Gl.glRotated(trackBarYrot2.Value, 0, 1, 0);
            Gl.glRotated(trackBarZrot2.Value, 0, 0, 1);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataBasicTexture.Width, dataBasicTexture.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataBasicTexture.Scan0);
            MakeObjectFromPolygons(task2Figure);
            Gl.glFlush();
            OpenGLControl.Invalidate();
        }
        private void trackBarXrot2_ValueChanged(object sender, EventArgs e) => rotateTask2();
        private void trackBarYrot2_ValueChanged(object sender, EventArgs e) => rotateTask2();
        private void trackBarZrot2_ValueChanged(object sender, EventArgs e) => rotateTask2();

        #endregion

        #region TASK3-4
        double z = 10;
        double x = 10;
        private void button3_Click(object sender, EventArgs e)
        {
            z = 10;
            x = 10;
            timerForTask4.Start();
            timerForTask2.Stop();
        }
        private void rotateTask4()
        {
            timerForTask4.Interval = trackBarAnimationSpeedH.Maximum + trackBarAnimationSpeedH.Minimum - trackBarAnimationSpeedH.Value;
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glTranslatef(0, 0, trackBarZvalueTask4.Value);
            Gl.glRotated(trackBarXrot4.Value, 1, 0, 0);
            Gl.glRotated(trackBarYrot4.Value, 0, 1, 0);
            Gl.glRotated(trackBarZrot4.Value, 0, 0, 1);

            Gl.glEnable(Gl.GL_TEXTURE_2D);

            double[,,] Dice1 = { { { x, 0, z }, { x, 0, z - 3 }, { x - 3, 0, z - 3 }, { x - 3, 0, z } } };
            double[,,] Dice2 = { { { x, 0, z }, { x, 3, z }, { x, 3, z - 3 }, { x, 0, z - 3 } } };
            double[,,] Dice3 = { { { x, 3, z }, { x, 3, z - 3 }, { x - 3, 3, z - 3 }, { x - 3, 3, z } } };
            double[,,] Dice4 = { { { x - 3, 0, z }, { x - 3, 3, z }, { x - 3, 3, z - 3 }, { x - 3, 0, z - 3 } } };
            double[,,] Dice5 = { { { x, 0, z - 3 }, { x, 3, z - 3 }, { x - 3, 3, z - 3 }, { x - 3, 0, z - 3 } } };
            double[,,] Dice6 = { { { x, 0, z }, { x, 3, z }, { x - 3, 3, z }, { x - 3, 0, z } } };

            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataTableTexture.Width, dataTableTexture.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataTableTexture.Scan0);
            MakeObjectFromPolygons(tableObject);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataTableTextureONE.Width, dataTableTextureONE.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataTableTextureONE.Scan0);
            MakeObjectFromPolygons(tableONE);

            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataDice1.Width, dataDice1.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataDice1.Scan0);
            MakeObjectFromPolygons(Dice1);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataDice2.Width, dataDice2.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataDice2.Scan0);
            MakeObjectFromPolygons(Dice2);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataDice3.Width, dataDice3.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataDice3.Scan0);
            MakeObjectFromPolygons(Dice3);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataDice4.Width, dataDice4.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataDice4.Scan0);
            MakeObjectFromPolygons(Dice4);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataDice5.Width, dataDice5.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataDice5.Scan0);
            MakeObjectFromPolygons(Dice5);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, dataDice6.Width, dataDice6.Height, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, dataDice6.Scan0);
            MakeObjectFromPolygons(Dice6);

            Gl.glFlush();
            OpenGLControl.Invalidate();

            if (x == 10 && z > -7)
            {
                z -= 0.5;
            }
            else if (z == -7 && x > -7)
            {
                x -= 0.5;
            }
            else if (x == -7 && z < 10)
            {
                z += 0.5;
            }
            else if (z == 10 && x < 10)
            {
                x += 0.5;
            }
        }
        private void timerForTask4_Tick(object sender, EventArgs e) => rotateTask4();
        #endregion
    }
}