using System;

namespace ApplyingAttributes
{
    [Serializable]
    public class Motorcycle
    {
        [NonSerialized]
        float weightOfCurrentPassengers;

        bool hasRadioSystem;
        bool hasHeadSet;
        bool hasSissyBar;
    }
}
