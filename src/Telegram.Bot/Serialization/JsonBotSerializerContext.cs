#if NET6_0_OR_GREATER
using Telegram.Bot.Requests;

namespace Telegram.Bot;

/// <summary>JsonSerializerContext for Bot API serialization with source generation</summary>
[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.SnakeCaseLower, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault)][JsonSerializable(typeof(GetUpdatesRequest))]
[JsonSerializable(typeof(SetWebhookRequest))]
[JsonSerializable(typeof(DeleteWebhookRequest))]
[JsonSerializable(typeof(GetWebhookInfoRequest))]
[JsonSerializable(typeof(GetMeRequest))]
[JsonSerializable(typeof(LogOutRequest))]
[JsonSerializable(typeof(CloseRequest))]
[JsonSerializable(typeof(SendMessageRequest))]
[JsonSerializable(typeof(ForwardMessageRequest))]
[JsonSerializable(typeof(ForwardMessagesRequest))]
[JsonSerializable(typeof(CopyMessageRequest))]
[JsonSerializable(typeof(CopyMessagesRequest))]
[JsonSerializable(typeof(SendPhotoRequest))]
[JsonSerializable(typeof(SendAudioRequest))]
[JsonSerializable(typeof(SendDocumentRequest))]
[JsonSerializable(typeof(SendVideoRequest))]
[JsonSerializable(typeof(SendAnimationRequest))]
[JsonSerializable(typeof(SendVoiceRequest))]
[JsonSerializable(typeof(SendVideoNoteRequest))]
[JsonSerializable(typeof(SendPaidMediaRequest))]
[JsonSerializable(typeof(SendMediaGroupRequest))]
[JsonSerializable(typeof(SendLocationRequest))]
[JsonSerializable(typeof(SendVenueRequest))]
[JsonSerializable(typeof(SendContactRequest))]
[JsonSerializable(typeof(SendPollRequest))]
[JsonSerializable(typeof(SendDiceRequest))]
[JsonSerializable(typeof(SendChatActionRequest))]
[JsonSerializable(typeof(SetMessageReactionRequest))]
[JsonSerializable(typeof(GetUserProfilePhotosRequest))]
[JsonSerializable(typeof(SetUserEmojiStatusRequest))]
[JsonSerializable(typeof(GetFileRequest))]
[JsonSerializable(typeof(BanChatMemberRequest))]
[JsonSerializable(typeof(UnbanChatMemberRequest))]
[JsonSerializable(typeof(RestrictChatMemberRequest))]
[JsonSerializable(typeof(PromoteChatMemberRequest))]
[JsonSerializable(typeof(SetChatAdministratorCustomTitleRequest))]
[JsonSerializable(typeof(BanChatSenderChatRequest))]
[JsonSerializable(typeof(UnbanChatSenderChatRequest))]
[JsonSerializable(typeof(SetChatPermissionsRequest))]
[JsonSerializable(typeof(ExportChatInviteLinkRequest))]
[JsonSerializable(typeof(CreateChatInviteLinkRequest))]
[JsonSerializable(typeof(EditChatInviteLinkRequest))]
[JsonSerializable(typeof(CreateChatSubscriptionInviteLinkRequest))]
[JsonSerializable(typeof(EditChatSubscriptionInviteLinkRequest))]
[JsonSerializable(typeof(RevokeChatInviteLinkRequest))]
[JsonSerializable(typeof(ApproveChatJoinRequest))]
[JsonSerializable(typeof(DeclineChatJoinRequest))]
[JsonSerializable(typeof(SetChatPhotoRequest))]
[JsonSerializable(typeof(DeleteChatPhotoRequest))]
[JsonSerializable(typeof(SetChatTitleRequest))]
[JsonSerializable(typeof(SetChatDescriptionRequest))]
[JsonSerializable(typeof(PinChatMessageRequest))]
[JsonSerializable(typeof(UnpinChatMessageRequest))]
[JsonSerializable(typeof(UnpinAllChatMessagesRequest))]
[JsonSerializable(typeof(LeaveChatRequest))]
[JsonSerializable(typeof(GetChatRequest))]
[JsonSerializable(typeof(GetChatAdministratorsRequest))]
[JsonSerializable(typeof(GetChatMemberCountRequest))]
[JsonSerializable(typeof(GetChatMemberRequest))]
[JsonSerializable(typeof(SetChatStickerSetRequest))]
[JsonSerializable(typeof(DeleteChatStickerSetRequest))]
[JsonSerializable(typeof(GetForumTopicIconStickersRequest))]
[JsonSerializable(typeof(CreateForumTopicRequest))]
[JsonSerializable(typeof(EditForumTopicRequest))]
[JsonSerializable(typeof(CloseForumTopicRequest))]
[JsonSerializable(typeof(ReopenForumTopicRequest))]
[JsonSerializable(typeof(DeleteForumTopicRequest))]
[JsonSerializable(typeof(UnpinAllForumTopicMessagesRequest))]
[JsonSerializable(typeof(EditGeneralForumTopicRequest))]
[JsonSerializable(typeof(CloseGeneralForumTopicRequest))]
[JsonSerializable(typeof(ReopenGeneralForumTopicRequest))]
[JsonSerializable(typeof(HideGeneralForumTopicRequest))]
[JsonSerializable(typeof(UnhideGeneralForumTopicRequest))]
[JsonSerializable(typeof(UnpinAllGeneralForumTopicMessagesRequest))]
[JsonSerializable(typeof(AnswerCallbackQueryRequest))]
[JsonSerializable(typeof(GetUserChatBoostsRequest))]
[JsonSerializable(typeof(GetBusinessConnectionRequest))]
[JsonSerializable(typeof(SetMyCommandsRequest))]
[JsonSerializable(typeof(DeleteMyCommandsRequest))]
[JsonSerializable(typeof(GetMyCommandsRequest))]
[JsonSerializable(typeof(SetMyNameRequest))]
[JsonSerializable(typeof(GetMyNameRequest))]
[JsonSerializable(typeof(SetMyDescriptionRequest))]
[JsonSerializable(typeof(GetMyDescriptionRequest))]
[JsonSerializable(typeof(SetMyShortDescriptionRequest))]
[JsonSerializable(typeof(GetMyShortDescriptionRequest))]
[JsonSerializable(typeof(SetChatMenuButtonRequest))]
[JsonSerializable(typeof(GetChatMenuButtonRequest))]
[JsonSerializable(typeof(SetMyDefaultAdministratorRightsRequest))]
[JsonSerializable(typeof(GetMyDefaultAdministratorRightsRequest))]
[JsonSerializable(typeof(EditMessageTextRequest))]
[JsonSerializable(typeof(EditInlineMessageTextRequest))]
[JsonSerializable(typeof(EditMessageCaptionRequest))]
[JsonSerializable(typeof(EditInlineMessageCaptionRequest))]
[JsonSerializable(typeof(EditMessageMediaRequest))]
[JsonSerializable(typeof(EditInlineMessageMediaRequest))]
[JsonSerializable(typeof(EditMessageLiveLocationRequest))]
[JsonSerializable(typeof(EditInlineMessageLiveLocationRequest))]
[JsonSerializable(typeof(StopMessageLiveLocationRequest))]
[JsonSerializable(typeof(StopInlineMessageLiveLocationRequest))]
[JsonSerializable(typeof(EditMessageReplyMarkupRequest))]
[JsonSerializable(typeof(EditInlineMessageReplyMarkupRequest))]
[JsonSerializable(typeof(StopPollRequest))]
[JsonSerializable(typeof(DeleteMessageRequest))]
[JsonSerializable(typeof(DeleteMessagesRequest))]
[JsonSerializable(typeof(SendStickerRequest))]
[JsonSerializable(typeof(GetStickerSetRequest))]
[JsonSerializable(typeof(GetCustomEmojiStickersRequest))]
[JsonSerializable(typeof(UploadStickerFileRequest))]
[JsonSerializable(typeof(CreateNewStickerSetRequest))]
[JsonSerializable(typeof(AddStickerToSetRequest))]
[JsonSerializable(typeof(SetStickerPositionInSetRequest))]
[JsonSerializable(typeof(DeleteStickerFromSetRequest))]
[JsonSerializable(typeof(ReplaceStickerInSetRequest))]
[JsonSerializable(typeof(SetStickerEmojiListRequest))]
[JsonSerializable(typeof(SetStickerKeywordsRequest))]
[JsonSerializable(typeof(SetStickerMaskPositionRequest))]
[JsonSerializable(typeof(SetStickerSetTitleRequest))]
[JsonSerializable(typeof(SetStickerSetThumbnailRequest))]
[JsonSerializable(typeof(SetCustomEmojiStickerSetThumbnailRequest))]
[JsonSerializable(typeof(DeleteStickerSetRequest))]
[JsonSerializable(typeof(GetAvailableGiftsRequest))]
[JsonSerializable(typeof(SendGiftRequest))]
[JsonSerializable(typeof(AnswerInlineQueryRequest))]
[JsonSerializable(typeof(AnswerWebAppQueryRequest))]
[JsonSerializable(typeof(SavePreparedInlineMessageRequest))]
[JsonSerializable(typeof(SendInvoiceRequest))]
[JsonSerializable(typeof(CreateInvoiceLinkRequest))]
[JsonSerializable(typeof(AnswerShippingQueryRequest))]
[JsonSerializable(typeof(AnswerPreCheckoutQueryRequest))]
[JsonSerializable(typeof(GetStarTransactionsRequest))]
[JsonSerializable(typeof(RefundStarPaymentRequest))]
[JsonSerializable(typeof(EditUserStarSubscriptionRequest))]
[JsonSerializable(typeof(SetPassportDataErrorsRequest))]
[JsonSerializable(typeof(SendGameRequest))]
[JsonSerializable(typeof(SetGameScoreRequest))]
[JsonSerializable(typeof(SetInlineGameScoreRequest))]
[JsonSerializable(typeof(GetGameHighScoresRequest))]
[JsonSerializable(typeof(GetInlineGameHighScoresRequest))]
[JsonSerializable(typeof(ApiResponse<Update[]>))]
[JsonSerializable(typeof(ApiResponse<bool>))]
[JsonSerializable(typeof(ApiResponse<WebhookInfo>))]
[JsonSerializable(typeof(ApiResponse<User>))]
[JsonSerializable(typeof(ApiResponse<Message>))]
[JsonSerializable(typeof(ApiResponse<MessageId[]>))]
[JsonSerializable(typeof(ApiResponse<MessageId>))]
[JsonSerializable(typeof(ApiResponse<Message[]>))]
[JsonSerializable(typeof(ApiResponse<UserProfilePhotos>))]
[JsonSerializable(typeof(ApiResponse<TGFile>))]
[JsonSerializable(typeof(ApiResponse<string>))]
[JsonSerializable(typeof(ApiResponse<ChatInviteLink>))]
[JsonSerializable(typeof(ApiResponse<ChatFullInfo>))]
[JsonSerializable(typeof(ApiResponse<ChatMember[]>))]
[JsonSerializable(typeof(ApiResponse<int>))]
[JsonSerializable(typeof(ApiResponse<ChatMember>))]
[JsonSerializable(typeof(ApiResponse<Sticker[]>))]
[JsonSerializable(typeof(ApiResponse<ForumTopic>))]
[JsonSerializable(typeof(ApiResponse<UserChatBoosts>))]
[JsonSerializable(typeof(ApiResponse<BusinessConnection>))]
[JsonSerializable(typeof(ApiResponse<BotCommand[]>))]
[JsonSerializable(typeof(ApiResponse<BotName>))]
[JsonSerializable(typeof(ApiResponse<BotDescription>))]
[JsonSerializable(typeof(ApiResponse<BotShortDescription>))]
[JsonSerializable(typeof(ApiResponse<MenuButton>))]
[JsonSerializable(typeof(ApiResponse<ChatAdministratorRights>))]
[JsonSerializable(typeof(ApiResponse<Poll>))]
[JsonSerializable(typeof(ApiResponse<StickerSet>))]
[JsonSerializable(typeof(ApiResponse<GiftList>))]
[JsonSerializable(typeof(ApiResponse<SentWebAppMessage>))]
[JsonSerializable(typeof(ApiResponse<PreparedInlineMessage>))]
[JsonSerializable(typeof(ApiResponse<StarTransactions>))]
[JsonSerializable(typeof(ApiResponse<GameHighScore[]>))]
[JsonSerializable(typeof(MessageOriginUser))]
[JsonSerializable(typeof(MessageOriginHiddenUser))]
[JsonSerializable(typeof(MessageOriginChat))]
[JsonSerializable(typeof(MessageOriginChannel))]
[JsonSerializable(typeof(PaidMediaPreview))]
[JsonSerializable(typeof(PaidMediaPhoto))]
[JsonSerializable(typeof(PaidMediaVideo))]
[JsonSerializable(typeof(BackgroundFillSolid))]
[JsonSerializable(typeof(BackgroundFillGradient))]
[JsonSerializable(typeof(BackgroundFillFreeformGradient))]
[JsonSerializable(typeof(BackgroundTypeFill))]
[JsonSerializable(typeof(BackgroundTypeWallpaper))]
[JsonSerializable(typeof(BackgroundTypePattern))]
[JsonSerializable(typeof(BackgroundTypeChatTheme))]
[JsonSerializable(typeof(ReplyKeyboardMarkup))]
[JsonSerializable(typeof(ReplyKeyboardRemove))]
[JsonSerializable(typeof(ForceReplyMarkup))]
[JsonSerializable(typeof(ChatMemberOwner))]
[JsonSerializable(typeof(ChatMemberAdministrator))]
[JsonSerializable(typeof(ChatMemberMember))]
[JsonSerializable(typeof(ChatMemberRestricted))]
[JsonSerializable(typeof(ChatMemberLeft))]
[JsonSerializable(typeof(ChatMemberBanned))]
[JsonSerializable(typeof(ReactionTypeEmoji))]
[JsonSerializable(typeof(ReactionTypeCustomEmoji))]
[JsonSerializable(typeof(ReactionTypePaid))]
[JsonSerializable(typeof(BotCommandScopeDefault))]
[JsonSerializable(typeof(BotCommandScopeAllPrivateChats))]
[JsonSerializable(typeof(BotCommandScopeAllGroupChats))]
[JsonSerializable(typeof(BotCommandScopeAllChatAdministrators))]
[JsonSerializable(typeof(BotCommandScopeChat))]
[JsonSerializable(typeof(BotCommandScopeChatAdministrators))]
[JsonSerializable(typeof(BotCommandScopeChatMember))]
[JsonSerializable(typeof(MenuButtonCommands))]
[JsonSerializable(typeof(MenuButtonWebApp))]
[JsonSerializable(typeof(MenuButtonDefault))]
[JsonSerializable(typeof(ChatBoostSourcePremium))]
[JsonSerializable(typeof(ChatBoostSourceGiftCode))]
[JsonSerializable(typeof(ChatBoostSourceGiveaway))]
[JsonSerializable(typeof(ResponseParameters))]
[JsonSerializable(typeof(InputMediaPhoto))]
[JsonSerializable(typeof(InputMediaVideo))]
[JsonSerializable(typeof(InputMediaAnimation))]
[JsonSerializable(typeof(InputMediaAudio))]
[JsonSerializable(typeof(InputMediaDocument))]
[JsonSerializable(typeof(InputPaidMediaPhoto))]
[JsonSerializable(typeof(InputPaidMediaVideo))]
[JsonSerializable(typeof(InlineQueryResultArticle))]
[JsonSerializable(typeof(InlineQueryResultPhoto))]
[JsonSerializable(typeof(InlineQueryResultGif))]
[JsonSerializable(typeof(InlineQueryResultMpeg4Gif))]
[JsonSerializable(typeof(InlineQueryResultVideo))]
[JsonSerializable(typeof(InlineQueryResultAudio))]
[JsonSerializable(typeof(InlineQueryResultVoice))]
[JsonSerializable(typeof(InlineQueryResultDocument))]
[JsonSerializable(typeof(InlineQueryResultLocation))]
[JsonSerializable(typeof(InlineQueryResultVenue))]
[JsonSerializable(typeof(InlineQueryResultContact))]
[JsonSerializable(typeof(InlineQueryResultGame))]
[JsonSerializable(typeof(InlineQueryResultCachedPhoto))]
[JsonSerializable(typeof(InlineQueryResultCachedGif))]
[JsonSerializable(typeof(InlineQueryResultCachedMpeg4Gif))]
[JsonSerializable(typeof(InlineQueryResultCachedSticker))]
[JsonSerializable(typeof(InlineQueryResultCachedDocument))]
[JsonSerializable(typeof(InlineQueryResultCachedVideo))]
[JsonSerializable(typeof(InlineQueryResultCachedVoice))]
[JsonSerializable(typeof(InlineQueryResultCachedAudio))]
[JsonSerializable(typeof(InputTextMessageContent))]
[JsonSerializable(typeof(InputLocationMessageContent))]
[JsonSerializable(typeof(InputVenueMessageContent))]
[JsonSerializable(typeof(InputContactMessageContent))]
[JsonSerializable(typeof(InputInvoiceMessageContent))]
[JsonSerializable(typeof(RevenueWithdrawalStatePending))]
[JsonSerializable(typeof(RevenueWithdrawalStateSucceeded))]
[JsonSerializable(typeof(RevenueWithdrawalStateFailed))]
[JsonSerializable(typeof(TransactionPartnerUser))]
[JsonSerializable(typeof(TransactionPartnerAffiliateProgram))]
[JsonSerializable(typeof(TransactionPartnerFragment))]
[JsonSerializable(typeof(TransactionPartnerTelegramAds))]
[JsonSerializable(typeof(TransactionPartnerTelegramApi))]
[JsonSerializable(typeof(TransactionPartnerOther))]
[JsonSerializable(typeof(PassportElementErrorDataField))]
[JsonSerializable(typeof(PassportElementErrorFrontSide))]
[JsonSerializable(typeof(PassportElementErrorReverseSide))]
[JsonSerializable(typeof(PassportElementErrorSelfie))]
[JsonSerializable(typeof(PassportElementErrorFile))]
[JsonSerializable(typeof(PassportElementErrorFiles))]
[JsonSerializable(typeof(PassportElementErrorTranslationFile))]
[JsonSerializable(typeof(PassportElementErrorTranslationFiles))]
[JsonSerializable(typeof(PassportElementErrorUnspecified))]
[JsonSerializable(typeof(FileBase))]
public partial class JsonBotSerializerContext : JsonSerializerContext;
#endif
