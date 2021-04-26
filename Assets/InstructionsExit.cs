using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsExit : MonoBehaviour
{
    // Start is called before the first frame update
 public void OnExit()
    {
        SceneManager.LoadScene(0);
    }
}
