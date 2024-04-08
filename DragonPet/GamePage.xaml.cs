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
        DragonImage.Source = current.GetDragonDesign();
        HungryBar.Progress = current.GetHungry();
        ThistBar.Progress = current.GetThirst();
        HappinessBar.Progress = current.GetHappiness();

    }

//------------------------------------------------------------------------------------------------
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
            HungryBar.Progress = current.GetHungry();
            ThistBar.Progress = current.GetThirst();
            HappinessBar.Progress = current.GetHappiness();

    }
//--------------------------------------------------------------------------------------------
    void ProgressConfig()
        {
            HungryBar.Progress = current.GetHungry();
            ThistBar.Progress = current.GetThirst();
            HappinessBar.Progress = current.GetHappiness();
        }
//---------------------------------------------------------------------------------------------
    void buttonHungryClicked(object sender, EventArgs args)
        {
            current.SetHungry(current.GetHungry()+0.1);
            ProgressConfig();
        }
    void buttonThirstClicked(object sender, EventArgs args)
        {
            current.SetThirst(current.GetThirst()+0.1);
            ProgressConfig();
        }
    void buttonHappinessClicked(object sender, EventArgs args)
        {
            current.SetHappiness(current.GetHappiness()+0.1);
            ProgressConfig();
        }
//-----------------------------------------------------------------------------

 
}