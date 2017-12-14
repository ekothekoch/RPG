using UnityEngine;
using System.Collections;

public class BaseMonkClass : BaseCharacterClass {

	public BaseMonkClass(){
		characterClassName = "Monk";
		characterClassDescription = "An expert in martial arts";
		minStrength = 3;
		minWisdom = 9;
		minCharisma = 3;
		minConstitution = 9;
		minDexterity = 9;
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
		UseBow=false;
		UseDagger=true;
		UseWand=false;
		UseQuarterStaff=false;
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
		proficiencyslot = 0;

	}
}
