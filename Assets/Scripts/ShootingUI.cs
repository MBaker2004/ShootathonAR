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

    void ShootBallOnButton()
    {
        Start();
        Vector3 spawnPosition = mainCam.transform.position + mainCam.transform.forward * 0.1f;
        Quaternion spawnRotation = mainCam.transform.rotation;

        GameObject spawnBall = Instantiate(BallPrefab, spawnPosition, spawnRotation);
        Rigidbody rb = spawnBall.GetComponent<Rigidbody>();

        if(rb != null)
        {
            rb.AddForce(mainCam.transform.forward * ballFowardForce);
        }

        Destroy(spawnBall, 5f);
    }
}
