using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ObsBody"))
        {
            Die();
        }

        if (collision.gameObject.CompareTag("ObsBody2"))
        {
            Die();
        }
    }

    void Die()
    { 
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true; 
        GetComponent <Player>().enabled = false;
        Invoke(nameof(ReloadLevel), 1.3f);
    }
    
    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
