using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    // Update is called once per frame
    void Update()
    {
        // Keep Camera object in same position as the player
        transform.position = cameraPosition.position;
    }
}
