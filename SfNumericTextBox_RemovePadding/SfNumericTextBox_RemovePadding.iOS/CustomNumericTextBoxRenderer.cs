﻿using CoreGraphics;
using SfNumericTextBox_RemovePadding;
using SfNumericTextBox_RemovePadding.iOS;
using Syncfusion.SfNumericTextBox.XForms;
using Syncfusion.SfNumericTextBox.XForms.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomNumericTextBox), typeof(CustomNumericTextBoxRenderer))]
namespace SfNumericTextBox_RemovePadding.iOS
{
	class CustomNumericTextBoxRenderer : SfNumericTextBoxRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<SfNumericTextBox> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
                Control.Layer.CornerRadius = 0f;
                Control.Layer.BorderColor = Color.Transparent.ToCGColor();
                Control.Layer.BorderWidth = 0;
                var leftPadding = typeof(Syncfusion.SfNumericTextBox.iOS.SfNumericTextBox).GetProperty("EditTextLeftPadding", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                leftPadding.SetValue(Control, 0);
            }
        }
	}
}