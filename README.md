# How-to-customize-the-range-intervals-in-Winforms-RangeSlider
RangeSlider provides an option to customize the range of the slider. We can set the Minimum value, Maximum value, Tick frequency and StartPosition of the slider. For more details please refer [How to customize the range intervals in RadialSlider](https://www.syncfusion.com/kb/11982/how-to-customize-the-range-intervals-in-winforms-rangeslider).

## C#
    //To Customize the Range
    this.rangeSlider1.Minimum = 1;
    this.rangeSlider1.Maximum = 10;
    this.rangeSlider1.TickFrequency = 1;
    this.StartPosition = FormStartPosition.CenterScreen;

![Custom RangeSlider](RangeSlider_CustomRangeintervals/Image/Custom%20RangeSlider.png)
