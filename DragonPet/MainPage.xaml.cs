﻿namespace DragonPet;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}


	  private void changepage(object sender, EventArgs args)
 		 {
				if (Application.Current != null)
				Application.Current.MainPage = new GamePage();
			}
	  
       private void OpenAbout (object sender, EventArgs args)
		{
			frameAbout.IsVisible = true;
		}
  


	private void BackAbout(object sender, EventArgs args)
		{
			frameAbout.IsVisible = false;
		}
	
 
}