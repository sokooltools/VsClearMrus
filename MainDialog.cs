using System;
using System.Threading;
using System.Windows.Forms;

namespace SokoolTools.VsClearMrus
{
	public partial class MainDialog : Form
	{
		private const string CAPTION = " the MRU lists\n(i.e., the \"Recent Projects and Solutions\" menu item,\n"
			+ "\"Find and Replace\" dialog drop down lists, etc.)\nfrom Visual Studio 2008 through 2015...";

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Initializes a new instance of the <see cref="MainDialog"/> class.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		public MainDialog()
		{
			InitializeComponent();
		}

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Handles the Load event of the Main dialog control.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		private void MainDialog_Load(object sender, EventArgs e)
		{
			var tooltip = new ToolTip();
			tooltip.SetToolTip(lblCaption, "Clears" + CAPTION);
			tooltip.SetToolTip(btnOk, "Click to clear" + CAPTION);
			tooltip.SetToolTip(btnCancel, "Click to close this dialog without making any changes.");
		}

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Handles the event raised by the "OK" button control when it is clicked.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		private void btnOk_Click(object sender, EventArgs e)
		{
			try
			{
				btnOk.Enabled = false;

				Implementation.ClearAllMrus();

				lblCaption.ForeColor = System.Drawing.Color.Green;
				lblCaption.Text = @"All Visual Studio MRUs have been cleared.";
				lblCaption.Refresh();
				Thread.Sleep(800);
				Close();
			}
			catch (Exception ex)
			{
				lblCaption.ForeColor = System.Drawing.Color.Red;
				lblCaption.Text = @"Clearing All Visual Studio MRUs resulted in the following error:\r\n" + ex.Message;
				lblCaption.Refresh();
			}
		}

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Handles the event raised by the "Cancel" button control when it is clicked.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}


	}
}
