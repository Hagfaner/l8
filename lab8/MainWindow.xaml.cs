﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using lab8;
namespace lab8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Standart exp = new Standart();
        static char oper =' ';
        static bool dec_point;
        static bool postequil = false;
        static bool firstop = false;
        public MainWindow()
        {
            
            InitializeComponent();
            display.Text = "0";
        }

       

        private void place_number(object sender, RoutedEventArgs e)
        {
            if (postequil)
            {
                display.Text = "0";
                sec_display.Text = "";
                postequil = false;
            }
            string buf=sender.ToString();
            char num = buf[buf.Length - 1];
            if (display.Text[0] == '0' && !dec_point)
            {
                display.Text=display.Text.Substring(1);
            }
            display.Text = exp.place_number(num, display.Text);
        }

        private void clear__Click(object sender, RoutedEventArgs e)
        {
            if (postequil)
            {
                sec_display.Text = "";
            }
            display.Text = "0";
            dec_point = false;
            dec.IsEnabled = true;
        }

        private void clear_all_Click(object sender, RoutedEventArgs e)
        {
            display.Text = "0";
            sec_display.Text = "";
            firstop = false;
            dec_point = false;
            dec.IsEnabled = true;
        }

        private void operations_click(object sender, RoutedEventArgs e)
        {
            string buf;
            postequil = false;
            
            if (firstop) {

                buf = exp.calculation(sec_display.Text + display.Text, oper);
                oper = exp.operations(sender);
                sec_display.Text = buf + ' ' + oper + ' ';

            }
            else
            {
                oper = exp.operations(sender);
                sec_display.Text = display.Text +' '+oper+' ';
            }
            
            dec_point = false;
            firstop = true;
            dec.IsEnabled = true;
            display.Text = "0";
        }

        private void equils_Click(object sender, RoutedEventArgs e)
        {
           if(oper!=' ')
            {
                display.Text = exp.calculation(sec_display.Text + display.Text, oper);
                sec_display.Text = "";
                oper = ' ';
                dec_point = false;
                dec.IsEnabled = true;
                postequil = true;
                firstop = false;
            }
           
            
        }

        private void dec_Click(object sender, RoutedEventArgs e)
        {
            dec_point = true;
            display.Text += ',';
            dec.IsEnabled = false;
        }

        private void one_div_x_Click(object sender, RoutedEventArgs e)
        {
            string buf;
            if (firstop)
            {

                buf = exp.calculation(sec_display.Text + display.Text, oper);
                
                display.Text = buf;
                firstop = false;

            }
            oper = ' ';

            sec_display.Text = "1/" + display.Text +"=";
            display.Text = exp.div1x(display.Text);
            postequil = true;
        }

        private void neg_Click(object sender, RoutedEventArgs e)
        {
            display.Text = exp.negativ(display.Text);
           
        }

        private void sqrt_x_Click(object sender, RoutedEventArgs e)
        {
            string buf;
            if (firstop)
            {

                buf = exp.calculation(sec_display.Text + display.Text, oper);

                display.Text = buf;
                firstop = false;

            }
            oper = ' ';
            sec_display.Text = "sqrt(" + display.Text + ")=";
            display.Text = exp.sqrtx(display.Text);
            postequil = true;
        }
        private void sqr_x_Click(object sender, RoutedEventArgs e)
        {
            string buf;
            if (firstop)
            {

                buf = exp.calculation(sec_display.Text + display.Text, oper);

                display.Text = buf;
                firstop = false;

            }
            oper = ' ';
            sec_display.Text = display.Text + "^2 =";
            display.Text = exp.pow_2(display.Text);
            postequil = true;
        }
      
        private void powof2_Click(object sender, RoutedEventArgs e)
        {
            string buf;
            if (firstop)
            {

                buf = exp.calculation(sec_display.Text + display.Text, oper);

                display.Text = buf;
                firstop = false;

            }
            oper = ' ';
            sec_display.Text = "2^"+display.Text+"=";
            display.Text = exp.powof2(display.Text);
            postequil = true;
        }

        private void clear_last_number_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text.IndexOf(',') != -1)
            {
                if (display.Text[display.Text.Length - 1] == ',') { dec_point = false; dec.IsEnabled = true; }
            }
            display.Text = display.Text.Remove(display.Text.Length - 1);

            if (display.Text.Length < 1 || display.Text == "-")
            {
                display.Text = "0";
            }
            
        }
    }
}
