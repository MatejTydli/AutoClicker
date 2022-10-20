using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using Cursor = System.Windows.Forms.Cursor;

namespace AutoClicker
{
	public partial class Form1 : Form
	{
        bool run = false;
        bool helperRun = false;
        bool helperRun2 = false;
        bool lockCursor = false;
        bool lockCursorOnCurrentPos = false;
        int cursorPosX, cursorPosY;

        readonly string[] mouseAction;

        Key startKey = Key.F;
        Key stopKey = Key.C;

        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        const int MOUSEEVENTF_LEFTUP = 0x0004;
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008;   
        const int MOUSEEVENTF_RIGHTUP = 0x0010;
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        const int MOUSEEVENTF_WHEEL = 0x0800;

        uint selectedEvent1 = MOUSEEVENTF_LEFTDOWN;
        uint selectedEvent2 = MOUSEEVENTF_LEFTUP;

        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            numInterval.Maximum = int.MaxValue;
            numX.Minimum = int.MinValue;
            numY.Minimum = int.MinValue;
            numX.Maximum = int.MaxValue;
            numY.Maximum = int.MaxValue;
            
            mouseAction = new string[] { "left mouse button", "right mouse button" };
            actionListBox.SelectedItem = mouseAction[0];
            timer1.Interval = (int)Math.Round(numInterval.Value);
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
		{
            if (run)
			{
                if (lockCursor)
                {
                    cursorPosX = (int)Math.Round(numX.Value);
                    cursorPosY = (int)Math.Round(numY.Value);
                    Cursor.Position = new Point(cursorPosX, cursorPosY);

                    Click(selectedEvent1, selectedEvent2, (uint)Cursor.Position.X, (uint)Cursor.Position.Y);
                }
                else if (lockCursorOnCurrentPos)
                {
                    Cursor.Position = new Point(cursorPosX, cursorPosY);
                    Click(selectedEvent1, selectedEvent2, (uint)Cursor.Position.X, (uint)Cursor.Position.Y);
                }
                else 
                {
                    Click(selectedEvent1, selectedEvent2, (uint)Cursor.Position.X, (uint)Cursor.Position.Y);
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = run ? "on" : "off";
            cursorPosLabel.Text = $"X: {Cursor.Position.X} Y: {Cursor.Position.Y}";

            if (lockCursorOnCurrentPos && !run)
			{
                cursorPosX = Cursor.Position.X;
                cursorPosY = Cursor.Position.Y;
            }
            
            if (Keyboard.IsKeyDown(startKey))
            {
                run = true;
            }
            else if (Keyboard.IsKeyDown(stopKey))
            {
                run = false;
            }
        }

        private void numInterval_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)Math.Round(numInterval.Value);
        }

        private void lockButton_Click(object sender, EventArgs e)
        {
            lockCursor = lockCursor ? false : true;
            lockCursorOnCurrentPos = lockCursor ? false : lockCursorOnCurrentPos;
            lockButton.Checked = lockCursor;
            lockButton2.Checked = lockCursorOnCurrentPos;
        }

        private void lockButton2_Click(object sender, EventArgs e)
        {
            lockCursorOnCurrentPos = lockCursorOnCurrentPos ? false : true;
            lockCursor = lockCursorOnCurrentPos ? false : lockCursor;
            lockButton.Checked = lockCursor;
            lockButton2.Checked = lockCursorOnCurrentPos;
        }

        private void actionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)actionListBox.SelectedItem == mouseAction[0])
            {
                selectedEvent1 = MOUSEEVENTF_LEFTDOWN;
                selectedEvent2 = MOUSEEVENTF_LEFTUP;
            }
            else if ((string)actionListBox.SelectedItem == mouseAction[1])
            {
                selectedEvent1 = MOUSEEVENTF_RIGHTDOWN;
                selectedEvent2 = MOUSEEVENTF_RIGHTUP;
            }
        }


        private void startKeyInput_TextChanged(object sender, EventArgs e)
        {
            startKeyInput.Text = startKey.ToString();                
        }

        private void stopKeyInput_TextChanged(object sender, EventArgs e)
        {
            stopKeyInput.Text = stopKey.ToString();
        }

        private void startKeyInput_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            helperRun = run;
            run = false;

            if (e.KeyCode.ToString() != stopKeyInput.Text)
			{
                if (helperRun)
				{
                    timer1.Stop();
				}

                Enum.TryParse(e.KeyCode.ToString(), out startKey);
            }
        }

        private void stopKeyInput_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            helperRun2 = run;
            run = false;

            if (e.KeyCode.ToString() != startKeyInput.Text)
            {
                Enum.TryParse(e.KeyCode.ToString(), out stopKey);
            }
        }

        private void startKeyInput_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (helperRun) 
            { 
                timer1.Start();
                run = true;
            }
            else
			{
                run = false;
                this.Text = "off";
            }

            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 75);
            Click(MOUSEEVENTF_LEFTDOWN, MOUSEEVENTF_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y);
        }

        private void stopKeyInput_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (helperRun2)
            {
                timer1.Start();
                run = true;
            }
            else
            {
                run = false;
                this.Text = "off";
            }

            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 75);
			Click(MOUSEEVENTF_LEFTDOWN, MOUSEEVENTF_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y);
        }
        
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

		public void Click(uint mouseEvent1, uint mouseEvent2, uint cursorX, uint cursorY)
        {
            mouse_event(mouseEvent1 | mouseEvent2, cursorX, cursorY, 0, 0);
        }
	}
}
