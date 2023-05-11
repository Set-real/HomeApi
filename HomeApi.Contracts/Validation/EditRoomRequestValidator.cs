using FluentValidation;
using HomeApi.Contracts.Models.Rooms.Request;
using System.Linq;

namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-валидатор запросов обновления комнаты
    /// </summary>
    public class EditRoomRequestValidator: AbstractValidator<EditRoomRequest>
    {
        /// <summary>
        /// Метод-конструктор, устанавливающий правила
        /// </summary>
        public EditRoomRequestValidator() 
        {
            RuleFor(x => x.NewRoomName).NotEmpty().Must(BeSupported)
                .WithMessage($"Please choose one of the following locations: {string.Join(", ", Values.ValidRooms)}");
            RuleFor(x => x.NewRoonAria).NotEmpty();
        }

        /// <summary>
        ///  Метод кастомной валидации для свойства location
        /// </summary>
        private bool BeSupported(string location)
        {
            return Values.ValidRooms.Any(e => e == location);
        }
    }
}
