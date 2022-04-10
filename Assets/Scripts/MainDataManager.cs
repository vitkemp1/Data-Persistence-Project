using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainDataManager : MonoBehaviour
{
    public static MainDataManager Instance;
    public string playerName="Player";
    public int bestScore=0;
    public string bestPlayer="Player";
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
        //LoadColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
