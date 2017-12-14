using UnityEngine;
using System.Collections;

public class BaseElfRace : BaseCharacterRace {

		public BaseElfRace(){
		CharacterRace = CharacterRaces.Elf;
		RaceName="Elf";
		RaceDescription="is an elf";
		constitutionBonus =-1;
		dexterityBonus = 1;
		mindResistanceBonus = 90;
		minStrength = 3;
		minWisdom = 3;
		minCharisma = 8;
		minConstitution =6;
		minDexterity = 7;
		minIntelligence = 8;
		maxStrength = 18;
		maxCharisma = 16;
		maxDexterity = 19;
		maxIntelligence = 18;
		maxWisdom = 18;
		maxConsititution = 17;
		int[] availableClass = new int[7];
		availableClass [0] =(int) CharacterClasses.BARBARIAN;
		availableClass [1] = (int) CharacterClasses.CLERIC;
		availableClass [2] = (int) CharacterClasses.FIGHTER;
		availableClass [3] = (int) CharacterClasses.THIEF;
		availableClass [4] = (int) CharacterClasses.MAGE;
		availableClass [5] = (int) CharacterClasses.RANGER;
		availableClass [6] = (int) CharacterClasses.SORCERER;
}}