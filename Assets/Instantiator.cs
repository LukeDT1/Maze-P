using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour {

    public Rigidbody objectToInstantiate;
    public int quantityPerInterval = 1;
    public float interval = 1f;
    public int maxObjects = 100;

    private Queue<Rigidbody> instantiatedObjects = new Queue<Rigidbody>();

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            for (int i = 0; i < quantityPerInterval; i++)
            {
                Rigidbody rb;
                if (instantiatedObjects.Count == maxObjects)
                {
                    rb = instantiatedObjects.Dequeue();
                    rb.transform.position = transform.position;
                    rb.transform.rotation = Quaternion.identity;
                }
                else
                {
                    rb = Instantiate<Rigidbody>(objectToInstantiate, transform.position, Quaternion.identity, transform);
                }
                instantiatedObjects.Enqueue(rb);
                rb.AddForce(Random.Range(1f, 2f), Random.Range(3f, 4f), Random.Range(1f, 2f));
            }
            yield return new WaitForSeconds(interval);
        }
    }
}