using UnityEngine;
using System.Collections;

public class BaseHalflingRace : BaseCharacterRace {

	public BaseHalflingRace(){
		CharacterRace = CharacterRaces.Halfling;
	RaceName="Halfling";
	RaceDescription="is a halfling";
	sThrowBonus = 2;
	wisdomBonus = -1;
	dexterityBonus = 1;
	strengthBonus = -1;
		minStrength = 6;
		minWisdom = 3;
		minCharisma = 3;
		minConstitution =10;
		minDexterity = 8;
		minIntelligence = 6;
		maxStrength = 17;
		maxCharisma = 18;
		maxDexterity = 19;
		maxIntelligence = 18;
		maxWisdom = 17;
		maxConsititution = 18;
		int[] availableClass = new int[5];
		availableClass [0] =(int) CharacterClasses.BARBARIAN;
		availableClass [1] = (int) CharacterClasses.CLERIC;
		availableClass [2] = (int) CharacterClasses.FIGHTER;
		availableClass [3] = (int) CharacterClasses.THIEF;
		availableClass [4] = (int) CharacterClasses.MAGE;
}
}
