using UnityEngine;

public class HotdogDebug : MonoBehaviour
{
    private void Start()
    {
        Hotdog baseDog = new ClassicHotdog();
        Hotdog withPickles = new PicklesDecorator(new ClassicHotdog());
        Hotdog withOnion = new SweetOnionDecorator(new ClassicHotdog());

        Debug.Log($"{baseDog.GetName()} ({baseDog.GetWeight()}г) Ч {baseDog.GetCost()}р.\n" +
                  $"ƒополнительна€ информаци€:\n" +
                  $"{withPickles.GetName()} ({withPickles.GetWeight()}г) Ч {withPickles.GetCost()}р.\n" +
                  $"{withOnion.GetName()} ({withOnion.GetWeight()}г) Ч {withOnion.GetCost()}р.");
    }
}
