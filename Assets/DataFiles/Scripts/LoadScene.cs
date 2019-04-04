using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public void LoadMulai()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadPetunjuk()
    {
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
