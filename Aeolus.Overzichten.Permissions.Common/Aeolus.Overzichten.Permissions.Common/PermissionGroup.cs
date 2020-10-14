namespace HenE.Aeolus.Shared.Permissions
{
    public enum PermissionGroup : ushort
    {
        Overzichten_Algemeen = PermissionModule.Overzichten | 0x0100,
        Overzichten_HollandRijnland = PermissionModule.Overzichten | 0x0200,
    }
}
