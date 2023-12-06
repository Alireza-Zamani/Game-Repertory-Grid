using System;
using System.Collections;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public static PanelManager Singleton;
    
    public Action<PanelState> OnPanelChange;

    public void SwitchPanelsTo(PanelState state)
    {
        OnPanelChange?.Invoke(state);   
    }

    private void Awake()
    {
        if (Singleton != null && Singleton != this)
            Destroy(this);
        else
            Singleton = this;
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(0.5f);
        
        SwitchPanelsTo(PanelState.Interviewee);
    }
}

public enum PanelState
{
    Interviewee,
    Games,
    Constructs,
    ConstructScoring,
    FinalScreen
}
