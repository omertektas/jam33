using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    [SerializeField] private GameObject introPanel,videoPanel,playGamePanel;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void passIntroPanel()
    {
        introPanel.SetActive(false);
        videoPanel.SetActive(true);
        StartCoroutine(isStoppedVideo());
        
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }


    IEnumerator isStoppedVideo()
    {
        yield return new WaitForSeconds(14);
        videoPanel.SetActive(false );
        playGamePanel.SetActive(true);
    }
    
}
