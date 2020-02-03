

namespace V1
{
  partial class LifeForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.m_panel = new V1.MPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.m_TimerChk = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.debugL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_panel
            // 
            this.m_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_panel.Location = new System.Drawing.Point(5, 64);
            this.m_panel.Margin = new System.Windows.Forms.Padding(4);
            this.m_panel.Name = "m_panel";
            this.m_panel.Size = new System.Drawing.Size(737, 422);
            this.m_panel.TabIndex = 0;
            this.m_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPanelPaint);
            this.m_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPanelMouseDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Step";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnStepButton);
            // 
            // m_TimerChk
            // 
            this.m_TimerChk.AutoSize = true;
            this.m_TimerChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_TimerChk.Location = new System.Drawing.Point(152, 20);
            this.m_TimerChk.Margin = new System.Windows.Forms.Padding(4);
            this.m_TimerChk.Name = "m_TimerChk";
            this.m_TimerChk.Size = new System.Drawing.Size(124, 21);
            this.m_TimerChk.TabIndex = 2;
            this.m_TimerChk.Text = "Timer On/Off";
            this.m_TimerChk.UseVisualStyleBackColor = true;
            this.m_TimerChk.Click += new System.EventHandler(this.OnTimerChk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.OnTimer);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(293, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnClearButton);
            // 
            // debugL
            // 
            this.debugL.AutoSize = true;
            this.debugL.Location = new System.Drawing.Point(476, 25);
            this.debugL.Name = "debugL";
            this.debugL.Size = new System.Drawing.Size(50, 17);
            this.debugL.TabIndex = 4;
            this.debugL.Text = "Debug";
            // 
            // LifeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 501);
            this.Controls.Add(this.debugL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_TimerChk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LifeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MPanel m_panel;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox m_TimerChk;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label debugL;
    }
}

