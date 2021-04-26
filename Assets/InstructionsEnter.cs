using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsEnter : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnEnter()
    {
        SceneManager.LoadScene(1);
    }
}

