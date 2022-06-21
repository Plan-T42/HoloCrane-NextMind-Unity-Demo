using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCraneToTarget : MonoBehaviour
{
    // Adjust the speed for the application.
    public float speed;

    public GameObject bridge;
    public GameObject trolley;
    public GameObject hoist;

    public GameObject Target;

    private Vector3 bridgeTargetVector;
    private Vector3 trolleyTargetVector;
    private Vector3 hoistTargetVector;



    // Start is called before the first frame update
    void Start()
    {
        speed = 1000.0f;

        bridgeTargetVector = new Vector3(Target.transform.localPosition.x + 1825, 0, 0);
        trolleyTargetVector = new Vector3(0, 0, Target.transform.localPosition.z + 6029);
        hoistTargetVector = new Vector3(0, Target.transform.localPosition.y + 293, 0);

        //bridge.transform.localPosition = bridgeTargetVector;
        //trolley.transform.localPosition = trolleyTargetVector;
        //hoist.transform.localPosition = hoistTargetVector;

        //Debug.Log(bridgeTargetVector.x + " " + trolleyTargetVector.z + " " + hoistTargetVector.y);

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime; // calculate distance to move

        bridge.transform.localPosition = Vector3.MoveTowards(bridge.transform.localPosition, bridgeTargetVector, step);
        trolley.transform.localPosition = Vector3.MoveTowards(trolley.transform.localPosition, trolleyTargetVector, step);
        hoist.transform.localPosition = Vector3.MoveTowards(hoist.transform.localPosition, hoistTargetVector, step);

    }
}
