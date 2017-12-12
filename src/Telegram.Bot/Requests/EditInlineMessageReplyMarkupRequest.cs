﻿using Newtonsoft.Json;
using Telegram.Bot.Requests.Abstractions;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Requests
{
    /// <summary>
    /// Edit only the reply markup of messages sent via the bot. On success the edited True is returned.
    /// </summary>
    public class EditInlineMessageReplyMarkupRequest : RequestBase<bool>,
                                                       IInlineMessage,
                                                       IInlineReplyMarkupMessage
    {
        /// <inheritdoc />
        public string InlineMessageId { get; set; }

        /// <inheritdoc cref="IInlineReplyMarkupMessage.ReplyMarkup" />
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Initializes a new request
        /// </summary>
        public EditInlineMessageReplyMarkupRequest()
            : base("editMessageReplyMarkup")
        { }

        /// <summary>
        /// Initializes a new request with inlineMessageId and new inline keyboard
        /// </summary>
        /// <param name="inlineMessageId">Identifier of the inline message</param>
        /// <param name="replyMarkup">A JSON-serialized object for an inline keyboard</param>
        public EditInlineMessageReplyMarkupRequest(string inlineMessageId, InlineKeyboardMarkup replyMarkup = default)
            : this()
        {
            InlineMessageId = inlineMessageId;
            ReplyMarkup = replyMarkup;
        }
    }
}
