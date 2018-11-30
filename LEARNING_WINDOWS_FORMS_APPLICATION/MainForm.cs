namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		private void firstNameTextBox_Leave(object sender, System.EventArgs e)
		{
			//if (firstNameTextBox.Text.Length > 20)
			//{
			//	System.Windows.Forms.MessageBox.Show
			//		(text: "First name value length should be less than or equal to 20 characters!");

			//	firstNameTextBox.Focus();
			//}
		}

		private void firstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (firstNameTextBox.Text.Length > 20)
			{
				System.Windows.Forms.MessageBox.Show
					(text: "First name value length should be less than or equal to 20 characters!");

				// بی خیال شو - شتر دیدی دیدی
				e.Cancel = true;

				// در این رخداد دستور ذیل غلط می‌باشد
				//firstNameTextBox.Focus();
			}
		}

		private void saveButton_Click(object sender, System.EventArgs e)
		{

		}
	}
}
