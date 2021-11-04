using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuloRandom : MonoBehaviour
{
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = Random.Range(0.5f, 3);

            int randomAction = Random.Range(0, 3);

            switch (randomAction)
            {
                default:
                    break;
                case 0:
                    gameObject.GetComponent<BoxCollider>().attachedRigidbody.AddForce(Vector3.up * 10000);
                    break;
                case 1:
                    //mudar de cor
                    break;
                case 2:
                    //dar uma espadada
                    break;
            }
        }
    }
}
