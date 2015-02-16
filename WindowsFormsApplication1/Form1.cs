//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace treeview
//{
//	public partial class Form1 : Form
//	{

//		//public class kData
//		//{   // instead of class you can use struct, but with some difficulties
//		//	public int index;
//		//	public int level;
//		//	public string NodeText;
//		//	public string OtherData;
//		//	//public stData()  { } // here you can initialize variables
//		//};
//		//List<kData> L; // instead of list you can use array, but I prefer Lists

//		public Form1( )
//		{



//			InitializeComponent ();
//		}

//		private void Form1_Load( object sender, EventArgs e )
//		{


//		}

//		private void button1_Click( object sender, EventArgs e )
//		{
//			// take data from ListBox and store it to List
//			string line;
//			L = new List<kData> ();
//			for ( int i = 0; i < listBox1.Items.Count; i++ )
//			{
//				line = listBox1.Items[i].ToString ();
//				L.Add ( new kData () );
//				L[i].index = i;
//				L[i].level = Convert.ToInt32 ( line.Substring ( 0, 1 ) );
//				L[i].NodeText = line.Substring ( 2 );
//				L[i].OtherData = "some other data you might need";

//			}

//			//populateBaseNodes ();

//		}

//		//public void populateBaseNodes( )
//		//{
//		//	int i;
//		//	treeView1.Nodes.Clear ();
//		//	treeView1.BeginUpdate ();

//		//	for ( i = 0; i < L.Count (); i++ )
//		//	{
//		//		if ( L[i].level == 0 )
//		//		{
//		//			treeView1.Nodes.Add ( L[i].NodeText, L[i].NodeText );
//		//			treeView1.Nodes[treeView1.Nodes.Count - 1].Tag = L[i];
//		//		}
//		//	}

//		//	for ( i = 0; i < treeView1.Nodes.Count; i++ )
//		//		populateChilds ( treeView1.Nodes[i] );

//		//	treeView1.EndUpdate ();
//		//	treeView1.Refresh ();
//		//}

//		//public void populateChilds( TreeNode parentNode )
//		//{
//		//	kData parentRed = (kData)parentNode.Tag;

//		//	for ( int i = parentRed.index + 1; i < L.Count; i++ )
//		//	{
//		//		if ( L[i].level == (parentRed.level + 1) )
//		//		{
//		//			parentNode.Nodes.Add ( L[i].NodeText, L[i].NodeText );
//		//			parentNode.Nodes[parentNode.Nodes.Count - 1].Tag = L[i];
//		//			populateChilds ( parentNode.Nodes[parentNode.Nodes.Count - 1] );
//		//		}
//		//		if ( L[i].level <= parentRed.level ) break;
//		//	}
//		//}
//	}

//}
