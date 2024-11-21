/*
 * Created by SharpDevelop.
 * User: CC2_PC33
 * Date: 20/11/2024
 * Time: 08:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tapetes_uriangato
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnverdiseñosClick(object sender, EventArgs e)
		{
			diseños diseños = new diseños();
			diseños.Show();
			
		}
	}
}
