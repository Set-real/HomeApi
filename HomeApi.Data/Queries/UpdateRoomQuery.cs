namespace HomeApi.Data.Queries
{
    public class UpdateRoomQuery
    {
        public string NewName { get; set; }
        public int NewAria { get; set; }

        public UpdateRoomQuery(string newName, int newAria)
        {
            NewName = newName;
            NewAria = newAria;
        }
    }
}
