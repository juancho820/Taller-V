using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

	public void Play()
    {
        Application.LoadLevel("SelectLvl");
    }
    public void Store()
    {
        Application.LoadLevel("Store");
    }
    public void Settings()
    {
        Application.LoadLevel("Settings");
    }
    public void Volver()
    {
        Application.LoadLevel("Main Menu");
    }
    public void LVL1()
    {
        Application.LoadLevel("Lvl1");
    }
}
