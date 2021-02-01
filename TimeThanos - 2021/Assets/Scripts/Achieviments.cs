using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Achieviment")]
public class Achieviments : ScriptableObject
{

    [SerializeField]
    public List<string> Achiev;

    [SerializeField]
    private List<bool> Completed;

    public int numberOfBooks;
    [SerializeField]
    private int currentBooks;
    public int numberOfMaps;
    [SerializeField]
    private int currentMaps;
    public int numberOfPlants;
    [SerializeField]
    private int currentPlants;
    public int numberOfPoints;
    [SerializeField]
    private int currentPoints;
    public int numberOfMushs;
    [SerializeField]
    private int currentMushs;
    public int numberOfCrystals;
    [SerializeField]
    private int currentCrystals;
    public int numberOfCrystalsBalls;
    [SerializeField]
    private int currentCrystalBalls;
    public int numberOfPotions;
    [SerializeField]
    private int currentPotions;

    void Start() {
        SaveSystem.GetInstance().LoadAchieviments();
    }

    public void InitCompleted() {
        Completed = new List<bool>();
        for(int i=0; i < Achiev.Count; i++) {
            Completed.Add(false);
        }
        Debug.Log("Entrei no Completed hahahahahahahah! Count: " + Completed.Count);
    }

    public int SizeOfCompleted() {
        return Completed.Count;
    }

    public void GiveAchiev(int id) {
        Completed[id] = true;
    }

    public bool CheckCompletion(int i) {
        return Completed[i];
    }

    public void AddBook() {
        currentBooks++;
    }

    public void AddMaps() {
        currentMaps++;
    }

    public void AddPlant() {
        currentPlants++;
    }

    public void AddPoints(int points) {
        currentPoints += points;
    }

    public void AddMush() {
        currentMushs++;
    }

    public void AddCrystals() {
        currentCrystals++;
    }

    public void AddCrystalBalls() {
        currentCrystalBalls++;
    }

    public void AddPotion() {
        currentPotions++;
    }

    public bool IsEnoughPotion() {
        return currentPotions >= numberOfPotions;
    }

    public bool IsEnoughBooks() {
        return currentBooks >= numberOfBooks;
    }

    public bool IsEnoughPlants() {
        return currentPlants >= numberOfPlants;
    }

    public bool IsEnoughMaps() {
        return currentMaps >= numberOfMaps;
    }

    public bool IsEnoughMushs() {
        return currentMushs >= numberOfMushs;
    }

    public bool IsEnoughCrystals() {
        return currentCrystals >= numberOfCrystals;
    }

    public bool IsEnoughCrystalsBalls() {
        return currentCrystalBalls >= numberOfCrystalsBalls;
    }

    public bool IsEnoughPoints() {
        return currentPoints >= numberOfPoints;
    }

    public int PresentMushrooms() {
        return currentMushs;
    }

    public int PresentCrystals() {
        return currentCrystals;
    }

    public int PresentPotions() {
        return currentPotions;
    }

    public int PresentCrystalBalls() {
        return currentCrystalBalls;
    }

    public int PresentPoints() {
        return currentPoints;
    }
}
