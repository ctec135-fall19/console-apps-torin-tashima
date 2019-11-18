using System;
using System.Windows.Forms;

namespace SimpleWFApp
{
	class Program
	{
		static void Main()
		{
			Application.Run(new MainWindow("Window Form App", 300, 400));
		}
	}
	
	class MainWindow : Form
	{
		private MenuStrip menuMainMenu = new MenuStrip();
		private ToolStripMenuItem menuFile = new ToolStripMenuItem();
		private ToolStripMenuItem menuExit = new ToolStripMenuItem();
		
		public MainWindow(string title, int height, int width) {
			// Set properties of window
			Text = title;
			Width = width;
			Height = height;
			
			// Method to build main menu
			BuildMenu();
		}
		
		private void BuildMenu() {
			// Add File menu item to menu bar
			menuFile.Text = "&File";
			menuMainMenu.Items.Add(menuFile);
			
			// Now add Exit menu item under File tab
			menuExit.Text = "E&xit";
			menuFile.DropDownItems.Add(menuExit);
			menuExit.Click += new System.EventHandler(this.menuExit_click);
			
			// Finally, set the menu for this form
			Controls.Add(this.menuMainMenu);
			MainMenuStrip = this.menuMainMenu;
		}
		
		// Handler for File > Exit event
		private void menuExit_click(object sender, EventArgs e) {
			Application.Exit();
		}
	}
}