using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ShootingUI : MonoBehaviour
{
    private Camera mainCam;

    [SerializeField] GameObject BallPrefab;
    [SerializeField] float ballFowardForce = 500f;

    public void Start()
    {
        mainCam = FindAnyObjectByType<Camera>();
    }

    void OnShootButtonClicked()
    {

    }
}
