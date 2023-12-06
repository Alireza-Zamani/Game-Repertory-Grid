using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonEvents : MonoBehaviour
{
    public void OnStartInterviewClick()
    {
        FindObjectOfType<UiIntervieweeInfo>().SaveInfo();
        
        PanelManager.Singleton.SwitchPanelsTo(PanelState.Games);
    }
    
    public void OnToPolesButtonClick()
    {
        FindObjectOfType<UIGamesInfo>().SaveInfo();
        
        PanelManager.Singleton.SwitchPanelsTo(PanelState.Constructs);
        FindObjectOfType<BatchGenerator>().GenerateNewBatch();
    }

    public void OnNewBatchButtonClick()
    {
        FindObjectOfType<BatchGenerator>().SaveInfo();
        FindObjectOfType<BatchGenerator>().GenerateNewBatch();
    }
    
    public void OnToScoringButtonClick()
    {
        FindObjectOfType<BatchGenerator>().SaveInfo();
        
        PanelManager.Singleton.SwitchPanelsTo(PanelState.ConstructScoring);
        FindObjectOfType<ConstructScorer>().SetupData();
    }

    public void OnNextConstructScoringButtonClick()
    {
        FindObjectOfType<ConstructScorer>().SaveInfo();
        FindObjectOfType<ConstructScorer>().SetupData();
    }

    public void OnStartNewInterviewClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
