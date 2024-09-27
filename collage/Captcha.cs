using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collage
{
    public class Captcha
    {
        public enum eCaptchaResult
        {
            WRONG = 0,
            OK = 1
        }
        delegate void OnEnter(bool compares);
        private class CaptchaForm : Form
        {
            private int m_iLength;
            private Font m_Font;
            private TextBox m_TextBox;
            private string m_sGeneratedText;
            private OnEnter m_Callback;

            private const int MARGIN_TOP = 20;
            private const int MARGIN_LEFT = 20;

            private int m_iTriesLeft;
            public void OnKeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (m_sGeneratedText.ToLower() == m_TextBox.Text.ToLower())
                    {
                        m_Callback(true);
                        this.Close();
                    }
                    else
                    {
                        if (--m_iTriesLeft <= 0)
                        {
                            m_Callback(false);
                            m_iTriesLeft = 3;
                            this.Close();
                        }
                        MessageBox.Show("Wrong captcha!");
                        GenerateNewCaptcha();
                    }
                }
            }
            public void GenerateNewCaptcha()
            {
                Random rand = new Random(DateTime.Now.Millisecond + DateTime.Now.Second);
                m_sGeneratedText = "";
                Graphics g = this.CreateGraphics();
                g.Clear(Color.White);
                for (int i = 0; i < m_iLength; i++)
                {
                    string letter = new string(new char[] { rand.Next(2) == 1 ? (char)rand.Next('0', '9') : (char)rand.Next('A', 'Z') });
                    m_sGeneratedText += letter;
                    g.DrawString(letter, m_Font, rand.Next(2) == 1 ? Brushes.Black : Brushes.Purple, new PointF(MARGIN_LEFT + i * ((int)m_Font.Size + 2) + rand.Next(-3, 3), MARGIN_TOP + rand.Next(-3, 3)));
                }
                g.DrawLine(Pens.Aquamarine, new Point(MARGIN_LEFT, rand.Next(MARGIN_TOP, MARGIN_TOP + (int)m_Font.Size)), new Point(MARGIN_LEFT + m_iLength * ((int)m_Font.Size + 2), rand.Next(MARGIN_TOP, MARGIN_TOP + (int)m_Font.Size)));
                g.DrawLine(Pens.Gray, new Point(MARGIN_LEFT, rand.Next(MARGIN_TOP, MARGIN_TOP + (int)m_Font.Size)), new Point(MARGIN_LEFT + m_iLength * ((int)m_Font.Size + 2), rand.Next(MARGIN_TOP, MARGIN_TOP + (int)m_Font.Size)));
                g.Dispose();
            }
            public void OnShow(object sender, EventArgs e)
            {
                GenerateNewCaptcha();
            }
            public CaptchaForm(int length)
            {
                m_iLength = Math.Abs(length);
                m_Font = new Font("Times New Roman", 12, FontStyle.Bold | FontStyle.Italic);
                //Form
                this.Size = new Size(m_iLength * ((int)m_Font.Size + 2) + MARGIN_LEFT * 2
                                   , (int)m_Font.Size + MARGIN_TOP * 2 + 80); // Font + 5 on top + 5 on bottom + 5 space on top + 40 textbox + 5 space on bottom     
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                this.ShowInTaskbar = true;
                this.BackColor = Color.White;
                this.Shown += OnShow;
                //TextBox
                m_TextBox = new TextBox();
                m_TextBox.Location = new Point(MARGIN_LEFT, (int)m_Font.Size + MARGIN_TOP + 10);
                m_TextBox.Font = new Font("Consolas", 12);
                m_TextBox.Size = new Size(m_iLength * ((int)m_TextBox.Font.Size + 2), (int)(m_TextBox.Font.Size * m_iLength) + 6);
                m_TextBox.KeyDown += OnKeyDown;
                this.Controls.Add(m_TextBox);
            }
            public void Open(OnEnter callback)
            {
                m_Callback = callback;
                m_iTriesLeft = 3;
                GenerateNewCaptcha();
                this.ShowDialog();
            }
        }
        private static eCaptchaResult m_Result;
        private static void Callback(bool res)
        {
            m_Result = res ? eCaptchaResult.OK : eCaptchaResult.WRONG;
        }
        public static eCaptchaResult Show(int length)
        {
            m_Result = eCaptchaResult.WRONG;
            CaptchaForm form = new CaptchaForm(length);
            form.Open(Callback);
            return m_Result;
        }
    }
}
