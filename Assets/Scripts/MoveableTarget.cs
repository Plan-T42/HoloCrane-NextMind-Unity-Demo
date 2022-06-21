using System;
using UnityEngine;
using System.Collections;
using TMPro;

public class MoveableTarget : MonoBehaviour
{

    public TextMeshPro TargetBridgeLocText = null;
    public TextMeshPro TargetTrolleyLocText = null;
    public TextMeshPro TargetHoistLocText = null;

    private void Update()
    {
        TargetBridgeLocText.text = (Math.Round(this.gameObject.transform.localPosition.x + 1825)).ToString();
        TargetTrolleyLocText.text = (Math.Round(this.gameObject.transform.localPosition.z + 6029)).ToString();
        TargetHoistLocText.text = (Math.Round(this.gameObject.transform.localPosition.y + 293)).ToString();
    }

    // Start is called before the first frame update
    public void UpdateTargetLocationInDTDoc()
    {
        // Update target location in Json data node
        GlobalInstance.Instance.jsonData["features"][6]["parameters"]["controlParameters"]["targetLocation"][0] = Math.Round(this.gameObject.transform.localPosition.x + 1825);
        GlobalInstance.Instance.jsonData["features"][6]["parameters"]["controlParameters"]["targetLocation"][1] = Math.Round(this.gameObject.transform.localPosition.z + 6029);
        GlobalInstance.Instance.jsonData["features"][6]["parameters"]["controlParameters"]["targetLocation"][2] = Math.Round(this.gameObject.transform.localPosition.y + 293);

        GameObject.Find("DTDashboard").GetComponent<DTDashboard>().ShowDT();
    }

}
