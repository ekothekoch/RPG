using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {

	public BaseMageClass(){
			
						characterClassName = "Mage";
						characterClassDescription = "A wise wizard, can cast spells.";
				
				
		minStrength = 3;
		minWisdom = 3;
		minCharisma = 3;
		minConstitution = 3;
		minDexterity = 3;
		minIntelligence =9;
		maxStrength = 18;
		maxCharisma = 18;
		maxDexterity = 18;
		maxIntelligence = 18;
		maxWisdom = 18;
		maxConsititution = 18;
		wisdom=11;
		constitution = 11;
		strength=12;
		intellect=16;
		dexterity = 10;
		resistance = 30;
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
