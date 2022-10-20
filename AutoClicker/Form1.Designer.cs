
namespace AutoClicker
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.numInterval = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.numX = new System.Windows.Forms.NumericUpDown();
			this.numY = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lockButton = new System.Windows.Forms.RadioButton();
			this.lockButton2 = new System.Windows.Forms.RadioButton();
			this.cursorPosLabel = new System.Windows.Forms.Label();
			this.actionListBox = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.stopKeyInput = new System.Windows.Forms.TextBox();
			this.startKeyInput = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "interval:";
			// 
			// numInterval
			// 
			this.numInterval.Location = new System.Drawing.Point(65, 10);
			this.numInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numInterval.Name = "numInterval";
			this.numInterval.Size = new System.Drawing.Size(75, 23);
			this.numInterval.TabIndex = 1;
			this.numInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numInterval.ValueChanged += new System.EventHandler(this.numInterval_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(150, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "in millisecond";
			// 
			// timer2
			// 
			this.timer2.Interval = 1;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// numX
			// 
			this.numX.Location = new System.Drawing.Point(380, 10);
			this.numX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numX.Name = "numX";
			this.numX.Size = new System.Drawing.Size(75, 23);
			this.numX.TabIndex = 7;
			this.numX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numY
			// 
			this.numY.Location = new System.Drawing.Point(480, 10);
			this.numY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numY.Name = "numY";
			this.numY.Size = new System.Drawing.Size(75, 23);
			this.numY.TabIndex = 8;
			this.numY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(360, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "X:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(460, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "Y:";
			// 
			// lockButton
			// 
			this.lockButton.AutoCheck = false;
			this.lockButton.AutoSize = true;
			this.lockButton.Location = new System.Drawing.Point(250, 15);
			this.lockButton.Name = "lockButton";
			this.lockButton.Size = new System.Drawing.Size(110, 19);
			this.lockButton.TabIndex = 6;
			this.lockButton.Text = "lock on position";
			this.lockButton.UseVisualStyleBackColor = true;
			this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
			// 
			// lockButton2
			// 
			this.lockButton2.AutoCheck = false;
			this.lockButton2.AutoSize = true;
			this.lockButton2.Location = new System.Drawing.Point(250, 40);
			this.lockButton2.Name = "lockButton2";
			this.lockButton2.Size = new System.Drawing.Size(151, 19);
			this.lockButton2.TabIndex = 11;
			this.lockButton2.Text = "lock on current position";
			this.lockButton2.UseVisualStyleBackColor = true;
			this.lockButton2.Click += new System.EventHandler(this.lockButton2_Click);
			// 
			// cursorPosLabel
			// 
			this.cursorPosLabel.AutoSize = true;
			this.cursorPosLabel.Location = new System.Drawing.Point(408, 43);
			this.cursorPosLabel.Name = "cursorPosLabel";
			this.cursorPosLabel.Size = new System.Drawing.Size(46, 15);
			this.cursorPosLabel.TabIndex = 12;
			this.cursorPosLabel.Text = "X: ? Y: ?";
			// 
			// actionListBox
			// 
			this.actionListBox.FormattingEnabled = true;
			this.actionListBox.ItemHeight = 15;
			this.actionListBox.Items.AddRange(new object[] {
            "left mouse button",
            "right mouse button"});
			this.actionListBox.Location = new System.Drawing.Point(65, 43);
			this.actionListBox.Name = "actionListBox";
			this.actionListBox.Size = new System.Drawing.Size(120, 34);
			this.actionListBox.TabIndex = 13;
			this.actionListBox.SelectedIndexChanged += new System.EventHandler(this.actionListBox_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(250, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 15);
			this.label5.TabIndex = 14;
			this.label5.Text = "start key:";
			// 
			// stopKeyInput
			// 
			this.stopKeyInput.Location = new System.Drawing.Point(455, 79);
			this.stopKeyInput.Name = "stopKeyInput";
			this.stopKeyInput.Size = new System.Drawing.Size(75, 23);
			this.stopKeyInput.TabIndex = 15;
			this.stopKeyInput.Text = "C";
			this.stopKeyInput.TextChanged += new System.EventHandler(this.stopKeyInput_TextChanged);
			this.stopKeyInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stopKeyInput_KeyDown);
			this.stopKeyInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stopKeyInput_KeyUp);
			// 
			// startKeyInput
			// 
			this.startKeyInput.Location = new System.Drawing.Point(312, 79);
			this.startKeyInput.Name = "startKeyInput";
			this.startKeyInput.Size = new System.Drawing.Size(75, 23);
			this.startKeyInput.TabIndex = 16;
			this.startKeyInput.Text = "F";
			this.startKeyInput.TextChanged += new System.EventHandler(this.startKeyInput_TextChanged);
			this.startKeyInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startKeyInput_KeyDown);
			this.startKeyInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.startKeyInput_KeyUp);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(393, 82);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 15);
			this.label6.TabIndex = 17;
			this.label6.Text = "stop key:";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(12, 109);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(560, 190);
			this.button1.TabIndex = 18;
			this.button1.Text = "uselles button";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 311);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.startKeyInput);
			this.Controls.Add(this.stopKeyInput);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.actionListBox);
			this.Controls.Add(this.cursorPosLabel);
			this.Controls.Add(this.lockButton2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numY);
			this.Controls.Add(this.numX);
			this.Controls.Add(this.lockButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numInterval);
			this.Controls.Add(this.label1);
			this.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "off";
			((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numInterval;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.NumericUpDown numX;
		private System.Windows.Forms.NumericUpDown numY;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton lockButton;
		private System.Windows.Forms.RadioButton lockButton2;
		private System.Windows.Forms.Label cursorPosLabel;
		private System.Windows.Forms.ListBox actionListBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox stopKeyInput;
		private System.Windows.Forms.TextBox startKeyInput;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
	}
}

