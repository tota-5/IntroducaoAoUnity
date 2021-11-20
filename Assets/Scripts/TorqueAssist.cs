using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorqueAssist : MonoBehaviour
{
    public Rigidbody myBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(myBody.gameObject.transform.up.y < 0.8)
        {
            float intensity = myBody.gameObject.transform.up.y - 1;
            myBody.AddRelativeTorque(Vector3.up * intensity);
        }
    }
}
