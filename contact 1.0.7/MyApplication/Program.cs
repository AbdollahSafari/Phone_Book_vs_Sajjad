namespace MyApplication;

internal static class Program
{
	static Program()
	{
	}

	[System.STAThread]
	private static void Main()
	{
		ApplicationConfiguration.Initialize();

		// **************************************************
		//System.Windows.Forms.Application.Run(mainForm: new StartupForm());
		// **************************************************

		// **************************************************
		var mainForm = new MainForm();

		Application.Run(mainForm: mainForm);

		if (mainForm != null)
		{
			if (mainForm.IsDisposed == false)
			{
				mainForm.Dispose();
			}

			//mainForm = null;
		}
		// **************************************************
	}
}
