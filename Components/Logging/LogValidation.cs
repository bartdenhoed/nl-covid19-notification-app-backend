﻿// Copyright 2020 De Staat der Nederlanden, Ministerie van Volksgezondheid, Welzijn en Sport.
// Licensed under the EUROPEAN UNION PUBLIC LICENCE v. 1.2
// SPDX-License-Identifier: EUPL-1.2

using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using NL.Rijksoverheid.ExposureNotification.BackEnd.Components.Workflow;

namespace NL.Rijksoverheid.ExposureNotification.BackEnd.Components.Logging
{

    public static class LogValidation
    {
        public static bool LogValidationMessages(this ILogger logger, string[] messages)
        {
            if (messages?.Any(string.IsNullOrWhiteSpace) ?? true)
                throw new ArgumentException(nameof(messages));

            if (messages.Length == 0)
                return false;

            logger.LogError(string.Join(Environment.NewLine, messages));

            return true;
        }
    }
}