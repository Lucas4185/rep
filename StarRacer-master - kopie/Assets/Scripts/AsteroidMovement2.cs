using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement2 : MonoBehaviour {

    int counter = 0;

    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 5);
        counter++;
        if (counter >= 1200)
        {
            Destroy(this.gameObject);
        }

    }
}
