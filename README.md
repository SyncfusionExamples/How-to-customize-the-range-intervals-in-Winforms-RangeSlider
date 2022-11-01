# How-to-customize-the-range-intervals-in-Winforms-RangeSlider
RangeSlider provides an option to customize the range of the slider. We can set the Minimum value, Maximum value, Tick frequency and StartPosition of the slider

## C#
    //To Customize the Range
    this.rangeSlider1.Minimum = 1;
    this.rangeSlider1.Maximum = 10;
    this.rangeSlider1.TickFrequency = 1;
    this.StartPosition = FormStartPosition.CenterScreen;
