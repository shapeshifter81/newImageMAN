using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1 
{

	public partial class Main : Form 
	{
	

		 //<summary>
		 //Variables GLOBAL
		 //</summary>
		public string strFileName;
		public string strFoldername;

		public Main( )
		{
			InitializeComponent ();

		}

		public void button2_Click( object sender, EventArgs e )
		{
			openFolder ();
		}

		#region OpenFolder

		public string openFolder( )
		{

			
			this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
			DialogResult result = this.folderBrowserDialog1.ShowDialog ();
			if ( result == DialogResult.OK )
			{
				listView1.Items.Clear ();

				// retrieve the name of the selected folder
				string foldername = this.folderBrowserDialog1.SelectedPath;
				strFoldername = foldername;

				treeView1.Nodes.Add (  foldername  );
			

				// print the folder name on a texxtbox
				textBox1.Text = foldername;

				//set properites forimagelist and listview
				imageList.ImageSize = new Size ( 100, 100 );
				listView1.CheckBoxes = true;

				int index = 0;
				// iterate over all files in the selected folder and add them to 
				// the listbox.
				foreach ( string filename in Directory.GetFiles ( foldername ) )
				{
					label1.Text = filename;

					ImageExtensionCheck iCheck = new ImageExtensionCheck ( filename );
					bool isImage = iCheck.chkValidExtension ();
					if ( isImage == true )
					{
						strFileName = filename;

						Image image = Image.FromFile ( filename );
						imageList.Images.Add ( image );

						string fileWP = Path.GetFileName ( filename );
						ListViewItem item = new ListViewItem ( fileWP, index );
						listView1.Items.Add ( item );
						item.Name = filename;
						listView1.View = View.LargeIcon;

						listView1.LargeImageList = imageList;

						index++;
					}


				}



			}

			return strFileName;
		}
		#endregion openfolder



		public void listView1_ItemChecked( object sender, ItemCheckedEventArgs e )
		{

			if ( e.Item.Checked == true )
			{
				listBox1.Items.Add(e.Item.Name);
				//TODO listbox or treeview???
				int i = treeView1.Nodes.Count;
				treeView1.Nodes[i - 1].Nodes.Add ( Path.GetFileName  ( e.Item.Name.ToString () ) );
				
				treeView1.ExpandAll();
			}
			else if ( e.Item.Checked == false )
			{
				listBox1.Items.Remove (e.Item.Name );
			}

			label1.Text = listBox1.Items.Count.ToString () + " Images Selected";

		}

		public void button1_Click( object sender, EventArgs e )
		{
			kData.PopTreeView();
		}

		public void listBox1_SelectedIndexChanged( object sender, EventArgs e )
		{

		}



		#region ShowSetlectedFiles

		//private void ShowSetlectedFiles( )
		//{
		//	//set properites forimagelist and listview
		//	imageList.ImageSize = new Size ( 100, 100 );
		//	listView1.CheckBoxes = true;

		//	int index = 0;
		//	int numCheckedItems = listView1.CheckedItems.Count;

		//	// iterate over all files in the selected folder and add them to 
		//	// the listbox.

		//	listBox1.Items.Clear ();
		//	imageList.Images.Clear ();

		//	foreach ( ListViewItem item in listView1.Items )
		//	{

		//		if ( item.Checked == true )
		//		{

		//			listBox1.Items.Add ( item.Name );

		//			Image image = Image.FromFile ( item.Name );
		//			imageList.Images.Add ( image );


		//			//ListViewItem item2 = new ListViewItem ( item.Name, index );
		//			//listView1.Items.Add ( item2 );
		//			////item.Name = filename;
		//			//listView1.View = View.LargeIcon;

		//			//listView1.LargeImageList = imageList;

		//			//index++;

		//		}


		//	}


		}
		#endregion

		

}




