using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace App9.ViewModels
{
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Text.RegularExpressions;
	using YoutubeExtractor;

    class DownloadAudioViewModel
    {
		#region Properties
		public string Url {
			get;
			set;
		}
		#endregion

		#region Constructors
		public DownloadAudioViewModel()
		{

		}
		#endregion

		#region Commands
		public ICommand SearchVideoCommand
		{
			get 
			{
				return new RelayCommand(SearchVideo);
			}
		}
		#endregion

		#region Methods
		private async void SearchVideo()
		{
			if (string.IsNullOrEmpty(Url))
			{
				await Application.Current.MainPage.DisplayAlert(
						"Error",
						"No has introducido el video de youtube",
						"Aceptar"
				);
				return;
			}
			Device.OpenUri(new Uri("https://www.convertmp3.io/widget/button/?video=" + Url));
		}
		#endregion


	}
}
