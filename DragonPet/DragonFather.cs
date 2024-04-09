namespace DragonPet;

    public class DragonFather
    {
        protected double hungry;
        protected double thirst;
        protected double happiness;

//---------------------------------------------------------------------------------------------------
    public DragonFather()
    {
        hungry = 0;
        thirst = 0;
        happiness = 0;
    }
//----------------------------------------------------------------------------------------------------
    public void SetHungry(double h)
    {
            if(h<0)
                hungry = 0;
            else if (h>1)
                hungry = 1;
            else
                hungry = h;
    }

    public void SetThirst(double t)
    {
            if(t<0)
                thirst = 0;
            else if (t>1)
                thirst = 1;
            else 
                thirst = t;
    }

    public void SetHappiness(double ha)
    {
            if(ha<0)
             happiness = 0;
            else if (ha>1)      
             happiness = 1;
            else
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
