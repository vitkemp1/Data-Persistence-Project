using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public InputField inputField;
    public Text bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        MainDataManager.Instance.LoadScore();
        bestScoreText.text = "Best Score : " + MainDataManager.Instance.bestPlayer + " : " + MainDataManager.Instance.bestScore;
        inputField.text = MainDataManager.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartNew()
    {
        if (inputField.text != "")
        {
            MainDataManager.Instance.playerName = inputField.text;
        }        
        SceneManager.LoadScene(1);
    }
}
