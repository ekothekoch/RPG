using UnityEngine;
using System.Collections;

public class BaseBarbarianClass : BaseCharacterClass {
    
	public BaseBarbarianClass(){
        
        characterClassName = "Barbarian";
		characterClassDescription = "Most strong characterclass in terms of weapons";
		minStrength = 9;
		minWisdom = 3;
		minCharisma = 3;
		minConstitution = 3;
		minDexterity = 3;
		minIntelligence = 3;
		maxStrength = 19;
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
	UseSling=false;
	UseCrossBow=false;	
	UsePriestSpells = false;
	UseHammer = true;
	UseMace = false;
	UseFlail = false;
	UseTwoHanded = false;
	UseShield = false;
	UseClub = true;
		proficiencyslot = 4;
	}
}
