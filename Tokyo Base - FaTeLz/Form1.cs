using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions;
namespace Tokyo
{
    public partial class Form1 : Form
    {
        //Settings

        Color OutlineColor = Color.FromArgb(0, 0, 0);
        Color HeaderColor = Color.DeepSkyBlue;
        Color HeaderColor2 = Color.DodgerBlue;
        Font HeaderFont = new Font("Arial", 14, FontStyle.Regular);
        float HeaderRotation = 0.0f;
        Color TitleColor = Color.FromArgb(255, 255, 255);
        String Title = "Tokyo Base";
        Color BodyColor = Color.FromArgb(240, 240, 240);
        int HeaderHeight = 40;


        MemoryFunctions Mem;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        bool mouseDown = false;
        bool active = false;

        bool godmode;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey); // Keys enumeration
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(System.Int32 vKey);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Form1(MemoryFunctions MemoryFunctions)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            Mem = MemoryFunctions;
        }
        private void init()
        {
            this.BackColor = BodyColor;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Base Created By FaTeLz/nTo Use this base you must credit:/nFaTeLz/nSir Mestre/n.Bypass");
        }
        
        void features()
        {
            if (active)
            {
                Mem._SET_INVINCIBILTY(godmode);
            }
        }
        float headerRot = 0;
        int fadeCol = 0;
        bool fadeUp = true;

        void fadeColor(Control control)
        {
            if (fadeUp)
            {
                fadeCol += 10;
            }
            else
            {
                fadeCol -= 10;
            }
            if (fadeCol == 240)
            {
                fadeUp = false;
            }
            else if (fadeCol == 0)
            {
                fadeUp = true;
            }
            control.ForeColor = Color.FromArgb(255, fadeCol, fadeCol, fadeCol);
        }
        private void scriptMain(object sender, EventArgs e)
        {
            fadeColor(label1);
            HeaderRotation += 1f;
            if (HeaderRotation == headerRot + 30)
            {
                headerRot = HeaderRotation;
                Invalidate();
            }
            godmode = godMode.Checked;
        }

        private void main(object sender, PaintEventArgs e)
        {
            Rectangle cRect = ClientRectangle;
            LinearGradientBrush headerFade = new LinearGradientBrush(new Rectangle(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, HeaderHeight), HeaderColor, HeaderColor2, HeaderRotation);
            Graphics Drawing = e.Graphics;
         Drawing.FillRectangle(headerFade, new Rectangle(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, HeaderHeight));
            e.Graphics.DrawString(Title, HeaderFont, new SolidBrush(TitleColor), new RectangleF(cRect.X, cRect.Y, cRect.Width, HeaderHeight), new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
            

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
        }

        private void tokyo_CheckBox1_CheckedChanged(object sender)
        {
            active = !active;
        }

        private void godMode_CheckedChanged(object sender)
        {

        }
    }
}
