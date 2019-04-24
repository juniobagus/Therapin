using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour {
    

    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void LoadMulai()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadPetunjuk()
    {
        SceneManager.LoadScene("PetunjukScene");
        Debug.Log("Load Petunjuk");
    }

    public void LoadTentang()
    {
        SceneManager.LoadScene("TentangScene");
        Debug.Log("Load Tentang");
    }

    public void LoadExit()
    {
        Debug.Log("Load Exit");
        Application.Quit();
        // System.Diagnostics.Process.GetCurrentProcess().Kill();
    }

    /* void Awake()
    {
        Input.backButtonLeavesApp = true;
    } */

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

}
