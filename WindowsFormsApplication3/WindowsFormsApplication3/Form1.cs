using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{

    public partial class Form1 : Form
    {
        public double b;
        public double a;
        public Boolean op = false;
        double anter;
        string ant;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            string tecla= (sender as Button).Text;

            if (tecla.Equals("C")) {
                b = 0;
                a = 0;
                op = false;
                anter = 0;
                ant = "";
                textBox1.Text = "";
            
            }else if(tecla.Equals("+")){
                if (op)
                {

                    //double suma = a + b;
                    if (!tecla.Equals("="))
                    {
                        b = anter;
                    }
                                       
                    a = 0;
                    textBox1.Text = b + "";
                    
                }else
                {
                    op = true;
                }
                ant = tecla;

                
            }else if(tecla.Equals("-")){
                if (op)
                {
                    //double suma = a - b;
                    if (!tecla.Equals("="))
                    {
                        b = anter;
                    }
                    //b = anter;
                    a = 0;
                    textBox1.Text = b + "";
                }
                else
                {
                    
                        op = true;
                    
                }
                ant = tecla;
            }else if(tecla.Equals("*")){
                if (op)
                {
                    if (!tecla.Equals("="))
                    {
                        b = anter;
                    }
                    // suma = a * b;
                    //b = anter;
                    a = 0;
                    textBox1.Text = b + "";
                }
                else
                {
                    op = true;
                }
                ant = tecla;
                
            }else if(tecla.Equals("/")){
                if (op)
                {
                    //double suma = a / b;
                    if (!tecla.Equals("="))
                    {
                        b = anter;
                    }
                    //b = anter;
                    a = 0;
                    textBox1.Text = b + "";
                }
                else
                {
                    op = true;
                }
                ant = tecla;
                
            }else{
                if (op)
                {
                    if(a==0)
                    {
                        textBox1.Text = "";
                    }
                    if (textBox1.Text.Length == 0)
                    {
                        textBox1.Text = textBox1.Text + tecla;
                        Double.TryParse(textBox1.Text, out a);
                    }
                    else if (textBox1.Text[textBox1.Text.Length - 1] != ',' | !((Button)sender).Text.Equals(","))
                    {
                        if (!((Button)sender).Text.Equals("+") && !((Button)sender).Text.Equals("-") && !((Button)sender).Text.Equals("*") && !((Button)sender).Text.Equals("/") && !((Button)sender).Text.Equals("="))
                        {
                            textBox1.Text = textBox1.Text + tecla;
                            Double.TryParse(textBox1.Text, out a);
                        }
                    }

                    if (tecla.Equals("="))
                    {
                        textBox1.Text = anter+"";
                        b = anter;
                    
                        
                    }
                    if (ant.Equals("+"))
                    {
                        anter = a + b;
                        if (b == 0)
                        {
                            textBox1.Text = anter + "";
                        }
                       
                       
                    }
                    else if (ant.Equals("-"))
                    {
                        anter = b - a;
                        if (b == 0) 
                        {
                            textBox1.Text = anter + "";
                        }
                        
                    }
                    else if (ant.Equals("*"))
                    {
                        anter = b * a;
                        if (b == 0)
                        {
                            textBox1.Text = anter + "";
                        }
                        
                    }
                    else if (ant.Equals("/"))
                    {
                        anter = b / a;
                        if (b == 0)
                        {
                            textBox1.Text = "Resultado indefinido";
                        }
                        
                    }
                    
                    


                }
                else
                {
                    if (textBox1.Text.Length == 0)
                    {
                        textBox1.Text = textBox1.Text + tecla;
                        Double.TryParse(textBox1.Text, out b);
                    }
                    else if (textBox1.Text[textBox1.Text.Length - 1] != '.' | !((Button)sender).Text.Equals("."))
                    {
                        textBox1.Text = textBox1.Text + tecla;
                        Double.TryParse(textBox1.Text, out b);
                    }
                }
            }


        }
        

    }
}
