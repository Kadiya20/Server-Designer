public static class cString
    {
        //AssemblyInfo
        internal const string CopyrightYear = "2022";
        internal const string AssemblyVersion = "2.2.1";
        public const string dox42ManagementUI = "dox42 Management UI";
        public const string dox42 = "dox42";
        public const string managementUI = "Management UI";
        internal const string dox42CompanyName = "dox42 GmbH";
        internal const string AssemblyConfigurationDebug = "Debug";
        internal const string AssemblyConfigurationRelease = "Release";

        //SessionParameter
        internal const string SessionKeyTrustedLocations = "trustedlocations-37ffa291-a70b-4a48-9442-9dc57ca9147f";
        internal const string SessionKeyADs = "azuread-4d221b76-1a62-4068-a118-6e00d1e0349b";
        internal const string SessionKeyUploadedFiles = "uploadedfiles-22397c1a-b6c2-4ae3-8119-43c37d5763ad";
        internal const string SessionKeyErrorMessage = "errormessage-79a8cc1d-7580-41a2-b395-65d8ccadd20a";
        internal const string SessionKeyManageFilesEnabled = "uploadEnabled-0ab3d8eb-3dd1-4c75-a8dc-fa7abade4f60";
        internal const string SessionKeyInitialSiteEnabled = "initialSiteEnabled-384f01c7-48dc-43a1-8bb6-439c8fa48e72";

        //Global
        internal static readonly string DayFormat = "dd.MM.yyyy";

        //AppSettings
        internal const string PathToFriendlyNameJson = "https://www.dox42.com/Modules/friendlyNames.json";
        internal const string PathTodox42AdditionalModulesJson = "https://www.dox42.com/Modules/dox42AdditionalModules.json";
        internal const string PathToDocumentationLinks = "https://www.dox42.com/Modules/documentationLinks.json";
        internal const string PathToContactInfo = "https://www.dox42.com/Modules/contactInfo.json";
        internal const string LicenseFilePath = "LicenseFilePath";
        internal static readonly string Dox42InstallFolder = "dox42InstallFolder";
        internal static readonly string TrialExpiration = "TrialExpiration";
        internal static readonly string Web_config = "Web.config";
        internal static readonly string NLog_config = "NLog.config";
        internal static readonly string Dox42InstallLocation_errorHint = "Hint: Check your dox42 install locations.";

        //PasswordReset
        public static string EmailDraftHtmlFilePath = "Content/ChangePasswordEmailDraft.html";
        internal static string formsAuth_RecoveryEmail = "formsAuth:RecoveryEmail";
        internal static string PasswordResetTokenKey = "passwordchangetoken";
        internal static object PathToPasswordResetPage = "/Account/ChangePassword.aspx";
        internal static string PasswordResetEmailSubject = "Password Reset Request";
        internal static string PasswordResetEmailSender = "development@dox42.com";
        internal static string PasswordResetEmailUrlToReplace = "https://bit.li.utlddssdstueincx";
        internal static double PasswordResetTokenMinutesToExpire = 5;

        //AppSettings key for dox42Server Web.Config
        internal static readonly string Dox42ServerMail = "dox42ServerMail";
        internal static readonly string MailServerPassWord = "MailServerPassWord";
        internal static readonly string MailServerPassWordDefaultValue = "****";
        internal static readonly string MailServer = "MailServer";
        internal static readonly string SendErrorsToMail = "SendErrorsToMail";
        internal static readonly string AppSettings_errorHint = "Hint: Check the Web.config, especially for incorrect file paths.";

        //TrustedTemplateLocations section
        internal static readonly string TrustedTemplateLocations = "trustedTemplateLocations";
        internal static readonly string AzureAD = "azureAD";
        internal static readonly string Key = "key";
        internal static readonly string Value = "value";
        internal static readonly string TrustedLocation_errorHint = "Hint: Check the trusted locations configuration.";

        //Users section
        internal static readonly string AuthorizedUsers = "system.web/authorization";
        internal static readonly string SessionKeyUsers = "authorizedUsers";
        internal static readonly string AuthorizedUsers_errorHint = "Hint: Check the authorized users";

        internal static readonly string AuthenticationSection = "system.web/authentication";

        //Controls + Grid
        internal static readonly string TxtNewPassword = "txtNewPassword";
        internal static readonly string Http = "http";

        //XAttributes
        internal static readonly string Resource365 = "resource365";
        internal static readonly string AppID = "appID";
        internal static readonly string Tenant = "tenant";
        internal static readonly string ClientKey = "clientKey";
        internal static readonly string Add = "add";
        internal static readonly string AzureADSettings_errorHint = "Hint: Check the AzureAD settings.";
        //Name of the "enabled" property of buttons
        internal const string EnabledButtonState = "Enabled";
        internal static string SavedAtTimeNow(string time)
        {
            return "Saved at " + time;
        }

        //Aspose-License upload
        internal static readonly string AsposeExtension = ".lic";
        internal enum UploadStatus
        {
            [Description("Upload status: File uploaded!")]
            Uploaded,

            [Description("Upload status: The file could not be uploaded. The following error occured: ")]
            Error,

            [Description("Upload status: The file could not be uploaded. This file is not a valid licence file")]
            InvalidFile
        }
        internal static string GetText(Enum val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
        internal static readonly string UploadStatus_uploaded = "Upload status: File uploaded!";
        internal static readonly string UploadStatus_errorCode = "Upload status: The file could not be uploaded. The following error occured: ";
        internal static readonly string UploadStatus_invalidFile = "Upload status: The file could not be uploaded. This file is not a valid licence file";
        internal const string TemplateAsposeFile = "<License><Data><LicensedTo></LicensedTo><EmailTo></EmailTo><LicenseType></LicenseType><LicenseNote></LicenseNote><OrderID></OrderID><UserID></UserID><OEM></OEM><Products><Product></Product></Products><EditionType></EditionType><SerialNumber></SerialNumber><SubscriptionExpiry></SubscriptionExpiry><LicenseVersion></LicenseVersion><LicenseInstructions></LicenseInstructions></Data><Signature></Signature></License>";
        internal const string InvalidAsposeLicenseFileError = "The Aspose license file provided is not valid!";
        internal const string InvalidAsposeLicenseFileExtensionError = "Invalid file name!";
        internal const string AsposeLicenseFileExactName = "Aspose.Total.lic";

        //Startup
        internal static readonly string Ida_ClientId = "microsoftAuth:ClientId";
        internal static readonly string MicrosoftAuth_RedirectUrl = "microsoftAuth:RedirectUrl";
        internal const string MicrosoftCommonAzureADEndpoint = "https://login.microsoftonline.com/common";

        internal static readonly string WebconfigSetupPageEnabled = "SetupPageEnabled";
        internal static readonly string formsAuth_Username = "formsAuth:Username";
        internal static readonly string formsAuth_Password = "formsAuth:Password";
        internal static readonly string formsAuth_InitialLogin = "formsAuth:InitialLogin";
        internal static readonly string WebconfigActiveAuth = "ActiveAuth";

        //Support.aspx.cs
        internal static readonly int PasswordCharacterLimit = 32;
        internal static string CurrentAuthSettings = "Current Settings";
        internal static string PasswordRestrictions = "Must contain at least 1 capital letter, 1 number and 1 special character. Must be 8-32 characters long";
        internal static string ErrorPageName = "Error.aspx";
        internal static string UploadPathTrustedTemplateLocationKey = "uploadPath";
        private static int Images;

        //Support.aspx.cs
        internal static readonly string Log = "Log";
        internal enum LogFileStatus
        {
            [Description("No Logfile found")]
            NotFound,

            [Description("Latest logfile: ")]
            LatestFound
        }
        internal static string GetText(this LogFileStatus val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }

        internal const string TestRestCallUrl = "dox42RestService.ashx?Operation=GenerateDocument&DocTemplate=https%3A%2F%2Fdox42.online%2F%2Ftestpage%2FTestpage.docx&ReturnAction.format=pdf&ReturnAction.fileName=Testpage.pdf&ReturnAction.disp=attachment&InputParam.Instanzname=";

        internal static readonly string Dox42Core_dll = "bin\\dox42Core.dll";

        internal const string Div = "div";
        internal const string Label = "label";
        internal const string DivWrapperCssClasses = "col-12 d-flex p-2 rounded bg-white border mb-3";
        internal const string DivCheckboxContainerCssClasses = "custom-control custom-checkbox my-auto";
        internal const string Class = "class";
        internal const string Chk = "chk";
        internal const string CheckboxCssClasses = "custom-control-input module-checkbox";
        internal const string Checked = "checked";
        internal const string True = "true";
        internal const string False = "false";
        internal const string OnClick = "onclick";
        internal const string CheckboxOnClickFunction = "return false;";
        internal const string CheckboxLabelCssClasses = "custom-control-label";
        internal const string For = "for";


        //gridAzureAD_RowUpdating
        internal static readonly string Provide_O365URL = "Please provide a O365 Url";

        //gridTrustedLocations_RowUpdating
        internal static readonly string Provide_HttpLocation = "Please provide only locations starting with http.";

        //gridUsers_RowUpdating
        internal static readonly string Provide_Username = "Please provide a username";

        //LogLevels
        internal static readonly string Rules = "rules";
        internal static readonly string Minlevel = "minlevel";

        //Help.aspx.cs
        internal static readonly string LinkTarget = "'_blank'";

        //Helper.cs
        internal static string ReturnFormattedTime()
        {
            return string.Format("{0} {1}", DateTime.Now.ToLocalTime().ToString("dd.MM.yyyy HH:mm:ss"), ReturnAbbreviatedLocalTimeZoneNameWithUTCOffset());
        }

        internal static string ReturnAbbreviatedLocalTimeZoneNameWithUTCOffset()
        {
            string timeZoneString = TimeZoneInfo.Local.StandardName;
            string utcOffsetString = TimeZoneInfo.Local.DisplayName.Substring(0, TimeZoneInfo.Local.DisplayName.IndexOf(')')+1);
            string result = string.Concat(System.Text.RegularExpressions.Regex
           .Matches(timeZoneString, "[A-Z]")
           .OfType<System.Text.RegularExpressions.Match>()
           .Select(match => match.Value));

            return string.Format("{0} {1}", result, utcOffsetString);
        }
        internal static readonly string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        internal static readonly string FilePathLastDeployed = Path.Combine(BaseDirectory, "App_LocalResources\\LastDeployed.txt");

        //Setup Tooltips and Errors
        internal static readonly string InvalidAppIDError = "Please enter a valid App ID (Client ID)!";
        internal static readonly string AppIDToolTip = "Enter the App ID (Client ID) of your dox42 Online Azure AD App registration";


        internal static readonly string HTMLFontAwesomeQuestionMark = "<i class='text-success fas fa-question-circle mx-1' style='font-size:16px'></i>";
        static readonly string HTMLFontawesomeSignout = "<i class='fa fa-sign-out-alt mx-1'></i>";
        internal static readonly string HTMLFontawesomeSave = "<i class='fa fa-save mx-1'></i>";
        internal static readonly string HTMLFontawesomePlus = "<i class='fa fa-plus mx-1' style='color:green'></i>";
        internal static readonly string HTMLFontawesomeInputParam = "<i class='fa-solid fa-circle-question' style='color:blue'></i>";/*fa-lg*/
        internal static readonly string HTMLFontawesomeSHLogin = "<i class='fa-solid fa-key' style='color:blue'></i>";
        internal static readonly string HTMLFontawesomeUp = "<i class='fa-solid fa-arrow-up'></i>";
        internal static readonly string HTMLFontawesomeDown = "<i class='fa-solid fa-arrow-down'></i>";
        internal static readonly string HTMLFontawesomeDelete = "<i class='fa-solid fa-trash-can'></i>";
        internal static readonly string HTMLFontawesomeClone = "<i class='fa-solid fa-clone'></i>";
        internal static readonly string HTMLFontawesomeRename = "<i class='fa-solid fa-pen'></i>";
        internal static readonly string HTMLFontawesomeSaveAction = "<i class='fa-solid fa-floppy-disk'></i>"; /*fa-3x*/
        internal static readonly string HTMLFontawesomeEmail = "<i class='fa-solid fa-envelope'></i>";
        internal static readonly string HTMLFontawesomeReturn = "<i class='fa-solid fa-file'></i>";
        internal static readonly string HTMLFontawesomePrint = "<i class='fa-solid fa-print'></i>";
        internal static readonly string HTMLFontawesomeSql = "<i class='fa-solid fa-database'></i>";
        internal static readonly string HTMLFontawesomeDocuSign = "<i class='fa-solid fa-signature'></i>";
        internal static readonly string HTMLFontawesomeDownloadSidebar = "<i class='fa-solid fa-file-arrow-down'></i>";
        internal static readonly string HTMLFontawesomeCodeSidebar = "<i class='fa-solid fa-code'></i>";
        internal static readonly string HTMLFontawesomeCostumeSidebar = "<i class='fa-solid fa-star'></i>";




        internal static readonly string HTMLFontawesomeTrash = "<i class='fa fa-trash mx-1'></i>";
        static readonly string HTMLFontawesomeEdit = "<i class='fas fa-edit mx-1'></i>";
        static readonly string HTMLFontawesomeDownload = "<i class='fas fa-download mx-1'></i>";
        internal static readonly string HTMLFontawesomeFlask = "<i class='fas fa-flask mx-1'></i>";
        internal static readonly string HTMLFontawesomePowerOff = "<i class='fas fa-power-off mx-1'></i>";
        internal const string HTMLFontawesomeUserCog = "<i class='fas fa-user-cog mx-1'></i>";

        internal static readonly string MainButtonSaveAndDeployWithFA = "Save and Deploy" + HTMLFontawesomeSave;
        internal static readonly string MainButtonCancelWithoutFA = "Cancel";
        internal static readonly string DownloadWithFA = "Download" + HTMLFontawesomeDownload;
        internal static readonly string AddWithFA = HTMLFontawesomePlus;
        internal static readonly string InputParams = HTMLFontawesomeInputParam;
        internal static readonly string SHLogin = HTMLFontawesomeSHLogin;
        internal static readonly string Up = HTMLFontawesomeUp;
        internal static readonly string Down = HTMLFontawesomeDown;
        internal static readonly string Delete = HTMLFontawesomeDelete;
        internal static readonly string Clone = HTMLFontawesomeClone;
        internal static readonly string Rename = HTMLFontawesomeRename;
        internal static readonly string Save = HTMLFontawesomeSaveAction;
        internal static readonly string Email = HTMLFontawesomeEmail;
        internal static readonly string Return = HTMLFontawesomeReturn;
        internal static readonly string Print = HTMLFontawesomePrint;
        internal static readonly string Sql = HTMLFontawesomeSql;
        internal static readonly string DocuSign = HTMLFontawesomeDocuSign;
        internal static readonly string DownloadSidebar = HTMLFontawesomeDownloadSidebar;
        internal static readonly string CodeSidebar = HTMLFontawesomeCodeSidebar;
        internal static readonly string CostumeSidebar = HTMLFontawesomeCostumeSidebar;

        //Errors and warnings:

        public const String DeleteWarningTitle = "Changes made are irreversible!";
        public const String DeleteWarningText = "Are you sure you want to delete?";
        public const String SaveWarningTitle = "Save Changes";
        public const String SaveWarningText = "Do you want to save the current config?";
        public const String ClosingWarningText = "Do you really want to close this dialog?";
        public const String RecentWarningTitle = "Keep filepath?";
        public const String RecentWarningText = "Do you want to keep this file path even though the file does not exist?";
        public const String EmptyParammetersText = "Some Actions don't have any parameter values. They will not be saved. Do you want to continue?";
        public const String ConvertToLiveConfigText = "You are about to overwrite an old dox42 Test Client config, it will be saved to a new dox42 Live Config. Do you wish to continue?";
        public const String SpecifyTemplatePathOperation = "Please specify a TemplatePath and Operation in the selected call!";
        public const String SpecifyValidUrl = "Please specify a valid dox42ServiceUrl!";
        public const String PublicCertificateFileErrorTitle = "Public key file could not be imported";
        public const String PublicCertificateFileErrorText = "Something went wrong while importing the public key file!";
        public const String PrivateCertificateFileErrorTitle = "Private key file could not be imported";
        public const String PrivateCertificateFileErrorText = "Something went wrong while importing the private key file!";
        public const String AppRegistrationParametersMissing = "Something went wrong while importing the private key file!";

        public const String ResturlCallMultipleCallsError = "REST Call cannot have multiple dox42 Output Actions of the same kind";
        public const String AddCallError = "Failed adding a Call";
        public const String Dox42ServiceError = "An error has occured launching the dox42 service";
        public const String InitError = "initialization failed";
        public const String ButtonGrayOurError = "Disabeling the buttons has failed";
        public const String BeforeSelectError = "An error has occured during the selection of an item";
        public const String AfterSelectError = "An error has occured, the item could not be selected";
        public const String ToGuiError = "An error occured during the loading of the GUI";
        public const String SaveConfigError = "Config could not be saved";
        public const String LoadConfigError = "Config could not be loaded";
        public const String PropertyGridValueChangedError = "Value could not be changed";
        public const String PropertyGridFocusedRowChangedError = "Focused row could not be changed";
        public const String DataGridValueChangedError = "The edit grid could not be updated";
        public const String ItemCloneError = "An error occured while cloning the selected Item";
        public const String ItemDeleteError = "An error occured deleting the selected Item";
        public const String ItemMoveError = "An error occured moving the selected Item";
        public const String HtmlDisplayError = "An error occured while displaying text on the HTML field";
        public const String NodeParamsUpdateError = "An Error occured updating the node parameters";
        public const String RestUrlError = "An error occured generating the REST URL";
        public const String AddInputParamsError = "An error occured adding the inputParams";
        public const String SaveGridPropertiesError = "An error occured saving the edit grid";
        public const String LoadGridPropertiesError = "An error occured loading the edit grid";
        public const String SaveDox42LiveError = "An error occured saving the Dox42Live config";
        public const String LoadDox42LiveError = "An error occured loading the Dox42Live config";
        public const String LoadDox42LiveNoNodesError = "No nodes found in the config file";
        public const String OpenDox42ServerDocError = "An error occured saving the Dox42Live config";
        public const String OpenReturnedFileError = "An error occured loading the the returned file";
        public const String ReturnedFileEmptyError = "The Format, in which the returned file should open, is empty. \n Please insert a format, e.g .pdf";
        public const String RenameActionError = "Only custom output actions can be renamed!";
        public const String TenantAndClientIdParameterRequiredError = "Tenant ID and client ID are required for this operation!";
        public const String CertificateFileRequiredError = "A certificate is required for this operation!";
        public const String CertificatePrivateKeyError = "The certificate may not contain a private key.";
        public const String ClientAssertionError = "Something went wrong while generating a client assertion";
        public const String InvalidClientOrTenantError = "Please enter valid tenant and app Ids!";
        public const String NoTokenProvidedError = "You must enter a valid access token to proceed!";
        public const String AzureAdRequiredError = "One of the call actions requires Azure AD to function, please add an Azure AD header!";
        public const string DuplicateCustomOutputActionNames = "A custom output action with this name already exists";
        public const string CreationFailed = "Creation failed";

        //Action Initialization
        public const string JsonConfigPath = "https://www.dox42.com/modules/serverdesigneroutputactions.json";
        public const string ActionJsonConfigKey = "actions";
        public const string StartingCallName = "Call - ";

    }