using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceLoader : MonoBehaviour {

    public void LoadNextScene() {
        // Using the SceneManger, we call GetActiveScene and return the buildIndex and store in our currentSceneIndex
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Use the SceneManager to call LoadScene() to load the next indexed scene.
        Debug.Log ("Loading the next scene at index:" + currentSceneIndex + "\n" );
        SceneManager.LoadScene(currentSceneIndex + 1);

    }

    public void LoadStartScene(){
        // Use the SceneManager to call LoadScene() to load the very first scene
        Debug.Log("Loading the start scene at index:" + 0 + "\n");
        SceneManager.LoadScene(0);
    }

    public void LoadEnteredScene(int index){
        // Use the SceneManager to call LoadScene() to load the scen at the given index
        Debug.Log("Loading the scene at index:" + index + "\n");
        SceneManager.LoadScene(index);
    }

    public void QuitGame(){
        // Close the application.
        Debug.Log("Closing the game. Goodbye.\n");
        Application.Quit();
    }
}
