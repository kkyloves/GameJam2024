using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildDontRotateController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0,0,0);
    }
}
