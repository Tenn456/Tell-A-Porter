using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [SerializeField]private Transform david;
    private void Update()
    {
        transform.position = new Vector3(david.position.x, david.position.y, transform.position.z);
    }
}
