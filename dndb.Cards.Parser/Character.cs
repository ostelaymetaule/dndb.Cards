using System;
using System.Collections.Generic;
using System.Text;

namespace dndb.Cards.Parser.Character
{
    
        using System;
        using System.Collections.Generic;

        using System.Globalization;
        using Newtonsoft.Json;
        using Newtonsoft.Json.Converters;

        public partial class CharacterData
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("success")]
            public bool Success { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("data")]
            public Data Data { get; set; }

            [JsonProperty("pagination")]
            public object Pagination { get; set; }
        }

        public partial class Data
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("readonlyUrl")]
            public Uri ReadonlyUrl { get; set; }

            [JsonProperty("avatarUrl")]
            public Uri AvatarUrl { get; set; }

            [JsonProperty("frameAvatarUrl")]
            public Uri FrameAvatarUrl { get; set; }

            [JsonProperty("backdropAvatarUrl")]
            public Uri BackdropAvatarUrl { get; set; }

            [JsonProperty("smallBackdropAvatarUrl")]
            public Uri SmallBackdropAvatarUrl { get; set; }

            [JsonProperty("largeBackdropAvatarUrl")]
            public Uri LargeBackdropAvatarUrl { get; set; }

            [JsonProperty("thumbnailBackdropAvatarUrl")]
            public Uri ThumbnailBackdropAvatarUrl { get; set; }

            [JsonProperty("defaultBackdrop")]
            public DefaultBackdrop DefaultBackdrop { get; set; }

            [JsonProperty("avatarId")]
            public long AvatarId { get; set; }

            [JsonProperty("frameAvatarId")]
            public long FrameAvatarId { get; set; }

            [JsonProperty("backdropAvatarId")]
            public long BackdropAvatarId { get; set; }

            [JsonProperty("smallBackdropAvatarId")]
            public long SmallBackdropAvatarId { get; set; }

            [JsonProperty("largeBackdropAvatarId")]
            public long LargeBackdropAvatarId { get; set; }

            [JsonProperty("thumbnailBackdropAvatarId")]
            public long ThumbnailBackdropAvatarId { get; set; }

            [JsonProperty("themeColorId")]
            public long ThemeColorId { get; set; }

            [JsonProperty("themeColor")]
            public ThemeColor ThemeColor { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("socialName")]
            public object SocialName { get; set; }

            [JsonProperty("gender")]
            public object Gender { get; set; }

            [JsonProperty("faith")]
            public string Faith { get; set; }

            [JsonProperty("age")]
            public object Age { get; set; }

            [JsonProperty("hair")]
            public object Hair { get; set; }

            [JsonProperty("eyes")]
            public object Eyes { get; set; }

            [JsonProperty("skin")]
            public object Skin { get; set; }

            [JsonProperty("height")]
            public object Height { get; set; }

            [JsonProperty("weight")]
            public object Weight { get; set; }

            [JsonProperty("inspiration")]
            public bool Inspiration { get; set; }

            [JsonProperty("baseHitPoints")]
            public long BaseHitPoints { get; set; }

            [JsonProperty("bonusHitPoints")]
            public object BonusHitPoints { get; set; }

            [JsonProperty("overrideHitPoints")]
            public object OverrideHitPoints { get; set; }

            [JsonProperty("removedHitPoints")]
            public long RemovedHitPoints { get; set; }

            [JsonProperty("temporaryHitPoints")]
            public long TemporaryHitPoints { get; set; }

            [JsonProperty("currentXp")]
            public long CurrentXp { get; set; }

            [JsonProperty("alignmentId")]
            public long AlignmentId { get; set; }

            [JsonProperty("lifestyleId")]
            public long LifestyleId { get; set; }

            [JsonProperty("stats")]
            public List<BonusStatElement> Stats { get; set; }

            [JsonProperty("bonusStats")]
            public List<BonusStatElement> BonusStats { get; set; }

            [JsonProperty("overrideStats")]
            public List<BonusStatElement> OverrideStats { get; set; }

            [JsonProperty("background")]
            public DataBackground Background { get; set; }

            [JsonProperty("race")]
            public Race Race { get; set; }

            [JsonProperty("raceDefinitionId")]
            public object RaceDefinitionId { get; set; }

            [JsonProperty("raceDefinitionTypeId")]
            public object RaceDefinitionTypeId { get; set; }

            [JsonProperty("notes")]
            public Notes Notes { get; set; }

            [JsonProperty("traits")]
            public Traits Traits { get; set; }

            [JsonProperty("preferences")]
            public Preferences Preferences { get; set; }

            [JsonProperty("configuration")]
            public Configuration Configuration { get; set; }

            [JsonProperty("lifestyle")]
            public object Lifestyle { get; set; }

            [JsonProperty("inventory")]
            public List<Inventory> Inventory { get; set; }

            [JsonProperty("currencies")]
            public Currencies Currencies { get; set; }

            [JsonProperty("classes")]
            public List<DataClass> Classes { get; set; }

            [JsonProperty("feats")]
            public List<Feat> Feats { get; set; }

            [JsonProperty("customDefenseAdjustments")]
            public List<object> CustomDefenseAdjustments { get; set; }

            [JsonProperty("customSenses")]
            public List<object> CustomSenses { get; set; }

            [JsonProperty("customSpeeds")]
            public List<object> CustomSpeeds { get; set; }

            [JsonProperty("customProficiencies")]
            public List<object> CustomProficiencies { get; set; }

            [JsonProperty("spellDefenses")]
            public object SpellDefenses { get; set; }

            [JsonProperty("customActions")]
            public List<object> CustomActions { get; set; }

            [JsonProperty("characterValues")]
            public List<CharacterValue> CharacterValues { get; set; }

            [JsonProperty("conditions")]
            public List<object> Conditions { get; set; }

            [JsonProperty("deathSaves")]
            public DeathSaves DeathSaves { get; set; }

            [JsonProperty("adjustmentXp")]
            public object AdjustmentXp { get; set; }

            [JsonProperty("spellSlots")]
            public List<PactMagic> SpellSlots { get; set; }

            [JsonProperty("pactMagic")]
            public List<PactMagic> PactMagic { get; set; }

            [JsonProperty("activeSourceCategories")]
            public List<long> ActiveSourceCategories { get; set; }

            [JsonProperty("spells")]
            public Choices Spells { get; set; }

            [JsonProperty("options")]
            public Tions Options { get; set; }

            [JsonProperty("choices")]
            public Choices Choices { get; set; }

            [JsonProperty("actions")]
            public Tions Actions { get; set; }

            [JsonProperty("modifiers")]
            public Modifiers Modifiers { get; set; }

            [JsonProperty("classSpells")]
            public List<ClassSpell> ClassSpells { get; set; }

            [JsonProperty("customItems")]
            public List<CustomItem> CustomItems { get; set; }

            [JsonProperty("campaign")]
            public Campaign Campaign { get; set; }

            [JsonProperty("creatures")]
            public List<Creature> Creatures { get; set; }
        }

        public partial class Tions
        {
            [JsonProperty("background")]
            public object Background { get; set; }

            [JsonProperty("class")]
            public List<FeatElement> Class { get; set; }

            [JsonProperty("feat")]
            public List<FeatElement> Feat { get; set; }

            [JsonProperty("item")]
            public object Item { get; set; }

            [JsonProperty("race")]
            public List<object> Race { get; set; }
        }

        public partial class FeatElement
        {
            [JsonProperty("abilityModifierStatId")]
            public object AbilityModifierStatId { get; set; }

            [JsonProperty("actionType")]
            public long ActionType { get; set; }

            [JsonProperty("activation")]
            public Activation Activation { get; set; }

            [JsonProperty("attackSubtype")]
            public object AttackSubtype { get; set; }

            [JsonProperty("attackTypeRange")]
            public object AttackTypeRange { get; set; }

            [JsonProperty("componentId")]
            public long ComponentId { get; set; }

            [JsonProperty("componentTypeId")]
            public long ComponentTypeId { get; set; }

            [JsonProperty("damageTypeId")]
            public object DamageTypeId { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("dice")]
            public object Dice { get; set; }

            [JsonProperty("displayAsAttack")]
            public object DisplayAsAttack { get; set; }

            [JsonProperty("entityTypeId")]
            public long EntityTypeId { get; set; }

            [JsonProperty("fixedSaveDc")]
            public object FixedSaveDc { get; set; }

            [JsonProperty("fixedToHit")]
            public object FixedToHit { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("isMartialArts")]
            public bool IsMartialArts { get; set; }

            [JsonProperty("isProficient")]
            public bool IsProficient { get; set; }

            [JsonProperty("limitedUse")]
            public ClassLimitedUse LimitedUse { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("numberOfTargets")]
            public object NumberOfTargets { get; set; }

            [JsonProperty("onMissDescription")]
            public string OnMissDescription { get; set; }

            [JsonProperty("range")]
            public ClassRange Range { get; set; }

            [JsonProperty("saveFailDescription")]
            public string SaveFailDescription { get; set; }

            [JsonProperty("saveStatId")]
            public object SaveStatId { get; set; }

            [JsonProperty("saveSuccessDescription")]
            public string SaveSuccessDescription { get; set; }

            [JsonProperty("snippet")]
            public string Snippet { get; set; }

            [JsonProperty("spellRangeType")]
            public object SpellRangeType { get; set; }

            [JsonProperty("value")]
            public object Value { get; set; }

            [JsonProperty("ammunition")]
            public object Ammunition { get; set; }
        }

        public partial class Activation
        {
            [JsonProperty("activationTime")]
            public long? ActivationTime { get; set; }

            [JsonProperty("activationType")]
            public long? ActivationType { get; set; }
        }

        public partial class ClassLimitedUse
        {
            [JsonProperty("maxNumberConsumed")]
            public long MaxNumberConsumed { get; set; }

            [JsonProperty("maxUses")]
            public long MaxUses { get; set; }

            [JsonProperty("minNumberConsumed")]
            public long MinNumberConsumed { get; set; }

            [JsonProperty("name")]
            public object Name { get; set; }

            [JsonProperty("numberUsed")]
            public long NumberUsed { get; set; }

            [JsonProperty("resetType")]
            public long ResetType { get; set; }

            [JsonProperty("statModifierUsesId")]
            public long? StatModifierUsesId { get; set; }

            [JsonProperty("operator")]
            public long Operator { get; set; }

            [JsonProperty("resetDice")]
            public object ResetDice { get; set; }
        }

        public partial class ClassRange
        {
            [JsonProperty("hasAoeSpecialDescription")]
            public bool HasAoeSpecialDescription { get; set; }

            [JsonProperty("aoeSize")]
            public object AoeSize { get; set; }

            [JsonProperty("aoeType")]
            public object AoeType { get; set; }

            [JsonProperty("longRange")]
            public object LongRange { get; set; }

            [JsonProperty("minimumRange")]
            public object MinimumRange { get; set; }

            [JsonProperty("range")]
            public object Range { get; set; }
        }

        public partial class DataBackground
        {
            [JsonProperty("customBackground")]
            public CustomBackground CustomBackground { get; set; }

            [JsonProperty("definition")]
            public BackgroundDefinition Definition { get; set; }

            [JsonProperty("definitionId")]
            public object DefinitionId { get; set; }

            [JsonProperty("hasCustomBackground")]
            public bool HasCustomBackground { get; set; }
        }

        public partial class CustomBackground
        {
            [JsonProperty("backgroundType")]
            public object BackgroundType { get; set; }

            [JsonProperty("characteristicsBackground")]
            public object CharacteristicsBackground { get; set; }

            [JsonProperty("characteristicsBackgroundDefinitionId")]
            public object CharacteristicsBackgroundDefinitionId { get; set; }

            [JsonProperty("description")]
            public object Description { get; set; }

            [JsonProperty("entityTypeId")]
            public long EntityTypeId { get; set; }

            [JsonProperty("featuresBackground")]
            public object FeaturesBackground { get; set; }

            [JsonProperty("featuresBackgroundDefinitionId")]
            public object FeaturesBackgroundDefinitionId { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("name")]
            public object Name { get; set; }
        }

        public partial class BackgroundDefinition
        {
            [JsonProperty("avatarUrl")]
            public object AvatarUrl { get; set; }

            [JsonProperty("bonds")]
            public List<Bond> Bonds { get; set; }

            [JsonProperty("contractsDescription")]
            public string ContractsDescription { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("entityTypeId")]
            public long EntityTypeId { get; set; }

            [JsonProperty("equipmentDescription")]
            public string EquipmentDescription { get; set; }

            [JsonProperty("featureDescription")]
            public string FeatureDescription { get; set; }

            [JsonProperty("featureName")]
            public string FeatureName { get; set; }

            [JsonProperty("flaws")]
            public List<Bond> Flaws { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("ideals")]
            public List<Bond> Ideals { get; set; }

            [JsonProperty("languagesDescription")]
            public string LanguagesDescription { get; set; }

            [JsonProperty("largeAvatarUrl")]
            public object LargeAvatarUrl { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("organization")]
            public object Organization { get; set; }

            [JsonProperty("personalityTraits")]
            public List<Bond> PersonalityTraits { get; set; }

            [JsonProperty("shortDescription")]
            public string ShortDescription { get; set; }

            [JsonProperty("skillProficienciesDescription")]
            public string SkillProficienciesDescription { get; set; }

            [JsonProperty("snippet")]
            public string Snippet { get; set; }

            [JsonProperty("spellsPostDescription")]
            public string SpellsPostDescription { get; set; }

            [JsonProperty("spellsPreDescription")]
            public string SpellsPreDescription { get; set; }

            [JsonProperty("suggestedCharacteristicsDescription")]
            public string SuggestedCharacteristicsDescription { get; set; }

            [JsonProperty("suggestedLanguages")]
            public object SuggestedLanguages { get; set; }

            [JsonProperty("suggestedProficiencies")]
            public object SuggestedProficiencies { get; set; }

            [JsonProperty("toolProficienciesDescription")]
            public string ToolProficienciesDescription { get; set; }

            [JsonProperty("isHomebrew")]
            public bool IsHomebrew { get; set; }

            [JsonProperty("sources")]
            public List<Source> Sources { get; set; }
        }

        public partial class Bond
        {
            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("diceRoll")]
            public long DiceRoll { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }
        }

        public partial class Source
        {
            [JsonProperty("sourceId")]
            public long SourceId { get; set; }

            [JsonProperty("pageNumber")]
            public long? PageNumber { get; set; }

            [JsonProperty("sourceType")]
            public long SourceType { get; set; }
        }

        public partial class BonusStatElement
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("name")]
            public object Name { get; set; }

            [JsonProperty("value")]
            public long? Value { get; set; }
        }

        public partial class Campaign
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("characters")]
            public List<Character> Characters { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("dmUserId")]
            public long DmUserId { get; set; }

            [JsonProperty("dmUsername")]
            public string DmUsername { get; set; }

            [JsonProperty("link")]
            public string Link { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("publicNotes")]
            public string PublicNotes { get; set; }
        }

        public partial class Character
        {
            [JsonProperty("avatarUrl")]
            public Uri AvatarUrl { get; set; }

            [JsonProperty("characterId")]
            public long CharacterId { get; set; }

            [JsonProperty("characterName")]
            public string CharacterName { get; set; }

            [JsonProperty("characterUrl")]
            public string CharacterUrl { get; set; }

            [JsonProperty("privacyType")]
            public long PrivacyType { get; set; }

            [JsonProperty("userId")]
            public long UserId { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("campaignId")]
            public object CampaignId { get; set; }
        }

        public partial class CharacterValue
        {
            [JsonProperty("contextId")]
            public object ContextId { get; set; }

            [JsonProperty("contextTypeId")]
            public object ContextTypeId { get; set; }

            [JsonProperty("notes")]
            public object Notes { get; set; }

            [JsonProperty("typeId")]
            public long TypeId { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }

            [JsonProperty("valueId")]
            public long ValueId { get; set; }

            [JsonProperty("valueTypeId")]
            public long ValueTypeId { get; set; }
        }

        public partial class Choices
        {
            [JsonProperty("background")]
            public List<RaceElement> Background { get; set; }

            [JsonProperty("class")]
            public List<RaceElement> Class { get; set; }

            [JsonProperty("feat")]
            public List<object> Feat { get; set; }

            [JsonProperty("item")]
            public List<object> Item { get; set; }

            [JsonProperty("race")]
            public List<RaceElement> Race { get; set; }
        }

        public partial class RaceElement
        {
            [JsonProperty("componentId")]
            public long ComponentId { get; set; }

            [JsonProperty("componentTypeId")]
            public long ComponentTypeId { get; set; }

            [JsonProperty("defaultSubtypes")]
            public List<string> DefaultSubtypes { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("isInfinite")]
            public bool IsInfinite { get; set; }

            [JsonProperty("isOptional")]
            public bool IsOptional { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("options")]
            public List<Option> Options { get; set; }

            [JsonProperty("optionValue")]
            public long OptionValue { get; set; }

            [JsonProperty("parentChoiceId")]
            public string ParentChoiceId { get; set; }

            [JsonProperty("subType")]
            public long? SubType { get; set; }

            [JsonProperty("type")]
            public long Type { get; set; }

            [JsonProperty("displayOrder")]
            public object DisplayOrder { get; set; }
        }

        public partial class Option
        {
            [JsonProperty("description")]
            public object Description { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }
        }

        public partial class ClassSpell
        {
            [JsonProperty("characterClassId")]
            public long CharacterClassId { get; set; }

            [JsonProperty("entityTypeId")]
            public long EntityTypeId { get; set; }

            [JsonProperty("spells")]
            public List<Spell> Spells { get; set; }
        }

        public partial class Spell
        {
            [JsonProperty("activation")]
            public Activation Activation { get; set; }

            [JsonProperty("additionalDescription")]
            public object AdditionalDescription { get; set; }

            [JsonProperty("alwaysPrepared")]
            public bool AlwaysPrepared { get; set; }

            [JsonProperty("atWillLimitedUseLevel")]
            public object AtWillLimitedUseLevel { get; set; }

            [JsonProperty("baseLevelAtWill")]
            public bool BaseLevelAtWill { get; set; }

            [JsonProperty("castAtLevel")]
            public object CastAtLevel { get; set; }

            [JsonProperty("castOnlyAsRitual")]
            public bool CastOnlyAsRitual { get; set; }

            [JsonProperty("componentId")]
            public long ComponentId { get; set; }

            [JsonProperty("componentTypeId")]
            public long ComponentTypeId { get; set; }

            [JsonProperty("countsAsKnownSpell")]
            public bool CountsAsKnownSpell { get; set; }

            [JsonProperty("definition")]
            public SpellDefinition Definition { get; set; }

            [JsonProperty("definitionId")]
            public long DefinitionId { get; set; }

            [JsonProperty("displayAsAttack")]
            public object DisplayAsAttack { get; set; }

            [JsonProperty("entityTypeId")]
            public long EntityTypeId { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("isSignatureSpell")]
            public object IsSignatureSpell { get; set; }

            [JsonProperty("limitedUse")]
            public object LimitedUse { get; set; }

            [JsonProperty("overrideSaveDc")]
            public object OverrideSaveDc { get; set; }

            [JsonProperty("prepared")]
            public bool Prepared { get; set; }

            [JsonProperty("range")]
            public DefinitionRange Range { get; set; }

            [JsonProperty("restriction")]
            public object Restriction { get; set; }

            [JsonProperty("ritualCastingType")]
            public object RitualCastingType { get; set; }

            [JsonProperty("spellCastingAbilityId")]
            public object SpellCastingAbilityId { get; set; }

            [JsonProperty("usesSpellSlot")]
            public bool UsesSpellSlot { get; set; }
        }

        public partial class SpellDefinition
        {
            [JsonProperty("activation")]
            public Activation Activation { get; set; }

            [JsonProperty("asPartOfWeaponAttack")]
            public bool AsPartOfWeaponAttack { get; set; }

            [JsonProperty("atHigherLevels")]
            public AtHigherLevels AtHigherLevels { get; set; }

            [JsonProperty("attackType")]
            public long? AttackType { get; set; }

            [JsonProperty("canCastAtHigherLevel")]
            public bool CanCastAtHigherLevel { get; set; }

            [JsonProperty("castingTimeDescription")]
            public string CastingTimeDescription { get; set; }

            [JsonProperty("components")]
            public List<long> Components { get; set; }

            [JsonProperty("componentsDescription")]
            public string ComponentsDescription { get; set; }

            [JsonProperty("concentration")]
            public bool Concentration { get; set; }

            [JsonProperty("conditions")]
            public List<Condition> Conditions { get; set; }

            [JsonProperty("damageEffect")]
            public object DamageEffect { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("duration")]
            public Duration Duration { get; set; }

            [JsonProperty("healing")]
            public object Healing { get; set; }

            [JsonProperty("healingDice")]
            public List<object> HealingDice { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("isHomebrew")]
            public bool IsHomebrew { get; set; }

            [JsonProperty("level")]
            public long Level { get; set; }

            [JsonProperty("modifiers")]
            public List<BackgroundElement> Modifiers { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("range")]
            public DefinitionRange Range { get; set; }

            [JsonProperty("rangeArea")]
            public object RangeArea { get; set; }

            [JsonProperty("requiresAttackRoll")]
            public bool RequiresAttackRoll { get; set; }

            [JsonProperty("requiresSavingThrow")]
            public bool RequiresSavingThrow { get; set; }

            [JsonProperty("ritual")]
            public bool Ritual { get; set; }

            [JsonProperty("saveDcAbilityId")]
            public long? SaveDcAbilityId { get; set; }

            [JsonProperty("school")]
            public string School { get; set; }

            [JsonProperty("snippet")]
            public string Snippet { get; set; }

            [JsonProperty("sourceId")]
            public object SourceId { get; set; }

            [JsonProperty("sourcePageNumber")]
            public long SourcePageNumber { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("tempHpDice")]
            public List<object> TempHpDice { get; set; }

            [JsonProperty("version")]
            public object Version { get; set; }

            [JsonProperty("sources")]
            public List<Source> Sources { get; set; }
        }

        public partial class AtHigherLevels
        {
            [JsonProperty("additionalAttacks")]
            public List<object> AdditionalAttacks { get; set; }

            [JsonProperty("additionalTargets")]
            public List<object> AdditionalTargets { get; set; }

            [JsonProperty("areaOfEffect")]
            public List<object> AreaOfEffect { get; set; }

            [JsonProperty("creatures")]
            public List<object> Creatures { get; set; }

            [JsonProperty("duration")]
            public List<object> Duration { get; set; }

            [JsonProperty("higherLevelDefinitions")]
            public List<HigherLevelDefinition> HigherLevelDefinitions { get; set; }

            [JsonProperty("points")]
            public List<object> Points { get; set; }

            [JsonProperty("scaleType")]
            public string ScaleType { get; set; }

            [JsonProperty("special")]
            public List<object> Special { get; set; }
        }

        public partial class HigherLevelDefinition
        {
            [JsonProperty("details")]
            public string Details { get; set; }

            [JsonProperty("dice")]
            public HitPointDice Dice { get; set; }

            [JsonProperty("level")]
            public long Level { get; set; }

            [JsonProperty("typeId")]
            public long TypeId { get; set; }

            [JsonProperty("value")]
            public long? Value { get; set; }
        }

        public partial class HitPointDice
        {
            [JsonProperty("diceCount")]
            public long? DiceCount { get; set; }

            [JsonProperty("diceMultiplier")]
            public long? DiceMultiplier { get; set; }

            [JsonProperty("diceString")]
            public string DiceString { get; set; }

            [JsonProperty("diceValue")]
            public long? DiceValue { get; set; }

            [JsonProperty("fixedValue")]
            public long? FixedValue { get; set; }
        }

        public partial class Condition
        {
            [JsonProperty("conditionDuration")]
            public long ConditionDuration { get; set; }

            [JsonProperty("conditionId")]
            public long ConditionId { get; set; }

            [JsonProperty("durationUnit")]
            public string DurationUnit { get; set; }

            [JsonProperty("exception")]
            public string Exception { get; set; }

            [JsonProperty("type")]
            public long Type { get; set; }
        }

        public partial class Duration
        {
            [JsonProperty("durationInterval")]
            public long DurationInterval { get; set; }

            [JsonProperty("durationUnit")]
            public string DurationUnit { get; set; }

            [JsonProperty("durationType")]
            public string DurationType { get; set; }
        }

        public partial class BackgroundElement
        {
            [JsonProperty("atHigherLevels", NullValueHandling = NullValueHandling.Ignore)]
            public AtHigherLevels AtHigherLevels { get; set; }

            [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
            public long? Count { get; set; }

            [JsonProperty("die", NullValueHandling = NullValueHandling.Ignore)]
            public HitPointDice Die { get; set; }

            [JsonProperty("durationUnit")]
            public object DurationUnit { get; set; }

            [JsonProperty("usePrimaryStat", NullValueHandling = NullValueHandling.Ignore)]
            public bool? UsePrimaryStat { get; set; }

            [JsonProperty("availableToMulticlass")]
            public bool? AvailableToMulticlass { get; set; }

            [JsonProperty("bonusTypes")]
            public List<object> BonusTypes { get; set; }

            [JsonProperty("dice")]
            public HitPointDice Dice { get; set; }

            [JsonProperty("duration")]
            public object Duration { get; set; }

            [JsonProperty("entityId")]
            public long? EntityId { get; set; }

            [JsonProperty("entityTypeId")]
            public long? EntityTypeId { get; set; }

            [JsonProperty("fixedValue")]
            public long? FixedValue { get; set; }

            [JsonProperty("friendlySubtypeName")]
            public string FriendlySubtypeName { get; set; }

            [JsonProperty("friendlyTypeName")]
            public string FriendlyTypeName { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("isGranted")]
            public bool IsGranted { get; set; }

            [JsonProperty("modifierSubTypeId")]
            public long ModifierSubTypeId { get; set; }

            [JsonProperty("modifierTypeId")]
            public long ModifierTypeId { get; set; }

            [JsonProperty("requiresAttunement")]
            public bool RequiresAttunement { get; set; }

            [JsonProperty("restriction")]
            public string Restriction { get; set; }

            [JsonProperty("statId")]
            public long? StatId { get; set; }

            [JsonProperty("subType")]
            public string SubType { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("value")]
            public long? Value { get; set; }

            [JsonProperty("componentId")]
            public long ComponentId { get; set; }

            [JsonProperty("componentTypeId")]
            public long ComponentTypeId { get; set; }
        }

        public partial class DefinitionRange
        {
            [JsonProperty("aoeType")]
            public string AoeType { get; set; }

            [JsonProperty("aoeValue")]
            public long? AoeValue { get; set; }

            [JsonProperty("origin")]
            public string Origin { get; set; }

            [JsonProperty("rangeValue")]
            public long? RangeValue { get; set; }
        }

        public partial class DataClass
        {
            [JsonProperty("classFeatures")]
            public List<ClassClassFeature> ClassFeatures { get; set; }

            [JsonProperty("definition")]
            public SubclassDefinitionClass Definition { get; set; }

            [JsonProperty("definitionId")]
            public long DefinitionId { get; set; }

            [JsonProperty("entityTypeId")]
            public long EntityTypeId { get; set; }

            [JsonProperty("hitDiceUsed")]
            public long HitDiceUsed { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("isStartingClass")]
            public bool IsStartingClass { get; set; }

            [JsonProperty("level")]
            public long Level { get; set; }

            [JsonProperty("subclassDefinition")]
            public SubclassDefinitionClass SubclassDefinition { get; set; }

            [JsonProperty("subclassDefinitionId")]
            public object SubclassDefinitionId { get; set; }
        }

        public partial class ClassClassFeature
        {
            [JsonProperty("definition")]
            public ClassFeatureDefinition Definition { get; set; }

            [JsonProperty("levelScale")]
            public LevelScale LevelScale { get; set; }
        }

        public partial class ClassFeatureDefinition
        {
            [JsonProperty("activation")]
            public object Activation { get; set; }

            [JsonProperty("creatureRules")]
            public List<CreatureRule> CreatureRules { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("displayOrder")]
            public long DisplayOrder { get; set; }

            [JsonProperty("entityTypeId")]
            public long EntityTypeId { get; set; }

            [JsonProperty("hideInBuilder")]
            public bool HideInBuilder { get; set; }

            [JsonProperty("hideInSheet")]
            public bool HideInSheet { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("isSubClassFeature")]
            public bool IsSubClassFeature { get; set; }

            [JsonProperty("levelScales")]
            public object LevelScales { get; set; }

            [JsonProperty("limitedUse")]
            public List<LimitedUseElement> LimitedUse { get; set; }

            [JsonProperty("multiClassDescription")]
            public string MultiClassDescription { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("requiredLevel")]
            public long RequiredLevel { get; set; }

            [JsonProperty("snippet")]
            public string Snippet { get; set; }

            [JsonProperty("sourceId")]
            public long SourceId { get; set; }

            [JsonProperty("sourcePageNumber")]
            public long SourcePageNumber { get; set; }

            [JsonProperty("infusionRules")]
            public List<InfusionRule> InfusionRules { get; set; }
        }

        public partial class CreatureRule
        {
            [JsonProperty("creatureGroupId")]
            public long CreatureGroupId { get; set; }

            [JsonProperty("levelDivisor")]
            public object LevelDivisor { get; set; }

            [JsonProperty("maxChallengeRatingId")]
            public object MaxChallengeRatingId { get; set; }

            [JsonProperty("monsterIds")]
            public List<long> MonsterIds { get; set; }

            [JsonProperty("monsterTypeId")]
            public object MonsterTypeId { get; set; }

            [JsonProperty("movementIds")]
            public List<object> MovementIds { get; set; }

            [JsonProperty("sizeIds")]
            public List<object> SizeIds { get; set; }
        }

        public partial class InfusionRule
        {
            [JsonProperty("level")]
            public long Level { get; set; }

            [JsonProperty("choiceKey")]
            public string ChoiceKey { get; set; }
        }

        public partial class LimitedUseElement
        {
            [JsonProperty("level")]
            public object Level { get; set; }

            [JsonProperty("uses")]
            public long Uses { get; set; }
        }

        public partial class LevelScale
        {
            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("dice")]
            public object Dice { get; set; }

            [JsonProperty("fixedValue")]
            public long FixedValue { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("level")]
            public long Level { get; set; }
        }

        public partial class SubclassDefinitionClass
        {
            [JsonProperty("avatarUrl")]
            public Uri AvatarUrl { get; set; }

            [JsonProperty("canCastSpells")]
            public bool CanCastSpells { get; set; }

            [JsonProperty("classFeatureDefinitions")]
            public object ClassFeatureDefinitions { get; set; }

            [JsonProperty("classFeatures")]
            public List<DefinitionClassFeature> ClassFeatures { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("equipmentDescription")]
            public string EquipmentDescription { get; set; }

            [JsonProperty("hitDice")]
            public long HitDice { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("knowsAllSpells")]
            public bool KnowsAllSpells { get; set; }

            [JsonProperty("largeAvatarUrl")]
            public Uri LargeAvatarUrl { get; set; }

            [JsonProperty("moreDetailsUrl")]
            public string MoreDetailsUrl { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("parentClassId")]
            public long? ParentClassId { get; set; }

            [JsonProperty("portraitAvatarUrl")]
            public Uri PortraitAvatarUrl { get; set; }

            [JsonProperty("sourceId")]
            public object SourceId { get; set; }

            [JsonProperty("sourceIds")]
            public List<object> SourceIds { get; set; }

            [JsonProperty("sourcePageNumber")]
            public long SourcePageNumber { get; set; }

            [JsonProperty("spellCastingAbilityId")]
            public long SpellCastingAbilityId { get; set; }

            [JsonProperty("spellContainerName")]
            public object SpellContainerName { get; set; }

            [JsonProperty("spellPrepareType")]
            public long SpellPrepareType { get; set; }

            [JsonProperty("subclassDefinition")]
            public object SubclassDefinition { get; set; }

            [JsonProperty("wealthDice")]
            public HitPointDice WealthDice { get; set; }

            [JsonProperty("isHomebrew")]
            public bool IsHomebrew { get; set; }

            [JsonProperty("sources")]
            public List<Source> Sources { get; set; }

            [JsonProperty("prerequisites")]
            public List<Prerequisite> Prerequisites { get; set; }

            [JsonProperty("primaryAbilities")]
            public List<long> PrimaryAbilities { get; set; }

            [JsonProperty("spellRules")]
            public SpellRules SpellRules { get; set; }
        }

        public partial class DefinitionClassFeature
        {
            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("displayOrder")]
            public long DisplayOrder { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("prerequisite")]
            public object Prerequisite { get; set; }

            [JsonProperty("requiredLevel")]
            public long RequiredLevel { get; set; }
        }

        public partial class Prerequisite
        {
            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("prerequisiteMappings")]
            public List<PrerequisiteMapping> PrerequisiteMappings { get; set; }
        }

        public partial class PrerequisiteMapping
        {
            [JsonProperty("entityId")]
            public long? EntityId { get; set; }

            [JsonProperty("entityTypeId")]
            public long? EntityTypeId { get; set; }

            [JsonProperty("friendlySubTypeName")]
            public string FriendlySubTypeName { get; set; }

            [JsonProperty("friendlyTypeName")]
            public string FriendlyTypeName { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("subType")]
            public string SubType { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("value")]
            public long? Value { get; set; }
        }

        public partial class SpellRules
        {
            [JsonProperty("isRitualSpellCaster")]
            public bool IsRitualSpellCaster { get; set; }

            [JsonProperty("levelCantripsKnownMaxes")]
            public List<long> LevelCantripsKnownMaxes { get; set; }

            [JsonProperty("levelSpellKnownMaxes")]
            public List<object> LevelSpellKnownMaxes { get; set; }

            [JsonProperty("levelSpellSlots")]
            public List<List<long>> LevelSpellSlots { get; set; }

            [JsonProperty("multiClassSpellSlotDivisor")]
            public long MultiClassSpellSlotDivisor { get; set; }

            [JsonProperty("multiClassSpellSlotRounding")]
            public long MultiClassSpellSlotRounding { get; set; }
        }

        public partial class Configuration
        {
            [JsonProperty("abilityScoreType")]
            public long AbilityScoreType { get; set; }

            [JsonProperty("showHelpText")]
            public bool ShowHelpText { get; set; }

            [JsonProperty("startingEquipmentType")]
            public long StartingEquipmentType { get; set; }
        }

        public partial class Creature
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("entityTypeId")]
            public long EntityTypeId { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("description")]
            public object Description { get; set; }

            [JsonProperty("isActive")]
            public bool IsActive { get; set; }

            [JsonProperty("removedHitPoints")]
            public long RemovedHitPoints { get; set; }

            [JsonProperty("temporaryHitPoints")]
            public long TemporaryHitPoints { get; set; }

            [JsonProperty("groupId")]
            public long GroupId { get; set; }

            [JsonProperty("definition")]
            public CreatureDefinition Definition { get; set; }
        }

        public partial class CreatureDefinition
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("entityTypeId")]
            public long EntityTypeId { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("alignmentId")]
            public long AlignmentId { get; set; }

            [JsonProperty("sizeId")]
            public long SizeId { get; set; }

            [JsonProperty("typeId")]
            public long TypeId { get; set; }

            [JsonProperty("armorClass")]
            public long ArmorClass { get; set; }

            [JsonProperty("armorClassDescription")]
            public string ArmorClassDescription { get; set; }

            [JsonProperty("averageHitPoints")]
            public long AverageHitPoints { get; set; }

            [JsonProperty("hitPointDice")]
            public HitPointDice HitPointDice { get; set; }

            [JsonProperty("movements")]
            public List<Movement> Movements { get; set; }

            [JsonProperty("passivePerception")]
            public long PassivePerception { get; set; }

            [JsonProperty("isHomebrew")]
            public bool IsHomebrew { get; set; }

            [JsonProperty("challengeRatingId")]
            public long ChallengeRatingId { get; set; }

            [JsonProperty("sourceId")]
            public long SourceId { get; set; }

            [JsonProperty("sourcePageNumber")]
            public object SourcePageNumber { get; set; }

            [JsonProperty("isLegendary")]
            public bool IsLegendary { get; set; }

            [JsonProperty("hasLair")]
            public bool HasLair { get; set; }

            [JsonProperty("avatarUrl")]
            public Uri AvatarUrl { get; set; }

            [JsonProperty("largeAvatarUrl")]
            public Uri LargeAvatarUrl { get; set; }

            [JsonProperty("basicAvatarUrl")]
            public Uri BasicAvatarUrl { get; set; }

            [JsonProperty("version")]
            public object Version { get; set; }

            [JsonProperty("swarm")]
            public object Swarm { get; set; }

            [JsonProperty("subTypes")]
            public List<object> SubTypes { get; set; }

            [JsonProperty("environments")]
            public List<object> Environments { get; set; }

            [JsonProperty("tags")]
            public List<object> Tags { get; set; }

            [JsonProperty("sources")]
            public List<Source> Sources { get; set; }

            [JsonProperty("stats")]
            public List<DefinitionStat> Stats { get; set; }

            [JsonProperty("senses")]
            public List<Sense> Senses { get; set; }

            [JsonProperty("damageAdjustments")]
            public List<long> DamageAdjustments { get; set; }

            [JsonProperty("conditionImmunities")]
            public List<long> ConditionImmunities { get; set; }

            [JsonProperty("savingThrows")]
            public List<SavingThrow> SavingThrows { get; set; }

            [JsonProperty("skills")]
            public List<Skill> Skills { get; set; }

            [JsonProperty("languages")]
            public List<object> Languages { get; set; }

            [JsonProperty("specialTraitsDescription")]
            public string SpecialTraitsDescription { get; set; }

            [JsonProperty("actionsDescription")]
            public string ActionsDescription { get; set; }

            [JsonProperty("reactionsDescription")]
            public string ReactionsDescription { get; set; }

            [JsonProperty("legendaryActionsDescription")]
            public string LegendaryActionsDescription { get; set; }

            [JsonProperty("characteristicsDescription")]
            public string CharacteristicsDescription { get; set; }

            [JsonProperty("lairDescription")]
            public string LairDescription { get; set; }

            [JsonProperty("languageDescription")]
            public object LanguageDescription { get; set; }

            [JsonProperty("languageNote")]
            public string LanguageNote { get; set; }
        }

        public partial class Movement
        {
            [JsonProperty("movementId")]
            public long MovementId { get; set; }

            [JsonProperty("speed")]
            public long Speed { get; set; }

            [JsonProperty("notes")]
            public object Notes { get; set; }
        }

        public partial class SavingThrow
        {
            [JsonProperty("statId")]
            public long StatId { get; set; }

            [JsonProperty("bonusModifier")]
            public object BonusModifier { get; set; }
        }

        public partial class Sense
        {
            [JsonProperty("senseId")]
            public long SenseId { get; set; }

            [JsonProperty("notes")]
            public string Notes { get; set; }
        }

        public partial class Skill
        {
            [JsonProperty("skillId")]
            public long SkillId { get; set; }

            [JsonProperty("value")]
            public long Value { get; set; }

            [JsonProperty("additionalBonus")]
            public object AdditionalBonus { get; set; }
        }

        public partial class DefinitionStat
        {
            [JsonProperty("statId")]
            public long StatId { get; set; }

            [JsonProperty("name")]
            public object Name { get; set; }

            [JsonProperty("value")]
            public long Value { get; set; }
        }

        public partial class Currencies
        {
            [JsonProperty("cp")]
            public long Cp { get; set; }

            [JsonProperty("ep")]
            public long Ep { get; set; }

            [JsonProperty("gp")]
            public long Gp { get; set; }

            [JsonProperty("pp")]
            public long Pp { get; set; }

            [JsonProperty("sp")]
            public long Sp { get; set; }
        }

        public partial class CustomItem
        {
            [JsonProperty("cost")]
            public object Cost { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("notes")]
            public string Notes { get; set; }

            [JsonProperty("quantity")]
            public long Quantity { get; set; }

            [JsonProperty("weight")]
            public object Weight { get; set; }
        }

        public partial class DeathSaves
        {
            [JsonProperty("failCount")]
            public long FailCount { get; set; }

            [JsonProperty("isStabilized")]
            public bool IsStabilized { get; set; }

            [JsonProperty("successCount")]
            public long SuccessCount { get; set; }
        }

        public partial class DefaultBackdrop
        {
            [JsonProperty("backdropAvatarUrl")]
            public Uri BackdropAvatarUrl { get; set; }

            [JsonProperty("smallBackdropAvatarUrl")]
            public Uri SmallBackdropAvatarUrl { get; set; }

            [JsonProperty("largeBackdropAvatarUrl")]
            public Uri LargeBackdropAvatarUrl { get; set; }

            [JsonProperty("thumbnailBackdropAvatarUrl")]
            public Uri ThumbnailBackdropAvatarUrl { get; set; }
        }

        public partial class Feat
        {
            [JsonProperty("componentTypeId")]
            public long ComponentTypeId { get; set; }

            [JsonProperty("componentId")]
            public long ComponentId { get; set; }

            [JsonProperty("definition")]
            public FeatDefinition Definition { get; set; }

            [JsonProperty("definitionId")]
            public long DefinitionId { get; set; }
        }

        public partial class FeatDefinition
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("entityTypeId")]
            public long EntityTypeId { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("snippet")]
            public string Snippet { get; set; }

            [JsonProperty("activation")]
            public Activation Activation { get; set; }

            [JsonProperty("sourceId")]
            public long? SourceId { get; set; }

            [JsonProperty("sourcePageNumber")]
            public long? SourcePageNumber { get; set; }

            [JsonProperty("creatureRules")]
            public List<object> CreatureRules { get; set; }

            [JsonProperty("prerequisites", NullValueHandling = NullValueHandling.Ignore)]
            public List<Prerequisite> Prerequisites { get; set; }

            [JsonProperty("isHomebrew", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsHomebrew { get; set; }

            [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
            public List<Source> Sources { get; set; }

            [JsonProperty("displayOrder", NullValueHandling = NullValueHandling.Ignore)]
            public long? DisplayOrder { get; set; }

            [JsonProperty("hideInBuilder", NullValueHandling = NullValueHandling.Ignore)]
            public bool? HideInBuilder { get; set; }

            [JsonProperty("hideInSheet", NullValueHandling = NullValueHandling.Ignore)]
            public bool? HideInSheet { get; set; }
        }

        public partial class Inventory
        {
            [JsonProperty("chargesUsed")]
            public long ChargesUsed { get; set; }

            [JsonProperty("definition")]
            public InventoryDefinition Definition { get; set; }

            [JsonProperty("definitionId")]
            public long DefinitionId { get; set; }

            [JsonProperty("definitionTypeId")]
            public long DefinitionTypeId { get; set; }

            [JsonProperty("displayAsAttack")]
            public object DisplayAsAttack { get; set; }

            [JsonProperty("entityTypeId")]
            public long EntityTypeId { get; set; }

            [JsonProperty("equipped")]
            public bool Equipped { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("isAttuned")]
            public bool IsAttuned { get; set; }

            [JsonProperty("limitedUse")]
            public InventoryLimitedUse LimitedUse { get; set; }

            [JsonProperty("quantity")]
            public long Quantity { get; set; }
        }

        public partial class InventoryDefinition
        {
            [JsonProperty("armorClass")]
            public long? ArmorClass { get; set; }

            [JsonProperty("attackType")]
            public long? AttackType { get; set; }

            [JsonProperty("attunementDescription")]
            public string AttunementDescription { get; set; }

            [JsonProperty("avatarUrl")]
            public Uri AvatarUrl { get; set; }

            [JsonProperty("baseArmorName")]
            public string BaseArmorName { get; set; }

            [JsonProperty("baseItemId")]
            public long? BaseItemId { get; set; }

            [JsonProperty("baseTypeId")]
            public long BaseTypeId { get; set; }

            [JsonProperty("bundleSize")]
            public long BundleSize { get; set; }

            [JsonProperty("canAttune")]
            public bool CanAttune { get; set; }

            [JsonProperty("canEquip")]
            public bool CanEquip { get; set; }

            [JsonProperty("categoryId")]
            public long? CategoryId { get; set; }

            [JsonProperty("cost")]
            public double? Cost { get; set; }

            [JsonProperty("damage")]
            public HitPointDice Damage { get; set; }

            [JsonProperty("damageType")]
            public string DamageType { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("entityTypeId")]
            public long EntityTypeId { get; set; }

            [JsonProperty("filterType")]
            public string FilterType { get; set; }

            [JsonProperty("fixedDamage")]
            public object FixedDamage { get; set; }

            [JsonProperty("grantedModifiers")]
            public List<BackgroundElement> GrantedModifiers { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("isConsumable")]
            public bool IsConsumable { get; set; }

            [JsonProperty("isHomebrew")]
            public bool IsHomebrew { get; set; }

            [JsonProperty("isMonkWeapon")]
            public bool IsMonkWeapon { get; set; }

            [JsonProperty("isPack")]
            public bool IsPack { get; set; }

            [JsonProperty("largeAvatarUrl")]
            public Uri LargeAvatarUrl { get; set; }

            [JsonProperty("longRange")]
            public long? LongRange { get; set; }

            [JsonProperty("magic")]
            public bool Magic { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("properties")]
            public List<Property> Properties { get; set; }

            [JsonProperty("range")]
            public long? Range { get; set; }

            [JsonProperty("rarity")]
            public string Rarity { get; set; }

            [JsonProperty("snippet")]
            public string Snippet { get; set; }

            [JsonProperty("sourceId")]
            public object SourceId { get; set; }

            [JsonProperty("sourcePageNumber")]
            public object SourcePageNumber { get; set; }

            [JsonProperty("stackable")]
            public bool Stackable { get; set; }

            [JsonProperty("stealthCheck")]
            public long? StealthCheck { get; set; }

            [JsonProperty("strengthRequirement")]
            public long? StrengthRequirement { get; set; }

            [JsonProperty("subType")]
            public string SubType { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("version")]
       
            public long? Version { get; set; }

            [JsonProperty("weaponBehaviors")]
            public List<object> WeaponBehaviors { get; set; }

            [JsonProperty("weight")]
            public double Weight { get; set; }

            [JsonProperty("levelInfusionGranted")]
            public object LevelInfusionGranted { get; set; }

            [JsonProperty("sources")]
            public List<Source> Sources { get; set; }

            [JsonProperty("armorTypeId")]
            public long? ArmorTypeId { get; set; }

            [JsonProperty("gearTypeId")]
            public long? GearTypeId { get; set; }

            [JsonProperty("groupedId")]
            public long? GroupedId { get; set; }

            [JsonProperty("canBeAddedToInventory")]
            public bool CanBeAddedToInventory { get; set; }
        }

        public partial class Property
        {
            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("notes")]
            public string Notes { get; set; }
        }

        public partial class InventoryLimitedUse
        {
            [JsonProperty("maxUses")]
            public long MaxUses { get; set; }

            [JsonProperty("numberUsed")]
            public long NumberUsed { get; set; }

            [JsonProperty("resetType")]
            public string ResetType { get; set; }

            [JsonProperty("resetTypeDescription")]
            public string ResetTypeDescription { get; set; }
        }

        public partial class Modifiers
        {
            [JsonProperty("background")]
            public List<BackgroundElement> Background { get; set; }

            [JsonProperty("class")]
            public List<BackgroundElement> Class { get; set; }

            [JsonProperty("condition")]
            public List<object> Condition { get; set; }

            [JsonProperty("feat")]
            public List<BackgroundElement> Feat { get; set; }

            [JsonProperty("item")]
            public List<BackgroundElement> Item { get; set; }

            [JsonProperty("race")]
            public List<BackgroundElement> Race { get; set; }
        }

        public partial class Notes
        {
            [JsonProperty("allies")]
            public object Allies { get; set; }

            [JsonProperty("backstory")]
            public string Backstory { get; set; }

            [JsonProperty("enemies")]
            public object Enemies { get; set; }

            [JsonProperty("organizations")]
            public object Organizations { get; set; }

            [JsonProperty("otherHoldings")]
            public object OtherHoldings { get; set; }

            [JsonProperty("otherNotes")]
            public string OtherNotes { get; set; }

            [JsonProperty("personalPossessions")]
            public string PersonalPossessions { get; set; }
        }

        public partial class PactMagic
        {
            [JsonProperty("available")]
            public long Available { get; set; }

            [JsonProperty("level")]
            public long Level { get; set; }

            [JsonProperty("used")]
            public long Used { get; set; }
        }

        public partial class Preferences
        {
            [JsonProperty("abilityScoreDisplayType")]
            public long AbilityScoreDisplayType { get; set; }

            [JsonProperty("encumbranceType")]
            public long EncumbranceType { get; set; }

            [JsonProperty("enforceFeatRules")]
            public bool EnforceFeatRules { get; set; }

            [JsonProperty("enforceMulticlassRules")]
            public bool EnforceMulticlassRules { get; set; }

            [JsonProperty("showScaledSpells")]
            public bool ShowScaledSpells { get; set; }

            [JsonProperty("hitPointType")]
            public long HitPointType { get; set; }

            [JsonProperty("ignoreCoinWeight")]
            public bool IgnoreCoinWeight { get; set; }

            [JsonProperty("primaryMovement")]
            public long PrimaryMovement { get; set; }

            [JsonProperty("primarySense")]
            public long PrimarySense { get; set; }

            [JsonProperty("privacyType")]
            public long PrivacyType { get; set; }

            [JsonProperty("progressionType")]
            public long ProgressionType { get; set; }

            [JsonProperty("sharingType")]
            public long SharingType { get; set; }

            [JsonProperty("showUnarmedStrike")]
            public bool ShowUnarmedStrike { get; set; }

            [JsonProperty("useHomebrewContent")]
            public bool UseHomebrewContent { get; set; }
        }

        public partial class Race
        {
            [JsonProperty("isSubRace")]
            public bool IsSubRace { get; set; }

            [JsonProperty("baseRaceName")]
            public string BaseRaceName { get; set; }

            [JsonProperty("entityRaceId")]
            public long EntityRaceId { get; set; }

            [JsonProperty("entityRaceTypeId")]
            public long EntityRaceTypeId { get; set; }

            [JsonProperty("fullName")]
            public string FullName { get; set; }

            [JsonProperty("baseRaceId")]
            public long BaseRaceId { get; set; }

            [JsonProperty("baseRaceTypeId")]
            public long BaseRaceTypeId { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("avatarUrl")]
            public Uri AvatarUrl { get; set; }

            [JsonProperty("largeAvatarUrl")]
            public Uri LargeAvatarUrl { get; set; }

            [JsonProperty("portraitAvatarUrl")]
            public Uri PortraitAvatarUrl { get; set; }

            [JsonProperty("moreDetailsUrl")]
            public string MoreDetailsUrl { get; set; }

            [JsonProperty("isHomebrew")]
            public bool IsHomebrew { get; set; }

            [JsonProperty("sourceIds")]
            public List<object> SourceIds { get; set; }

            [JsonProperty("groupIds")]
            public List<object> GroupIds { get; set; }

            [JsonProperty("type")]
            public long Type { get; set; }

            [JsonProperty("subRaceShortName")]
            public object SubRaceShortName { get; set; }

            [JsonProperty("baseName")]
            public string BaseName { get; set; }

            [JsonProperty("racialTraits")]
            public List<RacialTrait> RacialTraits { get; set; }

            [JsonProperty("weightSpeeds")]
            public WeightSpeeds WeightSpeeds { get; set; }

            [JsonProperty("featIds")]
            public List<object> FeatIds { get; set; }

            [JsonProperty("size")]
            public object Size { get; set; }

            [JsonProperty("sizeId")]
            public long SizeId { get; set; }

            [JsonProperty("supportsSubrace")]
            public object SupportsSubrace { get; set; }

            [JsonProperty("sources")]
            public List<Source> Sources { get; set; }
        }

        public partial class RacialTrait
        {
            [JsonProperty("definition")]
            public FeatDefinition Definition { get; set; }
        }

        public partial class WeightSpeeds
        {
            [JsonProperty("encumbered")]
            public object Encumbered { get; set; }

            [JsonProperty("heavilyEncumbered")]
            public object HeavilyEncumbered { get; set; }

            [JsonProperty("normal")]
            public Normal Normal { get; set; }

            [JsonProperty("override")]
            public object Override { get; set; }

            [JsonProperty("pushDragLift")]
            public object PushDragLift { get; set; }
        }

        public partial class Normal
        {
            [JsonProperty("burrow")]
            public long Burrow { get; set; }

            [JsonProperty("climb")]
            public long Climb { get; set; }

            [JsonProperty("fly")]
            public long Fly { get; set; }

            [JsonProperty("swim")]
            public long Swim { get; set; }

            [JsonProperty("walk")]
            public long Walk { get; set; }
        }

        public partial class ThemeColor
        {
            [JsonProperty("backgroundColor")]
            public string BackgroundColor { get; set; }

            [JsonProperty("classId")]
            public object ClassId { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("raceId")]
            public object RaceId { get; set; }

            [JsonProperty("subRaceId")]
            public object SubRaceId { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("themeColor")]
            public string ThemeColorThemeColor { get; set; }

            [JsonProperty("themeColorId")]
            public long ThemeColorId { get; set; }
        }

        public partial class Traits
        {
            [JsonProperty("appearance")]
            public object Appearance { get; set; }

            [JsonProperty("bonds")]
            public string Bonds { get; set; }

            [JsonProperty("flaws")]
            public string Flaws { get; set; }

            [JsonProperty("ideals")]
            public string Ideals { get; set; }

            [JsonProperty("personalityTraits")]
            public string PersonalityTraits { get; set; }
        }
     
       

           
       
    

}


