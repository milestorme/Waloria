﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SpellGenerator
{
    public struct Spell
    {
        public uint Entry;
        public uint Category;
        public uint Dispel;
        public uint Mechanic;
        public uint Attributes;
        public uint AttributesEx;
        public uint AttributesEx2;
        public uint AttributesEx3;
        public uint AttributesEx4;
        public uint AttributesEx5;
        public uint AttributesEx6;
        public uint AttributesEx7;
        public uint Stances;
        public uint unk_320_2;
        public uint StancesNot;
        public uint unk_320_3;
        public uint Targets;
        public uint TargetCreatureType;
        public uint requiresSpellFocus;
        public uint FacingCasterFlags;
        public uint CasterAuraState;
        public uint TargetAuraState;
        public uint CasterAuraStateNot;
        public uint TargetAuraStateNot;
        public uint casterAuraSpell;
        public uint targetAuraSpell;
        public uint excludeCasterAuraSpell;
        public uint excludeTargetAuraSpell;
        public uint CastingTimeIndex;
        public uint RecoveryTime;
        public uint CategoryRecoveryTime;
        public uint interruptFlags;
        public uint AuraInterruptFlags;
        public uint ChannelInterruptFlags;
        public uint procFlags;
        public uint procChance;
        public uint procCharges;
        public uint maxLevel;
        public uint baseLevel;
        public uint spellLevel;
        public uint DurationIndex;
        public uint powerType;
        public uint manaCost;
        public uint manaCostPerlevel;
        public uint manaPerSecond;
        public uint manaPerSecondPerLevel;
        public uint rangeIndex;
        public float speed;
        public uint modalNextSpell;
        public uint StackAmount;
        public uint Totem1;
        public uint Totem2;
        public int Reagent1;
        public int Reagent2;
        public int Reagent3;
        public int Reagent4;
        public int Reagent5;
        public int Reagent6;
        public int Reagent7;
        public int Reagent8;
        public uint ReagentCount1;
        public uint ReagentCount2;
        public uint ReagentCount3;
        public uint ReagentCount4;
        public uint ReagentCount5;
        public uint ReagentCount6;
        public uint ReagentCount7;
        public uint ReagentCount8;
        public int EquippedItemClass;
        public int EquippedItemSubClassMask;
        public int EquippedItemInventoryTypeMask;
        public uint Effect1;
        public uint Effect2;
        public uint Effect3;
        public int EffectDieSides1;
        public int EffectDieSides2;
        public int EffectDieSides3;
        public float EffectRealPointsPerLevel1;
        public float EffectRealPointsPerLevel2;
        public float EffectRealPointsPerLevel3;
        public int EffectBasePoints1;
        public int EffectBasePoints2;
        public int EffectBasePoints3;
        public uint EffectMechanic1;
        public uint EffectMechanic2;
        public uint EffectMechanic3;
        public uint EffectImplicitTargetA1;
        public uint EffectImplicitTargetA2;
        public uint EffectImplicitTargetA3;
        public uint EffectImplicitTargetB1;
        public uint EffectImplicitTargetB2;
        public uint EffectImplicitTargetB3;
        public uint EffectRadiusIndex1;
        public uint EffectRadiusIndex2;
        public uint EffectRadiusIndex3;
        public uint EffectApplyAuraName1;
        public uint EffectApplyAuraName2;
        public uint EffectApplyAuraName3;
        public uint EffectAmplitude1;
        public uint EffectAmplitude2;
        public uint EffectAmplitude3;
        public float EffectValueMultiplier1;
        public float EffectValueMultiplier2;
        public float EffectValueMultiplier3;
        public uint EffectChainTarget1;
        public uint EffectChainTarget2;
        public uint EffectChainTarget3;
        public uint EffectItemType1;
        public uint EffectItemType2;
        public uint EffectItemType3;
        public int EffectMiscValue1;
        public int EffectMiscValue2;
        public int EffectMiscValue3;
        public int EffectMiscValueB1;
        public int EffectMiscValueB2;
        public int EffectMiscValueB3;
        public uint EffectTriggerSpell1;
        public uint EffectTriggerSpell2;
        public uint EffectTriggerSpell3;
        public float EffectPointsPerComboPoint1;
        public float EffectPointsPerComboPoint2;
        public float EffectPointsPerComboPoint3;
        public uint EffectSpellClassMask1;
        public uint EffectSpellClassMask2;
        public uint EffectSpellClassMask3;
        public uint EffectSpellClassMask4;
        public uint EffectSpellClassMask5;
        public uint EffectSpellClassMask6;
        public uint EffectSpellClassMask7;
        public uint EffectSpellClassMask8;
        public uint EffectSpellClassMask9;
        public uint SpellVisual1;
        public uint SpellVisual2;
        public uint SpellIconID;
        public uint activeIconID;
        public uint spellPriority;
        public UInt32 SpellName_0;
        public UInt32 SpellName_1;
        public UInt32 SpellName_2;
        public UInt32 SpellName_3;
        public UInt32 SpellName_4;
        public UInt32 SpellName_5;
        public UInt32 SpellName_6;
        public UInt32 SpellName_7;
        public UInt32 SpellName_8;
        public UInt32 SpellName_9;
        public UInt32 SpellName_10;
        public UInt32 SpellName_11;
        public UInt32 SpellName_12;
        public UInt32 SpellName_13;
        public UInt32 SpellName_14;
        public UInt32 SpellName_15;
        public uint SpellNameFlag;
        public UInt32 Rank_0;
        public UInt32 Rank_1;
        public UInt32 Rank_2;
        public UInt32 Rank_3;
        public UInt32 Rank_4;
        public UInt32 Rank_5;
        public UInt32 Rank_6;
        public UInt32 Rank_7;
        public UInt32 Rank_8;
        public UInt32 Rank_9;
        public UInt32 Rank_10;
        public UInt32 Rank_11;
        public UInt32 Rank_12;
        public UInt32 Rank_13;
        public UInt32 Rank_14;
        public UInt32 Rank_15;
        public uint RankFlags;
        public UInt32 Description_0;
        public UInt32 Description_1;
        public UInt32 Description_2;
        public UInt32 Description_3;
        public UInt32 Description_4;
        public UInt32 Description_5;
        public UInt32 Description_6;
        public UInt32 Description_7;
        public UInt32 Description_8;
        public UInt32 Description_9;
        public UInt32 Description_10;
        public UInt32 Description_11;
        public UInt32 Description_12;
        public UInt32 Description_13;
        public UInt32 Description_14;
        public UInt32 Description_15;
        public uint DescriptionFlags;
        public UInt32 ToolTip_0;
        public UInt32 ToolTip_1;
        public UInt32 ToolTip_2;
        public UInt32 ToolTip_3;
        public UInt32 ToolTip_4;
        public UInt32 ToolTip_5;
        public UInt32 ToolTip_6;
        public UInt32 ToolTip_7;
        public UInt32 ToolTip_8;
        public UInt32 ToolTip_9;
        public UInt32 ToolTip_10;
        public UInt32 ToolTip_11;
        public UInt32 ToolTip_12;
        public UInt32 ToolTip_13;
        public UInt32 ToolTip_14;
        public UInt32 ToolTip_15;
        public uint ToolTipFlags;
        public uint ManaCostPercentage;
        public uint StartRecoveryCategory;
        public uint StartRecoveryTime;
        public uint MaxTargetLevel;
        public uint SpellFamilyName;
        public uint SpellFamilyFlagsLow;
        public uint SpellFamilyFlagsHigh;
        public uint SpellFamilyFlags2;
        public uint MaxAffectedTargets;
        public uint DmgClass;
        public uint PreventionType;
        public uint StanceBarOrder;
        public float EffectDamageMultiplier1;
        public float EffectDamageMultiplier2;
        public float EffectDamageMultiplier3;
        public uint MinFactionId;
        public uint MinReputation;
        public uint RequiredAuraVision;
        public uint TotemCategory1;
        public uint TotemCategory2;
        public int AreaGroupId;
        public uint SchoolMask;
        public uint runeCostID;
        public uint spellMissileID;
        public uint PowerDisplayId;
        public float EffectBonusMultiplier1;
        public float EffectBonusMultiplier2;
        public float EffectBonusMultiplier3;
        public uint spellDescriptionVariableID;
        public uint SpellDifficultyId;
    }
}
