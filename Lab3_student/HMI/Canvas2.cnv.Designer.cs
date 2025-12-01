/*
 * Created by EcoStruxure Automation Expert.
 * User: vaatmar1
 * Date: 11/5/2023
 * Time: 7:43 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for Canvas2.
	/// </summary>
	partial class Canvas2
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BUTTONAdp = new HMI.Main.Symbols.BUTTONAdp.sDefault();
			this.HCylAdp = new HMI.Main.Symbols.HCylAdp.sDefault();
			this.VCylAdp = new HMI.Main.Symbols.VCylAdp.sDefault();
			// 
			// BUTTONAdp
			// 
			this.BUTTONAdp.BeginInit();
			this.BUTTONAdp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 136D, 178D);
			this.BUTTONAdp.Name = "BUTTONAdp";
			this.BUTTONAdp.SecurityToken = ((uint)(4294967295u));
			this.BUTTONAdp.TagName = "5CEF04DF83DE2A88";
			this.BUTTONAdp.EndInit();
			// 
			// HCylAdp
			// 
			this.HCylAdp.BeginInit();
			this.HCylAdp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 56D, 280D);
			this.HCylAdp.Name = "HCylAdp";
			this.HCylAdp.SecurityToken = ((uint)(4294967295u));
			this.HCylAdp.TagName = "84660A5E573F96DD";
			this.HCylAdp.EndInit();
			// 
			// VCylAdp
			// 
			this.VCylAdp.BeginInit();
			this.VCylAdp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 328D, 56D);
			this.VCylAdp.Name = "VCylAdp";
			this.VCylAdp.SecurityToken = ((uint)(4294967295u));
			this.VCylAdp.TagName = "3F1798276AF82FE2";
			this.VCylAdp.EndInit();
			// 
			// Canvas2
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(600D)), ((float)(520D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas2";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.BUTTONAdp,
			this.HCylAdp,
			this.VCylAdp});
			this.Size = new System.Drawing.Size(600, 520);

		}
		private HMI.Main.Symbols.BUTTONAdp.sDefault BUTTONAdp;
		private HMI.Main.Symbols.HCylAdp.sDefault HCylAdp;
		private HMI.Main.Symbols.VCylAdp.sDefault VCylAdp;
		#endregion
	}
}
