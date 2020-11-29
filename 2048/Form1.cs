using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        
        Label[,] blockArr;
        int[,] valueArr;
        Dictionary<int, Color> bgColor = new Dictionary<int, Color>
        {
            { 0, Color.FromArgb(205, 193, 180) },
            { 2, Color.FromArgb(238, 228, 218) },
            { 4, Color.FromArgb(238, 225, 201) },
            { 8, Color.FromArgb(243, 178, 122) },
            { 16, Color.FromArgb(246, 150, 100) },
            { 32, Color.FromArgb(247, 124, 95) },
            { 64, Color.FromArgb(247, 95, 59) },
            { 128, Color.FromArgb(237, 208, 115) },
            { 256, Color.FromArgb(237, 204, 98) }
        };
        Dictionary<int, Color> fontColor = new Dictionary<int, Color>
        {
            { 0, Color.FromArgb(119, 110, 101) },
            { 2, Color.FromArgb(119, 110, 101) },
            { 4, Color.FromArgb(119, 110, 101) },
            { 8, Color.FromArgb(255, 255, 255) },
            { 16, Color.FromArgb(255, 255, 255) },
            { 32, Color.FromArgb(255, 255, 255) },
            { 64, Color.FromArgb(255, 255, 255) },
            { 128, Color.FromArgb(255, 255, 255) },
            { 256, Color.FromArgb(255, 255, 255) }
        };
        public Form1()
        {
            InitializeComponent();
            InitValues();
            CreateBlock();
            Display();
        }
        private bool IsEmptyBlock(Point p)
        {
            return valueArr[p.x, p.y] != 0 ? true : false;
        }

        private int GetEmptyBlockNum()
        {
            int emptyBlockNum = 0;
            for (int i=0; i<4; i++)
            {
                for (int j=0; j<4; j++)
                {
                    if (valueArr[i, j] == 0) emptyBlockNum++;
                }
            }
            return emptyBlockNum;
        }

        private Point GetRandomValue()
        {
            Random r = new Random();
            Point p = new Point(r.Next(0, 4), r.Next(0, 4));
            while (IsEmptyBlock(p) && GetEmptyBlockNum()!=0)
            {
                p = new Point(r.Next(0, 4), r.Next(0, 4));
            }
            return p;
        }

        private void CreateBlock()
        {
            int getEmptyBlockNum = GetEmptyBlockNum();
            int loopNum = 2;
            if (getEmptyBlockNum == 0) return;
            if (getEmptyBlockNum == 1) loopNum = 1;
            for (int i = 0; i < loopNum; i++)
            {
                Point p = GetRandomValue();
                valueArr[p.x, p.y] = 2;
            }
        }

        private void InitValues()
        {
            blockArr = new Label[4, 4]{
                { Block11, Block12, Block13, Block14 },
                { Block21, Block22, Block23, Block24 },
                { Block31, Block32, Block33, Block34 },
                { Block41, Block42, Block43, Block44 }
            };
            
            valueArr = new int[4, 4]{
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };
        }
        private void Display()
        {
            for (int i=0; i<4; i++) {
                for (int j=0; j<4; j++) {
                    Label block = blockArr[i, j];
                    int value = valueArr[i, j];
                    SetColor(block, value);
                    block.Text = value.ToString();
                    if (value == 0) block.Text = "";
                }
            }
        }

        private void SetColor(Label block, int value)
        {
            try
            {
                block.BackColor = bgColor[value];
                block.ForeColor = fontColor[value];
            }
            catch
            {
                block.BackColor = Color.FromArgb(255, 0, 0);
                block.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode.ToString())
            {
                case "W":
                    UpKeyDown();
                    break;
                case "A":
                    LeftKeyDown();
                    break;
                case "S":
                    DownKeyDown();
                    break;
                case "D":
                    RightKeyDown();
                    break;
            }
            CreateBlock();
            Display();
        }

        private void RightKeyDown()
        {
            for(int i=0; i<4; i++)
            {
                for(int j=3; j>0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (valueArr[i, j] != 0 && valueArr[i, j] == valueArr[i, k])
                        {
                            ScoreText.Text = (int.Parse(ScoreText.Text) + valueArr[i, j]).ToString();
                            valueArr[i, j] *= 2;
                            valueArr[i, k] = 0;
                            break;
                        }
                        if (valueArr[i, k] != 0) break;
                    }
                }
                for (int j=3; j>0; j--)
                {
                    for (int k=j-1; k>=0; k--)
                    {
                        if (valueArr[i, j] == 0 && valueArr[i, k] != 0) {
                            valueArr[i, j] = valueArr[i, k];
                            valueArr[i, k] = 0;
                        }
                    }
                }
            }
        }
        private void LeftKeyDown()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = j+1; k < 4; k++)
                    {
                        if (valueArr[i, j] != 0 && valueArr[i, j] == valueArr[i, k])
                        {
                            ScoreText.Text = (int.Parse(ScoreText.Text) + valueArr[i, j]).ToString();
                            valueArr[i, j] *= 2;
                            valueArr[i, k] = 0;
                            break;
                        }
                        if (valueArr[i, k] != 0) break;
                    }
                }
                for (int j = 0; j < 3; j++)
                {
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (valueArr[i, j] == 0 && valueArr[i, k] != 0)
                        {
                            valueArr[i, j] = valueArr[i, k];
                            valueArr[i, k] = 0;
                        }
                    }
                }
            }
        }

        private void UpKeyDown()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (valueArr[j, i] != 0 && valueArr[j, i] == valueArr[k, i])
                        {
                            ScoreText.Text = (int.Parse(ScoreText.Text) + valueArr[j, i]).ToString();
                            valueArr[j, i] *= 2;
                            valueArr[k, i] = 0;
                            break;
                        }
                        if (valueArr[k, i] != 0) break;
                    }
                }
                for (int j = 0; j < 3; j++)
                {
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (valueArr[j, i] == 0 && valueArr[k, i] != 0)
                        {
                            valueArr[j, i] = valueArr[k, i];
                            valueArr[k, i] = 0;
                        }
                    }
                }
            }
        }
        private void DownKeyDown()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j > 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (valueArr[j, i] != 0 && valueArr[j, i] == valueArr[k, i])
                        {
                            ScoreText.Text = (int.Parse(ScoreText.Text) + valueArr[j, i]).ToString();
                            valueArr[j, i] *= 2;
                            valueArr[k, i] = 0;
                            break;
                        }
                        if (valueArr[k, i] != 0) break;
                    }
                }
                for (int j = 3; j > 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (valueArr[j, i] == 0 && valueArr[k, i] != 0)
                        {
                            valueArr[j, i] = valueArr[k, i];
                            valueArr[k, i] = 0;
                        }
                    }
                }
            }
        }

        private void ClearScore()
        {
            ScoreText.Text = "0";
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            ClearScore();
            InitValues();
            CreateBlock();
            Display();
        }
    }
    public class Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
