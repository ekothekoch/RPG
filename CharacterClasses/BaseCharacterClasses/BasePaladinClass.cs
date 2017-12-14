using UnityEngine;
using System.Collections;

public class BasePaladinClass : BaseCharacterClass {

	public BasePaladinClass(){

				characterClassName = "Paladin";
				characterClassDescription = "A good fighter and a good priest";
		minStrength = 12;
		minWisdom = 13;
		minCharisma = 17;
		minConstitution = 9;
		minDexterity = 3;
		minIntelligence = 3;
		maxStrength = 18;
		maxCharisma = 18;
		maxDexterity = 18;
		maxIntelligence = 18;
		maxWisdom = 18;
		maxConsititution = 18;
		wisdom=16;
		constitution = 12;
		strength=12;
		intellect=12;
		dexterity = 16;
		resistance = 10;
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
		UseTwoHanded = true;
		UseShield = true;
		UseClub = true;
		proficiencyslot = 3;
}
}