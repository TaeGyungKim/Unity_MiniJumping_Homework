using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private float jump_power;
    private float time = 0;
    //ÅØ½ºÃÄ icon
    public Texture2D icon = null;


    // Start is called before the first frame update
    void Start()
    {
        jump_power = Random.Range(4.0f, 9.0f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (Input.GetButton("Jump"))
            GetComponent<Rigidbody>().velocity = new Vector3(0, jump_power, 0);
    }
    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("main_scene");
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 30, 20, 100, 20),"Time : "+ time.ToString("F1"));
        GUI.Label(new Rect(65, Screen.height - 20, 256, 32), "Jump Power : " + jump_power.ToString("F2"));

        GUI.DrawTexture(new Rect(0, Screen.height - 64, 64, 64), icon);
    }
}
