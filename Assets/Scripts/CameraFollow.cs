using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float horizontalAxis;
    public float verticalAxis;
    public Transform target;
    public Vector3 offSet;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // -10 is because the cameras position is at -10 naturally
        offSet = new Vector3(horizontalAxis, verticalAxis, -10);

        Vector3 desiredPostion = target.position + offSet;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPostion, speed);
        transform.position = smoothedPosition;
    }
}
