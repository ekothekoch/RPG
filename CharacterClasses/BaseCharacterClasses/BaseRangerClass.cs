using UnityEngine;
using System.Collections;

public class BaseRangerClass : BaseCharacterClass {

	public BaseRangerClass(){
		characterClassName = "Ranger";
		characterClassDescription = "Skillful archer";
		minStrength = 13;
		minWisdom = 14;
		minCharisma = 3;
		minConstitution =14;
		minDexterity = 13;
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
		UsePriestSpells = true;
		UseHammer = true;
		UseMace = true;
		UseFlail = true;
		UseTwoHanded = false;
		UseShield = true;
		UseClub = true;
		proficiencyslot = 3;

	}
}
