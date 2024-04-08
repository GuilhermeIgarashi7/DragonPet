namespace DragonPet;


public partial class GamePage : ContentPage
{
    DragonFather current;
    Light Snow = new Light();
    Night Banguela = new Night();
    Purple Violet = new Purple();
    public GamePage()
    {
        InitializeComponent();
        current = Snow;
    }

void buttonChangeClicked(object sender, EventArgs args)
    {
        if(current==Snow)
            {
                current=Banguela;
            }
            else if(current==Banguela)
            {
                current=Violet;
            }
            else if (current==Violet)
            {
                current=Snow;
            }
            DragonImage.Source=current.GetDragonDesign();
    }
void buttonHungryClicked(object sender, EventArgs args)
    {
        current.SetHungry(current.GetHungry()+0.1);

    }
		private void change(object sender, EventArgs args)
 		 {
				if (Application.Current != null)
				Application.Current.MainPage = new MainPage();
			}
	  
 
}