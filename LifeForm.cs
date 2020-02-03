using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace V1
{
  public partial class LifeForm : Form
  {
    #region CONSTANTS
    const int MAX_CELLS = 50;
    const int CELL_SIZE = 10;
    const int C_M = 2; // CellMargin
    #endregion
    
    //2 matrixs used to manage the n-t and n+1-t generation
    bool[,] m_CA = new bool[MAX_CELLS,MAX_CELLS];
    bool[,] m_CB = new bool[MAX_CELLS, MAX_CELLS];
    bool[,] m_CC; // current ( active ) CellArray n'te generation pointer to toggle

    public LifeForm()
    {
      InitializeComponent();
      timer1.Interval = 100;
      // Test some arrays (Points/Cells)
      // m_CA[3, 3] = true; m_CA[3, 4] = true; m_CA[3, 5] = true;
       //m_CA[4, 3] = true; m_CA[4, 4] = true; m_CA[4, 5] = true;
       m_CC = m_CA;
    }

    private void OnPanelPaint(object sender, PaintEventArgs e)
    {
      DrawGrid(e.Graphics);
      DrawCells(e.Graphics);
    }

    private void OnPanelMouseDown(object sender, MouseEventArgs e)
    {
            
            int x = MousePosition.X;
            int y = MousePosition.Y;

            // the Cell edit
           
      debugL.Text = e.X.ToString() + " " + e.Y.ToString();
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
                x = x / CELL_SIZE;
                y = y / CELL_SIZE;
               
                TurnCellOnOff(x, y);
            }


               
      m_panel.Invalidate();
    }

   

    //Draw active cells of m_CC array
    void DrawCells(Graphics gr)
    {
         Brush br = new SolidBrush(Color.Blue);
            int x, y;
            for (int i = 0; i < MAX_CELLS; i++)
            {
                for (int j = 0; j < MAX_CELLS; j++) {
                    x = i * CELL_SIZE + C_M;
                    y = j * CELL_SIZE + C_M;

                    if (m_CC[i,j]) {    // if true = alive 
                        gr.FillRectangle(br, x, y, CELL_SIZE-2*C_M, CELL_SIZE-2*C_M);
                    }
                    
                }
            }

     }

    void DrawGrid(Graphics gr)
    {
            // Draw Grid
            Pen pen = new Pen(Color.Red, 1);
            int  x, y;
            for (int i = 0; i <= MAX_CELLS; i++)
            {
                x = i * CELL_SIZE;
                gr.DrawLine(pen,x,0,x,MAX_CELLS*CELL_SIZE);

            }

            for (int j = 0; j <= MAX_CELLS; j++)
            {
                y = j * CELL_SIZE;
                gr.DrawLine(pen, MAX_CELLS * CELL_SIZE, y, 0, y);

            }
        }

    // Calculating next generation
    private void OnStepButton(object sender, EventArgs e)
    {
      if (m_CC == m_CA)
      {
        ClearCells(m_CB);
        CalcNextGeneration(m_CA, m_CB);
        m_CC = m_CB;
      }
      else
      {
        ClearCells(m_CA);
        CalcNextGeneration(m_CB, m_CA);
        m_CC = m_CA;
      }
      m_panel.Invalidate();
    }

    private void OnTimerChk(object sender, EventArgs e)
    {
      if (timer1.Enabled)
        timer1.Enabled = false;
      else
        timer1.Enabled = true;
    }

    private void OnTimer(object sender, EventArgs e)
    {
      OnStepButton(null, null);
    }

    private void OnClearButton(object sender, EventArgs e)
    {
      ClearCells(m_CA); ClearCells(m_CB);
            ClearCells(m_CC);
      m_panel.Invalidate();
    }

  }
}