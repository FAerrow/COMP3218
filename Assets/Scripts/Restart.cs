using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision) {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }

}
