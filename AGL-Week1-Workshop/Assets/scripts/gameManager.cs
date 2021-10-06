using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    public int catCount;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        if (catCount < 0)
        {
            catCount = FindObjectsOfType<cat>().Length;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void collectCat()
    {
        print("collect cat");
        catCount--;
        if(catCount == 0)
        {
            print("Game over");
            SceneManager.LoadScene("GameOver");
        }
    }
}
