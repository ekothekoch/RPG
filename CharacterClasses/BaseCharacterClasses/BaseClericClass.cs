using UnityEngine;
using System.Collections;

public class BaseClericClass : BaseCharacterClass {

	public BaseClericClass(){
		characterClassName = "Cleric";
		characterClassDescription = "A strong healer";
        minStrength = 3;
        minWisdom = 9;
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

        wisdom =15;
		constitution=14;
		strength=15;
		intellect=5;
		dexterity = 10;
		resistance = 20;
		gold = 100;

		UseSword=false;
		UseBow=false;
		UseDagger=false;
		UseWand=false;
		UseQuarterStaff=true;
		UseMagic=false;
		UseAxe=false;
		UseSling=true;
		UseCrossBow=false;	
		UsePriestSpells = true;
		UseHammer = true;
		UseMace = true;
		UseFlail = true;
		UseTwoHanded = false;
		UseShield = true;
		UseClub = true;
		proficiencyslot = 2;
	

	}
}
