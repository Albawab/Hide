namespace HenE.Aeolus.Shared.Permissions
{
    using System;
    using System.ComponentModel;
    using System.Linq;

    public static class PermissionChecker
    {
        /// <summary>
        /// This is used by the policy provider to check the permission name string
        /// </summary>
        /// <param name="packedPermissions"></param>
        /// <param name="permissionToCheck"></param>
        /// <returns></returns>
        public static bool ThisPermissionIsAllowed(this string packedPermissions, string permissionToCheck)
        {
            var userPermissions = packedPermissions.UnpackPermissionsFromString().ToArray();

            if (!Enum.TryParse(permissionToCheck, true, out Permission permission))
            {
                throw new InvalidEnumArgumentException($"{permissionToCheck} could not be converted to a {nameof(Permission)}.");
            }

            return userPermissions.UserHasThisPermission(permission);
        }

        /// <summary>
        /// This is the main checker of whether a user permission allows them to access something with the given permission
        /// </summary>
        /// <param name="userPermissions"></param>
        /// <param name="permissionToCheck"></param>
        /// <returns></returns>
        public static bool UserHasThisPermission(this Permission[] userPermissions, Permission permissionToCheck)
        {
            return userPermissions.Contains(permissionToCheck) || IsSuperUser(userPermissions) || HasValidGroupLevelPermission(userPermissions, permissionToCheck);
        }

        private static bool IsSuperUser(Permission[] userPermissions)
        {
            return userPermissions.Contains(Permission.AccessAll);
        }

        private static bool HasValidGroupLevelPermission(Permission[] userPermissions, Permission permissionToCheck)
        {
            var groupLevelPermission = CalculateGroupLevelPermission(permissionToCheck);

            return groupLevelPermission != Permission.NotSet && userPermissions.Contains(groupLevelPermission);
        }

        private static Permission CalculateGroupLevelPermission(Permission permission)
        {
            return (Permission)((ushort)permission | 0x00FF);
        }
    }
}