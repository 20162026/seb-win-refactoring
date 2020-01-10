﻿/*
 * Copyright (c) 2020 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace SafeExamBrowser.Configuration.ConfigurationData
{
	internal static class Keys
	{
		internal const int WINDOWS = 1;

		internal static class Applications
		{
			internal const string Active = "active";
			internal const string AllowCustomPath = "allowUserToChooseApp";
			internal const string AllowRunning = "runInBackground";
			internal const string Argument = "argument";
			internal const string Arguments = "arguments";
			internal const string AutoStart = "autostart";
			internal const string AutoTerminate = "strongKill";
			internal const string Blacklist = "prohibitedProcesses";
			internal const string Description = "description";
			internal const string DisplayName = "title";
			internal const string ExecutableName = "executable";
			internal const string ExecutablePath = "path";
			internal const string OperatingSystem = "os";
			internal const string OriginalName = "originalName";
			internal const string ShowInShell = "iconInTaskbar";
			internal const string Whitelist = "permittedProcesses";
		}

		internal static class Audio
		{
			internal const string InitialVolumeLevel = "audioVolumeLevel";
			internal const string MuteAudio = "audioMute";
			internal const string SetInitialVolumeLevel = "audioSetVolumeLevel";
		}

		internal static class Browser
		{
			internal const string AllowConfigurationDownloads = "downloadAndOpenSebConfig";
			internal const string AllowDeveloperConsole = "allowDeveloperConsole";
			internal const string AllowDownloads = "allowDownUploads";
			internal const string AllowPageZoom = "enableZoomPage";
			internal const string CustomUserAgentDesktop = "browserUserAgentWinDesktopModeCustom";
			internal const string CustomUserAgentMobile = "browserUserAgentWinTouchModeCustom";
			internal const string EnableBrowser = "enableSebBrowser";
			internal const string PopupPolicy = "newBrowserWindowByLinkPolicy";
			internal const string PopupBlockForeignHost = "newBrowserWindowByLinkBlockForeign";
			internal const string QuitUrl = "quitURL";
			internal const string QuitUrlConfirmation = "quitURLConfirm";
			internal const string ShowToolbar = "enableBrowserWindowToolbar";
			internal const string SendCustomHeaders = "sendBrowserExamKey";
			internal const string StartUrl = "startURL";
			internal const string UserAgentModeDesktop = "browserUserAgentWinDesktopMode";
			internal const string UserAgentModeMobile = "browserUserAgentWinTouchMode";

			internal static class AdditionalWindow
			{
				internal const string AllowAddressBar = "newBrowserWindowAllowAddressBar";
				internal const string AllowNavigation = "newBrowserWindowNavigation";
				internal const string AllowReload = "newBrowserWindowAllowReload";
				internal const string ShowReloadWarning = "newBrowserWindowShowReloadWarning";
				internal const string WindowHeight = "newBrowserWindowByLinkHeight";
				internal const string WindowWidth = "newBrowserWindowByLinkWidth";
				internal const string WindowPosition = "newBrowserWindowByLinkPositioning";
			}

			internal static class Filter
			{
				internal const string EnableContentRequestFilter = "URLFilterEnableContentFilter";
				internal const string EnableMainRequestFilter = "URLFilterEnable";
				internal const string FilterRules = "URLFilterRules";
				internal const string RuleAction = "action";
				internal const string RuleIsActive = "active";
				internal const string RuleExpression = "expression";
				internal const string RuleExpressionIsRegex = "regex";
			}

			internal static class MainWindow
			{
				internal const string AllowAddressBar = "browserWindowAllowAddressBar";
				internal const string AllowNavigation = "allowBrowsingBackForward";
				internal const string AllowReload = "browserWindowAllowReload";
				internal const string ShowReloadWarning = "showReloadWarning";
				internal const string WindowHeight = "mainBrowserWindowHeight";
				internal const string WindowMode = "browserViewMode";
				internal const string WindowWidth = "mainBrowserWindowWidth";
				internal const string WindowPosition = "mainBrowserWindowPositioning";
			}

			internal static class Proxy
			{
				internal const string AutoConfigure = "AutoConfigurationEnabled";
				internal const string AutoConfigureUrl = "AutoConfigurationURL";
				internal const string AutoDetect = "AutoDiscoveryEnabled";
				internal const string BypassList = "ExceptionsList";
				internal const string Policy = "proxySettingsPolicy";
				internal const string Settings = "proxies";

				internal static class Ftp
				{
					internal const string Enable = "FTPEnable";
					internal const string Host = "FTPProxy";
					internal const string Password = "FTPPassword";
					internal const string Port = "FTPPort";
					internal const string RequiresAuthentication = "FTPRequiresPassword";
					internal const string Username = "FTPUsername";
				}

				internal static class Http
				{
					internal const string Enable   = "HTTPEnable";
					internal const string Host = "HTTPProxy";
					internal const string Password = "HTTPPassword";
					internal const string Port = "HTTPPort";
					internal const string RequiresAuthentication = "HTTPRequiresPassword";
					internal const string Username = "HTTPUsername";
				}

				internal static class Https
				{
					internal const string Enable = "HTTPSEnable";
					internal const string Host = "HTTPSProxy";
					internal const string Password = "HTTPSPassword";
					internal const string Port = "HTTPSPort";
					internal const string RequiresAuthentication = "HTTPSRequiresPassword";
					internal const string Username = "HTTPSUsername";
				}

				internal static class Socks
				{
					internal const string Enable = "SOCKSEnable";
					internal const string Host = "SOCKSProxy";
					internal const string Password = "SOCKSPassword";
					internal const string Port = "SOCKSPort";
					internal const string RequiresAuthentication = "SOCKSRequiresPassword";
					internal const string Username = "SOCKSUsername";
				}
			}
		}

		internal static class ConfigurationFile
		{
			internal const string AdminPasswordHash = "hashedAdminPassword";
			internal const string ConfigurationPurpose = "sebConfigPurpose";
			internal const string KeepClientConfigEncryption = "clientConfigKeepEncryption";
		}

		internal static class General
		{
			internal const string AllowApplicationLog = "allowApplicationLog";
			internal const string LogLevel = "logLevel";
			internal const string OriginatorVersion = "originatorVersion";
		}

		internal static class Keyboard
		{
			internal const string EnableAltEsc = "enableAltEsc";
			internal const string EnableAltTab = "enableAltTab";
			internal const string EnableAltF4 = "enableAltF4";
			internal const string EnableCtrlEsc = "enableCtrlEsc";
			internal const string EnableEsc = "enableEsc";
			internal const string EnableF1 = "enableF1";
			internal const string EnableF2 = "enableF2";
			internal const string EnableF3 = "enableF3";
			internal const string EnableF4 = "enableF4";
			internal const string EnableF5 = "enableF5";
			internal const string EnableF6 = "enableF6";
			internal const string EnableF7 = "enableF7";
			internal const string EnableF8 = "enableF8";
			internal const string EnableF9 = "enableF9";
			internal const string EnableF10 = "enableF10";
			internal const string EnableF11 = "enableF11";
			internal const string EnableF12 = "enableF12";
			internal const string EnablePrintScreen = "enablePrintScreen";
			internal const string EnableSystemKey = "enableStartMenu";
		}

		internal static class Mouse
		{
			internal const string EnableRightMouse = "enableRightMouse";
		}

		internal static class Network
		{
			internal static class Certificates
			{
				internal const string CertificateData = "certificateData";
				internal const string CertificateType = "type";
				internal const string EmbeddedCertificates = "embeddedCertificates";
			}
		}

		internal static class Security
		{
			internal const string AllowVirtualMachine = "allowVirtualMachine";
			internal const string KioskModeCreateNewDesktop = "createNewDesktop";
			internal const string KioskModeDisableExplorerShell = "killExplorerShell";
			internal const string QuitPasswordHash = "hashedQuitPassword";
			internal const string ServicePolicy = "sebServicePolicy";
		}

		internal static class UserInterface
		{
			internal const string ShowAudio = "audioControlEnabled";
			internal const string ShowClock = "showTime";
			internal const string ShowKeyboardLayout = "showInputLanguage";
			internal const string ShowWirelessNetwork = "allowWlan";
			internal const string UserInterfaceMode = "touchOptimized";

			internal static class Taskbar
			{
				internal const string ShowApplicationLog = "showApplicationLogButton";
			}
		}
	}
}
