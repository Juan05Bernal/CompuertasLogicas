namespace Ucu.Poo.Exercise{

public class NotGate : IGate
{
  private ILogicValue input1;
   

  public NotGate (ILogicValue input1)
    {
        this.input1 = input1;
        
    }
    public bool Output
    {
        get
            {
                return !this.input1.Value;
            }
    }
}
}
