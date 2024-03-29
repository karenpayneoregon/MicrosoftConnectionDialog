﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Data.ConnectionUI {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Data.ConnectionUI.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} object was incorrectly sited..
        /// </summary>
        internal static string BadSite {
            get {
                return ResourceManager.GetString("BadSite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .NET Framework Data Provider for Microsoft SQL Server Compact 3.5.
        /// </summary>
        internal static string DataProvider_SqlEverywhere {
            get {
                return ResourceManager.GetString("DataProvider_SqlEverywhere", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this data provider to connect to a Microsoft SQL Server Compact 3.5 database file..
        /// </summary>
        internal static string DataProvider_SqlEverywhere_Description {
            get {
                return ResourceManager.GetString("DataProvider_SqlEverywhere_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PlatformService:          {0}.
        /// </summary>
        internal static string Reg_NotifyService {
            get {
                return ResourceManager.GetString("Reg_NotifyService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified file is either not a valid SQL Server Compact file or it is corrupted. Would you like to repair it?.
        /// </summary>
        internal static string SqlCeConnectionProperties_DatabaseCorruptNeedsRepair {
            get {
                return ResourceManager.GetString("SqlCeConnectionProperties_DatabaseCorruptNeedsRepair", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Repair SQL Server Compact Database.
        /// </summary>
        internal static string SqlCeConnectionProperties_DatabaseCorruptNeedsRepairTitle {
            get {
                return ResourceManager.GetString("SqlCeConnectionProperties_DatabaseCorruptNeedsRepairTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This version of Visual Studio does not support creating connection to the database files on a mobile device..
        /// </summary>
        internal static string SqlCeConnectionProperties_DeviceNotSupported {
            get {
                return ResourceManager.GetString("SqlCeConnectionProperties_DeviceNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The selected database file may be corrupted. Run the repair ultility to check the database or repair the database by creating a new data connection and completing the Add Connection dialog box..
        /// </summary>
        internal static string SqlCeConnectionProperties_FileNeedsRepair {
            get {
                return ResourceManager.GetString("SqlCeConnectionProperties_FileNeedsRepair", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The selected database was created with an earlier version of SQL Server Compact and needs to be upgraded to SQL Server Compact 3.5 before the connection can be opened or tested.  Upgrade the database by creating a new data connection and completing the Add Connection dialog box..
        /// </summary>
        internal static string SqlCeConnectionProperties_FileNeedsUpgrading {
            get {
                return ResourceManager.GetString("SqlCeConnectionProperties_FileNeedsUpgrading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This connection cannot be tested because no database file has been specified..
        /// </summary>
        internal static string SqlCeConnectionProperties_MustSpecifyDataSource {
            get {
                return ResourceManager.GetString("SqlCeConnectionProperties_MustSpecifyDataSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection properties object must be of type SqlCeConnectionProperties..
        /// </summary>
        internal static string SqlCeConnectionUIControl_InvalidConnectionProperties {
            get {
                return ResourceManager.GetString("SqlCeConnectionUIControl_InvalidConnectionProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified identifier is in an invalid format..
        /// </summary>
        internal static string SqlCeDataObjectIdentifierConverter_InvalidIdentifier {
            get {
                return ResourceManager.GetString("SqlCeDataObjectIdentifierConverter_InvalidIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &quot;{0}&quot; was not found..
        /// </summary>
        internal static string SqlCeDataObjectIdentifierConverter_InvalidType {
            get {
                return ResourceManager.GetString("SqlCeDataObjectIdentifierConverter_InvalidType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameters to EnumerateObjects are invalid..
        /// </summary>
        internal static string SqlCeObjectEnumerator_InvalidParameters {
            get {
                return ResourceManager.GetString("SqlCeObjectEnumerator_InvalidParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Advanced.
        /// </summary>
        internal static string SqlConnectionProperties_Advanced {
            get {
                return ResourceManager.GetString("SqlConnectionProperties_Advanced", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The percent of free space in the database file that is allowed before autoshrink begins (Default is 60)..
        /// </summary>
        internal static string SqlConnectionProperties_AutoshrinkThreshold {
            get {
                return ResourceManager.GetString("SqlConnectionProperties_AutoshrinkThreshold", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file path and name of the SQL Server Compact database..
        /// </summary>
        internal static string SqlConnectionProperties_DataSource {
            get {
                return ResourceManager.GetString("SqlConnectionProperties_DataSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of locks a transaction will acquire before attempting escalation from row to page, or from page to table (Default is 100)..
        /// </summary>
        internal static string SqlConnectionProperties_DefaultLockEscalation {
            get {
                return ResourceManager.GetString("SqlConnectionProperties_DefaultLockEscalation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the encryption of the database file (Default mode is platform default)..
        /// </summary>
        internal static string SqlConnectionProperties_EncryptionMode {
            get {
                return ResourceManager.GetString("SqlConnectionProperties_EncryptionMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initialization.
        /// </summary>
        internal static string SqlConnectionProperties_Initialization {
            get {
                return ResourceManager.GetString("SqlConnectionProperties_Initialization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The locale ID (LCID) to use with the database..
        /// </summary>
        internal static string SqlConnectionProperties_LocaleIdentifier {
            get {
                return ResourceManager.GetString("SqlConnectionProperties_LocaleIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum size of the database, in MB (Default 128)..
        /// </summary>
        internal static string SqlConnectionProperties_MaxDatabaseSize {
            get {
                return ResourceManager.GetString("SqlConnectionProperties_MaxDatabaseSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The database password, which can be up to 40 characters in length..
        /// </summary>
        internal static string SqlConnectionProperties_Password {
            get {
                return ResourceManager.GetString("SqlConnectionProperties_Password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Returns security-sensitive information like password as part of the connection (Default is false)..
        /// </summary>
        internal static string SqlConnectionProperties_PersistSecurityInfo {
            get {
                return ResourceManager.GetString("SqlConnectionProperties_PersistSecurityInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Security.
        /// </summary>
        internal static string SqlConnectionProperties_Security {
            get {
                return ResourceManager.GetString("SqlConnectionProperties_Security", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source.
        /// </summary>
        internal static string SqlConnectionProperties_Source {
            get {
                return ResourceManager.GetString("SqlConnectionProperties_Source", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The location of the temporary database..
        /// </summary>
        internal static string SqlConnectionProperties_TempFileDirectory {
            get {
                return ResourceManager.GetString("SqlConnectionProperties_TempFileDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified provider object is not a System.Data.SqlClient.SqlConnection..
        /// </summary>
        internal static string SqlConnectionSupport_UnrecognizedProviderObject {
            get {
                return ResourceManager.GetString("SqlConnectionSupport_UnrecognizedProviderObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to sdf;.
        /// </summary>
        internal static string SqlConnectionUIControl_BrowseFileDefaultExt {
            get {
                return ResourceManager.GetString("SqlConnectionUIControl_BrowseFileDefaultExt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SQL Server Compact 3.5 Databases (*.sdf)|*.sdf|All Files (*.*)|*.*.
        /// </summary>
        internal static string SqlConnectionUIControl_BrowseFileFilter {
            get {
                return ResourceManager.GetString("SqlConnectionUIControl_BrowseFileFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select SQL Server Compact 3.5 Database File.
        /// </summary>
        internal static string SqlConnectionUIControl_BrowseFileTitle {
            get {
                return ResourceManager.GetString("SqlConnectionUIControl_BrowseFileTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection Failed.
        /// </summary>
        internal static string SqlConnectionUIControl_ConnectionFailed {
            get {
                return ResourceManager.GetString("SqlConnectionUIControl_ConnectionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parsing values of SqlDbType {0} is not implemented..
        /// </summary>
        internal static string SqlDataParameter_ParseNotImplemented {
            get {
                return ResourceManager.GetString("SqlDataParameter_ParseNotImplemented", resourceCulture);
            }
        }
    }
}
