using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

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
    [System.Serializable]
    class SaveData
    {
        public string bestPlayer;
        public int bestScore;
        public string LastPlayer;
    }
    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.bestPlayer = bestPlayer;
        data.bestScore = bestScore;
        data.LastPlayer = playerName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestPlayer = data.bestPlayer;
            bestScore = data.bestScore;
            playerName = data.LastPlayer;
        }
    }

}
