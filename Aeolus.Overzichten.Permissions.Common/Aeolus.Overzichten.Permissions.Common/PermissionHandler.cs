namespace HenE.Aeolus.Shared.Permissions
{
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;

    public class PermissionHandler : AuthorizationHandler<PermissionRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            var permissionsClaim = context.User.Claims.SingleOrDefault(c => c.Type == PermissionConstants.PackedPermissionClaimType);

            if (permissionsClaim == null)
            {
                return Task.CompletedTask;
            }

            if (permissionsClaim.Value.ThisPermissionIsAllowed(requirement.PermissionName))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}