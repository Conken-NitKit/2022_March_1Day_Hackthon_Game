using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public void MoveUpPosition()
    {
        this.transform.position += new Vector3(0f, 1f, 0f);
    }
}
