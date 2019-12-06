using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateThirdPartyReferencesInModuleBuild.Classes
{




    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class CreateModuleInfo
    {

        private CreateModuleInfoClients clientsField;

        private CreateModuleInfoResources resourcesField;

        private object versionField;

        private string descriptionField;

        /// <remarks/>
        public CreateModuleInfoClients Clients
        {
            get
            {
                return this.clientsField;
            }
            set
            {
                this.clientsField = value;
            }
        }

        /// <remarks/>
        public CreateModuleInfoResources Resources
        {
            get
            {
                return this.resourcesField;
            }
            set
            {
                this.resourcesField = value;
            }
        }

        /// <remarks/>
        public object Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CreateModuleInfoClients
    {

        private string dotNetCoreDllField;

        private string dotNetFrontendFrameworkDllField;

        private string sLCoreDllField;

        private string sLFrontendFrameworkDllField;

        private string silverLightsSDKAssembliesPathField;

        private string[] referencesField;

        private bool copyReferenceToModuleField;

        /// <remarks/>
        public string DotNetCoreDll
        {
            get
            {
                return this.dotNetCoreDllField;
            }
            set
            {
                this.dotNetCoreDllField = value;
            }
        }

        /// <remarks/>
        public string DotNetFrontendFrameworkDll
        {
            get
            {
                return this.dotNetFrontendFrameworkDllField;
            }
            set
            {
                this.dotNetFrontendFrameworkDllField = value;
            }
        }

        /// <remarks/>
        public string SLCoreDll
        {
            get
            {
                return this.sLCoreDllField;
            }
            set
            {
                this.sLCoreDllField = value;
            }
        }

        /// <remarks/>
        public string SLFrontendFrameworkDll
        {
            get
            {
                return this.sLFrontendFrameworkDllField;
            }
            set
            {
                this.sLFrontendFrameworkDllField = value;
            }
        }

        /// <remarks/>
        public string SilverLightsSDKAssembliesPath
        {
            get
            {
                return this.silverLightsSDKAssembliesPathField;
            }
            set
            {
                this.silverLightsSDKAssembliesPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public string[] References
        {
            get
            {
                return this.referencesField;
            }
            set
            {
                this.referencesField = value;
            }
        }

        /// <remarks/>
        public bool CopyReferenceToModule
        {
            get
            {
                return this.copyReferenceToModuleField;
            }
            set
            {
                this.copyReferenceToModuleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CreateModuleInfoResources
    {

        private CreateModuleInfoResourcesServicesDlls servicesDllsField;

        private object cliDllsField;

        private object webPagesField;

        private object silverlightDllsField;

        private object agentDllsField;

        private object installScriptField;

        private object sqlScriptsField;

        private object objectsToImportField;

        private object msSqlScriptField;

        private bool noComponentsField;

        /// <remarks/>
        public CreateModuleInfoResourcesServicesDlls ServicesDlls
        {
            get
            {
                return this.servicesDllsField;
            }
            set
            {
                this.servicesDllsField = value;
            }
        }

        /// <remarks/>
        public object CliDlls
        {
            get
            {
                return this.cliDllsField;
            }
            set
            {
                this.cliDllsField = value;
            }
        }

        /// <remarks/>
        public object WebPages
        {
            get
            {
                return this.webPagesField;
            }
            set
            {
                this.webPagesField = value;
            }
        }

        /// <remarks/>
        public object SilverlightDlls
        {
            get
            {
                return this.silverlightDllsField;
            }
            set
            {
                this.silverlightDllsField = value;
            }
        }

        /// <remarks/>
        public object AgentDlls
        {
            get
            {
                return this.agentDllsField;
            }
            set
            {
                this.agentDllsField = value;
            }
        }

        /// <remarks/>
        public object InstallScript
        {
            get
            {
                return this.installScriptField;
            }
            set
            {
                this.installScriptField = value;
            }
        }

        /// <remarks/>
        public object SqlScripts
        {
            get
            {
                return this.sqlScriptsField;
            }
            set
            {
                this.sqlScriptsField = value;
            }
        }

        /// <remarks/>
        public object ObjectsToImport
        {
            get
            {
                return this.objectsToImportField;
            }
            set
            {
                this.objectsToImportField = value;
            }
        }

        /// <remarks/>
        public object MsSqlScript
        {
            get
            {
                return this.msSqlScriptField;
            }
            set
            {
                this.msSqlScriptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NoComponents
        {
            get
            {
                return this.noComponentsField;
            }
            set
            {
                this.noComponentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CreateModuleInfoResourcesServicesDlls
    {

        private string stringField;

        /// <remarks/>
        public string @string
        {
            get
            {
                return this.stringField;
            }
            set
            {
                this.stringField = value;
            }
        }
    }





}

