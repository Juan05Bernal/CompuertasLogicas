using System;
namespace Ucu.Poo.Exercise{
public class GateOutput : ILogicValue
{
    private IGate gate;
    public GateOutput(IGate gate)
    {
        this.gate = gate;
    }
    public bool Value 
    {
        get
        {
            return gate.Output;
        }
    }

}
}