using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderScoreText : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private TMP_Text _text;

    private void Awake() => _text = GetComponent<TMP_Text>();

    private void Start() => _slider.onValueChanged.AddListener(OnSliderValueChangeHandler);

    private void OnDestroy() => _slider.onValueChanged.RemoveListener(OnSliderValueChangeHandler);

    private void OnSliderValueChangeHandler(float value)
    {
        _text.text = value.ToString();
    }
}
