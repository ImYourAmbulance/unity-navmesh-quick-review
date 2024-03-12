using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovementScript : MonoBehaviour
{
    int numSteps = 1000;
    int stepSign = 1;
    void Update()
    {
        if (numSteps == 0) 
        {
            numSteps = 1000;
            stepSign *= -1;
        }
        transform.position += new Vector3(0.01f, 0, 0) * stepSign;
        numSteps--;
    }
}
