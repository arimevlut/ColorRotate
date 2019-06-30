using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    public float RotateAngle;

    public void LeftSpinButton()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, RotateAngle);
    }

    public void RightSpinButton()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, -RotateAngle);
    }
}
