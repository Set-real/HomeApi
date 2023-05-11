namespace HomeApi.Contracts.Models.Devices
{
    /// <summary>
    /// Запрос для обновления свойств конматы
    /// </summary>
    public class EditRoomRequest
    {
        public string NewRoomName { get; set; }
        public int NewRoonAria { get; set; }
    }
}
