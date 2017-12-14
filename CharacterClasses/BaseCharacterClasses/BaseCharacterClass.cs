using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseCharacterClass {
    private int _minWisdom;
    private int _maxWisdom;
    private int _minConstitution;
    private int _maxConstitution;
    private int _minStrength;
    private int _maxStrength;
      int _minIntelligence;
      int _maxIntelligence;
    private int _minCharisma;
    private int _maxCharisma;
    private int _minDexterity;
    private int _maxDexterity;
   

    private int _proficiencyslot;
	private int _spellslot;
	private string _characterClassName;
	private string _characterClassDescription;
	
	private int _wisdom=12;
	private int _constitution=10;
	private int _strength=8;
	private int _intellect=8;
	private int _charisma=10;
	private int _dexterity=10;
	private int _coldres=10;
	private int _acidres=10;
	private int _fireres=10;
	private int _mindres=10;
	private int _gold;
	private int _toHit;
	private int _toAc;
	private int _toDamage;
	private int _weight;
	private int _toMissile;
	private int _toHp;
	private int _pickPocket;
	private int _openLocks;
	private int _detectTraps;
	private int _stealth;

	/*private bool useSword=false;
	private bool useBow=false;
	private bool useDagger=false;
	private bool useWand=false;
	private bool useQuarterStaff=false;
	private bool useMagic=false;
	private bool useAxe=false;
	private bool useSling=false;
	private bool useCrossBow=false;	
	private bool useHealSpells = false;*/
	public CharacterClasses CharacterClass{ get; set; }
//	public List<BaseAbility> playersAbilities=new List<BaseAbility>();
	public bool UseSword{ get; set; }
	public bool UseBow{ get; set; }
	public bool UseDagger{ get; set; }
	public bool UseWand{ get; set; }
	public bool UseQuarterStaff{ get; set; }
	public bool UseMagic{ get; set; }
	public bool UseAxe{ get; set; }
	public bool UseSling{ get; set; }
	public bool UseCrossBow{ get; set; }
	public bool UsePriestSpells{ get; set; }
	public bool UseHammer{ get; set; }
	public bool UseMace{ get; set; }
	public bool UseFlail{ get; set; }
	public bool UseTwoHanded{ get; set; }
	public bool UseShield{ get; set; }
	public bool UseClub{ get; set; }
	public int proficiencyslot {
		get{ return _proficiencyslot; }
		set{ _proficiencyslot = value; }
	}
	public int spellslot {
		get{ return _spellslot; }
		set{ _spellslot = value; }
	}
	public string characterClassName{
	get {return _characterClassName;}
	set {_characterClassName=value;}}
	public int dexterity{
	get {return _dexterity;}
	set {_dexterity=value;}}
	public int gold{
	get {return _gold;}
	set {_gold=value;}}
	public string characterClassDescription{
	get {return _characterClassDescription;}
	set {_characterClassDescription=value;}}
	public int  wisdom{
	get {return _wisdom;}
	set {_wisdom=value;}}
	public int constitution{
	get {return _constitution;}
	set {_constitution=value;}}
	public int strength{
	get {return _strength;}
	set {_strength=value;}}
	public int intellect{
	get {return _intellect;}
	set {_intellect=value;}}
	public int charisma{
	get {return _charisma;}
	set {_charisma=value;}}
	public int resistance{
	get {return _coldres;}
	set {_coldres=value;}}
	public int acidres{
		get {return _acidres;}
		set {_acidres=value;}}
	public int mindres{
		get {return _mindres;}
		set {_mindres=value;}}
	public int fireres{
		get {return _fireres;}
		set {_fireres=value;}}
	public int tohp{
		get {return _toHp;}
		set {_toHp=value;}}
	public int tomissile{
		get {return _toMissile;}
		set {_toMissile=value;}}
	public int weight{
		get {return _weight;}
		set {_weight=value;}}
	public int todamage{
		get {return _toDamage;}
		set {_toDamage=value;}}
	public int toac{
		get {return _toAc;}
		set {_toAc=value;}}
	public int tohit{
		get {return _toHit;}
		set {_toHit=value;}}
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
	public int pickPocket{
		get {return _pickPocket;}
		set {_pickPocket=value;}}
	public int openLocks{
		get {return _openLocks;}
		set {_openLocks=value;}}
	public int detectTraps{
		get {return _detectTraps;}
		set {_detectTraps=value;}}
	public int stealth{
		get {return _stealth;}
		set {_stealth=value;}}
}
public enum CharacterClasses{
	FIGHTER,
	MAGE,
	THIEF,
	PALADIN,
	RANGER,
	BARBARIAN,
	CLERIC,
	DRUID,
	MONK,
	SORCERER,
	}

