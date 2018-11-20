using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    [SerializeField]
    string scene;
    SceneManager scManager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void StartMainMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadStringScene()
    {
        SceneManager.LoadScene(scene);
    }
}
