using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanel : MonoBehaviour
{
    [SerializeField] private PanelState currentPanelState;

    private void Start() => PanelManager.Singleton.OnPanelChange += PanelChangeHandler;

    private void OnDestroy() => PanelManager.Singleton.OnPanelChange -= PanelChangeHandler;

    private void PanelChangeHandler(PanelState state)
    {
        if (state == currentPanelState)
            foreach (Transform t in transform)
                t.gameObject.SetActive(true);
        else
            foreach (Transform t in transform)
                t.gameObject.SetActive(false);
    }
}
