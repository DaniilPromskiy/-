using UnityEngine;

public class ConsoleLogger : MonoBehaviour, IGameEventListener
{
    public GameEvent eventToListen;

    private void OnEnable() => eventToListen.Register(this);
    private void OnDisable() => eventToListen.Unregister(this);

    public void OnEventRaised()
    {
        Debug.Log("Event triggered: " + eventToListen.name);
    }
}
