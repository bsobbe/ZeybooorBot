using UnityEngine;
using System.Collections;

public class LevelManagerController : MonoBehaviour
{
    public void LoadLevel(string name)
    {
        //Debug.Log("Level " + name);
        Application.LoadLevel(name);
    }

    public void Quit()
    {
        //Debug.Log("Quit request");
        Application.Quit();
    }
}
