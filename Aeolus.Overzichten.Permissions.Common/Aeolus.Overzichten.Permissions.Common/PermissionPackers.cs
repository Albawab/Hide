namespace HenE.Aeolus.Shared.Permissions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class PermissionPackers
    {
        public static string PackPermissionsIntoString(this IEnumerable<Permission> permissions)
        {
            return permissions.Aggregate("", (s, permission) => s + (char)permission);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S4456:Parameter validation in yielding methods should be wrapped", Justification = "Bewust 1 functie aangehouden")]
        public static IEnumerable<Permission> UnpackPermissionsFromString(this string packedPermissions)
        {
            if (packedPermissions == null)
            {
                throw new ArgumentNullException(nameof(packedPermissions));
            }

            foreach (var character in packedPermissions)
            {
                yield return (Permission)character;
            }
        }

        public static Permission? FindPermissionViaName(this string permissionName)
        {
            return Enum.TryParse(permissionName, out Permission permission)
                ? (Permission?)permission
                : null;
        }
    }
}