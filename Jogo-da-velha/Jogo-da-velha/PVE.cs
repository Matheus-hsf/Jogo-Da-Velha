using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class PVE : Form
    {
        public PVE()
        {
            InitializeComponent();
        }

        

        
        int minhaVez = 0;
        int troca = 1;
        string win;
        bool fim = true;
        int jogada = 0;
        

        private void PVE_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void a1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            minhaVez = 1;
            jogada++;

            if (troca == 1)
            {
                b.Text = "x";
            }

           
            b.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            


            #region MinhaRodada


            if (minhaVez == 0)
            {
                if (a1.Text == "")
                {
                    a1.Enabled = true;
                }
            }

            if (minhaVez == 0)
            {
                if (a2.Text == "")
                {
                    a2.Enabled = true;
                }
            }
            if (minhaVez == 0)
            {
                if (a3.Text == "")
                {
                    a3.Enabled = true;
                }
            }
            if (minhaVez == 0)
            {
                if (a4.Text == "")
                {
                    a4.Enabled = true;
                }
            }
            if (minhaVez == 0)
            {
                if (a5.Text == "")
                {
                    a5.Enabled = true;
                }
            }
            if (minhaVez == 0)
            {
                if (a6.Text == "")
                {
                    a6.Enabled = true;
                }
            }
            if (minhaVez == 0)
            {
                if (a7.Text == "")
                {
                    a7.Enabled = true;
                }
            }
            if (minhaVez == 0)
            {
                if (a8.Text == "")
                {
                    a8.Enabled = true;
                }
            }
            if (minhaVez == 0)
            {
                if (a9.Text == "")
                {
                    a9.Enabled = true;
                }
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            #endregion

            #region Adversario
            #region VezDele
            if (minhaVez == 1)
            {
                if (a1.Text == "")
                {
                    a1.Enabled = false;
                }
            }

            if (minhaVez == 1)
            {
                if (a2.Text == "")
                {
                    a2.Enabled = false;
                }
            }
            if (minhaVez == 1)
            {
                if (a3.Text == "")
                {
                    a3.Enabled = false;
                }
            }
            if (minhaVez == 1)
            {
                if (a4.Text == "")
                {
                    a4.Enabled = false;
                }
            }
            if (minhaVez == 1)
            {
                if (a5.Text == "")
                {
                    a5.Enabled = false;
                }
            }
            if (minhaVez == 1)
            {
                if (a6.Text == "")
                {
                    a6.Enabled = false;
                }
            }
            if (minhaVez == 1)
            {
                if (a7.Text == "")
                {
                    a7.Enabled = false;
                }
            }
            if (minhaVez == 1)
            {
                if (a8.Text == "")
                {
                    a8.Enabled = false;
                }
            }
            if (minhaVez == 1)
            {
                if (a9.Text == "")
                {
                    a9.Enabled = false;
                }
            }
            #endregion

            #region Jogadas
            
            if (minhaVez == 1 && jogada == 1)
            {
                if (a1.Text != "" && a5.Text != "o" )
                {
                    if (a5.Text != "x" && a5.Text != "o" )
                    {
                        a5.Text = "o";
                        minhaVez = 0;
                    }
                    
                }

                else if (a7.Text == "o" && a5.Text == "o")
                {
                                     
                        a3.Text = "o";
                        minhaVez = 0;
                    
                }

                else if (a2.Text != "" && a5.Text != "o")
                {
                    if (a5.Text != "x" && a5.Text != "o")
                    {
                        a5.Text = "o";
                        minhaVez = 0;
                    }
                }
                else if (a3.Text != "" && a5.Text != "o")
                {
                    if (a5.Text != "x" && a5.Text != "o")
                    {
                        a5.Text = "o";
                        minhaVez = 0;
                    }
                }

                else if (a4.Text != "" && a5.Text != "o")
                {
                    if (a5.Text != "x" && a5.Text != "o")
                    {
                        a5.Text = "o";
                        minhaVez = 0;
                    }
                }

                else if (a5.Text != "" && a5.Text != "o")
                {
                    if (a1.Text != "x" && a1.Text != "o")
                    {
                        a1.Text = "o";
                        minhaVez = 0;
                    }
                }
                else if (a6.Text != "" && a5.Text != "o")
                {
                    if (a5.Text != "x" && a5.Text != "o")
                    {
                        a5.Text = "o";
                        minhaVez = 0;
                    }
                }

                else if (a7.Text != "" && a5.Text != "o")
                {
                    if (a5.Text != "x" && a5.Text != "o")
                    {
                        a5.Text = "o";
                        minhaVez = 0;
                    }
                }

                else if (a8.Text != "" && a5.Text != "o")
                {
                    if (a5.Text != "x" && a5.Text != "o")
                    {
                        a5.Text = "o";
                        minhaVez = 0;
                    }
                }

                else if (a9.Text != "" && a5.Text != "o")
                {
                    if (a5.Text != "x" && a5.Text != "o")
                    {
                        a5.Text = "o";
                        minhaVez = 0;
                    }
                }

            }


            if (minhaVez == 1 && jogada == 2)
            {

                #region A1 = X
                if (a1.Text == "x")
                {
                    if (a2.Text == "x")
                    {
                        if (a3.Text == "")
                        {
                            a3.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a4.Text == "x")
                    {
                        if (a7.Text == "")
                        {
                            a7.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a5.Text == "x")
                    {
                        if (a9.Text == "")
                        {
                            a9.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a3.Text == "x")
                    {
                      if (a2.Text == "")
	                  {
                        a2.Text = "o";
                        minhaVez = 0;
                      }
                    }

                    else if (a6.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a7.Text == "x")
                    {
                        if (a4.Text == "")
                        {
                            a4.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a2.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a8.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a9.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                   
                }

                
                #endregion
                #region A2 = X

                if (a2.Text == "x")
                {
                    if (a1.Text == "x")
                    {
                        if (a3.Text == "")
                        {
                            a3.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a3.Text == "x")
                    {
                        if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a5.Text == "x")
                    {
                        if (a8.Text == "")
                        {
                            a8.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a4.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a6.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a7.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a8.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a9.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }

                    
                   
                }




                #endregion
                #region A3 = X

                if (a3.Text == "x")
                {
                    if (a2.Text == "x")
                    {
                        if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a1.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a6.Text == "x")
                    {
                        if (a9.Text == "")
                        {
                            a9.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a9.Text == "x")
                    {
                        if (a6.Text == "")
                        {
                            a6.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a8.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a4.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a5.Text == "x")
                    {
                        if (a7.Text == "")
                        {
                            a7.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a7.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }

                    
                   
                }

                #endregion
                #region A4 = X

                if (a4.Text == "x")
                {
                    if (a1.Text == "x")
                    {
                        if (a7.Text =="")
                        {
                            a7.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a6.Text == "x")
                    {
                        if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }


                    else if (a7.Text == "x")
                    {
                        if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a5.Text == "x")
                    {
                        if (a6.Text == "")
                        {
                            a6.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a6.Text == "x")
                    {
                        if (a5.Text == "")
                        {
                            a5.Text = "o";
                            minhaVez = 0;
                        }
                    }

                    else if (a8.Text == "x")
                    {
                        if (a7.Text == "")
                        {
                            a7.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }

                    else if (a9.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    
                    else if (a2.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }

                    
                }
                    
                #endregion
                #region A5 = X

                if (a5.Text == "x")
                {
                    if (a1.Text == "x")
                    {
                        if (a9.Text == "")
                        {
                            a9.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a2.Text == "x")
                    {
                        if (a8.Text == "")
                        {
                            a8.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a3.Text == "x")
                    {
                        if (a7.Text == "")
                        {
                            a7.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a4.Text == "x")
                    {
                        if (a6.Text == "")
                        {
                            a6.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a6.Text == "x")
                    {
                        if (a4.Text == "")
                        {
                            a4.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a7.Text == "x")
                    {
                        if (a3.Text == "")
                        {
                            a3.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a8.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a9.Text == "x")
                    {
                        if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a7.Text == "")
                        {
                            a7.Text = "o";
                            minhaVez = 0;
                        }

                    }
                }


                #endregion
                #region A6 = X

                if (a6.Text == "x")
                {
                    if (a9.Text == "x")
                    {
                        if (a3.Text == "")
                        {
                            a3.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a3.Text == "x")
                    {
                        if (a9.Text == "")
                        {
                            a9.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a4.Text == "x")
                    {
                        if (a5.Text == "")
                        {
                            a5.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a5.Text == "x")
                    {
                        if (a4.Text == "")
                        {
                            a4.Text = "o";
                            minhaVez = 0;
                        }
                    }

                    else if (a8.Text == "x")
                    {
                        if (a9.Text == "")
                        {
                            a9.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a7.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a1.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a2.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                   
                }

                #endregion
                #region A7 = X

                if (a7.Text == "x")
                {
                    if (a1.Text == "x")
                    {
                        if (a4.Text == "")
                        {
                            a4.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a4.Text == "x")
                    {
                        if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a5.Text == "x")
                    {
                        if (a3.Text == "")
                        {
                            a3.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a3.Text == "x")
                    {
                        if (a5.Text == "")
                        {
                            a5.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a8.Text == "x")
                    {
                        if (a9.Text == "")
                        {
                            a9.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a9.Text == "x")
                    {
                        if (a8.Text == "")
                        {
                            a8.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a2.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                        else if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    
                   
                }

                #endregion
                #region A8 = X
                
                if (a8.Text == "x")
                {
                    if (a7.Text == "x")
                    {
                        if (a9.Text == "")
                        {
                            a9.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a9.Text == "x")
                    {
                        if (a7.Text == "")
                        {
                            a7.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a5.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    
                }

                #endregion
                #region A9 = X

                if (a9.Text == "x")
                {
                    if (a7.Text == "x")
                    {
                        if (a8.Text == "")
                        {
                            a8.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a8.Text == "x")
                    {
                        if (a7.Text == "")
                        {
                            a7.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a3.Text == "x")
                    {
                        if (a6.Text == "")
                        {
                            a6.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a6.Text == "x")
                    {
                        if (a3.Text == "")
                        {
                            a3.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a1.Text == "x")
                    {
                        if (a5.Text == "")
                        {
                            a5.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else if (a5.Text == "x")
                    {
                        if (a1.Text == "")
                        {
                            a1.Text = "o";
                            minhaVez = 0;
                        }
                    }
                }

                #endregion
                
            }

           

            if (minhaVez == 1 && jogada == 3)
            {

#region DaPraGanhar
                if (a1.Text == "o" && a2.Text == "o")
                {
                    if (a3.Text == "")
                    {
                        a3.Text = "o";
                        minhaVez = 0;
                    }
                    else
                    {
                        a7.Text = "o";
                        minhaVez = 0;
                    }
                
                }

                else if (a1.Text == "o" && a3.Text == "o")
                {
                    if (a2.Text == "")
                    {
                        a2.Text = "o";
                        minhaVez = 0;
                    }
                    else
                    {
                        a8.Text = "o";
                        minhaVez = 0;
                    }

                }

                else if (a3.Text == "o" && a2.Text == "o")
                {
                    if (a1.Text == "")
                    {
                        a1.Text = "o";
                        minhaVez = 0;

                    }
                }

                else if (a1.Text == "o" && a7.Text == "o")
                {
                    if (a4.Text == "")
                    {
                        a4.Text = "o";
                        minhaVez = 0;
                    }
                    else
                    {
                        a6.Text = "o";
                        minhaVez = 0;
                    }
                }

                else if (a1.Text == "o" && a4.Text == "o")
                {
                    if (a7.Text == "")
                    {
                        a7.Text = "o";
                        minhaVez = 0;
                    }
                    else
                    {
                        a3.Text = "o";
                        minhaVez = 0;
                    }
                }

                else if (a1.Text == "o" && a9.Text == "o")
                {
                    if (a5.Text == "")
                    {
                        a5.Text = "o";
                        minhaVez = 0;
                    }
                   
                }

                else if (a1.Text == "o" && a5.Text == "o")
                {
                    if (a9.Text == "")
                    {
                        a9.Text = "o";
                        minhaVez = 0;
                    }
                    else if (a2.Text == "")
                    {
                        a8.Text = "o";
                        minhaVez = 0;
                    }
                    else if (a4.Text == "")
                    {
                        a6.Text = "o";
                        minhaVez = 0;
                    }
                }

                else if (a5.Text == "o" && a9.Text == "o")
                {
                    if (a1.Text == "")
                    {
                        a1.Text = "o";
                        minhaVez = 0;
                    }
                    else if (a8.Text == "")
                    {
                        a2.Text = "o";
                        minhaVez = 0;
                    }
                    else if (a6.Text == "")
                    {
                        a4.Text = "o";
                        minhaVez = 0;
                    }
                }

                else if (a4.Text == "o" && a5.Text == "o")
                {
                    if (a6.Text == "")
                    {
                        a6.Text = "o";
                        minhaVez = 0;
                    }
                    else
                    {
                        a2.Text = "o";
                        minhaVez = 0;
                    }
                }

                else if (a5.Text == "o" && a6.Text == "o")
                {
                    if (a4.Text == "")
                    {
                        a4.Text = "o";
                        minhaVez = 0;
                    }
                    else
                    {
                        a2.Text = "o";
                        minhaVez = 0;
                    }
                }

                else if (a7.Text == "o" && a8.Text == "o")
                {
                    if (a9.Text == "")
                    {
                        a9.Text = "o";
                        minhaVez = 0;

                    }
                }

                else if (a9.Text == "o" && a8.Text == "o")
                {
                    if (a7.Text == "")
                    {
                        a7.Text = "o";
                        minhaVez = 0;

                    }
                }

                else if (a7.Text == "o" && a9.Text == "o")
                {
                    if (a8.Text == "")
                    {
                        a8.Text = "o";
                        minhaVez = 0;

                    }
                }

                else if (a2.Text == "o" && a5.Text == "o")
                {
                    if (a8.Text == "")
                    {
                        a8.Text = "o";
                        minhaVez = 0;
                    }
                    else if (a1.Text == "x" && a7.Text == "x")
                    {
                        a4.Text = "o";
                        minhaVez = 0;
                    }
                    else if (a8.Text == "x" && a9.Text == "x")
                    {
                        if (a7.Text == "")
                        {
                            a7.Text = "o";
                            minhaVez = 0;
                        }
                    }
                }

                else if (a5.Text == "o" && a8.Text == "o")
                {
                    if (a2.Text == "")
                    {
                        a2.Text = "o";
                        minhaVez = 0;
                    }
                    else
                    {
                        a4.Text = "o";
                        minhaVez = 0;
                    }
                }

                else if (a3.Text == "o" && a6.Text == "o")
                {
                    if (a9.Text == "")
                    {
                        a9.Text = "o";
                        minhaVez = 0;

                    }
                }

                else if (a9.Text == "o" && a6.Text == "o")
                {
                    if (a3.Text == "")
                    {
                        a3.Text = "o";
                        minhaVez = 0;

                    }
                }

                else if (a3.Text == "o" && a9.Text == "o")
                {
                    if (a6.Text == "")
                    {
                        a6.Text = "o";
                        minhaVez = 0;

                    }
                }

                else if (a3.Text == "o" && a5.Text == "o")
                {

                    if (a1.Text == "x" && a2.Text == "x")
                    {
                        if (a4.Text == "")
                        {
                        a4.Text = "o";
                        minhaVez = 0;
                        }
                        
                    }
                    else
                    {
                        if (a8.Text == "")
                        {
                            a8.Text = "o";
                            minhaVez = 0;
                        }
                    }
                }

                else if (a5.Text == "o" && a7.Text == "o")
                {
                    if (a1.Text == "x" && a3.Text == "x")
                    {
                        if (a2.Text == "")
                        {
                            a2.Text = "o";
                            minhaVez = 0;
                        }
                    }
                    else
                    {
                        if (a6.Text == "")
                        {
                            a6.Text = "o";
                            minhaVez = 0;
                        }
                    }

                }

               

                





#endregion


                   



                

            









            }


            #endregion












            #endregion

            #region Ganhou?
            if (a1.Text == a2.Text && a2.Text == a3.Text && a1.Text != "" && fim == true)
            {
                win = a1.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");



            }
            if (a1.Text == a5.Text && a5.Text == a9.Text && a1.Text != "" && fim == true)
            {
                win = a1.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            if (a1.Text == a4.Text && a4.Text == a7.Text && a1.Text != "" && fim == true)
            {
                win = a1.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            if (a2.Text == a5.Text && a5.Text == a8.Text && a2.Text != "" && fim == true)
            {
                win = a2.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            if (a3.Text == a6.Text && a6.Text == a9.Text && a3.Text != "" && fim == true)
            {
                win = a3.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            if (a3.Text == a5.Text && a5.Text == a7.Text && a3.Text != "" && fim == true)
            {
                win = a3.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            if (a4.Text == a5.Text && a5.Text == a6.Text && a4.Text != "" && fim == true)
            {
                win = a4.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            if (a7.Text == a8.Text && a8.Text == a9.Text && a7.Text != "" && fim == true)
            {
                win = a7.Text;
                fim = false;
                MessageBox.Show("O " + win + " ganhou!!!");
            }
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            a4.Text = "";
            a5.Text = "";
            a6.Text = "";
            a7.Text = "";
            a8.Text = "";
            a9.Text = "";

            fim = true;
            a1.Enabled = true;
            a2.Enabled = true;
            a3.Enabled = true;
            a4.Enabled = true;
            a5.Enabled = true;
            a6.Enabled = true;
            a7.Enabled = true;
            a8.Enabled = true;
            a9.Enabled = true;
            minhaVez = 0;
            jogada = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
