using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int coinCount;
    public Text textComponent;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
        coinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    public void AddCoinCount()
    {
        coinCount = coinCount + 1;
        Debug.Log("CoinCount:" + coinCount);
        textComponent.text = "CoinCount : " + coinCount;
    }

    //以下はボタン押下時のSE用
    public void ChangeSceneWait(string nextScene)
    {
        StartCoroutine(changeSceneCoroutine(nextScene));
    }
    private IEnumerator changeSceneCoroutine(string nextScene)
    {
        yield return new WaitForSeconds(1);
        ChangeScene(nextScene);
    }
    //ちょっと応用 リセットで音を鳴らしてみる
    public void ResetSceneWait()
    {
        StartCoroutine(resetSceneCoroutine());
    }
    private IEnumerator resetSceneCoroutine()
    {
        yield return new WaitForSeconds(1);
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }
}
