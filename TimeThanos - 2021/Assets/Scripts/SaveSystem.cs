using System;
using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SaveSystem : MonoBehaviour
{
    [HideInInspector]
    public Achieviments Achiev;
    [HideInInspector]
    public HighScore Hs;
    public Achieviments emptyAchiev;
    public HighScore emptyHs;

    public static float saveVersion = 1.0f;
    
    private static string saveFileName1 = "Achieviments";
    private static string saveFileName2 = "HighScore";

    public static bool SucessfulLoad = false;

    private static string SavePath1
    {
        get
        {
            return Path.Combine(Application.persistentDataPath, saveFileName1 + ".dat");
        }
    }

    private static string SavePath2
    {
        get
        {
            return Path.Combine(Application.persistentDataPath, saveFileName2 + ".dat");
        }
    }

    private static string versionSaveName = "version";
    private static string VersionSavePath
    {
        get
        {
            return Path.Combine(Application.persistentDataPath, versionSaveName + ".ver");
        }
    }

    private static SaveSystem instance;
    public static SaveSystem GetInstance()
    {
        return instance;
    }

    private void Awake() {
        if(instance != null) {
            GameObject.Destroy(this.gameObject);
        }
        else {
            instance = this;
        }
        LoadAchieviments();
        LoadHighScore();
        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadAchieviments() {
        string path = SavePath1;
        string versionPath = VersionSavePath;
        if(!File.Exists(path) || !File.Exists(versionPath)) {
            SaveAchieviments();
            return;
        }
        using(StreamReader streamReader = File.OpenText(versionPath)) {
            string str = streamReader.ReadToEnd();
            try {
                float ver = float.Parse(str);
                if(ver < saveVersion) {
                    Debug.LogWarning("Warning: old save version");
                    return;
                }
            }
            catch (Exception e) {
                Debug.LogWarning("Warning: invalid save-version format" + e.Message);
                return;
            }
        }
        try {
            byte[] buffer = File.ReadAllBytes(path);
            for(int i=0;i< buffer.Length;i ++) {
                buffer[i] = (Byte)((~buffer[i]) & 0xFF);
            }
            string jsonString = Encoding.UTF8.GetString(buffer);
            Achiev = ScriptableObject.CreateInstance<Achieviments>();
            JsonUtility.FromJsonOverwrite(jsonString, Achiev);
            SucessfulLoad = true;
            Debug.Log("Dei Load nos Achieviments!");
            return;
        }
        catch (Exception e) {
            Debug.LogWarning("Unable to load savefile " + e.Message);
            return;
        } 
    }

    public void LoadHighScore() {
        string path = SavePath2;
        string versionPath = VersionSavePath;
        if(!File.Exists(path) || !File.Exists(versionPath)) {
            SaveHighScore();
            return;
        }
        
        using(StreamReader streamReader = File.OpenText(versionPath)) {
            string str = streamReader.ReadToEnd();
            try {
                float ver = float.Parse(str);
                if(ver < saveVersion) {
                    Debug.LogWarning("Warning: old save version");
                    return;
                }
            }
            catch (Exception e) {
                Debug.LogWarning("Warning: invalid save-version format" + e.Message);
                return;
            }
        }
        try {
            byte[] buffer = File.ReadAllBytes(path);
            for(int i=0;i< buffer.Length;i ++) {
                buffer[i] = (Byte)((~buffer[i]) & 0xFF);
            }
            string jsonString = Encoding.UTF8.GetString(buffer);
            Hs = ScriptableObject.CreateInstance<HighScore>();
            JsonUtility.FromJsonOverwrite(jsonString, Hs);
            SucessfulLoad = true;
            Debug.Log("Dei Load nos HighScores!");
            return;
        }
        catch (Exception e) {
            Debug.LogWarning("Unable to load savefile " + e.Message);
            return;
        }
    }

    public void SaveAchieviments() {
        string json_ps = JsonUtility.ToJson(Achiev);
        byte[] buffer = Encoding.UTF8.GetBytes(json_ps);
        for(int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = (Byte)((~buffer[i]) & 0xFF);
        }
        try
        {
            File.WriteAllBytes(SavePath1, buffer);
        }
        catch (Exception e)
        {
            Debug.LogWarning("Unable to write to savefile" + e.Message);
        }
        
        using (StreamWriter streamWriter = File.CreateText (VersionSavePath))
        {
            streamWriter.Write (saveVersion.ToString());
        }
        Debug.Log("Achieviments Salvo!");
    }

    public void SaveHighScore() {
        string json_ps = JsonUtility.ToJson(Hs);
        byte[] buffer = Encoding.UTF8.GetBytes(json_ps);
        for(int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = (Byte)((~buffer[i]) & 0xFF);
        }
        try
        {
            File.WriteAllBytes(SavePath2, buffer);
        }
        catch (Exception e)
        {
            Debug.LogWarning("Unable to write to savefile" + e.Message);
        }
        
        using (StreamWriter streamWriter = File.CreateText (VersionSavePath))
        {
            streamWriter.Write (saveVersion.ToString());
        }
        Debug.Log("HighScores Salvo!");
    }
}
