using UnityEngine;
using System.Collections;

public class BaseHalfOrcRace : BaseCharacterRace {
	public BaseHalfOrcRace(){

		CharacterRace = CharacterRaces.HalfOrc;
		RaceName="HalfOrc";
		RaceDescription="is a halforc";
		constitutionBonus = 1;
		intellectBonus = -2;
		strengthBonus = 1;
		minStrength = 4;
		minWisdom = 3;
		minCharisma = 3;
		minConstitution =4;
		minDexterity = 3;
		minIntelligence = 1;
		maxStrength = 19;
		maxCharisma = 18;
		maxDexterity = 18;
		maxIntelligence = 16;
		maxWisdom = 18;
		maxConsititution = 19;
		int[] availableClass = new int[4];
		availableClass [0] =(int) CharacterClasses.BARBARIAN;
		availableClass [1] = (int) CharacterClasses.CLERIC;
		availableClass [2] = (int) CharacterClasses.FIGHTER;
		availableClass [3] = (int) CharacterClasses.THIEF;
	
}
}