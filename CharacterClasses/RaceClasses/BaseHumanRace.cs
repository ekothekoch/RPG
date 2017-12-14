using UnityEngine;
using System.Collections;

public class BaseHumanRace : BaseCharacterRace {

		public BaseHumanRace(){
		CharacterRace = CharacterRaces.Human;
		RaceName="Human";
		RaceDescription="is a human";
		minStrength = 3;
		minWisdom = 3;
		minCharisma = 3;
		minConstitution =3;
		minDexterity = 3;
		minIntelligence = 3;
		maxStrength = 18;
		maxCharisma = 18;
		maxDexterity = 18;
		maxIntelligence = 18;
		maxWisdom = 18;
		maxConsititution = 18;
		int[] availableClass = new int[10];
		availableClass [0] =(int) CharacterClasses.BARBARIAN;
		availableClass [1] = (int) CharacterClasses.CLERIC;
		availableClass [2] = (int) CharacterClasses.FIGHTER;
		availableClass [3] = (int) CharacterClasses.THIEF;
		availableClass [4] =(int) CharacterClasses.DRUID;
		availableClass [5] = (int) CharacterClasses.RANGER;
		availableClass [6] = (int) CharacterClasses.SORCERER;
		availableClass [7] = (int) CharacterClasses.MAGE;
		availableClass [8] = (int) CharacterClasses.PALADIN;
		availableClass [9] = (int) CharacterClasses.MONK;
		}}

