using UnityEngine;
using System.Collections;

public class BaseSorcererClass : BaseCharacterClass {
	

	public BaseSorcererClass(){
	
		characterClassName = "Sorcerer";
		characterClassDescription = "Believes in old magic";
		minStrength = 3;
		minWisdom = 3;
		minCharisma = 9;
		minConstitution = 3;
		minDexterity = 3;
		minIntelligence = 9;
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
		UseSword=false;
		UseBow=false;
		UseDagger=true;
		UseWand=true;
		UseQuarterStaff=true;
		UseMagic=true;
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
		proficiencyslot = 1;

	}
}
