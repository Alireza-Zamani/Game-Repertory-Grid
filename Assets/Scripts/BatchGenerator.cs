using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class BatchGenerator : MonoBehaviour
{
    [SerializeField] private TMP_Text element1;
    [SerializeField] private TMP_Text element2;
    [SerializeField] private TMP_Text element3;
    
    [SerializeField] private TMP_InputField emergentInputField;
    [SerializeField] private TMP_InputField contrastInputField;

    private Dictionary<int, string> _combinations = null;

    private void SetData()
    {
        _combinations = new Dictionary<int, string>
        {
            {0, InterviewDataHolder.WorstGame},
            {1, InterviewDataHolder.BadGame},
            {2, InterviewDataHolder.MediocreGame},
            {3, InterviewDataHolder.GoodGame},
            {4, InterviewDataHolder.BestGame},
            {5, InterviewDataHolder.IdealGame},
        };
    }
    
    public void GenerateNewBatch()
    {
        if (_combinations == null) SetData();

        List<int> randomKeys = new List<int>();

        while (randomKeys.Count < 3)
        {
            int randomNumber = Random.Range(0, 6);
            
            if (!randomKeys.Contains(randomNumber))
                randomKeys.Add(randomNumber);
        }

        element1.text = _combinations[randomKeys[0]];
        element2.text = _combinations[randomKeys[1]];
        element3.text = _combinations[randomKeys[2]];
    }

    public void SaveInfo()
    {
        InterviewDataHolder.PoleDataList ??= new List<ConstructData>();
        
        ConstructData constructData = new ConstructData
        {
            EmergentPole = emergentInputField.text,
            ContrastPole = contrastInputField.text
        };
        
        InterviewDataHolder.PoleDataList.Add(constructData); 
        
        emergentInputField.text = "";
        contrastInputField.text = "";
    }
}
