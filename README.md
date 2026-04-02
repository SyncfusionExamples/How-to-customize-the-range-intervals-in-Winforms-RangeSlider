# How to Customize the Range Intervals in WinForms RangeSlider
This sample demonstrates how to build a user-friendly time-scale slider in a WinForms application using the Syncfusion RangeSlider. It shows how to customize tick intervals, format labels (e.g., 12-hour time), and configure minimum/maximum values so users can scrub through a logical range like half-hour increments across a day.

## Features
- Set minimum/maximum slider bounds for the domain
- Configure tick frequency for uniform intervals (e.g., every 30 minutes)
- Show labels along the track for better readability
- Customize label text via DrawLabel to display formatted values (e.g., 01:00 PM)
- Optional snapping behavior through TickFrequency
- Easy to center and initialize with form StartPosition

## Getting Started
1. Create a new Windows Forms App (.NET Framework or .NET) in Visual Studio.
2. Install the NuGet package: Syncfusion.Tools.Windows.
3. Add a RangeSlider (namespace: Syncfusion.Windows.Forms.Tools) to your form (e.g., rangeSlider1).
4. Configure core properties and hook the DrawLabel event to customize the label text.

## Usage Tips
- Map numeric ticks to domain values (minutes, distance, progress) inside DrawLabel.
- Adjust Minimum/Maximum to match your domain length. For a 24-hour range at 30-minute intervals, you would use 0..48 with TickFrequency = 1.
- Use ShowLabels for readability; hide if labels are too dense and render a legend elsewhere.
- If you need a specific start time, offset your base DateTime accordingly in DrawLabel.

## About the Sample
This sample provides a concise starting point for building domain-aware sliders in WinForms. It demonstrates mapping numeric ticks to real-world values (e.g., half-hour time slots), customizing label rendering for human-friendly formats, and setting uniform tick intervals for predictable navigation. Extend it by changing the domain (dates, percentages, distances), providing snapping and selection logic, and applying your app theme. The goal is to help users scrub, read, and select values effortlessly with clear, formatted labels.
