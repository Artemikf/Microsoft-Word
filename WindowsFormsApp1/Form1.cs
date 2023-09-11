using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool jer = false; bool kur = false; bool pod = false;
        bool clev = false; bool pocnt = false; bool cprav = false; bool mark = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripButton1.Text = "Жирный";
            
            toolStripButton2.Text = "Курсив";
            toolStripButton3.Text = "Подчеркнутый";
            toolStripButton4.Text = "Слева";
            toolStripButton5.Text = "Посредине";
            toolStripButton6.Text = "Справа";
            toolStripButton7.Text = "Маркировка";
            toolStripButton8.Text = "Картинка";
            toolStripButton9.Text = "Назад";
            toolStripButton10.Text = "Вперед";
            toolStripSplitButton1.Text = "Цвет текста";
            toolStripSplitButton2.Text = "Размер текста";
            toolStripComboBox1.Text = "Выбор шрифта";
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 11);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            jer = true;
            if (jer)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                jer = false;
            }
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            kur = true;
            if (kur)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
            }
            else
                kur = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            pod = true;
            if (pod)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline    );
            }
            else
                pod = false;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            clev = true;
            if (clev)
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            else
                clev = false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            pocnt = true;
            if (pocnt)
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            else
                pocnt = false;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            cprav = true;
            if (cprav)
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            else
                cprav = false;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Black;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 11);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 13);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 14);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 15);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 16);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            mark = true;
            if (mark)
                richTextBox1.SelectionBullet = true;
            else
            {
                richTextBox1.SelectionBullet = false;
                mark = false;
            }


        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile("img/f1.png");
            image = new Bitmap(image, new Size(120, 120));
            Clipboard.SetImage(image);
            richTextBox1.Paste();

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
