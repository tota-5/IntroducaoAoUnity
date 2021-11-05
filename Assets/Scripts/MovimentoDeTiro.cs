using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDeTiro : MonoBehaviour
{
    public float lifeTime = 3;

    public float velocity = 0.1f;

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;

        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }

        gameObject.transform.position += gameObject.transform.forward * velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
