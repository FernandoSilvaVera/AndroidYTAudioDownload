using System;
using System.Collections.Generic;
using System.Text;

namespace App9.ViewModels
{
	class MainViewModel
	{
		#region ViewModels
		public DownloadAudioViewModel DownloadAudio {
			get;
			set;
		}
		#endregion

		#region Constructors
		public MainViewModel()
		{
			DownloadAudio = new DownloadAudioViewModel();
		}
		#endregion

	}
}
