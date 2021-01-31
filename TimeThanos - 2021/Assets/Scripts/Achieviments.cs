using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Achieviment")]
public class Achieviments : ScriptableObject
{

    public List<string> Achiev;

    private List<bool> Completed;

    public int numberOfBooks;
    private int currentBooks;
    public int numberOfMaps;
    private int currentMaps;
    public int numberOfPlants;
    private int currentPlants;
    public int numberOfPaintings;
    private int currentPaintings;
    public int numberOfPoints;
    private int currentPoints;
    public int numberOfMushs;
    private int currentMushs;
    public int numberOfCrystals;
    private int currentCrystals;
    public int numberOfCrystalsBalls;
    private int currentCrystalBalls;
    public int numberOfPotions;
    private int currentPotions;

    void Start() {
        SaveSystem.GetInstance().LoadAchieviments();
    }

    public void InitCompleted() {
        Completed = new List<bool>();
        for(int i=0; i < Achiev.Count; i++) {
            Completed.Add(false);
        }
        Debug.Log(Completed.Count);
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

    public void AddPaintings() {
        currentPaintings++;
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

    public bool IsEnoughPaintings() {
        return currentPaintings >= numberOfPaintings;
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
}
