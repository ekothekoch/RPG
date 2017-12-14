using UnityEngine;
using System.Collections;

public class BasePlayer:BaseCharacterClass {

    private string _playerName;
    public string playername
    {
				get{ return _playerName;}
				set{ _playerName = value; }
	}
	public int playerLevel {get;set;}
	public int currentXP{get;set;}
	public int requiredXP{get;set;}
    void Start()
    {
        Debug.Log(wisdom);
    }
    public BasePlayer()
    {
        wisdom = GameInformation.playerClass.wisdom;
        constitution = GameInformation.playerClass.wisdom;
        strength = GameInformation.playerClass.strength;
        intellect = GameInformation.playerClass.intellect;
        charisma = GameInformation.playerClass.charisma;
        dexterity = GameInformation.playerClass.dexterity;
        UseAxe = GameInformation.playerClass.UseAxe;
        UseSword = GameInformation.playerClass.UseSword;
        UseBow = GameInformation.playerClass.UseBow;
        UseDagger = GameInformation.playerClass.UseDagger;
        UseWand = GameInformation.playerClass.UseWand;
        UseQuarterStaff = GameInformation.playerClass.UseQuarterStaff;
        UseMagic = GameInformation.playerClass.UseMagic;
        UseSling = GameInformation.playerClass.UseSling;
        UseCrossBow = GameInformation.playerClass.UseCrossBow;
        UsePriestSpells = GameInformation.playerClass.UsePriestSpells;
        UseHammer = GameInformation.playerClass.UseHammer;
        UseMace = GameInformation.playerClass.UseMace;
        UseFlail = GameInformation.playerClass.UseFlail;
        UseTwoHanded = GameInformation.playerClass.UseTwoHanded;
        UseShield = GameInformation.playerClass.UseShield;
        UseClub = GameInformation.playerClass.UseClub;
        proficiencyslot= GameInformation.playerClass.proficiencyslot;
        characterClassName = GameInformation.playerClass.characterClassName;
        characterClassDescription = GameInformation.playerClass.characterClassDescription;
    }


}