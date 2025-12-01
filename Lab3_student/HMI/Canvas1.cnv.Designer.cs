/*
 * Created by EcoStruxure Automation Expert.
 * User: vaatmar1
 * Date: 11/5/2023
 * Time: 7:00 PM
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
	/// Summary description for Canvas1.
	/// </summary>
	partial class Canvas1
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.HCylinder = new HMI.Main.Symbols.HCylinderLS.sDefault();
			this.VCylinder = new HMI.Main.Symbols.VCylinderLS.sDefault();
			this.InsertWP = new HMI.Main.Symbols.BUTTON.HMI();
			// 
			// HCylinder
			// 
			this.HCylinder.BeginInit();
			this.HCylinder.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 288D, 264D);
			this.HCylinder.Name = "HCylinder";
			this.HCylinder.SecurityToken = ((uint)(4294967295u));
			this.HCylinder.TagName = "6C64157A5D1FD27C";
			this.HCylinder.EndInit();
			// 
			// VCylinder
			// 
			this.VCylinder.BeginInit();
			this.VCylinder.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 696D, 16D);
			this.VCylinder.Name = "VCylinder";
			this.VCylinder.SecurityToken = ((uint)(4294967295u));
			this.VCylinder.TagName = "3EF90BAF2E625401";
			this.VCylinder.EndInit();
			// 
			// InsertWP
			// 
			this.InsertWP.BeginInit();
			this.InsertWP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 448D, 480D);
			this.InsertWP.Name = "InsertWP";
			this.InsertWP.SecurityToken = ((uint)(4294967295u));
			this.InsertWP.TagName = "F5B237E716BAE339";
			this.InsertWP.EndInit();
			// 
			// Canvas1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1280D)), ((float)(910D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas1";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HCylinder,
			this.VCylinder,
			this.InsertWP});
			this.Size = new System.Drawing.Size(1280, 910);

		}
		private HMI.Main.Symbols.HCylinderLS.sDefault HCylinder;
		private HMI.Main.Symbols.VCylinderLS.sDefault VCylinder;
		private HMI.Main.Symbols.BUTTON.HMI InsertWP;
		#endregion
	}
}
