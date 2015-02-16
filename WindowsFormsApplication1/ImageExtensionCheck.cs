using System;
using System.IO;
namespace WindowsFormsApplication1
{
	class ImageExtensionCheck
	{
		public ImageExtensionCheck( string filePath )
		{
			_fName = filePath;
		}
		//string fname = Path.GetExtension ( _fName ).ToString();
		static string _fName;

		public bool chkValidExtension( )
		{
			string ext = Path.GetExtension ( _fName ).ToUpper ();
			string[] PosterAllowedExtensions = new string[] { ".GIF", ".JPEG", ".JPG", ".PNG" };
			for ( int i = 0; i < PosterAllowedExtensions.Length; i++ )
			{
				if ( ext == PosterAllowedExtensions[i] )
					return true;
			}
			return false;
		}
	}
}



