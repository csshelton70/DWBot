using DatabaseLayer;
using DatabaseLayer.Models;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DataImport
{
    internal class Program
    {
        private static Root root;
        private static MoveContext ctx;

        static void Main(string[] args)
        {


            string myJsonResponse = "";

            var embeddedProvider = new EmbeddedFileProvider(Assembly.GetExecutingAssembly());
            using (var stream = embeddedProvider.GetFileInfo("RawData.Json").CreateReadStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    myJsonResponse = reader.ReadToEnd();
                }
            }


            root = JsonConvert.DeserializeObject<Root>(myJsonResponse);
            ctx = new MoveContext();

            Console.WriteLine("Starting");

            Console.WriteLine("Adding Moves");
            AddMoves();
            
            Console.WriteLine("Adding Moves again to catch requires/replaces links");
            AddMoves();

            Console.WriteLine("Adding Basic Moves");
            AddBasicMoves();

            Console.WriteLine("Adding Special Moves");
            AddSpecialMoves();

            //AddGMMoves();
            //AddDungeonMoves();
            Console.WriteLine("Done");
            Console.ReadLine();


        }

        /*
        private static void Check(dynamic a, dynamic b)
        {


            if (a.name == b.name &&
                a.description == b.description &&
                a.key == b.key)
            {

            }
            else
            {
                Console.WriteLine($"{a.name} doesn't match");

            }
        }
        */

        private static void AddMoves()
        {
            Console.WriteLine("  Adding Moves");
            AddNewMove(root.moves.a_little_help_from_my_friends);
            AddNewMove(root.moves.a_port_in_the_storm);
            AddNewMove(root.moves.an_ear_for_magic);
            AddNewMove(root.moves.arcane_art);
            AddNewMove(root.moves.bamboozle);
            AddNewMove(root.moves.bard_elf);
            AddNewMove(root.moves.bard_human);
            AddNewMove(root.moves.bardic_lore);
            AddNewMove(root.moves.charming_and_open);
            AddNewMove(root.moves.con);
            AddNewMove(root.moves.devious);
            AddNewMove(root.moves.duelists_block);
            AddNewMove(root.moves.duelists_parry);
            AddNewMove(root.moves.eldritch_chord);
            AddNewMove(root.moves.eldritch_tones);
            AddNewMove(root.moves.healing_chorus);
            AddNewMove(root.moves.healing_song);
            AddNewMove(root.moves.it_goes_to_eleven);
            AddNewMove(root.moves.metal_hurlant);
            AddNewMove(root.moves.reputation);
            AddNewMove(root.moves.unforgettable_face);
            AddNewMove(root.moves.vicious_blast);
            AddNewMove(root.moves.vicious_cacophony);
            AddNewMove(root.moves.deity);
            AddNewMove(root.moves.divine_guidance);
            AddNewMove(root.moves.turn_undead);
            AddNewMove(root.moves.commune);
            AddNewMove(root.moves.cast_a_spell_cleric);
            AddNewMove(root.moves.cleric_dwarf);
            AddNewMove(root.moves.cleric_human);
            AddNewMove(root.moves.chosen_one);
            AddNewMove(root.moves.invigorate);
            AddNewMove(root.moves.the_scales_of_life_and_death);
            AddNewMove(root.moves.serenity);
            AddNewMove(root.moves.first_aid);
            AddNewMove(root.moves.divine_intervention);
            AddNewMove(root.moves.penitent);
            AddNewMove(root.moves.empower);
            AddNewMove(root.moves.orison_for_guidance);
            AddNewMove(root.moves.divine_protection);
            AddNewMove(root.moves.devoted_healer);
            AddNewMove(root.moves.anointed);
            AddNewMove(root.moves.apotheosis);
            AddNewMove(root.moves.reaper);
            AddNewMove(root.moves.providence);
            AddNewMove(root.moves.greater_first_aid);
            AddNewMove(root.moves.divine_invincibility);
            AddNewMove(root.moves.martyr);
            AddNewMove(root.moves.divine_armor);
            AddNewMove(root.moves.greater_empower);
            AddNewMove(root.moves.multiclass_dabbler);
            AddNewMove(root.moves.born_of_the_soil);
            AddNewMove(root.moves.by_nature_sustained);
            AddNewMove(root.moves.spirit_tongue);
            AddNewMove(root.moves.shapeshifter);
            AddNewMove(root.moves.studied_essence);
            AddNewMove(root.moves.druid_elf);
            AddNewMove(root.moves.druid_human);
            AddNewMove(root.moves.druid_halfling);
            AddNewMove(root.moves.hunters_brother);
            AddNewMove(root.moves.red_of_tooth_and_claw);
            AddNewMove(root.moves.communion_of_whispers);
            AddNewMove(root.moves.barkskin);
            AddNewMove(root.moves.eyes_of_the_tiger);
            AddNewMove(root.moves.shed);
            AddNewMove(root.moves.thing_talker);
            AddNewMove(root.moves.formcrafter);
            AddNewMove(root.moves.elemental_mastery);
            AddNewMove(root.moves.balance);
            AddNewMove(root.moves.embracing_no_form);
            AddNewMove(root.moves.doppelgängers_dance);
            AddNewMove(root.moves.blood_and_thunder);
            AddNewMove(root.moves.the_druid_sleep);
            AddNewMove(root.moves.world_talker);
            AddNewMove(root.moves.stalkers_sister);
            AddNewMove(root.moves.formshaper);
            AddNewMove(root.moves.chimera);
            AddNewMove(root.moves.weather_weaver);
            AddNewMove(root.moves.bend_bars_lift_gates);
            AddNewMove(root.moves.armored);
            AddNewMove(root.moves.signature_weapon);
            AddNewMove(root.moves.fighter_dwarf);
            AddNewMove(root.moves.fighter_elf);
            AddNewMove(root.moves.fighter_halfling);
            AddNewMove(root.moves.fighter_human);
            AddNewMove(root.moves.merciless);
            AddNewMove(root.moves.heirloom);
            AddNewMove(root.moves.armor_mastery);
            AddNewMove(root.moves.improved_weapon);
            AddNewMove(root.moves.seeing_red);
            AddNewMove(root.moves.interrogator);
            AddNewMove(root.moves.scent_of_blood);
            AddNewMove(root.moves.iron_hide);
            AddNewMove(root.moves.blacksmith);
            AddNewMove(root.moves.bloodthirsty);
            AddNewMove(root.moves.armored_perfection);
            AddNewMove(root.moves.evil_eye);
            AddNewMove(root.moves.taste_of_blood);
            AddNewMove(root.moves.multiclass_initiate);
            AddNewMove(root.moves.steel_hide);
            AddNewMove(root.moves.through_deaths_eyes);
            AddNewMove(root.moves.eye_for_weaponry);
            AddNewMove(root.moves.superior_warrior);
            AddNewMove(root.moves.lay_on_hands_cha);
            AddNewMove(root.moves.i_am_the_law);
            AddNewMove(root.moves.quest);
            AddNewMove(root.moves.paladin_human);
            AddNewMove(root.moves.divine_favor);
            AddNewMove(root.moves.bloody_aegis);
            AddNewMove(root.moves.smite);
            AddNewMove(root.moves.exterminatus);
            AddNewMove(root.moves.charge);
            AddNewMove(root.moves.staunch_defender);
            AddNewMove(root.moves.setup_strike);
            AddNewMove(root.moves.holy_protection);
            AddNewMove(root.moves.voice_of_authority);
            AddNewMove(root.moves.hospitaller);
            AddNewMove(root.moves.evidence_of_faith);
            AddNewMove(root.moves.holy_smite);
            AddNewMove(root.moves.ever_onward);
            AddNewMove(root.moves.impervious_defender);
            AddNewMove(root.moves.tandem_strike);
            AddNewMove(root.moves.divine_authority);
            AddNewMove(root.moves.perfect_hospitaller);
            AddNewMove(root.moves.indomitable);
            AddNewMove(root.moves.perfect_knight);
            AddNewMove(root.moves.hunt_and_track_wis);
            AddNewMove(root.moves.called_shot);
            AddNewMove(root.moves.animal_companion);
            AddNewMove(root.moves.command);
            AddNewMove(root.moves.ranger_elf);
            AddNewMove(root.moves.ranger_human);
            AddNewMove(root.moves.half_elven);
            AddNewMove(root.moves.wild_empathy);
            AddNewMove(root.moves.familiar_prey);
            AddNewMove(root.moves.vipers_strike);
            AddNewMove(root.moves.camouflage);
            AddNewMove(root.moves.mans_best_friend);
            AddNewMove(root.moves.blot_out_the_sun);
            AddNewMove(root.moves.well_trained);
            AddNewMove(root.moves.god_amidst_the_wastes);
            AddNewMove(root.moves.follow_me);
            AddNewMove(root.moves.a_safe_place);
            AddNewMove(root.moves.wild_speech);
            AddNewMove(root.moves.hunters_prey);
            AddNewMove(root.moves.vipers_fangs);
            AddNewMove(root.moves.smaugs_belly);
            AddNewMove(root.moves.strider);
            AddNewMove(root.moves.a_safer_place);
            AddNewMove(root.moves.observant);
            AddNewMove(root.moves.special_trick);
            AddNewMove(root.moves.unnatural_ally);
            AddNewMove(root.moves.trap_expert);
            AddNewMove(root.moves.tricks_of_the_trade);
            AddNewMove(root.moves.backstab);
            AddNewMove(root.moves.flexible_morals);
            AddNewMove(root.moves.poisoner);
            AddNewMove(root.moves.thief_halfling);
            AddNewMove(root.moves.thief_human);
            AddNewMove(root.moves.cheap_shot);
            AddNewMove(root.moves.cautious);
            AddNewMove(root.moves.wealth_and_taste);
            AddNewMove(root.moves.shoot_first);
            AddNewMove(root.moves.poison_master);
            AddNewMove(root.moves.envenom);
            AddNewMove(root.moves.brewer);
            AddNewMove(root.moves.underdog);
            AddNewMove(root.moves.connections);
            AddNewMove(root.moves.dirty_fighter);
            AddNewMove(root.moves.extremely_cautious);
            AddNewMove(root.moves.alchemist);
            AddNewMove(root.moves.serious_underdog);
            AddNewMove(root.moves.evasion);
            AddNewMove(root.moves.strong_arm_true_aim);
            AddNewMove(root.moves.escape_route);
            AddNewMove(root.moves.disguise);
            AddNewMove(root.moves.heist);
            AddNewMove(root.moves.prodigy);
            AddNewMove(root.moves.empowered_magic);
            AddNewMove(root.moves.fount_of_knowledge);
            AddNewMove(root.moves.know_it_all);
            AddNewMove(root.moves.expanded_spellbook);
            AddNewMove(root.moves.enchanter);
            AddNewMove(root.moves.logical);
            AddNewMove(root.moves.arcane_ward);
            AddNewMove(root.moves.counterspell);
            AddNewMove(root.moves.quick_study);
            AddNewMove(root.moves.master);
            AddNewMove(root.moves.greater_empowered_magic);
            AddNewMove(root.moves.enchanters_soul);
            AddNewMove(root.moves.highly_logical);
            AddNewMove(root.moves.arcane_armor);
            AddNewMove(root.moves.protective_counter);
            AddNewMove(root.moves.ethereal_tether);
            AddNewMove(root.moves.mystical_puppet_strings);
            AddNewMove(root.moves.spell_augmentation);
            AddNewMove(root.moves.self_powered);
            AddNewMove(root.moves.spellbook);
            AddNewMove(root.moves.prepare_spells);
            AddNewMove(root.moves.cast_a_spell_wizard);
            AddNewMove(root.moves.spell_defense);
            AddNewMove(root.moves.ritual);
            AddNewMove(root.moves.wizard_elf);
            AddNewMove(root.moves.wizard_human);
            AddNewMove(root.moves.aid_or_interfere);
            AddNewMove(root.moves.defend);
            AddNewMove(root.moves.defy_danger);
            AddNewMove(root.moves.discern_realities);
            AddNewMove(root.moves.encumbrance);
            AddNewMove(root.moves.hack_and_slash);
            AddNewMove(root.moves.last_breath);
            AddNewMove(root.moves.make_camp);
            AddNewMove(root.moves.multiclass_master);
            AddNewMove(root.moves.parley);
            AddNewMove(root.moves.spout_lore);
            AddNewMove(root.moves.take_watch);
            AddNewMove(root.moves.undertake_a_perilous_journey);
            AddNewMove(root.moves.volley);


        }

        private static void AddBasicMoves()
        {

            ctx.BasicMoves_CreateIfMissing(ctx.Moves_Read("hack_and_slash").GetAwaiter().GetResult()).GetAwaiter();
            ctx.BasicMoves_CreateIfMissing(ctx.Moves_Read("defy_danger").GetAwaiter().GetResult()).GetAwaiter();
            ctx.BasicMoves_CreateIfMissing(ctx.Moves_Read("defend").GetAwaiter().GetResult()).GetAwaiter();
            ctx.BasicMoves_CreateIfMissing(ctx.Moves_Read("volley").GetAwaiter().GetResult()).GetAwaiter();
            ctx.BasicMoves_CreateIfMissing(ctx.Moves_Read("discern_realities").GetAwaiter().GetResult()).GetAwaiter();
            ctx.BasicMoves_CreateIfMissing(ctx.Moves_Read("parley").GetAwaiter().GetResult()).GetAwaiter();
            ctx.BasicMoves_CreateIfMissing(ctx.Moves_Read("spout_lore").GetAwaiter().GetResult()).GetAwaiter();
            ctx.BasicMoves_CreateIfMissing(ctx.Moves_Read("aid_or_interfere").GetAwaiter().GetResult()).GetAwaiter();
        }

        private static void AddSpecialMoves()
        {

            ctx.SpecialMoves_CreateIfMissing(ctx.Moves_Read("encumbrance").GetAwaiter().GetResult()).GetAwaiter();
            ctx.SpecialMoves_CreateIfMissing(ctx.Moves_Read("make_camp").GetAwaiter().GetResult()).GetAwaiter();
            ctx.SpecialMoves_CreateIfMissing(ctx.Moves_Read("take_watch").GetAwaiter().GetResult()).GetAwaiter();
            ctx.SpecialMoves_CreateIfMissing(ctx.Moves_Read("undertake_a_perilous_journey").GetAwaiter().GetResult()).GetAwaiter();
            ctx.SpecialMoves_CreateIfMissing(ctx.Moves_Read("last_breath").GetAwaiter().GetResult()).GetAwaiter();
            ctx.SpecialMoves_CreateIfMissing(ctx.Moves_Read("end_of_session").GetAwaiter().GetResult()).GetAwaiter();
            ctx.SpecialMoves_CreateIfMissing(ctx.Moves_Read("level_up").GetAwaiter().GetResult()).GetAwaiter();
            ctx.SpecialMoves_CreateIfMissing(ctx.Moves_Read("carouse").GetAwaiter().GetResult()).GetAwaiter();
            ctx.SpecialMoves_CreateIfMissing(ctx.Moves_Read("supply").GetAwaiter().GetResult()).GetAwaiter();
            ctx.SpecialMoves_CreateIfMissing(ctx.Moves_Read("recover").GetAwaiter().GetResult()).GetAwaiter();
            ctx.SpecialMoves_CreateIfMissing(ctx.Moves_Read("recruit").GetAwaiter().GetResult()).GetAwaiter();
            ctx.SpecialMoves_CreateIfMissing(ctx.Moves_Read("outstanding_warrants").GetAwaiter().GetResult()).GetAwaiter();
            ctx.SpecialMoves_CreateIfMissing(ctx.Moves_Read("bolster").GetAwaiter().GetResult()).GetAwaiter();

        }


        private static void AddDmMoves()
        {

        }

        private static void AddNewMove(dynamic y)
        {
            string name = y.name;
            string key = y.key;
            string description = y.description;
            string? requires = null;
            string? replaces = null;
            try
            {
                requires = y.requires;
            }
            catch
            { }
            try
            {
                replaces = y.replaces;
            }
            catch
            { }

            bool exists = Task.Run(() => ctx.Moves_DoesKeyExist(key)).GetAwaiter().GetResult();


            if (!exists)
            {
                if (Task.Run(() => ctx.Moves_Create(name, key, description, requires, replaces)).GetAwaiter().GetResult() == true)
                {
                    Console.WriteLine($"    Added {key}");
                }
                else
                {
                    Console.WriteLine($"    Skipped for valid reason {key}");
                }
            }
            else
            {
                Console.WriteLine($"    Skipping {key}");
            }
        }

        private static void AddBasicMove(string key)
        {
            var m = ctx.Moves_Read(key);

            if (m != null)
            {

            }
        }


    }
}


