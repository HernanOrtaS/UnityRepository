using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerConversacion : MonoBehaviour
{
    [SerializeField]
    public bool estadoPanel; //visible o no
    [SerializeField]
    GameObject panelConv;
    // Start is called before the first frame update
    void Start()
    {
        estadoPanel = false;
        panelConv = GameObject.Find("Panel");
        panelConv.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            estadoPanel = !estadoPanel;
            panelConv.SetActive(estadoPanel);
        }
    }
}
