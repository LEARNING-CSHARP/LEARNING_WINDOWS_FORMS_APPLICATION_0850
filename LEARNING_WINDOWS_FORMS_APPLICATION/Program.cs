﻿namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	/// <summary>
	/// Startup Class
	/// </summary>
	internal static class Program
	{
		static Program()
		{
		}

		/// <summary>
		/// Startup Function
		/// </summary>
		[System.STAThread]
		internal static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			MainForm startupForm = new MainForm();

			System.Windows.Forms.Application.Run(startupForm);

			if (startupForm != null)
			{
				if (startupForm.IsDisposed == false)
				{
					startupForm.Dispose();
				}

				startupForm = null;
			}
			// **************************************************
		}
	}
}
