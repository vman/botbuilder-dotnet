﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Bot.Schema;

namespace Microsoft.Bot.Builder.AI.QnA
{
    /// <summary>
    /// QnA dialog response options class.
    /// </summary>
    public class QnADialogResponseOptions
    {
        public const string PreciseAnswer = "PreciseAnswer";

        public const string Both = "Both";
        
        /// <summary>
        /// Gets or sets get or set for Active learning card title.
        /// </summary>
        /// <value>
        /// Get or set for Active learning card title.
        /// </value>
        public string ActiveLearningCardTitle { get; set; }

        /// <summary>
        /// Gets or sets get or set for Card no match text.
        /// </summary>
        /// <value>
        /// Get or set for Card no match text.
        /// </value>
        public string CardNoMatchText { get; set; }

        /// <summary>
        /// Gets or sets get or set for No answer.
        /// </summary>
        /// <value>
        /// Get or set for No answer.
        /// </value>
        public Activity NoAnswer { get; set; }

        /// <summary>
        /// Gets or sets get or set for Card no match response.
        /// </summary>
        /// <value>
        /// Get or set for Card no match response.
        /// </value>
        public Activity CardNoMatchResponse { get; set; }

        /// <summary>
        /// Gets or sets get or set for MRCAnswerSpanRenderingOption.
        /// </summary>
        /// <value>
        /// Get or set for Card no match MRCAnswerSpanRenderingOption.
        /// </value>
        public string ContentChoice { get; set; } = PreciseAnswer;
    }
}
