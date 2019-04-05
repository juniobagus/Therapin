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
        Debug.Log("Load Tentang");
    }

    public void LoadExit()
    {
        Debug.Log("Load Exit");
    }
}
