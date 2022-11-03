using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject pf_wall;
    private float interval;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
             interval = Random.Range(1.0f, 2.0f);
            float rnd_y = Random.Range(-3f, 4f);

            Instantiate(pf_wall, new Vector3(transform.position.x, rnd_y, transform.position.z), transform.rotation);
            yield return new WaitForSeconds(interval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
