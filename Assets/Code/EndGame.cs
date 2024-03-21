using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code { 
public class EndGame : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
            if (other.gameObject.GetComponent<SkiControls>())
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            
    }
}
}