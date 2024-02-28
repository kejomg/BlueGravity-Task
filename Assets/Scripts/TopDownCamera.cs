using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Basic camera follow script.
public class TopDownCamera : MonoBehaviour
{
    public Transform target; 
    public float smoothing = 5f; 
    public Vector2 minPosition; 
    public Vector2 maxPosition; 

    private Vector3 offset; 

    void Start()
    {
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset;

        targetCamPos.x = Mathf.Clamp(targetCamPos.x, minPosition.x, maxPosition.x);
        targetCamPos.y = Mathf.Clamp(targetCamPos.y, minPosition.y, maxPosition.y);

        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
