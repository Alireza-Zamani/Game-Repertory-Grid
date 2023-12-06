using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGamesInfo : MonoBehaviour
{
    [SerializeField] private TMP_InputField worstGame;
    [SerializeField] private TMP_InputField badGame;
    [SerializeField] private TMP_InputField mediocreGame;
    [SerializeField] private TMP_InputField goodGame;
    [SerializeField] private TMP_InputField BestGame;
    [SerializeField] private TMP_InputField idealGame;
    
    public void SaveInfo()
    {
        InterviewDataHolder.WorstGame = worstGame.text;
        InterviewDataHolder.BadGame = badGame.text;
        InterviewDataHolder.MediocreGame = mediocreGame.text;
        InterviewDataHolder.GoodGame = goodGame.text;
        InterviewDataHolder.BestGame = BestGame.text;
        InterviewDataHolder.IdealGame = idealGame.text;
    }

}
