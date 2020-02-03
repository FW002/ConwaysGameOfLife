using System;
using System.Collections.Generic;
using System.Text;

namespace V1
{
  partial class LifeForm
  {
    // aOld Matrix with the n-t generation
    // aNew Matrix with the n+1-t generation
    void CalcNextGeneration(bool[,] aOld, bool[,] aNew)
    {
      m_CC = aOld; // making sure that m_CC=aOld
            int nCount;
            for(int i = 0; i < MAX_CELLS; i++)
            {
                for(int j = 0; j < MAX_CELLS; j++)
                {
                    //if (ValOf(i, j)) // living cells of the n-t generation
                    //{
                        nCount = GetNeighbourCount(i, j);
                        if(nCount == 3)
                        {
                            aNew[i, j] = true;
                        }
                        else if(nCount < 2 || nCount > 3)
                        {
                            aNew[i, j] = false;
                        }
                        else
                        {
                            aNew[i, j] = m_CC[i, j];
                            
                        }
                    //}
                    //else//dead cells of the n-t generation
                    //{
                    //    nCount = GetNeighbourCount(i, j);
                    //    m_panel.Invalidate();
                    //}
                }
            }
        
    }

    void ClearCells(bool[,] aCells)
    {
            // switch all cells to off (false state)
            for(int i = 0; i < MAX_CELLS; i++)
            {
                for(int j = 0; j < MAX_CELLS; j++)
                {
                    aCells[i,j] = false;
                }
               
            }
           
    }

        // cells of m_CC
         void TurnCellOnOff(int aX, int aY)
         {
            // toggle cell at position aX and aY ( switch on/off )          
           if(m_CC[aX ,aY])
            {
                m_CC[aX, aY] = false;
            }
            else
            {
                m_CC[aX, aY] = true;
            }

         }
    
    // cells of m_CC
    int GetNeighbourCount(int i, int j)
    {
            // how much living neighbours for Cell(i,j)
            int count = 0;
            for (int d = i - 1; d <= i + 1; d++)
            {
                for (int s = j - 1; s <= j + 1; s++)
                {

                   
                   
                    if(m_CC[((d + MAX_CELLS) % MAX_CELLS), ((s + MAX_CELLS) % MAX_CELLS)])
                    {
                        
                        if (!(d == i && s == j))
                        {
                            count++;
                          
                        }
                    }
                }
            }

      return count;
    }

    // Is Cell(i,j) of m_CC on or off ?
    // with correct handling of i,j<0 and i,j>=MAX_CELLS
    bool ValOf(int i, int j)
    {
            int x = (i+MAX_CELLS) % MAX_CELLS;
            int y = (j+MAX_CELLS) % MAX_CELLS;
            
            return m_CC[x,y];
    }

  }
}
