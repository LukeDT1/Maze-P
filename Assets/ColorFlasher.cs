using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFlasher : MonoBehaviour {

    public Color colorA;
    public Color colorB;
    private Renderer rend;

    void Start () {
        rend = GetComponent<Renderer>();
        StartCoroutine(Flash());
	}

    private IEnumerator Flash ()
    {
        while (true)
        {
            rend.material.color = colorA;
            yield return new WaitForSeconds(0.25f);
            rend.material.color = colorB;
            yield return new WaitForSeconds(0.25f);
        }
    }
}
