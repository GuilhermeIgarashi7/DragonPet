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
        ThirstBar.Progress = current.GetThirst();
        HappinessBar.Progress = current.GetHappiness();

        var timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(1);
		timer.Tick += (s, e) => DownGradeBar();
		timer.Start();

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
            ThirstBar.Progress = current.GetThirst();
            HappinessBar.Progress = current.GetHappiness();

    }
//--------------------------------------------------------------------------------------------
    void ProgressConfig()
        {
            HungryBar.Progress = current.GetHungry();
            ThirstBar.Progress = current.GetThirst();
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
    void DownGradeBar()
        {
            current.SetHungry(current.GetHungry() - 0.001);
            HungryBar.Progress = current.GetHungry();

            current.SetThirst(current.GetThirst() - 0.001);
            ThirstBar.Progress = current.GetThirst();

            current.SetHappiness(current.GetHappiness() - 0.001);
            HappinessBar.Progress = current.GetHappiness();

            Snow.SetHungry(Snow.GetHungry() - 0.001);
            Snow.SetThirst(Snow.GetThirst() - 0.001);
            Snow.SetHappiness(Snow.GetHappiness() - 0.001);

        }
 
}