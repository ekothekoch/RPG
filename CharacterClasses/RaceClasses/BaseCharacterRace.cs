using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseCharacterRace  {

	private string raceName = "Needs a name";
	private string raceDescription="Needs description";
	private int _strengthBonus=0;
	private int _dexterityBonus=0;
	private int _intellectBonus=0;
	private int _constitutionBonus=0;
	private int _wisdomBonus=0;
	private int _charismaBonus=0;
	private int _sThrowBonus=0;
	private int _mindResistanceBonus=0;
	private int _coldResistanceBonus=0;
	private int _fireResistanceBonus=0;
	private int _minWisdom;
	private int _maxWisdom;
	private int _minConstitution;
	private int _maxConstitution;
	private int _minStrength;
	private int _maxStrength;
	private int _minIntelligence;
	private int _maxIntelligence;
	private int _minCharisma;
	private int _maxCharisma;
	private int _minDexterity;
	private int _maxDexterity;


		public string RaceName {
				get{ return raceName; }
				set{ raceName = value; }
		}
		public string RaceDescription {
				get{ return raceDescription; }
				set{ raceDescription = value; }
		}
	public int strengthBonus {
		get{ return _strengthBonus; }
		set{ _strengthBonus = value; }
	}

	public int dexterityBonus {
		get{ return _dexterityBonus; }
		set{ _dexterityBonus = value; }
	}
	public int intellectBonus {
		get{ return _intellectBonus; }
		set{ _intellectBonus = value; }
	}
	public int constitutionBonus {
		get{ return _constitutionBonus; }
		set{ _constitutionBonus = value; }
	}
	public int sThrowBonus {
		get{ return _sThrowBonus; }
		set{ _sThrowBonus = value; }
	}
	public int mindResistanceBonus {
		get{ return _mindResistanceBonus; }
		set{ _mindResistanceBonus = value; }
	}
	public int coldResistanceBonus {
		get{ return _coldResistanceBonus; }
		set{ _coldResistanceBonus = value; }
	}
	public int fireResistanceBonus {
		get{ return _fireResistanceBonus; }
		set{ _fireResistanceBonus = value; }
	}

	public int charismaBonus {

		get { return _charismaBonus; }
		set{ _charismaBonus = value; }
	}				
		public int wisdomBonus {
			get{ return _wisdomBonus; }
			set{ _wisdomBonus = value; }
		}	
	public int maxDexterity{
		get {return _maxDexterity;}
		set {_maxDexterity=value;}}
	public int minDexterity{
		get {return _minDexterity;}
		set {_minDexterity=value;}}
	public int maxCharisma{
		get {return _maxCharisma;}
		set {_maxCharisma=value;}}
	public int minCharisma{
		get {return _minCharisma;}
		set {_minCharisma=value;}}
	public int maxIntelligence{
		get {return _maxIntelligence;}
		set {_maxIntelligence=value;}}
	public int minIntelligence{
		get {return _minIntelligence;}
		set {_minIntelligence=value;}}
	public int maxWisdom{
		get {return _maxWisdom;}
		set {_maxWisdom=value;}}
	public int minWisdom{
		get {return _minWisdom;}
		set {_minWisdom=value;}}
	public int maxConsititution{
		get {return _maxConstitution;}
		set {_maxConstitution=value;}}
	public int minConstitution{
		get {return _minConstitution;}
		set {_minConstitution=value;}}
	public int maxStrength{
		get {return _maxStrength;}
		set {_maxStrength=value;}}
	public int minStrength{
		get {return _minStrength;}
		set {_minStrength=value;}}
	public CharacterRaces CharacterRace{ get; set; }
	
}
public enum CharacterRaces
{
	Elf,
	Halfelf,
	Dwarf,
	Gnome,
	Human,
	HalfOrc,
	Halfling
}