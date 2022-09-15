// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.MSGraph.Version1_0.Applications.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftGraphServicePrincipal : MicrosoftGraphDirectoryObject
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftGraphServicePrincipal
        /// class.
        /// </summary>
        public MicrosoftGraphServicePrincipal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftGraphServicePrincipal
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="id">Read-only.</param>
        /// <param name="deletedDateTime"></param>
        /// <param name="tags">Custom strings that can be used to categorize
        /// and identify the service principal. Not nullable. Supports $filter
        /// (eq, NOT, ge, le, startsWith).</param>
        /// <param name="accountEnabled">true if the service principal account
        /// is enabled; otherwise, false. Supports $filter (eq, ne, NOT,
        /// in).</param>
        /// <param name="alternativeNames">Used to retrieve service principals
        /// by subscription, identify resource group and full resource ids for
        /// managed identities. Supports $filter (eq, NOT, ge, le,
        /// startsWith).</param>
        /// <param name="appDescription">The description exposed by the
        /// associated application.</param>
        /// <param name="appDisplayName">The display name exposed by the
        /// associated application.</param>
        /// <param name="appId">The unique identifier for the associated
        /// application (its appId property).</param>
        /// <param name="appOwnerOrganizationId">Contains the tenant id where
        /// the application is registered. This is applicable only to service
        /// principals backed by applications.Supports $filter (eq, ne, NOT,
        /// ge, le).</param>
        /// <param name="appRoleAssignedTo">App role assignments for this app
        /// or service, granted to users, groups, and other service
        /// principals.Supports $expand.</param>
        /// <param name="appRoleAssignmentRequired">Specifies whether users or
        /// other service principals need to be granted an app role assignment
        /// for this service principal before users can sign in or apps can get
        /// tokens. The default value is false. Not nullable. Supports $filter
        /// (eq, ne, NOT).</param>
        /// <param name="appRoleAssignments">App role assignment for another
        /// app or service, granted to this service principal. Supports
        /// $expand.</param>
        /// <param name="appRoles">The roles exposed by the application which
        /// this service principal represents. For more information see the
        /// appRoles property definition on the application entity. Not
        /// nullable.</param>
        /// <param name="applicationTemplateId">Unique identifier of the
        /// applicationTemplate that the servicePrincipal was created from.
        /// Read-only. Supports $filter (eq, ne, NOT, startsWith).</param>
        /// <param name="createdObjects">Directory objects created by this
        /// service principal. Read-only. Nullable.</param>
        /// <param name="description">Free text field to provide an internal
        /// end-user facing description of the service principal. End-user
        /// portals such MyApps will display the application description in
        /// this field. The maximum allowed size is 1024 characters. Supports
        /// $filter (eq, ne, NOT, ge, le, startsWith) and $search.</param>
        /// <param name="disabledByMicrosoftStatus">Specifies whether Microsoft
        /// has disabled the registered application. Possible values are: null
        /// (default value), NotDisabled, and
        /// DisabledDueToViolationOfServicesAgreement (reasons may include
        /// suspicious, abusive, or malicious activity, or a violation of the
        /// Microsoft Services Agreement).  Supports $filter (eq, ne,
        /// NOT).</param>
        /// <param name="displayName">The display name for the service
        /// principal. Supports $filter (eq, ne, NOT, ge, le, in, startsWith),
        /// $search, and $orderBy.</param>
        /// <param name="endpoints">Endpoints available for discovery. Services
        /// like Sharepoint populate this property with a tenant specific
        /// SharePoint endpoints that other applications can discover and use
        /// in their experiences.</param>
        /// <param name="homepage">Home page or landing page of the
        /// application.</param>
        /// <param name="keyCredentials">The collection of key credentials
        /// associated with the service principal. Not nullable. Supports
        /// $filter (eq, NOT, ge, le).</param>
        /// <param name="loginUrl">Specifies the URL where the service provider
        /// redirects the user to Azure AD to authenticate. Azure AD uses the
        /// URL to launch the application from Microsoft 365 or the Azure AD My
        /// Apps. When blank, Azure AD performs IdP-initiated sign-on for
        /// applications configured with SAML-based single sign-on. The user
        /// launches the application from Microsoft 365, the Azure AD My Apps,
        /// or the Azure AD SSO URL.</param>
        /// <param name="logoutUrl">Specifies the URL that will be used by
        /// Microsoft's authorization service to logout an user using OpenId
        /// Connect front-channel, back-channel or SAML logout
        /// protocols.</param>
        /// <param name="memberOf">Roles that this service principal is a
        /// member of. HTTP Methods: GET Read-only. Nullable. Supports
        /// $expand.</param>
        /// <param name="notes">Free text field to capture information about
        /// the service principal, typically used for operational purposes.
        /// Maximum allowed size is 1024 characters.</param>
        /// <param name="notificationEmailAddresses">Specifies the list of
        /// email addresses where Azure AD sends a notification when the active
        /// certificate is near the expiration date. This is only for the
        /// certificates used to sign the SAML token issued for Azure AD
        /// Gallery applications.</param>
        /// <param name="oauth2PermissionGrants">Delegated permission grants
        /// authorizing this service principal to access an API on behalf of a
        /// signed-in user. Read-only. Nullable.</param>
        /// <param name="oauth2PermissionScopes">The delegated permissions
        /// exposed by the application. For more information see the
        /// oauth2PermissionScopes property on the application entity's api
        /// property. Not nullable.</param>
        /// <param name="ownedObjects">Directory objects that are owned by this
        /// service principal. Read-only. Nullable. Supports $expand.</param>
        /// <param name="owners">Directory objects that are owners of this
        /// servicePrincipal. The owners are a set of non-admin users or
        /// servicePrincipals who are allowed to modify this object. Read-only.
        /// Nullable. Supports $expand.</param>
        /// <param name="passwordCredentials">The collection of password
        /// credentials associated with the service principal. Not
        /// nullable.</param>
        /// <param name="preferredSingleSignOnMode">Specifies the single
        /// sign-on mode configured for this application. Azure AD uses the
        /// preferred single sign-on mode to launch the application from
        /// Microsoft 365 or the Azure AD My Apps. The supported values are
        /// password, saml, notSupported, and oidc.</param>
        /// <param name="preferredTokenSigningKeyThumbprint">Reserved for
        /// internal use only. Do not write or otherwise rely on this property.
        /// May be removed in future versions.</param>
        /// <param name="replyUrls">The URLs that user tokens are sent to for
        /// sign in with the associated application, or the redirect URIs that
        /// OAuth 2.0 authorization codes and access tokens are sent to for the
        /// associated application. Not nullable.</param>
        /// <param name="servicePrincipalNames">Contains the list of
        /// identifiersUris, copied over from the associated application.
        /// Additional values can be added to hybrid applications. These values
        /// can be used to identify the permissions exposed by this app within
        /// Azure AD. For example,Client apps can specify a resource URI which
        /// is based on the values of this property to acquire an access token,
        /// which is the URI returned in the 'aud' claim.The any operator is
        /// required for filter expressions on multi-valued properties. Not
        /// nullable.  Supports $filter (eq, NOT, ge, le, startsWith).</param>
        /// <param name="servicePrincipalType">Identifies if the service
        /// principal represents an application or a managed identity. This is
        /// set by Azure AD internally. For a service principal that represents
        /// an application this is set as Application. For a service principal
        /// that represent a managed identity this is set as
        /// ManagedIdentity.</param>
        /// <param name="signInAudience">Specifies the Microsoft accounts that
        /// are supported for the current application. Read-only. Supported
        /// values are:AzureADMyOrg: Users with a Microsoft work or school
        /// account in my organization鈥檚 Azure AD tenant
        /// (single-tenant).AzureADMultipleOrgs: Users with a Microsoft work or
        /// school account in any organization鈥檚 Azure AD tenant
        /// (multi-tenant).AzureADandPersonalMicrosoftAccount: Users with a
        /// personal Microsoft account, or a work or school account in any
        /// organization鈥檚 Azure AD tenant.PersonalMicrosoftAccount: Users with
        /// a personal Microsoft account only.</param>
        /// <param name="tokenEncryptionKeyId">Specifies the keyId of a public
        /// key from the keyCredentials collection. When configured, Azure AD
        /// issues tokens for this application encrypted using the key
        /// specified by this property. The application code that receives the
        /// encrypted token must use the matching private key to decrypt the
        /// token before it can be used for the signed-in user.</param>
        /// <param name="transitiveMemberOf"></param>
        public MicrosoftGraphServicePrincipal(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string id = default(string), System.DateTime? deletedDateTime = default(System.DateTime?), IList<string> tags = default(IList<string>), bool? accountEnabled = default(bool?), IList<string> alternativeNames = default(IList<string>), string appDescription = default(string), string appDisplayName = default(string), string appId = default(string), System.Guid? appOwnerOrganizationId = default(System.Guid?), IList<MicrosoftGraphAppRoleAssignment> appRoleAssignedTo = default(IList<MicrosoftGraphAppRoleAssignment>), bool? appRoleAssignmentRequired = default(bool?), IList<MicrosoftGraphAppRoleAssignment> appRoleAssignments = default(IList<MicrosoftGraphAppRoleAssignment>), IList<MicrosoftGraphAppRole> appRoles = default(IList<MicrosoftGraphAppRole>), string applicationTemplateId = default(string), IList<MicrosoftGraphDirectoryObject> createdObjects = default(IList<MicrosoftGraphDirectoryObject>), string description = default(string), string disabledByMicrosoftStatus = default(string), string displayName = default(string), IList<MicrosoftGraphEndpoint> endpoints = default(IList<MicrosoftGraphEndpoint>), string homepage = default(string), IList<MicrosoftGraphKeyCredential> keyCredentials = default(IList<MicrosoftGraphKeyCredential>), string loginUrl = default(string), string logoutUrl = default(string), IList<MicrosoftGraphDirectoryObject> memberOf = default(IList<MicrosoftGraphDirectoryObject>), string notes = default(string), IList<string> notificationEmailAddresses = default(IList<string>), IList<MicrosoftGraphOAuth2PermissionGrant> oauth2PermissionGrants = default(IList<MicrosoftGraphOAuth2PermissionGrant>), IList<MicrosoftGraphPermissionScope> oauth2PermissionScopes = default(IList<MicrosoftGraphPermissionScope>), IList<MicrosoftGraphDirectoryObject> ownedObjects = default(IList<MicrosoftGraphDirectoryObject>), IList<MicrosoftGraphDirectoryObject> owners = default(IList<MicrosoftGraphDirectoryObject>), IList<MicrosoftGraphPasswordCredential> passwordCredentials = default(IList<MicrosoftGraphPasswordCredential>), string preferredSingleSignOnMode = default(string), string preferredTokenSigningKeyThumbprint = default(string), IList<string> replyUrls = default(IList<string>), IList<string> servicePrincipalNames = default(IList<string>), string servicePrincipalType = default(string), string signInAudience = default(string), System.Guid? tokenEncryptionKeyId = default(System.Guid?), IList<MicrosoftGraphDirectoryObject> transitiveMemberOf = default(IList<MicrosoftGraphDirectoryObject>))
            : base(additionalProperties, id, deletedDateTime)
        {
            Tags = tags;
            AccountEnabled = accountEnabled;
            AlternativeNames = alternativeNames;
            AppDescription = appDescription;
            AppDisplayName = appDisplayName;
            AppId = appId;
            AppOwnerOrganizationId = appOwnerOrganizationId;
            AppRoleAssignedTo = appRoleAssignedTo;
            AppRoleAssignmentRequired = appRoleAssignmentRequired;
            AppRoleAssignments = appRoleAssignments;
            AppRoles = appRoles;
            ApplicationTemplateId = applicationTemplateId;
            CreatedObjects = createdObjects;
            Description = description;
            DisabledByMicrosoftStatus = disabledByMicrosoftStatus;
            DisplayName = displayName;
            Endpoints = endpoints;
            Homepage = homepage;
            KeyCredentials = keyCredentials;
            LoginUrl = loginUrl;
            LogoutUrl = logoutUrl;
            MemberOf = memberOf;
            Notes = notes;
            NotificationEmailAddresses = notificationEmailAddresses;
            Oauth2PermissionGrants = oauth2PermissionGrants;
            Oauth2PermissionScopes = oauth2PermissionScopes;
            OwnedObjects = ownedObjects;
            Owners = owners;
            PasswordCredentials = passwordCredentials;
            PreferredSingleSignOnMode = preferredSingleSignOnMode;
            PreferredTokenSigningKeyThumbprint = preferredTokenSigningKeyThumbprint;
            ReplyUrls = replyUrls;
            ServicePrincipalNames = servicePrincipalNames;
            ServicePrincipalType = servicePrincipalType;
            SignInAudience = signInAudience;
            TokenEncryptionKeyId = tokenEncryptionKeyId;
            TransitiveMemberOf = transitiveMemberOf;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets custom strings that can be used to categorize and
        /// identify the service principal. Not nullable. Supports $filter (eq,
        /// NOT, ge, le, startsWith).
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets true if the service principal account is enabled;
        /// otherwise, false. Supports $filter (eq, ne, NOT, in).
        /// </summary>
        [JsonProperty(PropertyName = "accountEnabled")]
        public bool? AccountEnabled { get; set; }

        /// <summary>
        /// Gets or sets used to retrieve service principals by subscription,
        /// identify resource group and full resource ids for managed
        /// identities. Supports $filter (eq, NOT, ge, le, startsWith).
        /// </summary>
        [JsonProperty(PropertyName = "alternativeNames")]
        public IList<string> AlternativeNames { get; set; }

        /// <summary>
        /// Gets or sets the description exposed by the associated application.
        /// </summary>
        [JsonProperty(PropertyName = "appDescription")]
        public string AppDescription { get; set; }

        /// <summary>
        /// Gets or sets the display name exposed by the associated
        /// application.
        /// </summary>
        [JsonProperty(PropertyName = "appDisplayName")]
        public string AppDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the associated application
        /// (its appId property).
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets contains the tenant id where the application is
        /// registered. This is applicable only to service principals backed by
        /// applications.Supports $filter (eq, ne, NOT, ge, le).
        /// </summary>
        [JsonProperty(PropertyName = "appOwnerOrganizationId")]
        public System.Guid? AppOwnerOrganizationId { get; set; }

        /// <summary>
        /// Gets or sets app role assignments for this app or service, granted
        /// to users, groups, and other service principals.Supports $expand.
        /// </summary>
        [JsonProperty(PropertyName = "appRoleAssignedTo")]
        public IList<MicrosoftGraphAppRoleAssignment> AppRoleAssignedTo { get; set; }

        /// <summary>
        /// Gets or sets specifies whether users or other service principals
        /// need to be granted an app role assignment for this service
        /// principal before users can sign in or apps can get tokens. The
        /// default value is false. Not nullable. Supports $filter (eq, ne,
        /// NOT).
        /// </summary>
        [JsonProperty(PropertyName = "appRoleAssignmentRequired")]
        public bool? AppRoleAssignmentRequired { get; set; }

        /// <summary>
        /// Gets or sets app role assignment for another app or service,
        /// granted to this service principal. Supports $expand.
        /// </summary>
        [JsonProperty(PropertyName = "appRoleAssignments")]
        public IList<MicrosoftGraphAppRoleAssignment> AppRoleAssignments { get; set; }

        /// <summary>
        /// Gets or sets the roles exposed by the application which this
        /// service principal represents. For more information see the appRoles
        /// property definition on the application entity. Not nullable.
        /// </summary>
        [JsonProperty(PropertyName = "appRoles")]
        public IList<MicrosoftGraphAppRole> AppRoles { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the applicationTemplate that the
        /// servicePrincipal was created from. Read-only. Supports $filter (eq,
        /// ne, NOT, startsWith).
        /// </summary>
        [JsonProperty(PropertyName = "applicationTemplateId")]
        public string ApplicationTemplateId { get; set; }

        /// <summary>
        /// Gets or sets directory objects created by this service principal.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(PropertyName = "createdObjects")]
        public IList<MicrosoftGraphDirectoryObject> CreatedObjects { get; set; }

        /// <summary>
        /// Gets or sets free text field to provide an internal end-user facing
        /// description of the service principal. End-user portals such MyApps
        /// will display the application description in this field. The maximum
        /// allowed size is 1024 characters. Supports $filter (eq, ne, NOT, ge,
        /// le, startsWith) and $search.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets specifies whether Microsoft has disabled the
        /// registered application. Possible values are: null (default value),
        /// NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons
        /// may include suspicious, abusive, or malicious activity, or a
        /// violation of the Microsoft Services Agreement).  Supports $filter
        /// (eq, ne, NOT).
        /// </summary>
        [JsonProperty(PropertyName = "disabledByMicrosoftStatus")]
        public string DisabledByMicrosoftStatus { get; set; }

        /// <summary>
        /// Gets or sets the display name for the service principal. Supports
        /// $filter (eq, ne, NOT, ge, le, in, startsWith), $search, and
        /// $orderBy.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets endpoints available for discovery. Services like
        /// Sharepoint populate this property with a tenant specific SharePoint
        /// endpoints that other applications can discover and use in their
        /// experiences.
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IList<MicrosoftGraphEndpoint> Endpoints { get; set; }

        /// <summary>
        /// Gets or sets home page or landing page of the application.
        /// </summary>
        [JsonProperty(PropertyName = "homepage")]
        public string Homepage { get; set; }

        /// <summary>
        /// Gets or sets the collection of key credentials associated with the
        /// service principal. Not nullable. Supports $filter (eq, NOT, ge,
        /// le).
        /// </summary>
        [JsonProperty(PropertyName = "keyCredentials")]
        public IList<MicrosoftGraphKeyCredential> KeyCredentials { get; set; }

        /// <summary>
        /// Gets or sets specifies the URL where the service provider redirects
        /// the user to Azure AD to authenticate. Azure AD uses the URL to
        /// launch the application from Microsoft 365 or the Azure AD My Apps.
        /// When blank, Azure AD performs IdP-initiated sign-on for
        /// applications configured with SAML-based single sign-on. The user
        /// launches the application from Microsoft 365, the Azure AD My Apps,
        /// or the Azure AD SSO URL.
        /// </summary>
        [JsonProperty(PropertyName = "loginUrl")]
        public string LoginUrl { get; set; }

        /// <summary>
        /// Gets or sets specifies the URL that will be used by Microsoft's
        /// authorization service to logout an user using OpenId Connect
        /// front-channel, back-channel or SAML logout protocols.
        /// </summary>
        [JsonProperty(PropertyName = "logoutUrl")]
        public string LogoutUrl { get; set; }

        /// <summary>
        /// Gets or sets roles that this service principal is a member of. HTTP
        /// Methods: GET Read-only. Nullable. Supports $expand.
        /// </summary>
        [JsonProperty(PropertyName = "memberOf")]
        public IList<MicrosoftGraphDirectoryObject> MemberOf { get; set; }

        /// <summary>
        /// Gets or sets free text field to capture information about the
        /// service principal, typically used for operational purposes. Maximum
        /// allowed size is 1024 characters.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets specifies the list of email addresses where Azure AD
        /// sends a notification when the active certificate is near the
        /// expiration date. This is only for the certificates used to sign the
        /// SAML token issued for Azure AD Gallery applications.
        /// </summary>
        [JsonProperty(PropertyName = "notificationEmailAddresses")]
        public IList<string> NotificationEmailAddresses { get; set; }

        /// <summary>
        /// Gets or sets delegated permission grants authorizing this service
        /// principal to access an API on behalf of a signed-in user.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(PropertyName = "oauth2PermissionGrants")]
        public IList<MicrosoftGraphOAuth2PermissionGrant> Oauth2PermissionGrants { get; set; }

        /// <summary>
        /// Gets or sets the delegated permissions exposed by the application.
        /// For more information see the oauth2PermissionScopes property on the
        /// application entity's api property. Not nullable.
        /// </summary>
        [JsonProperty(PropertyName = "oauth2PermissionScopes")]
        public IList<MicrosoftGraphPermissionScope> Oauth2PermissionScopes { get; set; }

        /// <summary>
        /// Gets or sets directory objects that are owned by this service
        /// principal. Read-only. Nullable. Supports $expand.
        /// </summary>
        [JsonProperty(PropertyName = "ownedObjects")]
        public IList<MicrosoftGraphDirectoryObject> OwnedObjects { get; set; }

        /// <summary>
        /// Gets or sets directory objects that are owners of this
        /// servicePrincipal. The owners are a set of non-admin users or
        /// servicePrincipals who are allowed to modify this object. Read-only.
        /// Nullable. Supports $expand.
        /// </summary>
        [JsonProperty(PropertyName = "owners")]
        public IList<MicrosoftGraphDirectoryObject> Owners { get; set; }

        /// <summary>
        /// Gets or sets the collection of password credentials associated with
        /// the service principal. Not nullable.
        /// </summary>
        [JsonProperty(PropertyName = "passwordCredentials")]
        public IList<MicrosoftGraphPasswordCredential> PasswordCredentials { get; set; }

        /// <summary>
        /// Gets or sets specifies the single sign-on mode configured for this
        /// application. Azure AD uses the preferred single sign-on mode to
        /// launch the application from Microsoft 365 or the Azure AD My Apps.
        /// The supported values are password, saml, notSupported, and oidc.
        /// </summary>
        [JsonProperty(PropertyName = "preferredSingleSignOnMode")]
        public string PreferredSingleSignOnMode { get; set; }

        /// <summary>
        /// Gets or sets reserved for internal use only. Do not write or
        /// otherwise rely on this property. May be removed in future versions.
        /// </summary>
        [JsonProperty(PropertyName = "preferredTokenSigningKeyThumbprint")]
        public string PreferredTokenSigningKeyThumbprint { get; set; }

        /// <summary>
        /// Gets or sets the URLs that user tokens are sent to for sign in with
        /// the associated application, or the redirect URIs that OAuth 2.0
        /// authorization codes and access tokens are sent to for the
        /// associated application. Not nullable.
        /// </summary>
        [JsonProperty(PropertyName = "replyUrls")]
        public IList<string> ReplyUrls { get; set; }

        /// <summary>
        /// Gets or sets contains the list of identifiersUris, copied over from
        /// the associated application. Additional values can be added to
        /// hybrid applications. These values can be used to identify the
        /// permissions exposed by this app within Azure AD. For example,Client
        /// apps can specify a resource URI which is based on the values of
        /// this property to acquire an access token, which is the URI returned
        /// in the 'aud' claim.The any operator is required for filter
        /// expressions on multi-valued properties. Not nullable.  Supports
        /// $filter (eq, NOT, ge, le, startsWith).
        /// </summary>
        [JsonProperty(PropertyName = "servicePrincipalNames")]
        public IList<string> ServicePrincipalNames { get; set; }

        /// <summary>
        /// Gets or sets identifies if the service principal represents an
        /// application or a managed identity. This is set by Azure AD
        /// internally. For a service principal that represents an application
        /// this is set as Application. For a service principal that represent
        /// a managed identity this is set as ManagedIdentity.
        /// </summary>
        [JsonProperty(PropertyName = "servicePrincipalType")]
        public string ServicePrincipalType { get; set; }

        /// <summary>
        /// Gets or sets specifies the Microsoft accounts that are supported
        /// for the current application. Read-only. Supported values
        /// are:AzureADMyOrg: Users with a Microsoft work or school account in
        /// my organization鈥檚 Azure AD tenant
        /// (single-tenant).AzureADMultipleOrgs: Users with a Microsoft work or
        /// school account in any organization鈥檚 Azure AD tenant
        /// (multi-tenant).AzureADandPersonalMicrosoftAccount: Users with a
        /// personal Microsoft account, or a work or school account in any
        /// organization鈥檚 Azure AD tenant.PersonalMicrosoftAccount: Users with
        /// a personal Microsoft account only.
        /// </summary>
        [JsonProperty(PropertyName = "signInAudience")]
        public string SignInAudience { get; set; }

        /// <summary>
        /// Gets or sets specifies the keyId of a public key from the
        /// keyCredentials collection. When configured, Azure AD issues tokens
        /// for this application encrypted using the key specified by this
        /// property. The application code that receives the encrypted token
        /// must use the matching private key to decrypt the token before it
        /// can be used for the signed-in user.
        /// </summary>
        [JsonProperty(PropertyName = "tokenEncryptionKeyId")]
        public System.Guid? TokenEncryptionKeyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transitiveMemberOf")]
        public IList<MicrosoftGraphDirectoryObject> TransitiveMemberOf { get; set; }

    }
}