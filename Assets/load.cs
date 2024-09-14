using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    public void Next()
    {
        SceneManager.LoadScene("menu");
    }

    public void StartTut()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void killPanel()
    {
        panel.SetActive(false);
    }

    public void MultiplayerLoad()
    {
        SceneManager.LoadScene("loading server");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
