namespace RangeSlider_Check
{
    partial class Form1
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
            this.rangeSlider1 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.SuspendLayout();
            // 
            // rangeSlider1
            // 
            this.rangeSlider1.BeforeTouchSize = new System.Drawing.Size(800, 33);
            this.rangeSlider1.ChannelHeight = 6;
            this.rangeSlider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.rangeSlider1.ForeColor = System.Drawing.Color.Black;
            this.rangeSlider1.Location = new System.Drawing.Point(178, 210);
            this.rangeSlider1.Name = "rangeSlider1";
            this.rangeSlider1.Size = new System.Drawing.Size(800, 33);
            this.rangeSlider1.SliderSize = new System.Drawing.Size(16, 21);
            this.rangeSlider1.TabIndex = 0;
            this.rangeSlider1.Text = "rangeSlider1";
            this.rangeSlider1.TickPlacement = Syncfusion.Windows.Forms.Tools.TickPlacement.Inline;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1196, 585);
            this.Controls.Add(this.rangeSlider1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Customization TickFrequency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RangeSlider rangeSlider1;
    }
}

