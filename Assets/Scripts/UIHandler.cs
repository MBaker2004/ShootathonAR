using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] Button UIStartButton;
    [SerializeField] Button UIShootButton;

    public static event Action OnUIStartButtonClicked;
    public static event Action OnUIShootButtonClicked;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UIStartButton.onClick.AddListener(OnStartButtonClicked);
        UIShootButton.onClick.AddListener(OnStartButtonClicked);

        UIShootButton.gameObject.SetActive(false);
    }
    void OnStartButtonClicked()
    {
        OnUIStartButtonClicked?.Invoke();
        UIStartButton.gameObject.SetActive(false);
        UIShootButton.gameObject.SetActive(true);
    }
    void OnShootButtonClicked()
    {
        OnUIShootButtonClicked?.Invoke();
    }
}
