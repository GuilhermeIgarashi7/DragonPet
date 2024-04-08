namespace DragonPet;

    public class DragonFather
    {
        protected double hungry;
        protected double thirst;
        protected double happiness;

//---------------------------------------------------------------------------------------------------
    public DragonFather()
    {
        hungry = 0.2;
        thirst = 0.4;
        happiness = 0.1;
    }
//----------------------------------------------------------------------------------------------------
    public void SetHungry(double h)
    {
        hungry = h;
    }

    public void SetThirst(double t)
    {
        thirst = t;
    }
    public void SetHappiness(double ha)
    {
        happiness = ha;
    }
    //------------------------------------------------------------------------------------------------------
    public double GetHungry()
    {
        return hungry;
    }
    public double GetThirst()
    {
        return thirst;
    }
    public double GetHappiness()
    {
        return happiness;
    }

    protected string DragonDesign;

    public string GetDragonDesign()
    {
        return DragonDesign;
    }
    //------------------------------------------------------------------------------------------------------------
}
