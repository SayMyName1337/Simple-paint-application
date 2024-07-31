using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Graphics.OpenGL;

using KeyPressEventArgs = System.Windows.Forms.KeyPressEventArgs;

namespace LR4
{
    public partial class Form1 : Form
    {
        private TwoDWorkMode workMode1;
        private ThreeDWorkMode workMode2;
        private ViewportMode viewportMode;
        private Color backgroundColor = Color.WhiteSmoke;

        private Sphere sphere = new Sphere(new Point3D(), 3, Color.Blue);

        private List<TwoDObject> twoDObjects = new List<TwoDObject>();

        private bool mousePressed = false;
        int mx, my;

        private int sphereAngleZ = 0;
        private int sphereAngleY = 0;
        private float sphereScale = 1;

        private Manual manual;

        public Form1()
        {
            InitializeComponent();
            twoDObjects.Add(new TwoDObject());
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            SetupViewport();
            glControl1.Invalidate();
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            SetupViewport();
            glControl1.Invalidate();
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            if(viewportMode == ViewportMode.THREE_D)
            {
                Matrix4 lMatrix = Matrix4.LookAt(15f, 0f, 0f, 0, 0, 0, 0, 0, 1);
                GL.MatrixMode(MatrixMode.Modelview);
                GL.LoadMatrix(ref lMatrix);

                GL.Rotate(sphereAngleZ, new Vector3d(0, 0, 1));
                GL.Rotate(sphereAngleY, new Vector3d(0, 1, 0));
                GL.Scale(new Vector3(sphereScale));
                sphere.Draw();
            }
            else
            {
                foreach (TwoDObject obj in twoDObjects)
                    obj.Draw();
            }
            
            glControl1.SwapBuffers();
        }

        private void glControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            if(viewportMode == ViewportMode.TWO_D && workMode1 == TwoDWorkMode.ADD)
            {
                twoDObjects[twoDObjects.Count - 1].AddPoint(e.X, e.Y);
                glControl1.Invalidate();

            }
            if (viewportMode == ViewportMode.TWO_D && workMode1 == TwoDWorkMode.EDIT)
            {
                foreach (TwoDObject obj in twoDObjects)
                {
                    if (obj.Hit(e.X, e.Y))
                    {
                        mousePressed = true;
                        mx = e.X;
                        my = e.Y;
                    }
                }
                    
                glControl1.Invalidate();
            }
            if (viewportMode == ViewportMode.THREE_D)
            {
                mousePressed = true;
                mx = e.X;
                my = e.Y;
            }
        }

        private void glControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mousePressed = false;
        }

        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mousePressed)
                return;
            if (viewportMode == ViewportMode.TWO_D && workMode1 == TwoDWorkMode.EDIT)
            {
                foreach (TwoDObject obj in twoDObjects)
                {
                    obj.Drag(e.X - mx, e.Y - my);
                }
            }
            if (viewportMode == ViewportMode.THREE_D && workMode2 == ThreeDWorkMode.ROTATE)
            {
                sphereAngleZ += (e.X - mx);
                sphereAngleY += (e.Y - my);
            }
            if (viewportMode == ViewportMode.THREE_D && workMode2 == ThreeDWorkMode.SCALE)
            {
                sphereScale += ((e.X - mx) + (e.Y - my)) / 10.0f;
                if (sphereScale < 0.2)
                    sphereScale = 0.2f;

                if (sphereScale > 3)
                    sphereScale = 3;
            }

            mx = e.X;
            my = e.Y;

            glControl1.Invalidate();
        }

        private void glControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (viewportMode == ViewportMode.THREE_D)
                return;

            switch (e.KeyChar)
            {
                case (char)13: //Enter
                    twoDObjects.Add(new TwoDObject());
                    break;

                case (char)32: //Space
                    twoDObjects[twoDObjects.Count - 1].IsClosed = true;
                    break;
            }

            glControl1.Invalidate();
        }

        private void SetupViewport()
        {
            GL.LoadIdentity();

            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            GL.ClearColor(backgroundColor);

            switch (viewportMode)
            {
                case ViewportMode.TWO_D:
                    GL.Disable(EnableCap.DepthTest);
                    GL.Disable(EnableCap.Lighting);
                    GL.Disable(EnableCap.Normalize);
                    GL.Disable(EnableCap.Light0);

                    GL.MatrixMode(MatrixMode.Projection);
                    GL.PushMatrix();
                    GL.LoadIdentity();
                    GL.Ortho(0, glControl1.Width, glControl1.Height, 0, 0, 1);
                    GL.MatrixMode(MatrixMode.Modelview);
                    break;

                case ViewportMode.THREE_D:
                    GL.Enable(EnableCap.DepthTest);
                    GL.DepthFunc(DepthFunction.Less);
                    GL.DepthMask(true);
                    Matrix4 perspectiveMatrix = Matrix4.CreatePerspectiveFieldOfView(1f, (float)glControl1.Width / glControl1.Height, 0.5f, 50);
                    GL.MatrixMode(MatrixMode.Projection);
                    GL.LoadMatrix(ref perspectiveMatrix);

                    GL.Enable(EnableCap.Lighting);
                    GL.Enable(EnableCap.Normalize);
                    GL.ShadeModel(ShadingModel.Smooth);

                    GL.Light(LightName.Light0, LightParameter.Ambient, new float[] { 0.3f, 0.3f, 0.3f });
                    GL.Light(LightName.Light0, LightParameter.Diffuse, new float[] { 0.3f, 0.3f, 0.3f });
                    GL.Light(LightName.Light0, LightParameter.Specular, new float[] { 0.5f, 0.5f, 0.5f });
                    GL.Light(LightName.Light0, LightParameter.Position, new float[] { 5.0f, 5.0f, 5.0f });

                    GL.Enable(EnableCap.Light0);
                    break;
            }
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TwoDObject obj in twoDObjects)
                obj.LineType = LineTypes.SOLID;
            solidToolStripMenuItem.Checked = true;
            dottedToolStripMenuItem.Checked = false;
            glControl1.Invalidate();
        }

        private void dottedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TwoDObject obj in twoDObjects)
                obj.LineType = LineTypes.DOTTED;
            solidToolStripMenuItem.Checked = false;
            dottedToolStripMenuItem.Checked = true;
            glControl1.Invalidate();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;
            backgroundColor = colorDialog.Color;
            SetupViewport();
            glControl1.Invalidate();
        }

        private void objectsColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;
            foreach (TwoDObject obj in twoDObjects)
                obj.LinesColor = colorDialog.Color;
            glControl1.Invalidate();
        }

        private void twoDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode1ToolStripMenuItem.Text = "Добавление";
            mode2ToolStripMenuItem.Text = "Редактирование";

            mode1ToolStripMenuItem.Checked = workMode1 == TwoDWorkMode.ADD ? true : false;
            mode2ToolStripMenuItem.Checked = workMode1 == TwoDWorkMode.EDIT ? true : false;

            viewportMode = ViewportMode.TWO_D;
            twoDToolStripMenuItem.Checked = true;
            threeDToolStripMenuItem.Checked = false;
            SetupViewport();
            glControl1.Invalidate();
        }

        private void threeDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode1ToolStripMenuItem.Text = "Вращение";
            mode2ToolStripMenuItem.Text = "Масштабирование";

            mode1ToolStripMenuItem.Checked = workMode2 == ThreeDWorkMode.ROTATE ? true : false;
            mode2ToolStripMenuItem.Checked = workMode2 == ThreeDWorkMode.SCALE ? true : false;

            viewportMode = ViewportMode.THREE_D;
            twoDToolStripMenuItem.Checked = false;
            threeDToolStripMenuItem.Checked = true;
            SetupViewport();
            glControl1.Invalidate();
        }

        private void mode1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewportMode == ViewportMode.TWO_D)
                workMode1 = TwoDWorkMode.ADD;
            else
                workMode2 = ThreeDWorkMode.ROTATE;

            mode1ToolStripMenuItem.Checked = true;
            mode2ToolStripMenuItem.Checked = false;
        }

        private void mode2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewportMode == ViewportMode.TWO_D)
                workMode1 = TwoDWorkMode.EDIT;
            else
                workMode2 = ThreeDWorkMode.SCALE;

            mode1ToolStripMenuItem.Checked = false;
            mode2ToolStripMenuItem.Checked = true;
        }

        private void solidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sphere.DrawType = DrawingType.SOLID;
            solidToolStripMenuItem1.Checked = true;
            wiredToolStripMenuItem.Checked = false;
            dottedToolStripMenuItem1.Checked = false;
            glControl1.Invalidate();
        }

        private void wiredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sphere.DrawType = DrawingType.WIRED;
            solidToolStripMenuItem1.Checked = false;
            wiredToolStripMenuItem.Checked = true;
            dottedToolStripMenuItem1.Checked = false;
            glControl1.Invalidate();
        }

        private void dottedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sphere.DrawType = DrawingType.DOTTED;
            solidToolStripMenuItem1.Checked = false;
            wiredToolStripMenuItem.Checked = false;
            dottedToolStripMenuItem1.Checked = true;
            glControl1.Invalidate();
        }

        private void oneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TwoDObject obj in twoDObjects)
                obj.LineWidth = 1;
            glControl1.Invalidate();
            oneToolStripMenuItem.Checked = true;
            twoToolStripMenuItem.Checked = false;
            threeToolStripMenuItem.Checked = false;
        }

        private void twoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TwoDObject obj in twoDObjects)
                obj.LineWidth = 2;
            glControl1.Invalidate();
            oneToolStripMenuItem.Checked = false;
            twoToolStripMenuItem.Checked = true;
            threeToolStripMenuItem.Checked = false;
        }

        private void threeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TwoDObject obj in twoDObjects)
                obj.LineWidth = 3;
            glControl1.Invalidate();
            oneToolStripMenuItem.Checked = false;
            twoToolStripMenuItem.Checked = false;
            threeToolStripMenuItem.Checked = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }

    enum ViewportMode
    {
        TWO_D, THREE_D
    }

    enum TwoDWorkMode
    {
        ADD, EDIT
    }

    enum ThreeDWorkMode
    {
        ROTATE, SCALE
    }
}
