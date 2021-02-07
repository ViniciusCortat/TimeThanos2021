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
    [HideInInspector]
    public Language lang;
    [HideInInspector]
    public Hats hats;
    public Achieviments emptyAchiev;
    public HighScore emptyHs;
    public Language emptylang;
    public Hats emptyhats;

    public static float saveVersion = 1.0f;
    
    private static string saveFileName1 = "Achieviments";
    private static string saveFileName2 = "HighScore";
    private static string saveFileName3 = "Language";
    private static string saveFileName4 = "Hats";

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

    private static string SavePath3
    {
        get
        {
            return Path.Combine(Application.persistentDataPath, saveFileName3 + ".dat");
        }
    }

    private static string SavePath4
    {
        get
        {
            return Path.Combine(Application.persistentDataPath, saveFileName4 + ".dat");
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
        LoadLanguage();
        LoadHats();
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
            return;
        }
        catch (Exception e) {
            Debug.LogWarning("Unable to load savefile " + e.Message);
            return;
        }
    }

    public void LoadLanguage() {
        string path = SavePath3;
        string versionPath = VersionSavePath;
        if(!File.Exists(path) || !File.Exists(versionPath)) {
            SaveLanguage();
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
            lang = ScriptableObject.CreateInstance<Language>();
            JsonUtility.FromJsonOverwrite(jsonString, lang);
            SucessfulLoad = true;
            return;
        }
        catch (Exception e) {
            Debug.LogWarning("Unable to load savefile " + e.Message);
            return;
        }
    }

    public void LoadHats() {
        string path = SavePath4;
        string versionPath = VersionSavePath;
        if(!File.Exists(path) || !File.Exists(versionPath)) {
            SaveHats();
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
            hats = ScriptableObject.CreateInstance<Hats>();
            JsonUtility.FromJsonOverwrite(jsonString, hats);
            SucessfulLoad = true;
            return;
        }
        catch (Exception e) {
            Debug.LogWarning("Unable to load savefile " + e.Message);
            return;
        }
    }

    public void SaveAchieviments() {
        if(!File.Exists(SavePath1) || !File.Exists(VersionSavePath)) {
            Achiev = GameObject.Instantiate(emptyAchiev);
            Achiev.InitCompleted();
        }
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
    }

    public void SaveHighScore() {
        if(!File.Exists(SavePath2) || !File.Exists(VersionSavePath)) {
            Hs = GameObject.Instantiate(emptyHs);
        }
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
    }

    public void SaveLanguage() {
        if(!File.Exists(SavePath3) || !File.Exists(VersionSavePath)) {
            lang = GameObject.Instantiate(emptylang);
            lang.InitLanguage();
        }
        string json_ps = JsonUtility.ToJson(lang);
        byte[] buffer = Encoding.UTF8.GetBytes(json_ps);
        for(int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = (Byte)((~buffer[i]) & 0xFF);
        }
        try
        {
            File.WriteAllBytes(SavePath3, buffer);
        }
        catch (Exception e)
        {
            Debug.LogWarning("Unable to write to savefile" + e.Message);
        }
        
        using (StreamWriter streamWriter = File.CreateText (VersionSavePath))
        {
            streamWriter.Write (saveVersion.ToString());
        }
    }

    public void SaveHats() {
        if(!File.Exists(SavePath4) || !File.Exists(VersionSavePath)) {
            hats = GameObject.Instantiate(emptyhats);
            hats.InitHat();
        }
        string json_ps = JsonUtility.ToJson(hats);
        byte[] buffer = Encoding.UTF8.GetBytes(json_ps);
        for(int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = (Byte)((~buffer[i]) & 0xFF);
        }
        try
        {
            File.WriteAllBytes(SavePath4, buffer);
        }
        catch (Exception e)
        {
            Debug.LogWarning("Unable to write to savefile" + e.Message);
        }
        
        using (StreamWriter streamWriter = File.CreateText (VersionSavePath))
        {
            streamWriter.Write (saveVersion.ToString());
        }
    }

    public void NewGame() {
        Hs = GameObject.Instantiate(emptyHs);
        Achiev = GameObject.Instantiate(emptyAchiev);
        hats = GameObject.Instantiate(emptyhats);
        Achiev.InitCompleted();
        hats.InitHat();
        SaveHighScore();
        SaveAchieviments();
        SaveHats();
        SucessfulLoad = true;
    }
}
