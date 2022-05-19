using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
  public float threshold = -8.3f;
    // Update is called once per frame
    void Update()
    {
      if(transform.position.y < threshold)
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }
    }
}
