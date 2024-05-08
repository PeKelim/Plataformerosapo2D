using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FruitManager : MonoBehaviour
{
    public Text levelCleared;


    private void Update()
    {
        FruitCollected();

    }

    public void FruitCollected()


    {
        if (levelCleared == null)
        {

        }

        if (transform.childCount == 0)
        {
            Debug.Log("No quedan frutas, Victoria");
            levelCleared.gameObject.SetActive(true);
            Invoke("ChangeScene", 1);
        }
    }

    void ChangeScene()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
