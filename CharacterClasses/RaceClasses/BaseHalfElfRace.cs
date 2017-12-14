using UnityEngine;
using System.Collections;

public class BaseHalfElfRace : BaseCharacterRace {
 
	public BaseHalfElfRace(){
       
        CharacterRace = CharacterRaces.Halfelf;
		RaceName="Halfelf";
		RaceDescription="is a halfelf";
		mindResistanceBonus = 30;
		minStrength = 3;
		minWisdom = 3;
		minCharisma = 3;
		minConstitution =6;
		minDexterity = 6;
		minIntelligence = 4;
		maxStrength = 18;
		maxCharisma = 18;
		maxDexterity = 18;
		maxIntelligence = 18;
		maxWisdom = 18;
		maxConsititution = 18;
        int[] availableClass = new int[8];
        availableClass[0] = (int)CharacterClasses.BARBARIAN;
        availableClass[1] = (int)CharacterClasses.CLERIC;
        availableClass[2] = (int)CharacterClasses.FIGHTER;
        availableClass[3] = (int)CharacterClasses.THIEF;
        availableClass[4] = (int)CharacterClasses.DRUID;
        availableClass[5] = (int)CharacterClasses.RANGER;
        availableClass[6] = (int)CharacterClasses.SORCERER;
        availableClass[7] = (int)CharacterClasses.MAGE;
    }
    
    
   
}
