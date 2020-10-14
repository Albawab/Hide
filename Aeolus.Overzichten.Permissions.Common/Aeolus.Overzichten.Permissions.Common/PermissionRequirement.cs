namespace HenE.Aeolus.Shared.Permissions
{
    using System;
    using Microsoft.AspNetCore.Authorization;

    public class PermissionRequirement : IAuthorizationRequirement
    {
        public PermissionRequirement(string permissionName)
        {
            PermissionName = permissionName ?? throw new ArgumentNullException(nameof(permissionName));
        }

        public string PermissionName { get; }
    }
}