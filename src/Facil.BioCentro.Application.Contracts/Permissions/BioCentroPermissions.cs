namespace Facil.BioCentro.Permissions;

public static class BioCentroPermissions
{
    public const string GroupName = "BioCentro";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public static class Clientes
    {
        public const string Default = GroupName + ".Clientes";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    public static class Funcionarios
    {
        public const string Default = GroupName + ".Funcionarios";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

}
