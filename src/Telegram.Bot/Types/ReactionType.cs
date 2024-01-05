using Telegram.Bot.Converters;

namespace Telegram.Bot.Types;

/// <summary>
/// This object describes the type of a reaction. Currently, it can be one of
/// <list type="bullet">
/// <item><see cref="ReactionTypeEmoji"/></item>
/// <item><see cref="ReactionTypeCustomEmoji"/></item>
/// </list>
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
[JsonConverter(typeof(ReactionTypeConverter))]
public abstract class ReactionType
{
    /// <summary>
    /// Type of the reaction
    /// </summary>
    [JsonProperty]
    public abstract string Type { get; }
}

/// <summary>
/// The reaction is based on an emoji.
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ReactionTypeEmoji : ReactionType
{
    /// <summary>
    /// Type of the reaction, always "emoji"
    /// </summary>
    public override string Type => "emoji";

    /// <summary>
    /// Reaction emoji. Currently, it can be one of "👍", "👎", "❤", "🔥", "🥰", "👏", "😁",
    /// "🤔", "🤯", "😱", "🤬", "😢", "🎉", "🤩", "🤮", "💩", "🙏", "👌", "🕊", "🤡", "🥱",
    /// "🥴", "😍", "🐳", "❤‍🔥", "🌚", "🌭", "💯", "🤣", "⚡", "🍌", "🏆", "💔", "🤨",
    /// "😐", "🍓", "🍾", "💋", "🖕", "😈", "😴", "😭", "🤓", "👻", "👨‍💻", "👀", "🎃",
    /// "🙈", "😇", "😨", "🤝", "✍", "🤗", "🫡", "🎅", "🎄", "☃", "💅", "🤪", "🗿", "🆒",
    /// "💘", "🙉", "🦄", "😘", "💊", "🙊", "😎", "👾", "🤷‍♂", "🤷", "🤷‍♀", "😡"
    /// </summary>
    /// <remarks>
    /// Available shortcuts: <see cref="Enums.KnownReactionTypeEmoji"/>
    /// </remarks>
    [JsonProperty(Required = Required.Always)]
    public string Emoji { get; set; } = default!;
}

/// <summary>
/// The reaction is based on an emoji.
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ReactionTypeCustomEmoji : ReactionType
{
    /// <summary>
    /// Type of the reaction, always "custom_emoji"
    /// </summary>
    public override string Type => "custom_emoji";

    /// <summary>
    /// Custom emoji identifier
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public string CustomEmojiId { get; set; } = default!;
}
