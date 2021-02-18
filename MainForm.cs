/*
 * Created by SharpDevelop.
 * User: Samuel
 * Date: 2/15/2021
 * Time: 3:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SubMainForm;


namespace FirstWinForms
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			Label1.Text = "Welcome to the Windows App";
		}
		void BtnSetClick(object sender, EventArgs e)
		{
			Label1.Text = "Welcome Again and Again";
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			Label1.Text = "Text has been cancelled";
		}
		void BtnResetClick(object sender, EventArgs e)
		{
			Label1.Text = "Welcome to the Windows app";
		}
		void BtnLogoutClick(object sender, EventArgs e)
		{
			Form2 newform = new Form2();
			newform.Show();
		}
	}
}
