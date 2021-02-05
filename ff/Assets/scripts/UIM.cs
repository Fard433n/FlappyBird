using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIM : MonoBehaviour
{
    public static UIM Instance { set; get; }

    public GameObject GameOverMenu;

    // Start is called before the first frame update

     public void Start()
    {
        Instance = this;
    }

    public void Playgame()
    {
        SceneManager.LoadScene(1);
    }

    public void Gameover()
    {
        GameOverMenu.SetActive(true);
    }
}
