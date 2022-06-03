using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void movement()
    {
        SceneManager.LoadScene(1);
    }

    public void rotation()
    {
        SceneManager.LoadScene(2);
    }

    public void Collision()
    {
        SceneManager.LoadScene(3);
    }
}
