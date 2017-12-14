using UnityEngine;
using System.Collections;

public class BaseGnomeRace : BaseCharacterRace {
		public BaseGnomeRace(){
		CharacterRace = CharacterRaces.Gnome;
		RaceName="Gnome";
		RaceDescription="is a gnome";
		intellectBonus = 1;
		wisdomBonus = -1;
		sThrowBonus = 2;
		minStrength = 6;
		minWisdom = 2;
		minCharisma = 3;
		minConstitution =8;
		minDexterity = 3;
		minIntelligence = 7;
		maxStrength = 18;
		maxCharisma = 18;
		maxDexterity = 18;
		maxIntelligence = 19;
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