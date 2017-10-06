﻿/*
 * Copyright (c) 2017 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using SafeExamBrowser.Contracts.Behaviour;
using SafeExamBrowser.Contracts.I18n;
using SafeExamBrowser.Contracts.Logging;
using SafeExamBrowser.Contracts.UserInterface;
using SafeExamBrowser.Contracts.WindowsApi;

namespace SafeExamBrowser.Core.Behaviour.Operations
{
	public class ClipboardOperation : IOperation
	{
		private ILogger logger;
		private INativeMethods nativeMethods;

		public ISplashScreen SplashScreen { private get; set; }

		public ClipboardOperation(ILogger logger, INativeMethods nativeMethods)
		{
			this.logger = logger;
			this.nativeMethods = nativeMethods;
		}

		public void Perform()
		{
			EmptyClipboard();
		}

		public void Revert()
		{
			EmptyClipboard();
		}

		private void EmptyClipboard()
		{
			logger.Info("Emptying clipboard...");
			SplashScreen.UpdateText(TextKey.SplashScreen_EmptyClipboard);

			nativeMethods.EmptyClipboard();
		}
	}
}