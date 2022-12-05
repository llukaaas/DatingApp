namespace API.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IMessageRepository MessageRepository { get; }
        ILikesRepository LikesRepository { get; }
        Task<bool> Complete(); //Sluzi da ako je false da se sve rollbackuje
        bool HasChanges(); //da li entityF sledi nesto sto promenilo u transakciji
    }
}