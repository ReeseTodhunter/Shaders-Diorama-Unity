using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    public float waitTimer = 3f;
    public float rotationAmount = 70f;
    private float temp = 70;
    private bool positive = true;

    private void Start()
    {
        temp = rotationAmount;
    }
    void Update()
    {
        if (temp > 0)
        {
            if (positive)
            {
                this.transform.Rotate(new Vector3(0, 0.1f, 0));
            }
            else
            {
                this.transform.Rotate(new Vector3(0, -0.1f, 0));
            }
            temp -= 0.1f;
        }
        else
        {
            waitTimer -= Time.deltaTime;
            if (waitTimer < 0)
            {
                positive = !positive;
                temp = rotationAmount;
                waitTimer = 3;
            }
        }
    }
}
