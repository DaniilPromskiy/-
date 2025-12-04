using UnityEngine;

public enum UIState
{
    Main,
    Add,
    Remove
}

public class UIStateMachine : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject addPanel;
    public GameObject removePanel;

    private UIState current;

    private void Start()
    {
        SwitchState(UIState.Main);
    }

    public void SwitchToMain() { SwitchState(UIState.Main); }
    public void SwitchToAdd() { SwitchState(UIState.Add); }
    public void SwitchToRemove() { SwitchState(UIState.Remove); }

    private void SwitchState(UIState state)
    {
        current = state;

        mainPanel.SetActive(state == UIState.Main);
        addPanel.SetActive(state == UIState.Add);
        removePanel.SetActive(state == UIState.Remove);

        GameEvents.UIStateEvent.Raise();
    }
}
