using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    [SerializeField] private Array Scenes;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Scene CurrentScene = SceneManager.GetActiveScene();
            Debug.Log("Active scene is"+ CurrentScene.buildIndex + ".");
            SceneManager.LoadScene(CurrentScene.buildIndex + 1);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Scene CurrentScene = SceneManager.GetActiveScene();
            Debug.Log("Active scene is" + CurrentScene.buildIndex + ".");
            SceneManager.LoadScene(CurrentScene.buildIndex - 1);
        }
    }
}
