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

 
}