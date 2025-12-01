/*
 * Created by EcoStruxure Automation Expert.
 * User: vaatmar1
 * Date: 11/5/2023
 * Time: 7:58 PM
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
	/// Summary description for Canvas3.
	/// </summary>
	partial class Canvas3
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BUTTONAdp = new HMI.Main.Symbols.BUTTONAdp.sDefault();
			this.HCylAdpOL = new HMI.Main.Symbols.HCylAdpOL.sDefault();
			this.VCylAdpOL = new HMI.Main.Symbols.VCylAdpOL.sDefault();
			// 
			// BUTTONAdp
			// 
			this.BUTTONAdp.BeginInit();
			this.BUTTONAdp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 233D, 340D);
			this.BUTTONAdp.Name = "BUTTONAdp";
			this.BUTTONAdp.SecurityToken = ((uint)(4294967295u));
			this.BUTTONAdp.TagName = "5CEF04DF83DE2A88";
			this.BUTTONAdp.EndInit();
			// 
			// HCylAdpOL
			// 
			this.HCylAdpOL.BeginInit();
			this.HCylAdpOL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 408D, 288D);
			this.HCylAdpOL.Name = "HCylAdpOL";
			this.HCylAdpOL.SecurityToken = ((uint)(4294967295u));
			this.HCylAdpOL.TagName = "81E0C620E5C03B02";
			this.HCylAdpOL.EndInit();
			// 
			// VCylAdpOL
			// 
			this.VCylAdpOL.BeginInit();
			this.VCylAdpOL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 720D, 80D);
			this.VCylAdpOL.Name = "VCylAdpOL";
			this.VCylAdpOL.SecurityToken = ((uint)(4294967295u));
			this.VCylAdpOL.TagName = "9E79DBFA47575F5E";
			this.VCylAdpOL.EndInit();
			// 
			// Canvas3
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1280D)), ((float)(910D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas3";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.BUTTONAdp,
			this.HCylAdpOL,
			this.VCylAdpOL});
			this.Size = new System.Drawing.Size(1280, 910);

		}
		private HMI.Main.Symbols.BUTTONAdp.sDefault BUTTONAdp;
		private HMI.Main.Symbols.HCylAdpOL.sDefault HCylAdpOL;
		private HMI.Main.Symbols.VCylAdpOL.sDefault VCylAdpOL;
		#endregion
	}
}
