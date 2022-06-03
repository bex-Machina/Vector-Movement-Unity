using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void movement()
    {
        SceneManager.LoadScene(0);
    }

    public void rotation()
    {
        SceneManager.LoadScene(1);
    }

    public void Collision()
    {
        SceneManager.LoadScene(2);
    }
}
