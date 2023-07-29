using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawn(){
        SceneManager.LoadScene("SpawnObject");
    }
    public void Measure(){
        SceneManager.LoadScene("measurement");
    }
    public void MeasuretoPannel(){
        SceneManager.LoadScene("UI");
    }
}
