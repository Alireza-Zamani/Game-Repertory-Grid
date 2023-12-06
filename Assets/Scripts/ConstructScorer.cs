using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConstructScorer : MonoBehaviour
{
    [SerializeField] private TMP_Text worstText;
    [SerializeField] private TMP_Text badText;
    [SerializeField] private TMP_Text mediocreText;
    [SerializeField] private TMP_Text goodText;
    [SerializeField] private TMP_Text bestText;
    [SerializeField] private TMP_Text idealText;
    
    [Space(50)]
        
    [SerializeField] private TMP_Text emergentText;
    [SerializeField] private TMP_Text contrastText;

    [Space(50)]
    
    [SerializeField] private Slider worstSlider;
    [SerializeField] private Slider badSlider;
    [SerializeField] private Slider mediocreSlider;
    [SerializeField] private Slider goodSlider;
    [SerializeField] private Slider bestSlider;
    [SerializeField] private Slider idealSlider;

    private int _currentIndex = -1;

    public void SetupData()
    {
        _currentIndex++;

        if (_currentIndex >= InterviewDataHolder.PoleDataList.Count)
        {
            InterviewOver();
            return;
        }

        worstText.text = InterviewDataHolder.WorstGame;
        badText.text = InterviewDataHolder.BadGame;
        mediocreText.text = InterviewDataHolder.MediocreGame;
        goodText.text = InterviewDataHolder.GoodGame;
        bestText.text = InterviewDataHolder.BestGame;
        idealText.text = InterviewDataHolder.IdealGame;

        emergentText.text = InterviewDataHolder.PoleDataList[_currentIndex].EmergentPole;
        contrastText.text = InterviewDataHolder.PoleDataList[_currentIndex].ContrastPole;
    }

    public void SaveInfo()
    {
        InterviewDataHolder.PoleDataList[_currentIndex].WorstScore = worstSlider.value.ToString();
        InterviewDataHolder.PoleDataList[_currentIndex].BadScore = badSlider.value.ToString();
        InterviewDataHolder.PoleDataList[_currentIndex].MediocreScore = mediocreSlider.value.ToString();
        InterviewDataHolder.PoleDataList[_currentIndex].GoodScore = goodSlider.value.ToString();
        InterviewDataHolder.PoleDataList[_currentIndex].BestScore = bestSlider.value.ToString();
        InterviewDataHolder.PoleDataList[_currentIndex].IdealScore = idealSlider.value.ToString();
        
        worstSlider.value = 1;
        badSlider.value = 1;     
        mediocreSlider.value = 1;
        goodSlider.value = 1;    
        bestSlider.value = 1;    
        idealSlider.value = 1;   
    }
    
    private void InterviewOver()
    {
        PanelManager.Singleton.SwitchPanelsTo(PanelState.FinalScreen);
        InterviewDataHolder.WriteToFile();
    }


}
