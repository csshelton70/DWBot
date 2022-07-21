using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataImport
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Aboleth
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Abomination
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Acolyte
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class AdvancedMoves1
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
        public string requires { get; set; }
        public string replaces { get; set; }
    }

    public class AdvancedMoves2
    {
        public string name { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
        public string key { get; set; }
        public string requires { get; set; }
    }

    public class Adventurer
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class AdventuringGear
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class AidOrInterfere
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Alchemist
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class Alignments
    {
        public Good good { get; set; }
        public Neutral neutral { get; set; }
        public Chaotic chaotic { get; set; }
        public Lawful lawful { get; set; }
        public Evil evil { get; set; }
    }

    public class AlignmentsList
    {
        public string name { get; set; }
        public string description { get; set; }
    }

    public class ALittleHelpFromMyFriends
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class AnEarForMagic
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Angel
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class AnimalCompanion
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Ankheg
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Anointed
    {
        public string name { get; set; }
        public string key { get; set; }
        public string requires { get; set; }
        public string description { get; set; }
    }

    public class Antitoxin
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class ApocalypseDragon
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class APortInTheStorm
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Apotheosis
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ArcaneArmor
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class ArcaneArt
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class ArcaneWard
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Armored
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ArmoredPerfection
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class ArmorMastery
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ASafePlace
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ASaferPlace
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class AssassinVine
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Attack
    {
        public string name { get; set; }
        public string damage { get; set; }
        public List<string> tags { get; set; }
    }

    public class Backstab
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class BagOfBooks
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class Bakunawa
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Balance
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Bamboozle
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Bandages
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class Bandit
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class BanditKing
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Banshee
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class BarbedDevil
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Bard
    {
        public string name { get; set; }
        public string description { get; set; }
        public int load { get; set; }
        public int base_hp { get; set; }
        public string damage { get; set; }
        public Names names { get; set; }
        public List<string> bonds { get; set; }
        public List<List<string>> looks { get; set; }
        public Alignments alignments { get; set; }
        public List<AlignmentsList> alignments_list { get; set; }
        public List<RaceMove> race_moves { get; set; }
        public List<StartingMove> starting_moves { get; set; }
        public List<AdvancedMoves1> advanced_moves_1 { get; set; }
        public List<AdvancedMoves2> advanced_moves_2 { get; set; }
        public List<object> gear_choices { get; set; }
        public string key { get; set; }
    }

    public class BardElf
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class BardHuman
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class BardicLore
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Barkskin
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class BasicMove
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Basilisk
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class BendBarsLiftGates
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class BlackPudding
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Blacksmith
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class BlinkDog
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class BloodAndThunder
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class Bloodthirsty
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class Bloodweed
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class BloodyAegis
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class BlotOutTheSun
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class BornOfTheSoil
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Brewer
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Bulette
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class BundleOfArrows
    {
        public string name { get; set; }
        public List<string> tags { get; set; }
    }

    public class ByNatureSustained
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class CalledShot
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Camouflage
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class CastASpellCleric
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class CastASpellWizard
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Cautious
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class CaveRat
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class CavernDwellers
    {
        public string title { get; set; }
    }

    public class Centaur
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class ChainDevil
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class ChaosOoze
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class ChaosSpawn
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Chaotic
    {
        public string name { get; set; }
        public string description { get; set; }
    }

    public class Charge
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class CharmingAndOpen
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class CheapShot
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Chimera
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
    }

    public class Choker
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class ChosenOne
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Chuul
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Classes
    {
        public Bard bard { get; set; }
        public Cleric cleric { get; set; }
        public Druid druid { get; set; }
        public Fighter fighter { get; set; }
        public Paladin paladin { get; set; }
        public Ranger ranger { get; set; }
        public Thief thief { get; set; }
        public Wizard wizard { get; set; }
    }

    public class ClassesList
    {
        public string name { get; set; }
        public string description { get; set; }
        public int load { get; set; }
        public int base_hp { get; set; }
        public string damage { get; set; }
        public Names names { get; set; }
        public List<string> bonds { get; set; }
        public List<List<string>> looks { get; set; }
        public Alignments alignments { get; set; }
        public List<AlignmentsList> alignments_list { get; set; }
        public List<RaceMove> race_moves { get; set; }
        public List<StartingMove> starting_moves { get; set; }
        public List<AdvancedMoves1> advanced_moves_1 { get; set; }
        public List<AdvancedMoves2> advanced_moves_2 { get; set; }
        public List<object> gear_choices { get; set; }
        public string key { get; set; }
    }

    public class Cleric
    {
        public string name { get; set; }
        public string key { get; set; }
        public string damage { get; set; }
        public int base_hp { get; set; }
        public int load { get; set; }
        public string description { get; set; }
        public Names names { get; set; }
        public List<string> bonds { get; set; }
        public List<List<string>> looks { get; set; }
        public Alignments alignments { get; set; }
        public List<AlignmentsList> alignments_list { get; set; }
        public List<GearChoice> gear_choices { get; set; }
        public List<StartingMove> starting_moves { get; set; }
        public List<RaceMove> race_moves { get; set; }
        public List<AdvancedMoves1> advanced_moves_1 { get; set; }
        public List<AdvancedMoves2> advanced_moves_2 { get; set; }
    }

    public class ClericDwarf
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ClericHuman
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Cloaker
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class ClubShillelagh
    {
        public string name { get; set; }
        public List<string> tags { get; set; }
    }

    public class Cockatrice
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Command
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Commune
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class CommunionOfWhispers
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Con
    {
        public string name { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class ConceptElemental
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Connections
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Corrupter
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Counterspell
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Coutal
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Crocodilian
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Crossbow
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class DaggerShiv
    {
        public string name { get; set; }
        public List<string> tags { get; set; }
    }

    public class DeepElfAssassin
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class DeepElfPriest
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class DeepElfSwordmaster
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Defend
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class DefyDanger
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Deity
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Derro
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Devious
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class DevotedHealer
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Devourer
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Digester
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class DirtyFighter
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class DiscernRealities
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Disguise
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class DivineArmor
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class DivineAuthority
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class DivineFavor
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class DivineGuidance
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class DivineIntervention
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class DivineInvincibility
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class DivineProtection
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class Djinn
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Doppelgänger
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class DoppelgängersDance
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Dragon
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Dragonbone
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class DragonTurtle
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class DragonWhelp
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Draugr
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Druid
    {
        public string name { get; set; }
        public string key { get; set; }
        public string damage { get; set; }
        public int base_hp { get; set; }
        public int load { get; set; }
        public string description { get; set; }
        public Names names { get; set; }
        public List<string> bonds { get; set; }
        public List<List<string>> looks { get; set; }
        public Alignments alignments { get; set; }
        public List<AlignmentsList> alignments_list { get; set; }
        public List<GearChoice> gear_choices { get; set; }
        public List<StartingMove> starting_moves { get; set; }
        public List<RaceMove> race_moves { get; set; }
        public List<AdvancedMoves1> advanced_moves_1 { get; set; }
        public List<AdvancedMoves2> advanced_moves_2 { get; set; }
    }

    public class DruidElf
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class DruidHalfling
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class DruidHuman
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Dryad
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class DuelingRapier
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class DuelistsBlock
    {
        public string name { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class DuelistsParry
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class DungeonRations
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class DwarvenHardtack
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class DwarvenWarrior
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class EagleLord
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class EarthElemental
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Ekek
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class EldritchChord
    {
        public string name { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class EldritchTones
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class ElementalMastery
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ElvenArrows
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class ElvenBread
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class ElvishHighArcanist
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class ElvishWarrior
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class EmbracingNoForm
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Empower
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class EmpoweredMagic
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Enchanter
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class EnchantersSoul
    {
        public string name { get; set; }
        public string key { get; set; }
        public string requires { get; set; }
        public string description { get; set; }
    }

    public class Encumbrance
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Envenom
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Equipment
    {
        public RaggedBow ragged_bow { get; set; }
        public FineBow fine_bow { get; set; }
        public Crossbow crossbow { get; set; }
        public BundleOfArrows bundle_of_arrows { get; set; }
        public ElvenArrows elven_arrows { get; set; }
        public ClubShillelagh club_shillelagh { get; set; }
        public Staff staff { get; set; }
        public DaggerShiv dagger_shiv { get; set; }
        public ThrowingDagger throwing_dagger { get; set; }
        public ShortSwordAxeWarhammerMace short_sword_axe_warhammer_mace { get; set; }
        public Spear spear { get; set; }
        public LongSwordBattleAxeFlail long_sword_battle_axe_flail { get; set; }
        public Halberd halberd { get; set; }
        public Rapier rapier { get; set; }
        public DuelingRapier dueling_rapier { get; set; }
        public LeatherChainmail leather_chainmail { get; set; }
        public ScaleMail scale_mail { get; set; }
        public Plate plate { get; set; }
        public Shield shield { get; set; }
        public AdventuringGear adventuring_gear { get; set; }
        public Bandages bandages { get; set; }
        public PoulticesAndHerbs poultices_and_herbs { get; set; }
        public HealingPotion healing_potion { get; set; }
        public KegOfDwarvenStout keg_of_dwarven_stout { get; set; }
        public BagOfBooks bag_of_books { get; set; }
        public Antitoxin antitoxin { get; set; }
        public DungeonRations dungeon_rations { get; set; }
        public PersonalFeast personal_feast { get; set; }
        public DwarvenHardtack dwarven_hardtack { get; set; }
        public ElvenBread elven_bread { get; set; }
        public HalflingPipeleaf halfling_pipeleaf { get; set; }
        public OilOfTagit oil_of_tagit { get; set; }
        public Bloodweed bloodweed { get; set; }
        public Goldenroot goldenroot { get; set; }
        public SerpentsTears serpents_tears { get; set; }
        public VorpalSword vorpal_sword { get; set; }
        public string key { get; set; }
    }

    public class EquipmentList
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class EscapeRoute
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class EtherealFilcher
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class EtherealTether
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Ettin
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Evasion
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class EverOnward
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class EvidenceOfFaith
    {
        public string name { get; set; }
        public string key { get; set; }
        public string requires { get; set; }
        public string description { get; set; }
    }

    public class Evil
    {
        public string description { get; set; }
        public string name { get; set; }
    }

    public class EvilEye
    {
        public string name { get; set; }
        public string key { get; set; }
        public string requires { get; set; }
        public string description { get; set; }
    }

    public class ExpandedSpellbook
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Exterminatus
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ExtremelyCautious
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class EyeForWeaponry
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class EyesOfTheTiger
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class FamiliarPrey
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Fighter
    {
        public string name { get; set; }
        public string key { get; set; }
        public string damage { get; set; }
        public int base_hp { get; set; }
        public int load { get; set; }
        public string description { get; set; }
        public Names names { get; set; }
        public List<string> bonds { get; set; }
        public List<List<string>> looks { get; set; }
        public Alignments alignments { get; set; }
        public List<AlignmentsList> alignments_list { get; set; }
        public List<GearChoice> gear_choices { get; set; }
        public List<StartingMove> starting_moves { get; set; }
        public List<RaceMove> race_moves { get; set; }
        public List<AdvancedMoves1> advanced_moves_1 { get; set; }
        public List<AdvancedMoves2> advanced_moves_2 { get; set; }
    }

    public class FighterDwarf
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class FighterElf
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class FighterHalfling
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class FighterHuman
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class FineBow
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class FireBeetle
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class FireEels
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class FirstAid
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class FleshGolem
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class FlexibleMorals
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class FollowMe
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Fool
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Formcrafter
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class FormianCenturion
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class FormianDrone
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class FormianQueen
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class FormianTaskmaster
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Formshaper
    {
        public string name { get; set; }
        public string key { get; set; }
        public string requires { get; set; }
        public string description { get; set; }
    }

    public class FountOfKnowledge
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Frogman
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Gargoyle
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class GearChoice
    {
        public string label { get; set; }
        public List<string> list { get; set; }
    }

    public class GelatinousCube
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Ghost
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Ghoul
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Girallon
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class GnollAlpha
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class GnollEmissary
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class GnollTracker
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Goblin
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class GoblinOrkaster
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class GodAmidstTheWastes
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Goldenroot
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class Goliath
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Good
    {
        public string name { get; set; }
        public string description { get; set; }
    }

    public class GrayRender
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class GreaterEmpower
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class GreaterEmpoweredMagic
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class GreaterFirstAid
    {
        public string name { get; set; }
        public string key { get; set; }
        public string requires { get; set; }
        public string description { get; set; }
    }

    public class Griffin
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Guardsman
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class HackAndSlash
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Halberd
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class HalfElven
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class HalflingPipeleaf
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class HalflingThief
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class HealingChorus
    {
        public string name { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class HealingPotion
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class HealingSong
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class HedgeWizard
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Heirloom
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Heist
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class HellHound
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class HighlyLogical
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class HighPriest
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class HillGiant
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class HolyProtection
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class HolySmite
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class Hospitaller
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class HuntAndTrackWis
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Hunter
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class HuntersBrother
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class HuntersPrey
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class Hydra
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class IAmTheLaw
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Imp
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class ImperviousDefender
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class ImprovedWeapon
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Indomitable
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Inevitable
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Interrogator
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Invigorate
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class IronGolem
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class IronHide
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ItGoesToEleven
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class KegOfDwarvenStout
    {
        public string description { get; set; }
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class Knight
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class KnowItAll
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Kobold
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Kraken
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Larvae
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class LastBreath
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Lawful
    {
        public string description { get; set; }
        public string name { get; set; }
    }

    public class LayOnHandsCha
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class LeatherChainmail
    {
        public string name { get; set; }
        public List<string> tags { get; set; }
    }

    public class Lich
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Lizardman
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Logical
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class LongSwordBattleAxeFlail
    {
        public string name { get; set; }
        public List<string> tags { get; set; }
    }

    public class MaggotSquid
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Magmin
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class MakeCamp
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class MansBestFriend
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Manticore
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Martyr
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class Master
    {
        public string name { get; set; }
        public string key { get; set; }
        public string requires { get; set; }
        public string description { get; set; }
    }

    public class Medusa
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Merchant
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Merciless
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class MetalHurlant
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Minotaur
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Mohrg
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Monsters
    {
        public Acolyte acolyte { get; set; }
        public Adventurer adventurer { get; set; }
        public Bandit bandit { get; set; }
        public BanditKing bandit_king { get; set; }
        public Fool fool { get; set; }
        public Guardsman guardsman { get; set; }
        public HalflingThief halfling_thief { get; set; }
        public HedgeWizard hedge_wizard { get; set; }
        public HighPriest high_priest { get; set; }
        public Hunter hunter { get; set; }
        public Knight knight { get; set; }
        public Merchant merchant { get; set; }
        public Noble noble { get; set; }
        public Peasant peasant { get; set; }
        public Rebel rebel { get; set; }
        public Soldier soldier { get; set; }
        public Spy spy { get; set; }
        public Tinkerer tinkerer { get; set; }
        public Aboleth aboleth { get; set; }
        public ApocalypseDragon apocalypse_dragon { get; set; }
        public ChaosSpawn chaos_spawn { get; set; }
        public Chuul chuul { get; set; }
        public DeepElfAssassin deep_elf_assassin { get; set; }
        public DeepElfSwordmaster deep_elf_swordmaster { get; set; }
        public DeepElfPriest deep_elf_priest { get; set; }
        public Dragon dragon { get; set; }
        public GrayRender gray_render { get; set; }
        public Magmin magmin { get; set; }
        public Minotaur minotaur { get; set; }
        public Naga naga { get; set; }
        public Salamander salamander { get; set; }
        public Bulette bulette { get; set; }
        public Chimera chimera { get; set; }
        public Derro derro { get; set; }
        public Digester digester { get; set; }
        public EtherealFilcher ethereal_filcher { get; set; }
        public Ettin ettin { get; set; }
        public Girallon girallon { get; set; }
        public IronGolem iron_golem { get; set; }
        public FleshGolem flesh_golem { get; set; }
        public Kraken kraken { get; set; }
        public Manticore manticore { get; set; }
        public Owlbear owlbear { get; set; }
        public Pegasus pegasus { get; set; }
        public RustMonster rust_monster { get; set; }
        public Xorn xorn { get; set; }
        public FormianDrone formian_drone { get; set; }
        public FormianTaskmaster formian_taskmaster { get; set; }
        public FormianCenturion formian_centurion { get; set; }
        public FormianQueen formian_queen { get; set; }
        public GnollTracker gnoll_tracker { get; set; }
        public GnollEmissary gnoll_emissary { get; set; }
        public GnollAlpha gnoll_alpha { get; set; }
        public OrcBloodwarrior orc_bloodwarrior { get; set; }
        public OrcBerserker orc_berserker { get; set; }
        public OrcBreaker orc_breaker { get; set; }

        [JsonProperty("orc_one-eye")]
        public OrcOneEye OrcOneEye { get; set; }
        public OrcShaman orc_shaman { get; set; }
        public OrcSlaver orc_slaver { get; set; }
        public OrcShadowhunter orc_shadowhunter { get; set; }
        public OrcWarchief orc_warchief { get; set; }
        public TritonSpy triton_spy { get; set; }
        public TritonTidecaller triton_tidecaller { get; set; }

        [JsonProperty("triton_sub-mariner")]
        public TritonSubMariner TritonSubMariner { get; set; }
        public TritonNoble triton_noble { get; set; }
        public AssassinVine assassin_vine { get; set; }
        public BlinkDog blink_dog { get; set; }
        public Centaur centaur { get; set; }
        public ChaosOoze chaos_ooze { get; set; }
        public Cockatrice cockatrice { get; set; }
        public Dryad dryad { get; set; }
        public EagleLord eagle_lord { get; set; }
        public ElvishWarrior elvish_warrior { get; set; }
        public ElvishHighArcanist elvish_high_arcanist { get; set; }
        public Griffin griffin { get; set; }
        public HillGiant hill_giant { get; set; }
        public Ogre ogre { get; set; }
        public RazorBoar razor_boar { get; set; }
        public Satyr satyr { get; set; }
        public Sprite sprite { get; set; }
        public Treant treant { get; set; }
        public Werewolf werewolf { get; set; }
        public Worg worg { get; set; }
        public Abomination abomination { get; set; }
        public Banshee banshee { get; set; }
        public Devourer devourer { get; set; }
        public Dragonbone dragonbone { get; set; }
        public Draugr draugr { get; set; }
        public Ghost ghost { get; set; }
        public Ghoul ghoul { get; set; }
        public Lich lich { get; set; }
        public Mohrg mohrg { get; set; }
        public Mummy mummy { get; set; }
        public Nightwing nightwing { get; set; }
        public Shadow shadow { get; set; }
        public Sigben sigben { get; set; }
        public Skeleton skeleton { get; set; }
        public Spectre spectre { get; set; }
        public Vampire vampire { get; set; }

        [JsonProperty("wight-wolf")]
        public WightWolf WightWolf { get; set; }
        public Zombie zombie { get; set; }
        public Bakunawa bakunawa { get; set; }
        public Basilisk basilisk { get; set; }
        public BlackPudding black_pudding { get; set; }
        public Coutal coutal { get; set; }
        public Crocodilian crocodilian { get; set; }
        public Doppelgänger doppelgänger { get; set; }
        public DragonTurtle dragon_turtle { get; set; }
        public DragonWhelp dragon_whelp { get; set; }
        public Ekek ekek { get; set; }
        public FireEels fire_eels { get; set; }
        public Frogman frogman { get; set; }
        public Hydra hydra { get; set; }
        public Kobold kobold { get; set; }
        public Lizardman lizardman { get; set; }
        public Medusa medusa { get; set; }
        public Sahuagin sahuagin { get; set; }
        public Sauropod sauropod { get; set; }
        public SwampShambler swamp_shambler { get; set; }
        public Troll troll { get; set; }

        [JsonProperty("will-o-wisp")]
        public WillOWisp WillOWisp { get; set; }
        public Ankheg ankheg { get; set; }
        public CaveRat cave_rat { get; set; }
        public Choker choker { get; set; }
        public Cloaker cloaker { get; set; }
        public DwarvenWarrior dwarven_warrior { get; set; }
        public EarthElemental earth_elemental { get; set; }
        public FireBeetle fire_beetle { get; set; }
        public Gargoyle gargoyle { get; set; }
        public GelatinousCube gelatinous_cube { get; set; }
        public Goblin goblin { get; set; }
        public GoblinOrkaster goblin_orkaster { get; set; }
        public Goliath goliath { get; set; }
        public Otyugh otyugh { get; set; }

        [JsonProperty("maggot-squid")]
        public MaggotSquid MaggotSquid { get; set; }
        public PurpleWorm purple_worm { get; set; }
        public Roper roper { get; set; }
        public RotGrub rot_grub { get; set; }
        public Spiderlord spiderlord { get; set; }
        public Troglodyte troglodyte { get; set; }
        public Angel angel { get; set; }
        public BarbedDevil barbed_devil { get; set; }
        public ChainDevil chain_devil { get; set; }
        public ConceptElemental concept_elemental { get; set; }
        public Corrupter corrupter { get; set; }
        public Djinn djinn { get; set; }
        public HellHound hell_hound { get; set; }
        public Imp imp { get; set; }
        public Inevitable inevitable { get; set; }
        public Larvae larvae { get; set; }
        public Nightmare nightmare { get; set; }
        public Quasit quasit { get; set; }
        public TheTarrasque the_tarrasque { get; set; }
        public WordDemon word_demon { get; set; }
        public string key { get; set; }
        public Settings settings { get; set; }
    }

    public class Moves
    {
        public ALittleHelpFromMyFriends a_little_help_from_my_friends { get; set; }
        public APortInTheStorm a_port_in_the_storm { get; set; }
        public AnEarForMagic an_ear_for_magic { get; set; }
        public ArcaneArt arcane_art { get; set; }
        public Bamboozle bamboozle { get; set; }
        public BardElf bard_elf { get; set; }
        public BardHuman bard_human { get; set; }
        public BardicLore bardic_lore { get; set; }
        public CharmingAndOpen charming_and_open { get; set; }
        public Con con { get; set; }
        public Devious devious { get; set; }
        public DuelistsBlock duelists_block { get; set; }
        public DuelistsParry duelists_parry { get; set; }
        public EldritchChord eldritch_chord { get; set; }
        public EldritchTones eldritch_tones { get; set; }
        public HealingChorus healing_chorus { get; set; }
        public HealingSong healing_song { get; set; }
        public ItGoesToEleven it_goes_to_eleven { get; set; }
        public MetalHurlant metal_hurlant { get; set; }
        public Reputation reputation { get; set; }
        public UnforgettableFace unforgettable_face { get; set; }
        public ViciousBlast vicious_blast { get; set; }
        public ViciousCacophony vicious_cacophony { get; set; }
        public Deity deity { get; set; }
        public DivineGuidance divine_guidance { get; set; }
        public TurnUndead turn_undead { get; set; }
        public Commune commune { get; set; }
        public CastASpellCleric cast_a_spell_cleric { get; set; }
        public ClericDwarf cleric_dwarf { get; set; }
        public ClericHuman cleric_human { get; set; }
        public ChosenOne chosen_one { get; set; }
        public Invigorate invigorate { get; set; }
        public TheScalesOfLifeAndDeath the_scales_of_life_and_death { get; set; }
        public Serenity serenity { get; set; }
        public FirstAid first_aid { get; set; }
        public DivineIntervention divine_intervention { get; set; }
        public Penitent penitent { get; set; }
        public Empower empower { get; set; }
        public OrisonForGuidance orison_for_guidance { get; set; }
        public DivineProtection divine_protection { get; set; }
        public DevotedHealer devoted_healer { get; set; }
        public Anointed anointed { get; set; }
        public Apotheosis apotheosis { get; set; }
        public Reaper reaper { get; set; }
        public Providence providence { get; set; }
        public GreaterFirstAid greater_first_aid { get; set; }
        public DivineInvincibility divine_invincibility { get; set; }
        public Martyr martyr { get; set; }
        public DivineArmor divine_armor { get; set; }
        public GreaterEmpower greater_empower { get; set; }
        public MulticlassDabbler multiclass_dabbler { get; set; }
        public string key { get; set; }
        public BornOfTheSoil born_of_the_soil { get; set; }
        public ByNatureSustained by_nature_sustained { get; set; }
        public SpiritTongue spirit_tongue { get; set; }
        public Shapeshifter shapeshifter { get; set; }
        public StudiedEssence studied_essence { get; set; }
        public DruidElf druid_elf { get; set; }
        public DruidHuman druid_human { get; set; }
        public DruidHalfling druid_halfling { get; set; }
        public HuntersBrother hunters_brother { get; set; }
        public RedOfToothAndClaw red_of_tooth_and_claw { get; set; }
        public CommunionOfWhispers communion_of_whispers { get; set; }
        public Barkskin barkskin { get; set; }
        public EyesOfTheTiger eyes_of_the_tiger { get; set; }
        public Shed shed { get; set; }
        public ThingTalker thing_talker { get; set; }
        public Formcrafter formcrafter { get; set; }
        public ElementalMastery elemental_mastery { get; set; }
        public Balance balance { get; set; }
        public EmbracingNoForm embracing_no_form { get; set; }
        public DoppelgängersDance doppelgängers_dance { get; set; }
        public BloodAndThunder blood_and_thunder { get; set; }
        public TheDruidSleep the_druid_sleep { get; set; }
        public WorldTalker world_talker { get; set; }
        public StalkersSister stalkers_sister { get; set; }
        public Formshaper formshaper { get; set; }
        public Chimera chimera { get; set; }
        public WeatherWeaver weather_weaver { get; set; }
        public BendBarsLiftGates bend_bars_lift_gates { get; set; }
        public Armored armored { get; set; }
        public SignatureWeapon signature_weapon { get; set; }
        public FighterDwarf fighter_dwarf { get; set; }
        public FighterElf fighter_elf { get; set; }
        public FighterHalfling fighter_halfling { get; set; }
        public FighterHuman fighter_human { get; set; }
        public Merciless merciless { get; set; }
        public Heirloom heirloom { get; set; }
        public ArmorMastery armor_mastery { get; set; }
        public ImprovedWeapon improved_weapon { get; set; }
        public SeeingRed seeing_red { get; set; }
        public Interrogator interrogator { get; set; }
        public ScentOfBlood scent_of_blood { get; set; }
        public IronHide iron_hide { get; set; }
        public Blacksmith blacksmith { get; set; }
        public Bloodthirsty bloodthirsty { get; set; }
        public ArmoredPerfection armored_perfection { get; set; }
        public EvilEye evil_eye { get; set; }
        public TasteOfBlood taste_of_blood { get; set; }
        public MulticlassInitiate multiclass_initiate { get; set; }
        public SteelHide steel_hide { get; set; }
        public ThroughDeathsEyes through_deaths_eyes { get; set; }
        public EyeForWeaponry eye_for_weaponry { get; set; }
        public SuperiorWarrior superior_warrior { get; set; }
        public LayOnHandsCha lay_on_hands_cha { get; set; }
        public IAmTheLaw i_am_the_law { get; set; }
        public Quest quest { get; set; }
        public PaladinHuman paladin_human { get; set; }
        public DivineFavor divine_favor { get; set; }
        public BloodyAegis bloody_aegis { get; set; }
        public Smite smite { get; set; }
        public Exterminatus exterminatus { get; set; }
        public Charge charge { get; set; }
        public StaunchDefender staunch_defender { get; set; }
        public SetupStrike setup_strike { get; set; }
        public HolyProtection holy_protection { get; set; }
        public VoiceOfAuthority voice_of_authority { get; set; }
        public Hospitaller hospitaller { get; set; }
        public EvidenceOfFaith evidence_of_faith { get; set; }
        public HolySmite holy_smite { get; set; }
        public EverOnward ever_onward { get; set; }
        public ImperviousDefender impervious_defender { get; set; }
        public TandemStrike tandem_strike { get; set; }
        public DivineAuthority divine_authority { get; set; }
        public PerfectHospitaller perfect_hospitaller { get; set; }
        public Indomitable indomitable { get; set; }
        public PerfectKnight perfect_knight { get; set; }
        public HuntAndTrackWis hunt_and_track_wis { get; set; }
        public CalledShot called_shot { get; set; }
        public AnimalCompanion animal_companion { get; set; }
        public Command command { get; set; }
        public RangerElf ranger_elf { get; set; }
        public RangerHuman ranger_human { get; set; }
        public HalfElven half_elven { get; set; }
        public WildEmpathy wild_empathy { get; set; }
        public FamiliarPrey familiar_prey { get; set; }
        public VipersStrike vipers_strike { get; set; }
        public Camouflage camouflage { get; set; }
        public MansBestFriend mans_best_friend { get; set; }
        public BlotOutTheSun blot_out_the_sun { get; set; }
        public WellTrained well_trained { get; set; }
        public GodAmidstTheWastes god_amidst_the_wastes { get; set; }
        public FollowMe follow_me { get; set; }
        public ASafePlace a_safe_place { get; set; }
        public WildSpeech wild_speech { get; set; }
        public HuntersPrey hunters_prey { get; set; }
        public VipersFangs vipers_fangs { get; set; }
        public SmaugsBelly smaugs_belly { get; set; }
        public Strider strider { get; set; }
        public ASaferPlace a_safer_place { get; set; }
        public Observant observant { get; set; }
        public SpecialTrick special_trick { get; set; }
        public UnnaturalAlly unnatural_ally { get; set; }
        public TrapExpert trap_expert { get; set; }
        public TricksOfTheTrade tricks_of_the_trade { get; set; }
        public Backstab backstab { get; set; }
        public FlexibleMorals flexible_morals { get; set; }
        public Poisoner poisoner { get; set; }
        public ThiefHalfling thief_halfling { get; set; }
        public ThiefHuman thief_human { get; set; }
        public CheapShot cheap_shot { get; set; }
        public Cautious cautious { get; set; }
        public WealthAndTaste wealth_and_taste { get; set; }
        public ShootFirst shoot_first { get; set; }
        public PoisonMaster poison_master { get; set; }
        public Envenom envenom { get; set; }
        public Brewer brewer { get; set; }
        public Underdog underdog { get; set; }
        public Connections connections { get; set; }
        public DirtyFighter dirty_fighter { get; set; }
        public ExtremelyCautious extremely_cautious { get; set; }
        public Alchemist alchemist { get; set; }
        public SeriousUnderdog serious_underdog { get; set; }
        public Evasion evasion { get; set; }
        public StrongArmTrueAim strong_arm_true_aim { get; set; }
        public EscapeRoute escape_route { get; set; }
        public Disguise disguise { get; set; }
        public Heist heist { get; set; }
        public Prodigy prodigy { get; set; }
        public EmpoweredMagic empowered_magic { get; set; }
        public FountOfKnowledge fount_of_knowledge { get; set; }
        public KnowItAll know_it_all { get; set; }
        public ExpandedSpellbook expanded_spellbook { get; set; }
        public Enchanter enchanter { get; set; }
        public Logical logical { get; set; }
        public ArcaneWard arcane_ward { get; set; }
        public Counterspell counterspell { get; set; }
        public QuickStudy quick_study { get; set; }
        public Master master { get; set; }
        public GreaterEmpoweredMagic greater_empowered_magic { get; set; }
        public EnchantersSoul enchanters_soul { get; set; }
        public HighlyLogical highly_logical { get; set; }
        public ArcaneArmor arcane_armor { get; set; }
        public ProtectiveCounter protective_counter { get; set; }
        public EtherealTether ethereal_tether { get; set; }
        public MysticalPuppetStrings mystical_puppet_strings { get; set; }
        public SpellAugmentation spell_augmentation { get; set; }
        public SelfPowered self_powered { get; set; }
        public Spellbook spellbook { get; set; }
        public PrepareSpells prepare_spells { get; set; }
        public CastASpellWizard cast_a_spell_wizard { get; set; }
        public SpellDefense spell_defense { get; set; }
        public Ritual ritual { get; set; }
        public WizardElf wizard_elf { get; set; }
        public WizardHuman wizard_human { get; set; }
        public AidOrInterfere aid_or_interfere { get; set; }
        public Defend defend { get; set; }
        public DefyDanger defy_danger { get; set; }
        public DiscernRealities discern_realities { get; set; }
        public Encumbrance encumbrance { get; set; }
        public HackAndSlash hack_and_slash { get; set; }
        public LastBreath last_breath { get; set; }
        public MakeCamp make_camp { get; set; }
        public MulticlassMaster multiclass_master { get; set; }
        public Parley parley { get; set; }
        public SpoutLore spout_lore { get; set; }
        public TakeWatch take_watch { get; set; }
        public UndertakeAPerilousJourney undertake_a_perilous_journey { get; set; }
        public Volley volley { get; set; }
    }

    public class MulticlassDabbler
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class MulticlassInitiate
    {
        public string name { get; set; }
        public string requires { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class MulticlassMaster
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Mummy
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class MysticalPuppetStrings
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Naga
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Names
    {
        public List<string> elf { get; set; }
        public List<string> human { get; set; }
        public List<string> dwarf { get; set; }
        public List<string> halfling { get; set; }
    }

    public class Near
    {
        public string name { get; set; }
        public string description { get; set; }
    }

    public class Neutral
    {
        public string name { get; set; }
        public string description { get; set; }
    }

    public class Nightmare
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Nightwing
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Noble
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class NPiercing
    {
        public string name { get; set; }
        public string description { get; set; }
    }

    public class Observant
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Ogre
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class OilOfTagit
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class OrcBerserker
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class OrcBloodwarrior
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class OrcBreaker
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class OrcOneEye
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class OrcShadowhunter
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class OrcShaman
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class OrcSlaver
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class OrcWarchief
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class OrisonForGuidance
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Otyugh
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Owlbear
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Paladin
    {
        public string name { get; set; }
        public string key { get; set; }
        public string damage { get; set; }
        public int base_hp { get; set; }
        public int load { get; set; }
        public string description { get; set; }
        public Names names { get; set; }
        public List<string> bonds { get; set; }
        public List<List<string>> looks { get; set; }
        public Alignments alignments { get; set; }
        public List<AlignmentsList> alignments_list { get; set; }
        public List<GearChoice> gear_choices { get; set; }
        public List<StartingMove> starting_moves { get; set; }
        public List<RaceMove> race_moves { get; set; }
        public List<AdvancedMoves1> advanced_moves_1 { get; set; }
        public List<AdvancedMoves2> advanced_moves_2 { get; set; }
    }

    public class PaladinHuman
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Parley
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Peasant
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Pegasus
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Penitent
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class PerfectHospitaller
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class PerfectKnight
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class PersonalFeast
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class Plate
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class Poisoner
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class PoisonMaster
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class PoulticesAndHerbs
    {
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class PrepareSpells
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Prodigy
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ProtectiveCounter
    {
        public string name { get; set; }
        public string key { get; set; }
        public string requires { get; set; }
        public string description { get; set; }
    }

    public class Providence
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class PurpleWorm
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Quasit
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Quest
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class QuickStudy
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class RaceMove
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class RaggedBow
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class Ranger
    {
        public string name { get; set; }
        public string key { get; set; }
        public string damage { get; set; }
        public int base_hp { get; set; }
        public int load { get; set; }
        public string description { get; set; }
        public Names names { get; set; }
        public List<object> bonds { get; set; }
        public List<List<string>> looks { get; set; }
        public Alignments alignments { get; set; }
        public List<AlignmentsList> alignments_list { get; set; }
        public List<GearChoice> gear_choices { get; set; }
        public List<StartingMove> starting_moves { get; set; }
        public List<RaceMove> race_moves { get; set; }
        public List<AdvancedMoves1> advanced_moves_1 { get; set; }
        public List<AdvancedMoves2> advanced_moves_2 { get; set; }
    }

    public class RangerElf
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class RangerHuman
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Rapier
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class RazorBoar
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Reaper
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Rebel
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class RedOfToothAndClaw
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Reputation
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Ritual
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Root
    {
        public Moves moves { get; set; }
        public string game_name { get; set; }
        public List<EquipmentList> equipment_list { get; set; }
        public List<ClassesList> classes_list { get; set; }
        public List<BasicMove> basic_moves { get; set; }
        public List<SpecialMove> special_moves { get; set; }
        public string key { get; set; }
        public Classes classes { get; set; }
        public Equipment equipment { get; set; }
        public Monsters monsters { get; set; }
        public Tags tags { get; set; }
        public ALittleHelpFromMyFriends a_little_help_from_my_friends { get; set; }
        public APortInTheStorm a_port_in_the_storm { get; set; }
        public AnEarForMagic an_ear_for_magic { get; set; }
        public ArcaneArt arcane_art { get; set; }
        public Bamboozle bamboozle { get; set; }
        public BardElf bard_elf { get; set; }
        public BardHuman bard_human { get; set; }
        public BardicLore bardic_lore { get; set; }
        public CharmingAndOpen charming_and_open { get; set; }
        public Con con { get; set; }
        public Devious devious { get; set; }
        public DuelistsBlock duelists_block { get; set; }
        public DuelistsParry duelists_parry { get; set; }
        public EldritchChord eldritch_chord { get; set; }
        public EldritchTones eldritch_tones { get; set; }
        public HealingChorus healing_chorus { get; set; }
        public HealingSong healing_song { get; set; }
        public ItGoesToEleven it_goes_to_eleven { get; set; }
        public MetalHurlant metal_hurlant { get; set; }
        public Reputation reputation { get; set; }
        public UnforgettableFace unforgettable_face { get; set; }
        public ViciousBlast vicious_blast { get; set; }
        public ViciousCacophony vicious_cacophony { get; set; }
        public Deity deity { get; set; }
        public DivineGuidance divine_guidance { get; set; }
        public TurnUndead turn_undead { get; set; }
        public Commune commune { get; set; }
        public CastASpellCleric cast_a_spell_cleric { get; set; }
        public ClericDwarf cleric_dwarf { get; set; }
        public ClericHuman cleric_human { get; set; }
        public ChosenOne chosen_one { get; set; }
        public Invigorate invigorate { get; set; }
        public TheScalesOfLifeAndDeath the_scales_of_life_and_death { get; set; }
        public Serenity serenity { get; set; }
        public FirstAid first_aid { get; set; }
        public DivineIntervention divine_intervention { get; set; }
        public Penitent penitent { get; set; }
        public Empower empower { get; set; }
        public OrisonForGuidance orison_for_guidance { get; set; }
        public DivineProtection divine_protection { get; set; }
        public DevotedHealer devoted_healer { get; set; }
        public Anointed anointed { get; set; }
        public Apotheosis apotheosis { get; set; }
        public Reaper reaper { get; set; }
        public Providence providence { get; set; }
        public GreaterFirstAid greater_first_aid { get; set; }
        public DivineInvincibility divine_invincibility { get; set; }
        public Martyr martyr { get; set; }
        public DivineArmor divine_armor { get; set; }
        public GreaterEmpower greater_empower { get; set; }
        public MulticlassDabbler multiclass_dabbler { get; set; }
        public BornOfTheSoil born_of_the_soil { get; set; }
        public ByNatureSustained by_nature_sustained { get; set; }
        public SpiritTongue spirit_tongue { get; set; }
        public Shapeshifter shapeshifter { get; set; }
        public StudiedEssence studied_essence { get; set; }
        public DruidElf druid_elf { get; set; }
        public DruidHuman druid_human { get; set; }
        public DruidHalfling druid_halfling { get; set; }
        public HuntersBrother hunters_brother { get; set; }
        public RedOfToothAndClaw red_of_tooth_and_claw { get; set; }
        public CommunionOfWhispers communion_of_whispers { get; set; }
        public Barkskin barkskin { get; set; }
        public EyesOfTheTiger eyes_of_the_tiger { get; set; }
        public Shed shed { get; set; }
        public ThingTalker thing_talker { get; set; }
        public Formcrafter formcrafter { get; set; }
        public ElementalMastery elemental_mastery { get; set; }
        public Balance balance { get; set; }
        public EmbracingNoForm embracing_no_form { get; set; }
        public DoppelgängersDance doppelgängers_dance { get; set; }
        public BloodAndThunder blood_and_thunder { get; set; }
        public TheDruidSleep the_druid_sleep { get; set; }
        public WorldTalker world_talker { get; set; }
        public StalkersSister stalkers_sister { get; set; }
        public Formshaper formshaper { get; set; }
        public Chimera chimera { get; set; }
        public WeatherWeaver weather_weaver { get; set; }
        public BendBarsLiftGates bend_bars_lift_gates { get; set; }
        public Armored armored { get; set; }
        public SignatureWeapon signature_weapon { get; set; }
        public FighterDwarf fighter_dwarf { get; set; }
        public FighterElf fighter_elf { get; set; }
        public FighterHalfling fighter_halfling { get; set; }
        public FighterHuman fighter_human { get; set; }
        public Merciless merciless { get; set; }
        public Heirloom heirloom { get; set; }
        public ArmorMastery armor_mastery { get; set; }
        public ImprovedWeapon improved_weapon { get; set; }
        public SeeingRed seeing_red { get; set; }
        public Interrogator interrogator { get; set; }
        public ScentOfBlood scent_of_blood { get; set; }
        public IronHide iron_hide { get; set; }
        public Blacksmith blacksmith { get; set; }
        public Bloodthirsty bloodthirsty { get; set; }
        public ArmoredPerfection armored_perfection { get; set; }
        public EvilEye evil_eye { get; set; }
        public TasteOfBlood taste_of_blood { get; set; }
        public MulticlassInitiate multiclass_initiate { get; set; }
        public SteelHide steel_hide { get; set; }
        public ThroughDeathsEyes through_deaths_eyes { get; set; }
        public EyeForWeaponry eye_for_weaponry { get; set; }
        public SuperiorWarrior superior_warrior { get; set; }
        public LayOnHandsCha lay_on_hands_cha { get; set; }
        public IAmTheLaw i_am_the_law { get; set; }
        public Quest quest { get; set; }
        public PaladinHuman paladin_human { get; set; }
        public DivineFavor divine_favor { get; set; }
        public BloodyAegis bloody_aegis { get; set; }
        public Smite smite { get; set; }
        public Exterminatus exterminatus { get; set; }
        public Charge charge { get; set; }
        public StaunchDefender staunch_defender { get; set; }
        public SetupStrike setup_strike { get; set; }
        public HolyProtection holy_protection { get; set; }
        public VoiceOfAuthority voice_of_authority { get; set; }
        public Hospitaller hospitaller { get; set; }
        public EvidenceOfFaith evidence_of_faith { get; set; }
        public HolySmite holy_smite { get; set; }
        public EverOnward ever_onward { get; set; }
        public ImperviousDefender impervious_defender { get; set; }
        public TandemStrike tandem_strike { get; set; }
        public DivineAuthority divine_authority { get; set; }
        public PerfectHospitaller perfect_hospitaller { get; set; }
        public Indomitable indomitable { get; set; }
        public PerfectKnight perfect_knight { get; set; }
        public HuntAndTrackWis hunt_and_track_wis { get; set; }
        public CalledShot called_shot { get; set; }
        public AnimalCompanion animal_companion { get; set; }
        public Command command { get; set; }
        public RangerElf ranger_elf { get; set; }
        public RangerHuman ranger_human { get; set; }
        public HalfElven half_elven { get; set; }
        public WildEmpathy wild_empathy { get; set; }
        public FamiliarPrey familiar_prey { get; set; }
        public VipersStrike vipers_strike { get; set; }
        public Camouflage camouflage { get; set; }
        public MansBestFriend mans_best_friend { get; set; }
        public BlotOutTheSun blot_out_the_sun { get; set; }
        public WellTrained well_trained { get; set; }
        public GodAmidstTheWastes god_amidst_the_wastes { get; set; }
        public FollowMe follow_me { get; set; }
        public ASafePlace a_safe_place { get; set; }
        public WildSpeech wild_speech { get; set; }
        public HuntersPrey hunters_prey { get; set; }
        public VipersFangs vipers_fangs { get; set; }
        public SmaugsBelly smaugs_belly { get; set; }
        public Strider strider { get; set; }
        public ASaferPlace a_safer_place { get; set; }
        public Observant observant { get; set; }
        public SpecialTrick special_trick { get; set; }
        public UnnaturalAlly unnatural_ally { get; set; }
        public TrapExpert trap_expert { get; set; }
        public TricksOfTheTrade tricks_of_the_trade { get; set; }
        public Backstab backstab { get; set; }
        public FlexibleMorals flexible_morals { get; set; }
        public Poisoner poisoner { get; set; }
        public ThiefHalfling thief_halfling { get; set; }
        public ThiefHuman thief_human { get; set; }
        public CheapShot cheap_shot { get; set; }
        public Cautious cautious { get; set; }
        public WealthAndTaste wealth_and_taste { get; set; }
        public ShootFirst shoot_first { get; set; }
        public PoisonMaster poison_master { get; set; }
        public Envenom envenom { get; set; }
        public Brewer brewer { get; set; }
        public Underdog underdog { get; set; }
        public Connections connections { get; set; }
        public DirtyFighter dirty_fighter { get; set; }
        public ExtremelyCautious extremely_cautious { get; set; }
        public Alchemist alchemist { get; set; }
        public SeriousUnderdog serious_underdog { get; set; }
        public Evasion evasion { get; set; }
        public StrongArmTrueAim strong_arm_true_aim { get; set; }
        public EscapeRoute escape_route { get; set; }
        public Disguise disguise { get; set; }
        public Heist heist { get; set; }
        public Prodigy prodigy { get; set; }
        public EmpoweredMagic empowered_magic { get; set; }
        public FountOfKnowledge fount_of_knowledge { get; set; }
        public KnowItAll know_it_all { get; set; }
        public ExpandedSpellbook expanded_spellbook { get; set; }
        public Enchanter enchanter { get; set; }
        public Logical logical { get; set; }
        public ArcaneWard arcane_ward { get; set; }
        public Counterspell counterspell { get; set; }
        public QuickStudy quick_study { get; set; }
        public Master master { get; set; }
        public GreaterEmpoweredMagic greater_empowered_magic { get; set; }
        public EnchantersSoul enchanters_soul { get; set; }
        public HighlyLogical highly_logical { get; set; }
        public ArcaneArmor arcane_armor { get; set; }
        public ProtectiveCounter protective_counter { get; set; }
        public EtherealTether ethereal_tether { get; set; }
        public MysticalPuppetStrings mystical_puppet_strings { get; set; }
        public SpellAugmentation spell_augmentation { get; set; }
        public SelfPowered self_powered { get; set; }
        public Spellbook spellbook { get; set; }
        public PrepareSpells prepare_spells { get; set; }
        public CastASpellWizard cast_a_spell_wizard { get; set; }
        public SpellDefense spell_defense { get; set; }
        public Ritual ritual { get; set; }
        public WizardElf wizard_elf { get; set; }
        public WizardHuman wizard_human { get; set; }
        public AidOrInterfere aid_or_interfere { get; set; }
        public Defend defend { get; set; }
        public DefyDanger defy_danger { get; set; }
        public DiscernRealities discern_realities { get; set; }
        public Encumbrance encumbrance { get; set; }
        public HackAndSlash hack_and_slash { get; set; }
        public LastBreath last_breath { get; set; }
        public MakeCamp make_camp { get; set; }
        public MulticlassMaster multiclass_master { get; set; }
        public Parley parley { get; set; }
        public SpoutLore spout_lore { get; set; }
        public TakeWatch take_watch { get; set; }
        public UndertakeAPerilousJourney undertake_a_perilous_journey { get; set; }
        public Volley volley { get; set; }
    }

    public class Roper
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class RotGrub
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class RustMonster
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Sahuagin
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Salamander
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Satyr
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Sauropod
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class ScaleMail
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class ScentOfBlood
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class SeeingRed
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class SelfPowered
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Serenity
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class SeriousUnderdog
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class SerpentsTears
    {
        public string name { get; set; }
        public List<string> tags { get; set; }
        public string description { get; set; }
    }

    public class Settings
    {
        public CavernDwellers cavern_dwellers { get; set; }
        public string key { get; set; }
    }

    public class SetupStrike
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Shadow
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Shapeshifter
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Shed
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Shield
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class ShootFirst
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ShortSwordAxeWarhammerMace
    {
        public string name { get; set; }
        public List<string> tags { get; set; }
    }

    public class Sigben
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class SignatureWeapon
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Skeleton
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class SmaugsBelly
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Smite
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Soldier
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Spear
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class SpecialMove
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class SpecialTrick
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Spectre
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class SpellAugmentation
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Spellbook
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class SpellDefense
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Spiderlord
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class SpiritTongue
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class SpoutLore
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class Sprite
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Spy
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Staff
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class StalkersSister
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class StartingMove
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class StaunchDefender
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class SteelHide
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class Strider
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class StrongArmTrueAim
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class StudiedEssence
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class SuperiorWarrior
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class SwampShambler
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Tags
    {
        public Near near { get; set; }
        public NPiercing n_piercing { get; set; }
        public string key { get; set; }
    }

    public class TakeWatch
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class TandemStrike
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class TasteOfBlood
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class TheDruidSleep
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class TheScalesOfLifeAndDeath
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class TheTarrasque
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Thief
    {
        public string name { get; set; }
        public string key { get; set; }
        public string damage { get; set; }
        public int base_hp { get; set; }
        public int load { get; set; }
        public string description { get; set; }
        public Names names { get; set; }
        public List<string> bonds { get; set; }
        public List<List<string>> looks { get; set; }
        public Alignments alignments { get; set; }
        public List<AlignmentsList> alignments_list { get; set; }
        public List<GearChoice> gear_choices { get; set; }
        public List<StartingMove> starting_moves { get; set; }
        public List<RaceMove> race_moves { get; set; }
        public List<AdvancedMoves1> advanced_moves_1 { get; set; }
        public List<AdvancedMoves2> advanced_moves_2 { get; set; }
    }

    public class ThiefHalfling
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ThiefHuman
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ThingTalker
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ThroughDeathsEyes
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class ThrowingDagger
    {
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class Tinkerer
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class TrapExpert
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Treant
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class TricksOfTheTrade
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class TritonNoble
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class TritonSpy
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class TritonSubMariner
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class TritonTidecaller
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Troglodyte
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Troll
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class TurnUndead
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Underdog
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class UndertakeAPerilousJourney
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class UnforgettableFace
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class UnnaturalAlly
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Vampire
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class ViciousBlast
    {
        public string name { get; set; }
        public string description { get; set; }
        public string replaces { get; set; }
        public string key { get; set; }
    }

    public class ViciousCacophony
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class VipersFangs
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class VipersStrike
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class VoiceOfAuthority
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Volley
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class VorpalSword
    {
        public string description { get; set; }
        public List<string> tags { get; set; }
        public string name { get; set; }
    }

    public class WealthAndTaste
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class WeatherWeaver
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class WellTrained
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class Werewolf
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class WightWolf
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class WildEmpathy
    {
        public string name { get; set; }
        public string key { get; set; }
        public string description { get; set; }
    }

    public class WildSpeech
    {
        public string name { get; set; }
        public string key { get; set; }
        public string replaces { get; set; }
        public string description { get; set; }
    }

    public class WillOWisp
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Wizard
    {
        public string name { get; set; }
        public string key { get; set; }
        public string damage { get; set; }
        public int base_hp { get; set; }
        public int load { get; set; }
        public string description { get; set; }
        public Names names { get; set; }
        public List<string> bonds { get; set; }
        public List<List<string>> looks { get; set; }
        public Alignments alignments { get; set; }
        public List<AlignmentsList> alignments_list { get; set; }
        public List<GearChoice> gear_choices { get; set; }
        public List<StartingMove> starting_moves { get; set; }
        public List<RaceMove> race_moves { get; set; }
        public List<AdvancedMoves1> advanced_moves_1 { get; set; }
        public List<AdvancedMoves2> advanced_moves_2 { get; set; }
    }

    public class WizardElf
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class WizardHuman
    {
        public string name { get; set; }
        public string description { get; set; }
        public string key { get; set; }
    }

    public class WordDemon
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Worg
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class WorldTalker
    {
        public string name { get; set; }
        public string key { get; set; }
        public string requires { get; set; }
        public string description { get; set; }
    }

    public class Xorn
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }

    public class Zombie
    {
        public string description { get; set; }
        public string instinct { get; set; }
        public int armor { get; set; }
        public int hp { get; set; }
        public List<Attack> attacks { get; set; }
        public string name { get; set; }
        public List<string> tags { get; set; }
        public List<string> moves { get; set; }
        public string key { get; set; }
    }


}
