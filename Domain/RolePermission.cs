namespace Domain;

public class RolePermission
{
    public int Id { get; set; }
    public Role Role { get; set; }
    public Permission Permission { get; set; }
}