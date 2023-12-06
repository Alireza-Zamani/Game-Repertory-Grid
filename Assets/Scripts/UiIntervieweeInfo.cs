using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiIntervieweeInfo : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private TMP_InputField ageInputField;
    [SerializeField] private TMP_InputField educationInputField;
    [SerializeField] private TMP_InputField GameplayTimeInputField;

    public void SaveInfo()
    {
        InterviewDataHolder.IntervieweeName = nameInputField.text;
        InterviewDataHolder.IntervieweeAge = ageInputField.text;
        InterviewDataHolder.IntervieweeEducation = educationInputField.text;
        InterviewDataHolder.IntervieweeAverageGameplayTime = GameplayTimeInputField.text;
    }
}
