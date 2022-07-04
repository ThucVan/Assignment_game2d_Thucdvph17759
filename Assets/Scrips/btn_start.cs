using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn_start : MonoBehaviour
{
    public Button btn;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        btn.onClick.AddListener(btn_nextScreen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    void btn_nextScreen()
    {
        Application.LoadLevel("main_Screen");
    }
}
