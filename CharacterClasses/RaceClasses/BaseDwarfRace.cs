using UnityEngine;
using System.Collections;
using System;

public class BaseDwarfRace : BaseCharacterRace {
    public string[] availableClass = new string[4] { CharacterClasses.BARBARIAN.ToString(),
        CharacterClasses.CLERIC.ToString(), CharacterClasses.FIGHTER.ToString(), CharacterClasses.THIEF.ToString() };

		public BaseDwarfRace(){
		CharacterRace = CharacterRaces.Dwarf;
		RaceName="Dwarf";
		RaceDescription="is a dwarf";
		sThrowBonus = 2;
		constitutionBonus = 1;
		dexterityBonus = -1;
		charismaBonus = -2;
		minStrength = 8;
		minWisdom = 3;
		minCharisma = 2;
		minConstitution =12;
		minDexterity = 3;
		minIntelligence = 3;
		maxStrength = 18;
		maxCharisma = 16;
		maxDexterity = 17;
		maxIntelligence = 18;
		maxWisdom = 18;
		maxConsititution = 19;
	

}

}