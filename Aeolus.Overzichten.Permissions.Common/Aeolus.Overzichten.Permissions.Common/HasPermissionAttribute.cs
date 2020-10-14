namespace HenE.Aeolus.Shared.Permissions
{
    using Microsoft.AspNetCore.Authorization;
    using System;

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = false)]
    public class HasPermissionAttribute : AuthorizeAttribute
    {
        public HasPermissionAttribute(Permission permission)
            : base(permission.ToString())
        {
        }
    }
}