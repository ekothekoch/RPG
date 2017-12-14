using UnityEngine;
using System.Collections;

public class BaseFighterClass : BaseCharacterClass {

	public BaseFighterClass(){
		characterClassName = "Fighter";
		characterClassDescription = "A strong and powerful hero";
		minStrength = 9;
		minWisdom = 3;
		minCharisma = 3;
		minConstitution = 3;
		minDexterity = 3;
		minIntelligence = 3;
		maxStrength = 18;
		maxCharisma = 18;
		maxDexterity = 18;
		maxIntelligence = 18;
		maxWisdom = 18;
		maxConsititution = 18;

		wisdom=15;
		constitution=14;
		strength=15;
		intellect=5;
		dexterity = 10;
		resistance = 20;
		gold = 100;
		UseSword=true;
		UseBow=true;
		UseDagger=true;
		UseWand=false;
		UseQuarterStaff=true;
		UseMagic=false;
		UseAxe=true;
		UseSling=true;
		UseCrossBow=true;	
		UsePriestSpells = false;
		UseHammer = true;
		UseMace = true;
		UseFlail = true;
		UseTwoHanded = false;
		UseShield = true;
		UseClub = true;
		proficiencyslot = 5;

		}




}

