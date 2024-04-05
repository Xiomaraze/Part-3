using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour
{
    bool nexx = false;
    private void Update()
    {
        if (nexx)
        {
            Next();
        }
    }

    private void Next()
    {
        SceneManager.LoadScene(1);
    }
}
