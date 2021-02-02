using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAchieviment : MonoBehaviour
{
    
    private Achieviments Achiev;

    void Start()
    {
        Achiev = SaveSystem.GetInstance().Achiev;
        if(Achiev.IsEnoughBooks()){
            TriggerAchieviment("Books");
        } 
        if(Achiev.IsEnoughMaps()) {
            TriggerAchieviment("Maps");
        } 
        if(Achiev.IsEnoughPotion()) {
            TriggerAchieviment("Potions");
        } 
        if(Achiev.IsEnoughMushs()) {
            TriggerAchieviment("Mushrooms");
        } 
        if(Achiev.IsEnoughPlants()) {
            TriggerAchieviment("Plants");
        } 
        if(Achiev.IsEnoughPoints()) {
            TriggerAchieviment("Points");
        } 
        if(Achiev.IsEnoughCrystals()) {
            TriggerAchieviment("Crystals");
        } 
        if(Achiev.IsEnoughCrystalsBalls()) {
            TriggerAchieviment("CrystalBalls");
        } 
        SaveSystem.GetInstance().SaveAchieviments();
    }

    
    void Update()
    {
        
    }

    private void TriggerAchieviment(string title) {
        int i = Achiev.Achiev.IndexOf(title);
        if(Achiev.CheckCompletion(i)){
            return;
        } 
        Achiev.GiveAchiev(i);
    }
}
