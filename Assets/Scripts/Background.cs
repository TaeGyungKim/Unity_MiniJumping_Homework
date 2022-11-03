using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = -5;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);


        if (gameObject.name == "Background" && transform.position.x < -99.4f)
            transform.position = new Vector3(99.4f, 0f, 5f);

    }
}
