using UnityEngine;
using System.Collections;

public class BaseThiefClass : BaseCharacterClass {
	public BaseThiefClass(){
		characterClassDescription = "very agile silent skilled player";
		characterClassName = "Thief";
		pickPocket=15;
		openLocks=10;
		detectTraps=5;
		stealth = 15;
		minStrength = 3;
		minWisdom = 3;
		minCharisma = 3;
		minConstitution = 3;
		minDexterity = 9;
		minIntelligence = 3;
		maxStrength = 18;
		maxCharisma = 18;
		maxDexterity = 18;
		maxIntelligence = 18;
		maxWisdom = 18;
		maxConsititution = 18;
		wisdom=13;
		constitution = 13;
		strength=12;
		intellect=16;
		dexterity = 16;
		resistance = 15;
		gold = 100;
		UseSword=true;
		UseBow=true;
		UseDagger=true;
		UseWand=false;
		UseQuarterStaff=true;
		UseMagic=false;
		UseAxe=false;
		UseSling=true;
		UseCrossBow=false;	
		UsePriestSpells = false;
		UseHammer = false;
		UseMace = false;
		UseFlail = false;
		UseTwoHanded = false;
		UseShield = false;
		UseClub = false;
		proficiencyslot = 2;
		}



}
