using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace _30klab
{
    public partial class Form1 : Form
    {   
        float rotX=0,rotY=0, rotZ=0;

        float[][] pt = {
        new float[] { -0.5f, -0.5f, -0.5f },new float[] { -0.5f, +0.5f, -0.5f },
        new float[] { 0.5f, -0.5f, -0.5f },new float[] { 0.5f, +0.5f, -0.5f },
        new float[] { -0.5f, -0.5f, 0.5f },new float[] { -0.5f, +0.5f, 0.5f },
        new float[] { 0.5f, -0.5f, 0.5f },new float[] { 0.5f, 0.5f, 0.5f }
        };


    public Form1()
        {
            InitializeComponent();
            OPENGLC.InitializeContexts();
            Gl.glClearColor(0, 0, 0, 0);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(-2, 2, -2, 2, -2, 2);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cube();
            OPENGLC.Refresh();
            
        }
        private void quad (int n1,int n2,int n3,int n4)
        {
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3fv(pt[n1]);
            Gl.glVertex3fv(pt[n1]);
            Gl.glColor3fv(pt[n2]);
            Gl.glVertex3fv(pt[n2]);
            Gl.glColor3fv(pt[n3]);
            Gl.glVertex3fv(pt[n3]);
            Gl.glColor3fv(pt[n4]);
            Gl.glVertex3fv(pt[n4]);
            Gl.glEnd();
        }

        private void btnxtransform_Click(object sender, EventArgs e)
        {
            rotX = (rotX + 5) % 360;
            OPENGLC.Refresh();
        }

        private void btnytransform_Click(object sender, EventArgs e)
        {
            rotY = (rotY + 5) % 360;
            OPENGLC.Refresh();
        }

        private void btnztransform_Click(object sender, EventArgs e)
        {
            rotZ = (rotZ + 5) % 360;
            OPENGLC.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rotZ = (rotZ + Convert.ToInt32(numericUpDown1.Value)) % 360;
            rotX = rotY + rotZ;
            OPENGLC.Refresh();
        }

        private void btnanmstart_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            timer1.Interval = 10;
            timer1.Start();
        }

        private void endanimation_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            timer1.Stop();
        }

        public void cube()
        {
            quad(6, 2, 3, 7);
            quad(5, 1, 0, 4);
            quad(7 ,3 ,1, 5);
            quad(4, 0, 2, 6);
            quad(2, 0, 1, 3);
            quad(7 ,5, 4, 6);
        }

        private void OPENGLC_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glShadeModel(Gl.GL_SMOOTH); 
            Gl.glPushMatrix();
            Gl.glRotatef(rotX, 1, 0, 0);
            Gl.glRotatef(rotY, 0, 1, 0);
            Gl.glRotatef(rotZ, 0, 0, 1);
            cube();
            Gl.glPopMatrix();
        }
    }
}
