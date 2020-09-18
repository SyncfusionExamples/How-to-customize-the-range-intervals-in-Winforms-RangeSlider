using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangeSlider_Check
{
    public partial class Form1 : MetroForm
    {
       
        public Form1()
        {
            InitializeComponent();
            this.rangeSlider1.DrawLabel += RangeSlider1_DrawLabel;
            this.rangeSlider1.ShowLabels = true;
            this.rangeSlider1.Minimum = 1;
            this.rangeSlider1.Maximum = 10;
            this.rangeSlider1.TickFrequency = 1;
            this.StartPosition = FormStartPosition.CenterScreen;
                 
        }

        private void RangeSlider1_DrawLabel(object sender, DrawLabelEventArgs e)
        {
            TimeSpan time2 = new TimeSpan(0,30,00);
            for (int i = 0; i < e.Value; i++)
            {
             time2 =  time2.Add(new TimeSpan(0, 30, 0));
            }
            DateTime time = DateTime.Today.Add(time2);
            e.Text = time.ToString("hh:mm tt");
            e.Handled = true;
        }   
    }

  
}
