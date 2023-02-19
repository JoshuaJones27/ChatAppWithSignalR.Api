namespace ChatAppWithSignalR.Api.Entitites
{
    public class TblUser
    {
        public int Id { get; set; }
        public string LoginId { get; set; } = null;
        public string UserName { get; set; } = null;
        public string Password { get; set; } = null;
        public byte[] StoreSalt { get; set; } = null;
        public bool IsOnline { get; set; }
        public DateTime LastLogonTime { get; set; }
    }
}