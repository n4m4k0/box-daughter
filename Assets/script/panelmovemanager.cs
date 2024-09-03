using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {

    }
    [SerializeField] GameObject panel;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
          panel.transform.position=panel.transform.position*15;
        }
        if (Input.GetKey(KeyCode.A))
        {
            panel.transform.position = panel.transform.position * 15;
        }
        if (Input.GetKey(KeyCode.S))
        {
            panel.transform.position = panel.transform.position * 15;
        }
        if (Input.GetKey(KeyCode.D))
        {
            panel.transform.position = panel.transform.position * 15;
        }
    }
}
